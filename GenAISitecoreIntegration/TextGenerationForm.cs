using SitecoreOperations.SitecoreGraphQLOperations;
using System;
using System.Windows.Forms;

namespace GenAISitecoreIntegration
{
    public partial class TextGenerationForm : Form
    {

        private GraphQLOperations qLOperations;

        public TextGenerationForm()
        {
            InitializeComponent();
        }

        private void TextGenerationForm_Load(object sender, EventArgs e)
        {
            qLOperations = new GraphQLOperations();
            noteTextBox.Hide();
            itemTypeDropdown.DataSource = Enum.GetValues(typeof(ItemType));
            templateTypeDropdown.DataSource = Enum.GetValues(typeof(TemplateType));
        }

        private async void createItemBtn_Click(object sender, EventArgs e)
        {
            var path = pathTextbox.Text;
            var itemType = itemTypeDropdown.SelectedItem;
            var query = queryTextbox.Text;
            var templateType = templateTypeDropdown.SelectedItem;
            var itemName = itemNameTextbox.Text;
            Object result;
            switch(itemType)
            {
                case ItemType.Article:
                    result = await qLOperations.CreateArticleItem(path, itemName, query, templateType.ToString());
                    break;
                case ItemType.Blog:
                    result = await qLOperations.CreateBlogItem(path, itemName, query, templateType.ToString());
                    break;
            }
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

        private void templateTypeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            var itemType = Enum.Parse(typeof(ItemType), itemTypeDropdown.SelectedItem.ToString());
            var templateType = Enum.Parse(typeof(TemplateType),templateTypeDropdown.SelectedItem.ToString());
            if ((ItemType)itemType == ItemType.Article)
            {
                switch(templateType)
                {
                    case TemplateType.template1:
                        noteTextBox.Text = "Template Schema:\n\nArticle Template 1\n" +
                            "\nArticle Title" +
                            "\nArticle Body";
                        noteTextBox.Show();
                        break;
                    case TemplateType.template2:
                        noteTextBox.Text = "Template Schema:\n\nArticle Template 2\n" +
                            "\nArticle Headline" +
                            "\nArticle LeadParagraph" +
                            "\nArticle Explanation";
                        noteTextBox.Show();
                        break;
                }
            }
            else if ((ItemType)itemType == ItemType.Blog)
            {
                switch (templateType)
                {
                    case TemplateType.template1:
                        noteTextBox.Text = "Template Schema:\n\nBlog Template 1\n" +
                            "\nBlog Title" +
                            "\nBlog Body";
                        noteTextBox.Show();
                        break;
                    case TemplateType.template2:
                        noteTextBox.Text = "Template Schema:\n\nBlog Template 2\n" +
                            "\nBlog Title" +
                            "\nBlog High-lights" +
                            "\nBlog Body"; 
                        noteTextBox.Show();
                        break;
                }
            }
        }
    }

    public enum ItemType
    {
        Article,
        Blog
    }

    public enum TemplateType
    {
        template1,
        template2
    }
}
