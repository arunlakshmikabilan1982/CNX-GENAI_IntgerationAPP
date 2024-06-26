﻿using SitecoreOperations.Models;
using SitecoreOperations.SitecoreGraphQLOperations;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GenAISitecoreIntegration
{
    public partial class TranslationForm : Form
    {
        private GraphQLOperations qLOperations;
        private Items itemFields;

        public TranslationForm()
        {
            InitializeComponent();
        }

        private void TranslationForm_Load(object sender, EventArgs e)
        {
            qLOperations = new GraphQLOperations();
            languageDropdown.DataSource = Enum.GetValues(typeof(Language));
        }

        private async void translateBtn_Click(object sender, EventArgs e)
        {
            var path = itemIdTextbox.Text;
            var field = fieldListDropdown.SelectedValue.ToString();
            var language = languageDropdown.SelectedValue.ToString();
            var selectedFieldValue = itemFields.fields.FirstOrDefault(x => x.name.Equals(field))?.value;
            await qLOperations.UpdateSitecoreItem(path, language, field, selectedFieldValue);
        }

        private async void getItemFieldsBtn_Click(object sender, EventArgs e)
        {
            var path = itemIdTextbox.Text;
            itemFields = await qLOperations.GetSitecoreItem(path);
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

    public enum Language
    {
        en,
        sp,
        cn,
        jp
    }
}
