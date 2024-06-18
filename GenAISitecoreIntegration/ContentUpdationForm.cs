using GenAISitecoreIntegration.Models;
using SitecoreOperations.Models;
using SitecoreOperations.SitecoreGraphQLOperations;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GenAISitecoreIntegration
{
    public partial class ContentUpdationForm : Form
    {
        private GraphQLOperations qLOperations;
        private Items itemFields;
        private AppSettings appSettings;

        public ContentUpdationForm()
        {
            InitializeComponent();
        }

        private void ContentUpdationForm_Load(object sender, EventArgs e)
        {
            qLOperations = new GraphQLOperations();
            languageDropdown.DataSource = Enum.GetValues(typeof(Language));
            appSettings = Helper.GetAppSettings();
        }

        private async void getItemFieldsBtn_Click(object sender, EventArgs e)
        {
            var id = itemIdTextbox.Text;
            itemFields = await qLOperations.GetSitecoreItem(id);
            if(itemFields!=null && itemFields.fields?.Length>0)
            {
                fieldListDropdown.DisplayMember = "name";
                fieldListDropdown.ValueMember = "name";
                fieldListDropdown.DataSource = itemFields.fields;

            }
        }
        
        private void fieldListDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedField = itemFields.fields.ToList().FirstOrDefault(x => x.name.Equals(fieldListDropdown.SelectedValue.ToString()));
            if (selectedField != null)
            {
                resultTextBox.Text = string.Format("Item: {0}\nSelected Field Are Below:\nField Name: {1}\nField Value: {2}", itemFields.name, selectedField.name, selectedField.value);
            }
            else
            {
                resultTextBox.Text = fieldListDropdown.SelectedValue.ToString() + " field does not exists";
            }
        }

        private void getContentBtn_Click(object sender, EventArgs e)
        {
            var itemId = itemIdTextbox.Text;
            var query = queryTextbox.Text;
            var language = languageDropdown.SelectedValue.ToString();
            var field = fieldListDropdown.SelectedValue.ToString();
            var result = qLOperations.AskGenAIBot(appSettings.AuthoringGraphQLUrl, appSettings.AuthoringAccessToken, itemId, field, query, language);
        }

        private void textGenerationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContentIdeationForm f1 = new ContentIdeationForm();
            f1.ShowDialog();
        }

        private void translationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TranslationForm f1 = new TranslationForm();
            f1.ShowDialog();
        }

        private void contentAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContentUpdationForm f1 = new ContentUpdationForm();
            f1.ShowDialog();
        }

        private void imageAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ImageToTextGenerationForm f1 = new ImageToTextGenerationForm();
            f1.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
