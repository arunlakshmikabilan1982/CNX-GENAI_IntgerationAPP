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

namespace SitecoreOperations.SitecoreGraphQLOperations
{
    public class GraphQLOperations
    {
        string GraphQLUrl = ConfigurationManager.AppSettings["graphQLUrl"];
        string AccessToken = ConfigurationManager.AppSettings["accessToken"];
        string PreviewGraphQLUrl = ConfigurationManager.AppSettings["previewGraphQLUrl"];
        string PreviewAccessToken = ConfigurationManager.AppSettings["previewAccessToken"];
        public async Task GetItemFields()
        {
            var graphQLClient = new GraphQLHttpClient(new GraphQLHttpClientOptions
            {
                EndPoint = new Uri(PreviewGraphQLUrl)
            }, new NewtonsoftJsonSerializer());

            //PreviewGraphQLUrl, new NewtonsoftJsonSerializer());

            graphQLClient.HttpClient.DefaultRequestHeaders.Add("sc_apikey", PreviewAccessToken);
            string ItemId = "7B486E43327544619799F2A897CC404B";
            string query = @"query getFields($id:String!){
                             sitecoreitem(path: $id, language: "en") {
                                 id
                                 name
                                fields{
                                id
                                name
                                }
                                 } }";
            var request = new GraphQLRequest
            {
                Query = query,
                Variables = new { id = ItemId, language = "en" }
            };
            var graphQLResponse = await graphQLClient.SendQueryAsync<SitecoreItem>(request);
            Console.WriteLine(graphQLResponse.Data);
        }
    }
}
