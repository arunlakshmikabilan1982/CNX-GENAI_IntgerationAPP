using SitecoreOperations.SitecoreGraphQLOperations;
using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace GenAISitecoreIntegration
{
    public partial class ImageToTextGenerationForm : Form
    {
        private GraphQLOperations qLOperations;

        public ImageToTextGenerationForm()
        {
            InitializeComponent();
        }

        private void ImageToTextGenerationForm_Load(object sender, EventArgs e)
        {
            qLOperations = new GraphQLOperations();
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

        private async void uploadBtn_Click(object sender, EventArgs e)
        {            
            using (FileStream fs = new FileStream(filePathTextbox.Text, FileMode.Open))
            {
                using (ZipArchive archive = new ZipArchive(fs))
                {
                    foreach (ZipArchiveEntry entry in archive.Entries)
                    {
                        if(!string.IsNullOrEmpty(entry.Name))
                        {
                            using (var stream = entry.Open())
                            using (var memoryStream = new MemoryStream())
                            {
                                stream.CopyTo(memoryStream);
                                var bytes = memoryStream.ToArray();
                                var base64 = Convert.ToBase64String(bytes);
                                await qLOperations.GetImageDescriptionAndUpdate(base64);
                            }
                        }
                    }
                }
            }
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Browse Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "zip",
                Filter = "zip files (*.zip)|*.zip",
                FilterIndex = 2,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePathTextbox.Text = openFileDialog1.FileName;
            }
        }
    }
}
