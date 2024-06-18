
namespace GenAISitecoreIntegration
{
    partial class ContentIdeationForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.itemIdLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resultLabel = new System.Windows.Forms.Label();
            this.noteTextBox = new System.Windows.Forms.RichTextBox();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.queryTextbox = new System.Windows.Forms.RichTextBox();
            this.itemNameTextbox = new System.Windows.Forms.TextBox();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.itemIdTextbox = new System.Windows.Forms.TextBox();
            this.createItemBtn = new System.Windows.Forms.Button();
            this.queryLabel = new System.Windows.Forms.Label();
            this.templateTypeDropdown = new System.Windows.Forms.ComboBox();
            this.templateTypeLabel = new System.Windows.Forms.Label();
            this.itemTypeDropdown = new System.Windows.Forms.ComboBox();
            this.itemTypeLabel = new System.Windows.Forms.Label();
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
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Lucida Fax", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(434, 62);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(491, 33);
            this.headerLabel.TabIndex = 8;
            this.headerLabel.Text = "Content Ideation Through GenAI";
            // 
            // itemIdLabel
            // 
            this.itemIdLabel.AutoSize = true;
            this.itemIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemIdLabel.Location = new System.Drawing.Point(30, 26);
            this.itemIdLabel.Name = "itemIdLabel";
            this.itemIdLabel.Size = new System.Drawing.Size(136, 25);
            this.itemIdLabel.TabIndex = 0;
            this.itemIdLabel.Text = "CMS Path/Id";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resultLabel);
            this.panel1.Controls.Add(this.noteTextBox);
            this.panel1.Controls.Add(this.resultTextBox);
            this.panel1.Controls.Add(this.queryTextbox);
            this.panel1.Controls.Add(this.itemNameTextbox);
            this.panel1.Controls.Add(this.itemNameLabel);
            this.panel1.Controls.Add(this.itemIdTextbox);
            this.panel1.Controls.Add(this.createItemBtn);
            this.panel1.Controls.Add(this.queryLabel);
            this.panel1.Controls.Add(this.templateTypeDropdown);
            this.panel1.Controls.Add(this.templateTypeLabel);
            this.panel1.Controls.Add(this.itemTypeDropdown);
            this.panel1.Controls.Add(this.itemTypeLabel);
            this.panel1.Controls.Add(this.itemIdLabel);
            this.panel1.Location = new System.Drawing.Point(64, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1212, 552);
            this.panel1.TabIndex = 6;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.Color.Purple;
            this.resultLabel.Location = new System.Drawing.Point(30, 386);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(180, 24);
            this.resultLabel.TabIndex = 10;
            this.resultLabel.Text = "Response Content";
            // 
            // noteTextBox
            // 
            this.noteTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteTextBox.Location = new System.Drawing.Point(909, 19);
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.ReadOnly = true;
            this.noteTextBox.Size = new System.Drawing.Size(279, 238);
            this.noteTextBox.TabIndex = 9;
            this.noteTextBox.Text = "";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(34, 434);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(636, 82);
            this.resultTextBox.TabIndex = 9;
            this.resultTextBox.Text = "";
            // 
            // queryTextbox
            // 
            this.queryTextbox.Location = new System.Drawing.Point(34, 262);
            this.queryTextbox.Name = "queryTextbox";
            this.queryTextbox.Size = new System.Drawing.Size(636, 82);
            this.queryTextbox.TabIndex = 8;
            this.queryTextbox.Text = "";
            // 
            // itemNameTextbox
            // 
            this.itemNameTextbox.Location = new System.Drawing.Point(34, 171);
            this.itemNameTextbox.Name = "itemNameTextbox";
            this.itemNameTextbox.Size = new System.Drawing.Size(280, 26);
            this.itemNameTextbox.TabIndex = 3;
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameLabel.Location = new System.Drawing.Point(30, 126);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(136, 25);
            this.itemNameLabel.TabIndex = 3;
            this.itemNameLabel.Text = "Content Title";
            // 
            // itemIdTextbox
            // 
            this.itemIdTextbox.Location = new System.Drawing.Point(34, 71);
            this.itemIdTextbox.Name = "itemIdTextbox";
            this.itemIdTextbox.Size = new System.Drawing.Size(415, 26);
            this.itemIdTextbox.TabIndex = 3;
            // 
            // createItemBtn
            // 
            this.createItemBtn.BackColor = System.Drawing.Color.Crimson;
            this.createItemBtn.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createItemBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createItemBtn.Location = new System.Drawing.Point(705, 275);
            this.createItemBtn.Name = "createItemBtn";
            this.createItemBtn.Size = new System.Drawing.Size(185, 50);
            this.createItemBtn.TabIndex = 6;
            this.createItemBtn.Text = "CREATE";
            this.createItemBtn.UseVisualStyleBackColor = false;
            this.createItemBtn.Click += new System.EventHandler(this.createItemBtn_Click);
            // 
            // queryLabel
            // 
            this.queryLabel.AutoSize = true;
            this.queryLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryLabel.ForeColor = System.Drawing.Color.Purple;
            this.queryLabel.Location = new System.Drawing.Point(30, 226);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(202, 24);
            this.queryLabel.TabIndex = 7;
            this.queryLabel.Text = "Your Prompt Query";
            // 
            // templateTypeDropdown
            // 
            this.templateTypeDropdown.FormattingEnabled = true;
            this.templateTypeDropdown.Location = new System.Drawing.Point(705, 71);
            this.templateTypeDropdown.Name = "templateTypeDropdown";
            this.templateTypeDropdown.Size = new System.Drawing.Size(185, 28);
            this.templateTypeDropdown.TabIndex = 3;
            this.templateTypeDropdown.SelectedIndexChanged += new System.EventHandler(this.templateTypeDropdown_SelectedIndexChanged);
            // 
            // templateTypeLabel
            // 
            this.templateTypeLabel.AutoSize = true;
            this.templateTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templateTypeLabel.Location = new System.Drawing.Point(690, 26);
            this.templateTypeLabel.Name = "templateTypeLabel";
            this.templateTypeLabel.Size = new System.Drawing.Size(189, 25);
            this.templateTypeLabel.TabIndex = 4;
            this.templateTypeLabel.Text = " Choose Template";
            // 
            // itemTypeDropdown
            // 
            this.itemTypeDropdown.FormattingEnabled = true;
            this.itemTypeDropdown.Location = new System.Drawing.Point(487, 69);
            this.itemTypeDropdown.Name = "itemTypeDropdown";
            this.itemTypeDropdown.Size = new System.Drawing.Size(183, 28);
            this.itemTypeDropdown.TabIndex = 3;
            this.itemTypeDropdown.SelectedIndexChanged += new System.EventHandler(this.itemTypeDropdown_SelectedIndexChanged);
            // 
            // itemTypeLabel
            // 
            this.itemTypeLabel.AutoSize = true;
            this.itemTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTypeLabel.Location = new System.Drawing.Point(483, 26);
            this.itemTypeLabel.Name = "itemTypeLabel";
            this.itemTypeLabel.Size = new System.Drawing.Size(143, 25);
            this.itemTypeLabel.TabIndex = 2;
            this.itemTypeLabel.Text = "Content Type";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1337, 36);
            this.menuStrip1.TabIndex = 10;
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
            // ContentIdeationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1337, 694);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.panel1);
            this.Name = "ContentIdeationForm";
            this.Text = "Content Ideation";
            this.Load += new System.EventHandler(this.TextGenerationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label itemIdLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button createItemBtn;
        private System.Windows.Forms.ComboBox templateTypeDropdown;
        private System.Windows.Forms.Label templateTypeLabel;
        private System.Windows.Forms.ComboBox itemTypeDropdown;
        private System.Windows.Forms.Label itemTypeLabel;
        private System.Windows.Forms.TextBox itemIdTextbox;
        private System.Windows.Forms.RichTextBox noteTextBox;
        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.TextBox itemNameTextbox;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textGenerationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem translationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.RichTextBox resultTextBox;
        private System.Windows.Forms.RichTextBox queryTextbox;
    }
}