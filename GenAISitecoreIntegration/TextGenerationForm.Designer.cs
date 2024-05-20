
namespace GenAISitecoreIntegration
{
    partial class TextGenerationForm
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
            this.pathLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.queryTextbox = new System.Windows.Forms.TextBox();
            this.queryLabel = new System.Windows.Forms.Label();
            this.pathTextbox = new System.Windows.Forms.TextBox();
            this.createItemBtn = new System.Windows.Forms.Button();
            this.templateTypeDropdown = new System.Windows.Forms.ComboBox();
            this.templateTypeLabel = new System.Windows.Forms.Label();
            this.itemTypeDropdown = new System.Windows.Forms.ComboBox();
            this.itemTypeLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.noteTextBox = new System.Windows.Forms.RichTextBox();
            this.noteLabel = new System.Windows.Forms.Label();
            this.itemNameTextbox = new System.Windows.Forms.TextBox();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(555, 18);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(207, 32);
            this.headerLabel.TabIndex = 8;
            this.headerLabel.Text = "Text Generation";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathLabel.Location = new System.Drawing.Point(30, 26);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(213, 23);
            this.pathLabel.TabIndex = 0;
            this.pathLabel.Text = "Path (Parent Item Path)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.itemNameTextbox);
            this.panel1.Controls.Add(this.itemNameLabel);
            this.panel1.Controls.Add(this.queryTextbox);
            this.panel1.Controls.Add(this.queryLabel);
            this.panel1.Controls.Add(this.pathTextbox);
            this.panel1.Controls.Add(this.createItemBtn);
            this.panel1.Controls.Add(this.templateTypeDropdown);
            this.panel1.Controls.Add(this.templateTypeLabel);
            this.panel1.Controls.Add(this.itemTypeDropdown);
            this.panel1.Controls.Add(this.itemTypeLabel);
            this.panel1.Controls.Add(this.pathLabel);
            this.panel1.Location = new System.Drawing.Point(60, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 238);
            this.panel1.TabIndex = 6;
            // 
            // queryTextbox
            // 
            this.queryTextbox.Location = new System.Drawing.Point(336, 71);
            this.queryTextbox.Name = "queryTextbox";
            this.queryTextbox.Size = new System.Drawing.Size(232, 26);
            this.queryTextbox.TabIndex = 3;
            // 
            // queryLabel
            // 
            this.queryLabel.AutoSize = true;
            this.queryLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryLabel.Location = new System.Drawing.Point(332, 26);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(64, 23);
            this.queryLabel.TabIndex = 7;
            this.queryLabel.Text = "Query";
            // 
            // pathTextbox
            // 
            this.pathTextbox.Location = new System.Drawing.Point(34, 71);
            this.pathTextbox.Name = "pathTextbox";
            this.pathTextbox.Size = new System.Drawing.Size(242, 26);
            this.pathTextbox.TabIndex = 3;
            // 
            // createItemBtn
            // 
            this.createItemBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.createItemBtn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createItemBtn.Location = new System.Drawing.Point(655, 153);
            this.createItemBtn.Name = "createItemBtn";
            this.createItemBtn.Size = new System.Drawing.Size(143, 45);
            this.createItemBtn.TabIndex = 6;
            this.createItemBtn.Text = "Create Item";
            this.createItemBtn.UseVisualStyleBackColor = false;
            this.createItemBtn.Click += new System.EventHandler(this.createItemBtn_Click);
            // 
            // templateTypeDropdown
            // 
            this.templateTypeDropdown.FormattingEnabled = true;
            this.templateTypeDropdown.Items.AddRange(new object[] {
            "template 1",
            "template 2"});
            this.templateTypeDropdown.Location = new System.Drawing.Point(336, 170);
            this.templateTypeDropdown.Name = "templateTypeDropdown";
            this.templateTypeDropdown.Size = new System.Drawing.Size(232, 28);
            this.templateTypeDropdown.TabIndex = 3;
            // 
            // templateTypeLabel
            // 
            this.templateTypeLabel.AutoSize = true;
            this.templateTypeLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templateTypeLabel.Location = new System.Drawing.Point(332, 126);
            this.templateTypeLabel.Name = "templateTypeLabel";
            this.templateTypeLabel.Size = new System.Drawing.Size(135, 23);
            this.templateTypeLabel.TabIndex = 4;
            this.templateTypeLabel.Text = "Template Type";
            // 
            // itemTypeDropdown
            // 
            this.itemTypeDropdown.FormattingEnabled = true;
            this.itemTypeDropdown.Items.AddRange(new object[] {
            "Article",
            "Blog"});
            this.itemTypeDropdown.Location = new System.Drawing.Point(34, 170);
            this.itemTypeDropdown.Name = "itemTypeDropdown";
            this.itemTypeDropdown.Size = new System.Drawing.Size(242, 28);
            this.itemTypeDropdown.TabIndex = 3;
            // 
            // itemTypeLabel
            // 
            this.itemTypeLabel.AutoSize = true;
            this.itemTypeLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTypeLabel.Location = new System.Drawing.Point(30, 126);
            this.itemTypeLabel.Name = "itemTypeLabel";
            this.itemTypeLabel.Size = new System.Drawing.Size(96, 23);
            this.itemTypeLabel.TabIndex = 2;
            this.itemTypeLabel.Text = "Item Type";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.resultLabel);
            this.panel2.Controls.Add(this.resultTextBox);
            this.panel2.Location = new System.Drawing.Point(94, 349);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 222);
            this.panel2.TabIndex = 7;
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
            this.resultTextBox.Location = new System.Drawing.Point(34, 60);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(730, 132);
            this.resultTextBox.TabIndex = 0;
            this.resultTextBox.Text = "";
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(957, 130);
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(347, 432);
            this.noteTextBox.TabIndex = 9;
            this.noteTextBox.Text = "";
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLabel.Location = new System.Drawing.Point(953, 80);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(58, 23);
            this.noteLabel.TabIndex = 10;
            this.noteLabel.Text = "Note:";
            // 
            // itemNameTextbox
            // 
            this.itemNameTextbox.Location = new System.Drawing.Point(625, 71);
            this.itemNameTextbox.Name = "itemNameTextbox";
            this.itemNameTextbox.Size = new System.Drawing.Size(213, 26);
            this.itemNameTextbox.TabIndex = 3;
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameLabel.Location = new System.Drawing.Point(621, 26);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(103, 23);
            this.itemNameLabel.TabIndex = 3;
            this.itemNameLabel.Text = "Item Name";
            // 
            // TextGenerationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 583);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "TextGenerationForm";
            this.Text = "TextGenerationForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button createItemBtn;
        private System.Windows.Forms.ComboBox templateTypeDropdown;
        private System.Windows.Forms.Label templateTypeLabel;
        private System.Windows.Forms.ComboBox itemTypeDropdown;
        private System.Windows.Forms.Label itemTypeLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.RichTextBox resultTextBox;
        private System.Windows.Forms.TextBox pathTextbox;
        private System.Windows.Forms.RichTextBox noteTextBox;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.TextBox queryTextbox;
        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.TextBox itemNameTextbox;
        private System.Windows.Forms.Label itemNameLabel;
    }
}