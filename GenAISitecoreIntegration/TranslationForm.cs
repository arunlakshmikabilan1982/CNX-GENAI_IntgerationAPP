using SitecoreOperations.SitecoreGraphQLOperations;
using System;
using System.Windows.Forms;

namespace GenAISitecoreIntegration
{
    public partial class TranslationForm : Form
    {
        private GraphQLOperations qLOperations;

        public TranslationForm()
        {
            InitializeComponent();
        }

        private void TranslationForm_Load(object sender, EventArgs e)
        {
            qLOperations = new GraphQLOperations();
        }

        private void translateBtn_Click(object sender, EventArgs e)
        {
            var path = itemPathTextbox.Text;
            var field = fieldListDropdown.SelectedValue.ToString();
            var language = languageDropdown.SelectedValue.ToString();
            var query = queryTextbox.Text;
            //qLOperations.Translate(path, query, field, language);
            //resultTextBox.Text = Helper.Translate(path, fieldId, language);
        }

        private async void getItemFieldsBtn_Click(object sender, EventArgs e)
        {
            var path = itemPathTextbox.Text;
            await qLOperations.GetSitecoreItem(path);
        }
    }
}
