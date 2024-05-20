using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphQL.Client;
using GraphQL.Client.Http;
using GraphQL.Client.Abstractions;
using System.Net;
using GraphQL.Client.Serializer.Newtonsoft;
using System.Configuration;
using SitecoreOperations.Models;
using GraphQL;
using System.Threading;
using System.Text.RegularExpressions;
using System.Net.Http;

namespace SitecoreOperations.SitecoreGraphQLOperations
{
    public class GraphQLOperations
    {
        string GraphQLUrl = ConfigurationManager.AppSettings["graphQLUrl"];
        string AccessToken = ConfigurationManager.AppSettings["accessToken"];
        string PreviewGraphQLUrl = ConfigurationManager.AppSettings["previewGraphQLUrl"];
        string PreviewAccessToken = ConfigurationManager.AppSettings["previewAccessToken"];
        string AuthoringGraphQLUrl = ConfigurationManager.AppSettings["authoringGraphQLUrl"];
        string AuthoringAccessToken = ConfigurationManager.AppSettings["authoringAccessToken"];
        string aricleblogGenAI = ConfigurationManager.AppSettings["articleblogGenAI"];
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

        // public async Task CreateArticleItem(String ParentItem, String ItemName, String Query, String Template)
        public async Task CreateArticleItem(string ParentItem, string ItemName, string Query, string Template)
        {
            var graphQLClient = new GraphQLHttpClient(new GraphQLHttpClientOptions
            {
                EndPoint = new Uri(AuthoringGraphQLUrl)
            }, new NewtonsoftJsonSerializer());
            graphQLClient.HttpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + AuthoringAccessToken);

            string articleTemplate = Constants.Templates.ArticleTemplateId;

            #region Gen AI Call

            var genAIBotApiUrl = @"" + aricleblogGenAI + Query + "/article/" + Template;
            string resultContentString = string.Empty;
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync(genAIBotApiUrl);
                resultContentString = await result.Content.ReadAsStringAsync();
            }
            var articleItemAI = new Article();
            if (Template == "template1")
            {
                articleItemAI.ArticleTitle = Regex.Split(resultContentString, "ArticleBody--")[0];
                articleItemAI.ArticleBody = Regex.Split(resultContentString, "ArticleBody--")[1];
            }
            else if (Template == "template2")
            {
                var articleLeadParagraphSplit = Regex.Split(resultContentString, "ArticleLeadParagraph--");
                var articleExplanationSplit = Regex.Split(articleLeadParagraphSplit[1], "ArticleExplanation--");
                articleItemAI.ArticleHeadline = articleLeadParagraphSplit[0];
                articleItemAI.ArticleLeadParagraph = articleExplanationSplit[0];
                articleItemAI.ArticleExplanation = articleExplanationSplit[1];
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
                    articleTitle = articleItemAI.ArticleTitle ?? string.Empty,
                    articleBody = articleItemAI.ArticleBody ?? string.Empty,
                    articleHeadline = articleItemAI.ArticleHeadline ?? string.Empty,
                    articleLeadParagraph = articleItemAI.ArticleLeadParagraph ?? string.Empty,
                    articleExplanation = articleItemAI.ArticleExplanation ?? string.Empty
                }
            };
            var graphQLResponse = await graphQLClient.SendMutationAsync<object>(request);
            Console.WriteLine(graphQLResponse.Data);
        }


        // public async Task CreateBlogItem(String ParentItem, String ItemName, String Query, String Template)
        public async Task CreateBlogItem()
        {
            var graphQLClient = new GraphQLHttpClient(new GraphQLHttpClientOptions
            {
                EndPoint = new Uri(AuthoringGraphQLUrl)
            }, new NewtonsoftJsonSerializer());

            string itemName = "Blog1";
            string articleTemplate = Constants.Templates.BlogTemplateId;
            string parentItem = "{14FEBEFA-3EAF-474B-83E5-3C36E41E794D}";

            //GenAI Call




            graphQLClient.HttpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + AuthoringAccessToken);

            string query = @"mutation($templateId:ID!, $language: String!, $itemName:String!, $parent:ID!)
                                  {
                                    createItem(
                                            input: {
                                                name: $itemName,
                                                templateId: $templateId ,
                                                parent: $parent,
                                                language: $language,
                                               fields: [{ name: ""BlogTitle"", value: $itemName },
                                                 { name: ""BlogBody"", value: $itemName },
                                                { name: ""BlogHilights"", value: $itemName }
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
                    templateId = articleTemplate,
                    itemName = itemName,
                    language = "en",
                    parent = parentItem,
                }
            };
            var graphQLResponse = await graphQLClient.SendMutationAsync<object>(request);
            Console.WriteLine(graphQLResponse.Data);
        }

        public async Task GetSitecoreItem()
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
                    "query { item(path: \"7B486E43327544619799F2A897CC404B\", language: \"en\") {fields(ownFields: true){name,value}}}",
                    new
                    {
                    });
                //Examine the GraphQL response to see if any errors were encountered
                if (result.Errors?.Count > 0)
                {
                    Console.WriteLine($"GraphQL returned errors:\n{string.Join("\n", result.Errors.Select(x => $"  - {x.Message}"))}");
                    return;
                }

                // Use the response data
                if (result.Data.item == null)
                {
                    Console.WriteLine($"item not found ,");
                }
                else
                {
                    Console.WriteLine($"Found item {result.Data.item?.id} ,");
                }
            }
            catch (Exception e)
            {

            }


        }
    }
}

