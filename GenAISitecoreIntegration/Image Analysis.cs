using SitecoreOperations.SitecoreGraphQLOperations;
using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace GenAISitecoreIntegration
{
    public partial class ImageAnalysisForm : Form
    {
        private GraphQLOperations qLOperations;

        public ImageAnalysisForm()
        {
            InitializeComponent();
        }

        private void ImageAnalysisForm_Load(object sender, EventArgs e)
        {
            qLOperations = new GraphQLOperations();
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

        private void uploadBtn_Click(object sender, EventArgs e)
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
                                //qLOperations.Image(itemIdTextbox.Text,base64);
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
