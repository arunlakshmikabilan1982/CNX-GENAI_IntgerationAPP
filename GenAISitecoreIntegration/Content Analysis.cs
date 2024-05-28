using SitecoreOperations.Models;
using SitecoreOperations.SitecoreGraphQLOperations;
using System;
using System.Windows.Forms;

namespace GenAISitecoreIntegration
{
    public partial class ContentAnalysisForm : Form
    {
        private GraphQLOperations qLOperations;
        private Items itemFields;

        public ContentAnalysisForm()
        {
            InitializeComponent();
        }

        private void ContentAnalysisForm_Load(object sender, EventArgs e)
        {
            qLOperations = new GraphQLOperations();
            languageDropdown.DataSource = Enum.GetValues(typeof(Language));
        }

        private async void getItemFieldsBtn_Click(object sender, EventArgs e)
        {
            var path = itemPathTextbox.Text;
            itemFields = await qLOperations.GetSitecoreItem(path);
            if(itemFields!=null && itemFields.fields?.Length>0)
            {
                fieldListDropdown.DisplayMember = "name";
                fieldListDropdown.ValueMember = "name";
                fieldListDropdown.DataSource = itemFields.fields;

            }
            resultTextBox.Text = "No Fields Found";
        }
        
        private void fieldListDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textGenerationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TextGenerationForm f1 = new TextGenerationForm();
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
            ContentAnalysisForm f1 = new ContentAnalysisForm();
            f1.ShowDialog();
        }

        private void imageAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ImageAnalysisForm f1 = new ImageAnalysisForm();
            f1.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void getContentBtn_Click(object sender, EventArgs e)
        {
            var query = queryTextbox.Text;
            var language = languageDropdown.SelectedIndex.ToString();
            var field = fieldListDropdown.SelectedIndex.ToString();
            _ = qLOperations.AskGenAIBot(itemFields.id, field, query, language);
        }
    }
}
