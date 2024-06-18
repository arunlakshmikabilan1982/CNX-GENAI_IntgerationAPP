using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using System.Configuration;
using SitecoreOperations.Models;
using GraphQL;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Net.Http;

namespace SitecoreOperations.SitecoreGraphQLOperations
{
    public class GraphQLOperations
    {
        string PreviewGraphQLUrl = ConfigurationManager.AppSettings["previewGraphQLUrl"];
        string PreviewAccessToken = ConfigurationManager.AppSettings["previewAccessToken"];
        string AuthoringGraphQLUrl = ConfigurationManager.AppSettings["authoringGraphQLUrl"];
        string AuthoringAccessToken = ConfigurationManager.AppSettings["authoringAccessToken"];
        string aricleblogGenAI = ConfigurationManager.AppSettings["articleblogGenAI"];
        string askGenAI = ConfigurationManager.AppSettings["askGenAIBot"];
        string TranslateGenAI = ConfigurationManager.AppSettings["aiTranslator"];
        string ImageToText = ConfigurationManager.AppSettings["aiImageToText"];

        public async Task GetItemFields()
        {
            var graphQLClient = new GraphQLHttpClient(new GraphQLHttpClientOptions
            {
                EndPoint = new Uri(PreviewGraphQLUrl)
            }, new NewtonsoftJsonSerializer());

            //PreviewGraphQLUrl, new NewtonsoftJsonSerializer());
            graphQLClient.HttpClient.DefaultRequestHeaders.Add("sc_apikey", PreviewAccessToken);
            string ItemId = "7B486E43327544619799F2A897CC404B";
            string query = @"query getFields($id:String, $language: String!){
                                 SitecoreItem:item(path: $id, language: $language) {
                                     name
                                    ItemFields:fields{
                                           name,
                                           value
                                            } }}";
                var request = new GraphQLRequest
                {
                    Query = query,
                    Variables = new { id = ItemId, language = "en" }
                };
            var graphQLResponse = await graphQLClient.SendQueryAsync<object>(request);
            Console.WriteLine(graphQLResponse.Data);
        }

        public async Task<GraphQLResponse<object>> AskGenAIBot(string AuthoringGraphQLUrl, string AuthoringAccessToken,
        string Item, string FieldName, string Query, string Language)
        {
            var graphQLClient = new GraphQLHttpClient(new GraphQLHttpClientOptions
            {
                EndPoint = new Uri(AuthoringGraphQLUrl)
            }, new NewtonsoftJsonSerializer());
            graphQLClient.HttpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + AuthoringAccessToken);

            var genAIBotApiUrl = @"" + askGenAI;

            var myObject = new GenAIBot
            {
                Query = Query
            };

            var objAsJson = JsonConvert.SerializeObject(myObject);
            var content = new StringContent(objAsJson, Encoding.UTF8, "application/json");

            HttpRequestMessage httpRequest = new HttpRequestMessage(HttpMethod.Post, genAIBotApiUrl);
            httpRequest.Content = new StringContent(objAsJson, Encoding.UTF8, "application/json");

            string resultContentString = string.Empty;
            using (var client = new HttpClient())
            {
                //client.DefaultRequestHeaders.Add("Content-Type", "application/json");
                var result = await client.SendAsync(httpRequest);
                resultContentString = await result.Content.ReadAsStringAsync();
            }

            string query = @"mutation($id:ID!, $language: String!, $fieldName:String!, $fieldvalue:String!)
                                  {
                                    updateItem(
                                            input: {
                                                database: ""master"",
                                                itemId: $id,
                                                language: $language,
                                               fields: [{ name: $fieldName, value: $fieldvalue }]
                                                }
                                                ) {
                                                item {
                                                    itemId
                                                }
                                                }
                                                }";
            var request = new GraphQLRequest
            {
                Query = query,
                Variables = new { id = Item, language = Language, fieldName = FieldName, fieldvalue = resultContentString }
            };
            var graphQLResponse = await graphQLClient.SendQueryAsync<object>(request);
            return graphQLResponse;

        }

        // public async Task CreateArticleItem(String ParentItem, String ItemName, String Query, String Template)
        public async Task<GraphQLResponse<object>> CreateArticleItem(string AuthoringGraphQLUrl, string AuthoringAccessToken,
            string ParentItem, string ItemName, string Query, string Template)
        {
            var graphQLClient = new GraphQLHttpClient(new GraphQLHttpClientOptions
            {
                EndPoint = new Uri(AuthoringGraphQLUrl)
            }, new NewtonsoftJsonSerializer());
            graphQLClient.HttpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + AuthoringAccessToken);

            string articleTemplate = Constants.Templates.ArticleTemplateId;

            #region Gen AI Call

            var myObject = new ContentGenerator
            {
                Query = Query,
                ContentType = "Article",
                FormatType = Template
            };

            var objAsJson = JsonConvert.SerializeObject(myObject);
            var content = new StringContent(objAsJson, Encoding.UTF8, "application/json");
            var genAIBotApiUrl = @"" + aricleblogGenAI;

            HttpRequestMessage httpRequest = new HttpRequestMessage(HttpMethod.Post, genAIBotApiUrl);
            httpRequest.Content = new StringContent(objAsJson, Encoding.UTF8, "application/json");

            var resultContentString = new Article();
            using (var client = new HttpClient())
            {
                var result = await client.SendAsync(httpRequest);
                var resultstring = result.Content.ReadAsStringAsync().Result;
                resultContentString = JsonConvert.DeserializeObject<Article>(resultstring);
            }

            #endregion Gen AI Call

            string query = @"mutation($templateId:ID!, $language: String!, $itemName:String!, $parent:ID!,
                                  $articleTitle: String!, $articleBody: String!, $articleHeadline: String!, $articleLeadParagraph: String!,
                                   $articleExplanation: String!)
                                  {
                                    createItem(
                                            input: {
                                                name: $itemName,
                                                templateId: $templateId ,
                                                parent: $parent,
                                                language: $language,
                                               fields: [{ name: ""ArticleTitle"", value: $articleTitle },
                                                { name: ""ArticleBody"", value: $articleBody },
                                                { name: ""ArticleHeadline"", value: $articleHeadline },
                                                { name: ""ArticleLeadParagraph"", value: $articleLeadParagraph },
                                                { name: ""ArticleExplanation"", value: $articleExplanation },
                                                ]
                                                }
                                                ) {
                                                item {
                                                    itemId
                                                }
                                                }
                                                }";
            var request = new GraphQLRequest
            {
                Query = query,
                Variables = new { templateId = articleTemplate, itemName = ItemName, language = "en", parent = ParentItem, 
                    articleTitle = resultContentString.ArticleTitle ?? string.Empty,
                    articleBody = resultContentString.ArticleBody ?? string.Empty,
                    articleHeadline = resultContentString.ArticleHeadline ?? string.Empty,
                    articleLeadParagraph = resultContentString.ArticleLeadParagraph ?? string.Empty,
                    articleExplanation = resultContentString.ArticleExplanation ?? string.Empty
                }
            };
            var graphQLResponse = await graphQLClient.SendMutationAsync<object>(request);
            Console.WriteLine(graphQLResponse.Data);
            return graphQLResponse;
        }


        // public async Task CreateBlogItem(String ParentItem, String ItemName, String Query, String Template)
        public async Task<GraphQLResponse<object>> CreateBlogItem(string AuthoringGraphQLUrl, string AuthoringAccessToken,
            String ParentItem, String ItemName, String Query, String Template)
        {
            var graphQLClient = new GraphQLHttpClient(new GraphQLHttpClientOptions
            {
                EndPoint = new Uri(AuthoringGraphQLUrl)
            }, new NewtonsoftJsonSerializer());
            graphQLClient.HttpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + AuthoringAccessToken);

            string blogTemplate = Constants.Templates.BlogTemplateId;

            #region Gen AI Call

            var myObject = new ContentGenerator
            {
                Query = Query,
                ContentType = "Blog",
                FormatType = Template
            };

            var objAsJson = JsonConvert.SerializeObject(myObject);
            var content = new StringContent(objAsJson, Encoding.UTF8, "application/json");
            var genAIBotApiUrl = @"" + aricleblogGenAI;

            HttpRequestMessage httpRequest = new HttpRequestMessage(HttpMethod.Post, genAIBotApiUrl);
            httpRequest.Content = new StringContent(objAsJson, Encoding.UTF8, "application/json");

            var resultContentString = new Blog();
            using (var client = new HttpClient())
            {
                var result = await client.SendAsync(httpRequest);
                var resultstring = result.Content.ReadAsStringAsync().Result;
                resultContentString = JsonConvert.DeserializeObject<Blog>(resultstring);
            }

            #endregion Gen AI Call

            string query = @"mutation($templateId:ID!, $language: String!, $itemName:String!, $parent:ID!,
                              $blogTitle:String!, $blogBody:String!, $blogHilights:String!)
                                  {
                                    createItem(
                                            input: {
                                                name: $itemName,
                                                templateId: $templateId ,
                                                parent: $parent,
                                                language: $language,
                                               fields: [{ name: ""BlogTitle"", value: $blogTitle },
                                                 { name: ""BlogBody"", value: $blogBody },
                                                { name: ""BlogHilights"", value: $blogHilights }
                                                ]
                                                }
                                                ) {
                                                item {
                                                    itemId
                                                }
                                                }
                                                }";
            var request = new GraphQLRequest
            {
                Query = query,
                Variables = new
                {
                    templateId = blogTemplate,
                    itemName = ItemName,
                    language = "en",
                    parent = ParentItem,
                    blogTitle = resultContentString.BlogTitle ?? string.Empty,
                    blogBody = resultContentString.BlogBody ?? string.Empty,
                    blogHilights = resultContentString.BlogHilights ?? string.Empty,
                }
            };

            var graphQLResponse = await graphQLClient.SendMutationAsync<object>(request);
            Console.WriteLine(graphQLResponse.Data);
            return graphQLResponse;
        }

        public async Task<Items> GetSitecoreItem(string itemPath)
        {
            try
            {
                string graphqlendpoint = System.Configuration.ConfigurationManager.AppSettings.Get("previewGraphQLUrl");
                string apikey = System.Configuration.ConfigurationManager.AppSettings.Get("scApikey");


                // Call GraphQL endpoint here, specifying return data type, endpoint, method, query, and variables
                var result = await Request.CallGraphQLAsync<DataItem>(
                    new Uri(graphqlendpoint),
                    HttpMethod.Post,
                    "",
                    apikey,
                    "query { item(path: \"" + itemPath + "\", language: \"en\") {id,name,fields(ownFields: true){name,value,id}}}",
                    new
                    {
                    });
                //Examine the GraphQL response to see if any errors were encountered
                if (result.Errors?.Count > 0)
                {
                    Console.WriteLine($"GraphQL returned errors:\n{string.Join("\n", result.Errors.Select(x => $"  - {x.Message}"))}");
                    return null;
                }
                else
                {
                    return result.Data.item;
                }
            }
            catch (Exception e)
            {
                throw e;

            }
        }

        public async Task<GraphQLResponse<Object>> UpdateSitecoreItem(string itemPath, string language, string fieldName, string fieldValue)
        {
            try
            {
                
                var graphQLClient = new GraphQLHttpClient(new GraphQLHttpClientOptions
                {
                    EndPoint = new Uri(AuthoringGraphQLUrl)
                }, new NewtonsoftJsonSerializer());




                var genAIBotApiUrl = @"" + TranslateGenAI;

                var myObject = new TransalteGenAIRequestBody
                {
                    text = fieldValue,
                    sourcelanguage = "English",
                    targetlanguage = language
                };

                var objAsJson = JsonConvert.SerializeObject(myObject);
                var content = new StringContent(objAsJson, Encoding.UTF8, "application/json");

                HttpRequestMessage httpRequest = new HttpRequestMessage(HttpMethod.Post, genAIBotApiUrl);
                httpRequest.Content = new StringContent(objAsJson, Encoding.UTF8, "application/json");

                string resultContentString = string.Empty;
                using (var client = new HttpClient())
                {
                    //client.DefaultRequestHeaders.Add("Content-Type", "application/json");
                    var result = await client.SendAsync(httpRequest);
                    resultContentString = await result.Content.ReadAsStringAsync();
                }
                string graphqlLanguage = "en";
                switch (language)
                {
                    case "Arabic":
                        graphqlLanguage = "ar-AE";
                        break;


                    case "Chinese":
                        graphqlLanguage = "zh-CN";
                        break;
                }

                graphQLClient.HttpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + AuthoringAccessToken);

                string query = @"mutation($itemPath: String!,$language: String!, $fieldName:String!, $fieldValue:ID!)
                                  {
                                    updateItem(
                                            input: {
                                                path: $itemPath,
                                                version: 1 ,
                                                language: $language,
                                               fields: [{ name: $fieldName, value: $fieldValue }
                                                ]
                                                }
                                                ) {
                                                item {
                                                    itemId
                                                }
                                                }
                                                }";
                var request = new GraphQLRequest
                {
                    Query = query,
                    Variables = new
                    {
                        itemPath = itemPath,
                        fieldName = fieldName,
                        language = graphqlLanguage,
                        fieldValue = resultContentString,
                    }
                };
                var graphQLResponse = await graphQLClient.SendMutationAsync<object>(request);
                if(graphQLResponse.Errors != null)
                {
                    return null;
                }
                Console.WriteLine(graphQLResponse.Data);
                return graphQLResponse;
            }
            catch (Exception e)
            {
                throw e;

            }
        }

        //public async Task<GraphQLResponse<Object>> GetImageDescriptionAndUpdate(string image)
        //{
        //    try
        //    {
        //        var graphQLClient = new GraphQLHttpClient(new GraphQLHttpClientOptions
        //        {
        //            EndPoint = new Uri(AuthoringGraphQLUrl)
        //        }, new NewtonsoftJsonSerializer());

        //        var genAIBotApiUrl = @"" + ImageToText;

        //        var myObject = new ImageToTextRequestBody
        //        {
        //            image=image
        //        };

        //        var objAsJson = JsonConvert.SerializeObject(myObject);
        //        var content = new StringContent(objAsJson, Encoding.UTF8, "application/json");

        //        HttpRequestMessage httpRequest = new HttpRequestMessage(HttpMethod.Post, genAIBotApiUrl);
        //        httpRequest.Content = new StringContent(objAsJson, Encoding.UTF8, "application/json");

        //        string resultContentString = string.Empty;
        //        using (var client = new HttpClient())
        //        {
        //            //client.DefaultRequestHeaders.Add("Content-Type", "application/json");
        //            var result = await client.SendAsync(httpRequest);
        //            resultContentString = await result.Content.ReadAsStringAsync();
        //        }

        //        graphQLClient.HttpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + AuthoringAccessToken);

        //        string query = @"mutation($itemPath: String!,$language: String!, $fieldName:String!, $fieldValue:ID!)
        //                          {
        //                            updateItem(
        //                                    input: {
        //                                        path: $itemPath,
        //                                        version: 1 ,
        //                                        language: $language,
        //                                       fields: [{ name: $fieldName, value: $fieldValue }
        //                                        ]
        //                                        }
        //                                        ) {
        //                                        item {
        //                                            itemId
        //                                        }
        //                                        }
        //                                        }";
        //        var request = new GraphQLRequest
        //        {
        //            Query = query,
        //            Variables = new
        //            {
        //                itemPath = itemPath,
        //                fieldName = fieldName,
        //                language = graphqlLanguage,
        //                fieldValue = resultContentString,
        //            }
        //        };
        //        var graphQLResponse = await graphQLClient.SendMutationAsync<object>(request);
        //        if (graphQLResponse.Errors != null)
        //        {
        //            return null;
        //        }
        //        Console.WriteLine(graphQLResponse.Data);
        //        return graphQLResponse;
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;

        //    }
        //}
    }
}
}


