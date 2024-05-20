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
            await qLOperations.GetSitecoreItem(path);
        }

        private void translationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TranslationForm f1 = new TranslationForm();
            f1.ShowDialog();
        }

        private void textGenerationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TextGenerationForm f1 = new TextGenerationForm();
            f1.ShowDialog();
        }
    }

    public enum Language
    {
        English,
        Spanish,
        Chinese,
        Japanese
    }
}
