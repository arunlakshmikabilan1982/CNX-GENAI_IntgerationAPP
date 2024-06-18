using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SitecoreOperations.SitecoreGraphQLOperations;
using System.Threading.Tasks;
using System.Configuration;

namespace SitecoreOperations
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var GraphQLClass = new GraphQLOperations();
            string AuthoringGraphQLUrl = ConfigurationManager.AppSettings["authoringGraphQLUrl"];
            string AuthoringAccessToken = ConfigurationManager.AppSettings["authoringAccessToken"];
            //await GraphQLClass.GetSitecoreItem("7B486E43327544619799F2A897CC404B");
            //await GraphQLClass.AskGenAIBot(AuthoringGraphQLUrl, AuthoringAccessToken,
            //    "{8CABB9E0-D013-4B69-AEAA-9798EA9737CF}", "ArticleBody", "Article on Sitecore CMS", "en"
            //    );
            //await GraphQLClass.GetItemLanguages();
            //await GraphQLClass.CreateArticleItem(AuthoringGraphQLUrl, AuthoringAccessToken,
            //"{743CFDD2-6505-4974-A6CA-5A6206392AAC}", "Article Today", "Generate article on nearest event", "Template1");
            await GraphQLClass.CreateBlogItem(AuthoringGraphQLUrl, AuthoringAccessToken,
            "{14FEBEFA-3EAF-474B-83E5-3C36E41E794D}", "Blog Today", "Generate blog on Concentrix Ethics", "Template1");

        }
    }
}
