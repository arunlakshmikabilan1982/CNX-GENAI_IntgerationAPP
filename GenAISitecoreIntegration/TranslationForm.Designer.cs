
namespace GenAISitecoreIntegration
{
    partial class TranslationForm
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
            this.itemIdLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.getItemFieldsBtn = new System.Windows.Forms.Button();
            this.itemIdTextbox = new System.Windows.Forms.TextBox();
            this.translateBtn = new System.Windows.Forms.Button();
            this.languageDropdown = new System.Windows.Forms.ComboBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.fieldListDropdown = new System.Windows.Forms.ComboBox();
            this.fieldListLabel = new System.Windows.Forms.Label();
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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemIdLabel
            // 
            this.itemIdLabel.AutoSize = true;
            this.itemIdLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemIdLabel.Location = new System.Drawing.Point(41, 35);
            this.itemIdLabel.Name = "itemIdLabel";
            this.itemIdLabel.Size = new System.Drawing.Size(71, 23);
            this.itemIdLabel.TabIndex = 0;
            this.itemIdLabel.Text = "Item Id";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.getItemFieldsBtn);
            this.panel1.Controls.Add(this.itemIdTextbox);
            this.panel1.Controls.Add(this.translateBtn);
            this.panel1.Controls.Add(this.languageDropdown);
            this.panel1.Controls.Add(this.languageLabel);
            this.panel1.Controls.Add(this.fieldListDropdown);
            this.panel1.Controls.Add(this.fieldListLabel);
            this.panel1.Controls.Add(this.itemIdLabel);
            this.panel1.Location = new System.Drawing.Point(151, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 281);
            this.panel1.TabIndex = 1;
            // 
            // getItemFieldsBtn
            // 
            this.getItemFieldsBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.getItemFieldsBtn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getItemFieldsBtn.Location = new System.Drawing.Point(460, 54);
            this.getItemFieldsBtn.Name = "getItemFieldsBtn";
            this.getItemFieldsBtn.Size = new System.Drawing.Size(188, 45);
            this.getItemFieldsBtn.TabIndex = 7;
            this.getItemFieldsBtn.Text = "Get Item Fields";
            this.getItemFieldsBtn.UseVisualStyleBackColor = false;
            this.getItemFieldsBtn.Click += new System.EventHandler(this.getItemFieldsBtn_Click);
            // 
            // itemIdTextbox
            // 
            this.itemIdTextbox.Location = new System.Drawing.Point(45, 73);
            this.itemIdTextbox.Name = "itemIdTextbox";
            this.itemIdTextbox.Size = new System.Drawing.Size(259, 26);
            this.itemIdTextbox.TabIndex = 3;
            // 
            // translateBtn
            // 
            this.translateBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.translateBtn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translateBtn.Location = new System.Drawing.Point(744, 121);
            this.translateBtn.Name = "translateBtn";
            this.translateBtn.Size = new System.Drawing.Size(172, 45);
            this.translateBtn.TabIndex = 6;
            this.translateBtn.Text = "Translate";
            this.translateBtn.UseVisualStyleBackColor = false;
            this.translateBtn.Click += new System.EventHandler(this.translateBtn_Click);
            // 
            // languageDropdown
            // 
            this.languageDropdown.FormattingEnabled = true;
            this.languageDropdown.Location = new System.Drawing.Point(429, 227);
            this.languageDropdown.Name = "languageDropdown";
            this.languageDropdown.Size = new System.Drawing.Size(259, 28);
            this.languageDropdown.TabIndex = 3;
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageLabel.Location = new System.Drawing.Point(425, 185);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(93, 23);
            this.languageLabel.TabIndex = 4;
            this.languageLabel.Text = "Language";
            // 
            // fieldListDropdown
            // 
            this.fieldListDropdown.FormattingEnabled = true;
            this.fieldListDropdown.Location = new System.Drawing.Point(45, 227);
            this.fieldListDropdown.Name = "fieldListDropdown";
            this.fieldListDropdown.Size = new System.Drawing.Size(259, 28);
            this.fieldListDropdown.TabIndex = 3;
            this.fieldListDropdown.SelectedIndexChanged += new System.EventHandler(this.fieldListDropdown_SelectedIndexChanged);
            // 
            // fieldListLabel
            // 
            this.fieldListLabel.AutoSize = true;
            this.fieldListLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldListLabel.Location = new System.Drawing.Point(41, 185);
            this.fieldListLabel.Name = "fieldListLabel";
            this.fieldListLabel.Size = new System.Drawing.Size(89, 23);
            this.fieldListLabel.TabIndex = 2;
            this.fieldListLabel.Text = "Field List";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.resultLabel);
            this.panel2.Controls.Add(this.resultTextBox);
            this.panel2.Location = new System.Drawing.Point(199, 418);
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
            this.headerLabel.Location = new System.Drawing.Point(558, 51);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(153, 32);
            this.headerLabel.TabIndex = 5;
            this.headerLabel.Text = "Translation";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
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
            // TranslationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1269, 673);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TranslationForm";
            this.Text = "Translation";
            this.Load += new System.EventHandler(this.TranslationForm_Load);
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

        private System.Windows.Forms.Label itemIdLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button translateBtn;
        private System.Windows.Forms.ComboBox languageDropdown;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.RichTextBox resultTextBox;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox itemIdTextbox;
        private System.Windows.Forms.Button getItemFieldsBtn;
        private System.Windows.Forms.ComboBox fieldListDropdown;
        private System.Windows.Forms.Label fieldListLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textGenerationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem translationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

