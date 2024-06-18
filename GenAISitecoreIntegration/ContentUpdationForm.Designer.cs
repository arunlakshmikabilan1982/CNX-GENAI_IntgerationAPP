
namespace GenAISitecoreIntegration
{
    partial class ContentUpdationForm
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
            this.resultLabel = new System.Windows.Forms.Label();
            this.queryLabel = new System.Windows.Forms.Label();
            this.queryTextbox = new System.Windows.Forms.RichTextBox();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.getItemFieldsBtn = new System.Windows.Forms.Button();
            this.itemIdTextbox = new System.Windows.Forms.TextBox();
            this.getContentBtn = new System.Windows.Forms.Button();
            this.languageDropdown = new System.Windows.Forms.ComboBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.fieldListDropdown = new System.Windows.Forms.ComboBox();
            this.fieldListLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textGenerationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.translationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemIdLabel
            // 
            this.itemIdLabel.AutoSize = true;
            this.itemIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemIdLabel.Location = new System.Drawing.Point(41, 35);
            this.itemIdLabel.Name = "itemIdLabel";
            this.itemIdLabel.Size = new System.Drawing.Size(136, 25);
            this.itemIdLabel.TabIndex = 0;
            this.itemIdLabel.Text = "CMS Path/Id";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resultLabel);
            this.panel1.Controls.Add(this.queryLabel);
            this.panel1.Controls.Add(this.queryTextbox);
            this.panel1.Controls.Add(this.resultTextBox);
            this.panel1.Controls.Add(this.getItemFieldsBtn);
            this.panel1.Controls.Add(this.itemIdTextbox);
            this.panel1.Controls.Add(this.getContentBtn);
            this.panel1.Controls.Add(this.languageDropdown);
            this.panel1.Controls.Add(this.languageLabel);
            this.panel1.Controls.Add(this.fieldListDropdown);
            this.panel1.Controls.Add(this.fieldListLabel);
            this.panel1.Controls.Add(this.itemIdLabel);
            this.panel1.Location = new System.Drawing.Point(287, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 543);
            this.panel1.TabIndex = 1;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.Color.Purple;
            this.resultLabel.Location = new System.Drawing.Point(42, 380);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(180, 24);
            this.resultLabel.TabIndex = 12;
            this.resultLabel.Text = "Response Content";
            // 
            // queryLabel
            // 
            this.queryLabel.AutoSize = true;
            this.queryLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryLabel.ForeColor = System.Drawing.Color.Purple;
            this.queryLabel.Location = new System.Drawing.Point(42, 227);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(202, 24);
            this.queryLabel.TabIndex = 11;
            this.queryLabel.Text = "Your Prompt Query";
            // 
            // queryTextbox
            // 
            this.queryTextbox.Location = new System.Drawing.Point(45, 266);
            this.queryTextbox.Name = "queryTextbox";
            this.queryTextbox.Size = new System.Drawing.Size(442, 98);
            this.queryTextbox.TabIndex = 10;
            this.queryTextbox.Text = "";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(45, 420);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(688, 101);
            this.resultTextBox.TabIndex = 0;
            this.resultTextBox.Text = "";
            // 
            // getItemFieldsBtn
            // 
            this.getItemFieldsBtn.BackColor = System.Drawing.Color.Crimson;
            this.getItemFieldsBtn.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getItemFieldsBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.getItemFieldsBtn.Location = new System.Drawing.Point(533, 51);
            this.getItemFieldsBtn.Name = "getItemFieldsBtn";
            this.getItemFieldsBtn.Size = new System.Drawing.Size(176, 48);
            this.getItemFieldsBtn.TabIndex = 7;
            this.getItemFieldsBtn.Text = "Get Fields";
            this.getItemFieldsBtn.UseVisualStyleBackColor = false;
            this.getItemFieldsBtn.Click += new System.EventHandler(this.getItemFieldsBtn_Click);
            // 
            // itemIdTextbox
            // 
            this.itemIdTextbox.Location = new System.Drawing.Point(45, 73);
            this.itemIdTextbox.Name = "itemIdTextbox";
            this.itemIdTextbox.Size = new System.Drawing.Size(442, 26);
            this.itemIdTextbox.TabIndex = 3;
            // 
            // getContentBtn
            // 
            this.getContentBtn.BackColor = System.Drawing.Color.Crimson;
            this.getContentBtn.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getContentBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.getContentBtn.Location = new System.Drawing.Point(517, 275);
            this.getContentBtn.Name = "getContentBtn";
            this.getContentBtn.Size = new System.Drawing.Size(216, 51);
            this.getContentBtn.TabIndex = 6;
            this.getContentBtn.Text = "Update Content";
            this.getContentBtn.UseVisualStyleBackColor = false;
            this.getContentBtn.Click += new System.EventHandler(this.getContentBtn_Click);
            // 
            // languageDropdown
            // 
            this.languageDropdown.FormattingEnabled = true;
            this.languageDropdown.Location = new System.Drawing.Point(304, 172);
            this.languageDropdown.Name = "languageDropdown";
            this.languageDropdown.Size = new System.Drawing.Size(183, 28);
            this.languageDropdown.TabIndex = 3;
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageLabel.Location = new System.Drawing.Point(299, 134);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(108, 25);
            this.languageLabel.TabIndex = 4;
            this.languageLabel.Text = "Language";
            // 
            // fieldListDropdown
            // 
            this.fieldListDropdown.FormattingEnabled = true;
            this.fieldListDropdown.Location = new System.Drawing.Point(45, 172);
            this.fieldListDropdown.Name = "fieldListDropdown";
            this.fieldListDropdown.Size = new System.Drawing.Size(232, 28);
            this.fieldListDropdown.TabIndex = 3;
            this.fieldListDropdown.SelectedIndexChanged += new System.EventHandler(this.fieldListDropdown_SelectedIndexChanged);
            // 
            // fieldListLabel
            // 
            this.fieldListLabel.AutoSize = true;
            this.fieldListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldListLabel.Location = new System.Drawing.Point(41, 134);
            this.fieldListLabel.Name = "fieldListLabel";
            this.fieldListLabel.Size = new System.Drawing.Size(99, 25);
            this.fieldListLabel.TabIndex = 2;
            this.fieldListLabel.Text = "Field List";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Lucida Fax", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(406, 46);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(505, 33);
            this.headerLabel.TabIndex = 5;
            this.headerLabel.Text = "Content Updation Through GenAI";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1269, 36);
            this.menuStrip1.TabIndex = 6;
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
            this.textGenerationToolStripMenuItem.Size = new System.Drawing.Size(359, 36);
            this.textGenerationToolStripMenuItem.Text = "Content Ideation";
            this.textGenerationToolStripMenuItem.Click += new System.EventHandler(this.textGenerationToolStripMenuItem_Click);
            // 
            // translationToolStripMenuItem
            // 
            this.translationToolStripMenuItem.Name = "translationToolStripMenuItem";
            this.translationToolStripMenuItem.Size = new System.Drawing.Size(359, 36);
            this.translationToolStripMenuItem.Text = "Language Translation";
            this.translationToolStripMenuItem.Click += new System.EventHandler(this.translationToolStripMenuItem_Click);
            // 
            // contentAnalysisToolStripMenuItem
            // 
            this.contentAnalysisToolStripMenuItem.Name = "contentAnalysisToolStripMenuItem";
            this.contentAnalysisToolStripMenuItem.Size = new System.Drawing.Size(359, 36);
            this.contentAnalysisToolStripMenuItem.Text = "Content Updation";
            this.contentAnalysisToolStripMenuItem.Click += new System.EventHandler(this.contentAnalysisToolStripMenuItem_Click);
            // 
            // imageAnalysisToolStripMenuItem
            // 
            this.imageAnalysisToolStripMenuItem.Name = "imageAnalysisToolStripMenuItem";
            this.imageAnalysisToolStripMenuItem.Size = new System.Drawing.Size(359, 36);
            this.imageAnalysisToolStripMenuItem.Text = "Image To Text Generation";
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
            // ContentUpdationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1269, 673);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ContentUpdationForm";
            this.Text = "  Content Updation";
            this.Load += new System.EventHandler(this.ContentUpdationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemIdLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button getContentBtn;
        private System.Windows.Forms.ComboBox languageDropdown;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.RichTextBox resultTextBox;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox itemIdTextbox;
        private System.Windows.Forms.Button getItemFieldsBtn;
        private System.Windows.Forms.ComboBox fieldListDropdown;
        private System.Windows.Forms.Label fieldListLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textGenerationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem translationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageAnalysisToolStripMenuItem;
        private System.Windows.Forms.RichTextBox queryTextbox;
        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.Label resultLabel;
    }
}

