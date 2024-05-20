using SitecoreOperations.SitecoreGraphQLOperations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            itemTypeDropdown.DataSource = Enum.GetValues(typeof(ItemType));
            templateTypeDropdown.DataSource = Enum.GetValues(typeof(TemplateType));
        }

        private async void createItemBtn_Click(object sender, EventArgs e)
        {
            var path = pathTextbox.Text;
            var itemType = itemTypeDropdown.SelectedValue;
            var query = queryTextbox.Text;
            var templateType = templateTypeDropdown.SelectedValue;
            var itemName = itemNameTextbox.Text;
            switch(itemType)
            {
                case ItemType.Article:
                    await qLOperations.CreateArticleItem(path, itemName, query, templateType.ToString());
                    break;
                case ItemType.Blog:
                    await qLOperations.CreateBlogItem(path, itemName, query, templateType.ToString());
                    break;
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
