
namespace GenAISitecoreIntegration
{
    partial class ImageAnalysisForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.itemPathLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.itemIdTextbox = new System.Windows.Forms.TextBox();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.imageUploadLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textGenerationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.translationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemPathLabel
            // 
            this.itemPathLabel.AutoSize = true;
            this.itemPathLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPathLabel.Location = new System.Drawing.Point(41, 35);
            this.itemPathLabel.Name = "itemPathLabel";
            this.itemPathLabel.Size = new System.Drawing.Size(71, 23);
            this.itemPathLabel.TabIndex = 0;
            this.itemPathLabel.Text = "Item Id";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.browseBtn);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.itemIdTextbox);
            this.panel1.Controls.Add(this.uploadBtn);
            this.panel1.Controls.Add(this.imageUploadLabel);
            this.panel1.Controls.Add(this.itemPathLabel);
            this.panel1.Location = new System.Drawing.Point(121, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 281);
            this.panel1.TabIndex = 1;
            // 
            // itemIdTextbox
            // 
            this.itemIdTextbox.Location = new System.Drawing.Point(45, 73);
            this.itemIdTextbox.Name = "itemIdTextbox";
            this.itemIdTextbox.Size = new System.Drawing.Size(259, 26);
            this.itemIdTextbox.TabIndex = 3;
            // 
            // uploadBtn
            // 
            this.uploadBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.uploadBtn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadBtn.Location = new System.Drawing.Point(744, 121);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(172, 45);
            this.uploadBtn.TabIndex = 6;
            this.uploadBtn.Text = "Upload";
            this.uploadBtn.UseVisualStyleBackColor = false;
            this.uploadBtn.Click += new System.EventHandler(this.translateBtn_Click);
            // 
            // imageUploadLabel
            // 
            this.imageUploadLabel.AutoSize = true;
            this.imageUploadLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageUploadLabel.Location = new System.Drawing.Point(44, 143);
            this.imageUploadLabel.Name = "imageUploadLabel";
            this.imageUploadLabel.Size = new System.Drawing.Size(126, 23);
            this.imageUploadLabel.TabIndex = 2;
            this.imageUploadLabel.Text = "Image Upload";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.resultLabel);
            this.panel2.Controls.Add(this.resultTextBox);
            this.panel2.Location = new System.Drawing.Point(169, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(871, 230);
            this.panel2.TabIndex = 3;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(30, 23);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(71, 23);
            this.resultLabel.TabIndex = 1;
            this.resultLabel.Text = "Result:";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(34, 64);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(793, 137);
            this.resultTextBox.TabIndex = 0;
            this.resultTextBox.Text = "";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(528, 51);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(194, 32);
            this.headerLabel.TabIndex = 5;
            this.headerLabel.Text = "Image Analysis";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1269, 36);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textGenerationToolStripMenuItem,
            this.translationToolStripMenuItem,
            this.contentAnalysisToolStripMenuItem,
            this.imageAnalysisToolStripMenuItem});
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(83, 32);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // textGenerationToolStripMenuItem
            // 
            this.textGenerationToolStripMenuItem.Name = "textGenerationToolStripMenuItem";
            this.textGenerationToolStripMenuItem.Size = new System.Drawing.Size(274, 36);
            this.textGenerationToolStripMenuItem.Text = "Text Generation";
            this.textGenerationToolStripMenuItem.Click += new System.EventHandler(this.textGenerationToolStripMenuItem_Click);
            // 
            // translationToolStripMenuItem
            // 
            this.translationToolStripMenuItem.Name = "translationToolStripMenuItem";
            this.translationToolStripMenuItem.Size = new System.Drawing.Size(274, 36);
            this.translationToolStripMenuItem.Text = "Translation";
            this.translationToolStripMenuItem.Click += new System.EventHandler(this.translationToolStripMenuItem_Click);
            // 
            // contentAnalysisToolStripMenuItem
            // 
            this.contentAnalysisToolStripMenuItem.Name = "contentAnalysisToolStripMenuItem";
            this.contentAnalysisToolStripMenuItem.Size = new System.Drawing.Size(274, 36);
            this.contentAnalysisToolStripMenuItem.Text = "Content Analysis";
            this.contentAnalysisToolStripMenuItem.Click += new System.EventHandler(this.contentAnalysisToolStripMenuItem_Click);
            // 
            // imageAnalysisToolStripMenuItem
            // 
            this.imageAnalysisToolStripMenuItem.Name = "imageAnalysisToolStripMenuItem";
            this.imageAnalysisToolStripMenuItem.Size = new System.Drawing.Size(274, 36);
            this.imageAnalysisToolStripMenuItem.Text = "Image Analysis";
            this.imageAnalysisToolStripMenuItem.Click += new System.EventHandler(this.imageAnalysisToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(64, 32);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 190);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 26);
            this.textBox1.TabIndex = 7;
            // 
            // browseBtn
            // 
            this.browseBtn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseBtn.Location = new System.Drawing.Point(366, 186);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(95, 32);
            this.browseBtn.TabIndex = 8;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            // 
            // ImageAnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1269, 673);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ImageAnalysisForm";
            this.Text = "Image Analysis";
            this.Load += new System.EventHandler(this.ImageAnalysisForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemPathLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.RichTextBox resultTextBox;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox itemIdTextbox;
        private System.Windows.Forms.Label imageUploadLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textGenerationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem translationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}

