using SitecoreOperations.Models;
using SitecoreOperations.SitecoreGraphQLOperations;
using System;
using System.Windows.Forms;

namespace GenAISitecoreIntegration
{
    public partial class ImageAnalysisForm : Form
    {
        private GraphQLOperations qLOperations;
        private Items itemFields;

        public ImageAnalysisForm()
        {
            InitializeComponent();
        }

        private void ImageAnalysisForm_Load(object sender, EventArgs e)
        {
            qLOperations = new GraphQLOperations();
            languageDropdown.DataSource = Enum.GetValues(typeof(Language));
        }

        private void translateBtn_Click(object sender, EventArgs e)
        {
            var path = itemPathTextbox.Text;
            var field = fieldListDropdown.SelectedItem.ToString();
            var language = languageDropdown.SelectedItem.ToString();
            var query = queryTextbox.Text;
            //qLOperations.Translate(path, query, field, language);
            //resultTextBox.Text = Helper.Translate(path, fieldId, language);
        }

        private async void getItemFieldsBtn_Click(object sender, EventArgs e)
        {
            var path = itemPathTextbox.Text;
            itemFields = await qLOperations.GetSitecoreItem(path);
            if(itemFields!=null && itemFields.fields?.Length>0)
            {
                fieldListDropdown.DisplayMember = "name";
                fieldListDropdown.ValueMember = "Id";
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
    }
}
