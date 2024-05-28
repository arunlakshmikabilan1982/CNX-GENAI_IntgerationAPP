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
    public class GraphQLMediaOperations
    {
        string PreviewGraphQLUrl = ConfigurationManager.AppSettings["previewGraphQLUrl"];
        string PreviewAccessToken = ConfigurationManager.AppSettings["previewAccessToken"];
        string AuthoringGraphQLUrl = ConfigurationManager.AppSettings["authoringGraphQLUrl"];
        string AuthoringAccessToken = ConfigurationManager.AppSettings["authoringAccessToken"];

    }
}
