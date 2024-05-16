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
using System.Threading.Tasks;
using System.Net.Http;

namespace SitecoreOperations.SitecoreGraphQLOperations
{
    public class GraphQLOperations
    {
        //    string GraphQLUrl = ConfigurationManager.AppSettings["graphQLUrl"];
        //    string AccessToken = ConfigurationManager.AppSettings["accessToken"];
        //    string PreviewGraphQLUrl = ConfigurationManager.AppSettings["previewGraphQLUrl"];
        //    string PreviewAccessToken = ConfigurationManager.AppSettings["previewAccessToken"];
        //    public async Task GetItemFields()
        //    {
        //        var graphQLClient = new GraphQLHttpClient(new GraphQLHttpClientOptions
        //        {
        //            EndPoint = new Uri(PreviewGraphQLUrl)
        //        }, new NewtonsoftJsonSerializer());

        //        //PreviewGraphQLUrl, new NewtonsoftJsonSerializer());

        //        graphQLClient.HttpClient.DefaultRequestHeaders.Add("sc_apikey", PreviewAccessToken);
        //        string ItemId = "7B486E43327544619799F2A897CC404B";
        //        string query = @"query getFields($id:String!){
        //                         sitecoreitem(path: $id, language: "en") {
        //                             id
        //                             name
        //                            fields{
        //                            id
        //                            name
        //                            }
        //                             ";
        //        var request = new GraphQLRequest
        //        {
        //            Query = query,
        //            Variables = new { id = ItemId, language = "en" }
        //        };
        //        var graphQLResponse = await graphQLClient.SendQueryAsync<SitecoreItem>(request);
        //        Console.WriteLine(graphQLResponse.Data);
        //    }
        //}
        public  async Task GetSitecoreItem(CancellationToken cancellationToken, string itemPath)
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
                    "query { item(path: \"" + itemPath + "\", language: \"en\") {fields(ownFields: true){name,value}}}",
                    new
                    {
                    },
                    cancellationToken);
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

