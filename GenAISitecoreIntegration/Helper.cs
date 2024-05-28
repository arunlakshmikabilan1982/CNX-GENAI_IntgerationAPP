using GenAISitecoreIntegration.Models;
using System.Configuration;

namespace GenAISitecoreIntegration
{
    public static class Helper
    {
        public static AppSettings GetAppSettings()
        {
            return new AppSettings()
            {
                PreviewGraphQLUrl = ConfigurationManager.AppSettings["previewGraphQLUrl"],
                PreviewAccessToken = ConfigurationManager.AppSettings["previewAccessToken"],
                AuthoringGraphQLUrl = ConfigurationManager.AppSettings["authoringGraphQLUrl"],
                AuthoringAccessToken = ConfigurationManager.AppSettings["authoringAccessToken"],
                ArticleblogGenAI = ConfigurationManager.AppSettings["articleblogGenAI"],
                AskGenAIBot = ConfigurationManager.AppSettings["askGenAIBot"],
                ScApikey= ConfigurationManager.AppSettings["scApikey"]
            };
        }
    }
}
