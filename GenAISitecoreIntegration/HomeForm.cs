using System;
using System.Windows.Forms;

namespace GenAISitecoreIntegration
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void textGenerationBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContentIdeationForm f1 = new ContentIdeationForm();
            f1.ShowDialog();
        }

        private void translationBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TranslationForm f1 = new TranslationForm();
            f1.ShowDialog();
        }

        private void contentBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContentUpdationForm f1 = new ContentUpdationForm();
            f1.ShowDialog();
        }

        private void imageBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ImageToTextGenerationForm f1 = new ImageToTextGenerationForm();
            f1.ShowDialog();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
