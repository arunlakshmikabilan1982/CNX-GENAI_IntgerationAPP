
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
            this.itemPathLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.queryTextbox = new System.Windows.Forms.TextBox();
            this.queryLabel = new System.Windows.Forms.Label();
            this.getItemFieldsBtn = new System.Windows.Forms.Button();
            this.itemPathTextbox = new System.Windows.Forms.TextBox();
            this.translateBtn = new System.Windows.Forms.Button();
            this.languageDropdown = new System.Windows.Forms.ComboBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.fieldListDropdown = new System.Windows.Forms.ComboBox();
            this.fieldListLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemPathLabel
            // 
            this.itemPathLabel.AutoSize = true;
            this.itemPathLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPathLabel.Location = new System.Drawing.Point(41, 35);
            this.itemPathLabel.Name = "itemPathLabel";
            this.itemPathLabel.Size = new System.Drawing.Size(93, 23);
            this.itemPathLabel.TabIndex = 0;
            this.itemPathLabel.Text = "Item Path";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.queryTextbox);
            this.panel1.Controls.Add(this.queryLabel);
            this.panel1.Controls.Add(this.getItemFieldsBtn);
            this.panel1.Controls.Add(this.itemPathTextbox);
            this.panel1.Controls.Add(this.translateBtn);
            this.panel1.Controls.Add(this.languageDropdown);
            this.panel1.Controls.Add(this.languageLabel);
            this.panel1.Controls.Add(this.fieldListDropdown);
            this.panel1.Controls.Add(this.fieldListLabel);
            this.panel1.Controls.Add(this.itemPathLabel);
            this.panel1.Location = new System.Drawing.Point(105, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 281);
            this.panel1.TabIndex = 1;
            // 
            // queryTextbox
            // 
            this.queryTextbox.Location = new System.Drawing.Point(429, 73);
            this.queryTextbox.Name = "queryTextbox";
            this.queryTextbox.Size = new System.Drawing.Size(259, 26);
            this.queryTextbox.TabIndex = 3;
            // 
            // queryLabel
            // 
            this.queryLabel.AutoSize = true;
            this.queryLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryLabel.Location = new System.Drawing.Point(425, 35);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(64, 23);
            this.queryLabel.TabIndex = 9;
            this.queryLabel.Text = "Query";
            // 
            // getItemFieldsBtn
            // 
            this.getItemFieldsBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.getItemFieldsBtn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getItemFieldsBtn.Location = new System.Drawing.Point(79, 121);
            this.getItemFieldsBtn.Name = "getItemFieldsBtn";
            this.getItemFieldsBtn.Size = new System.Drawing.Size(188, 34);
            this.getItemFieldsBtn.TabIndex = 7;
            this.getItemFieldsBtn.Text = "Get Item Fields";
            this.getItemFieldsBtn.UseVisualStyleBackColor = false;
            this.getItemFieldsBtn.Click += new System.EventHandler(this.getItemFieldsBtn_Click);
            // 
            // itemPathTextbox
            // 
            this.itemPathTextbox.Location = new System.Drawing.Point(45, 73);
            this.itemPathTextbox.Name = "itemPathTextbox";
            this.itemPathTextbox.Size = new System.Drawing.Size(259, 26);
            this.itemPathTextbox.TabIndex = 3;
            // 
            // translateBtn
            // 
            this.translateBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.translateBtn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translateBtn.Location = new System.Drawing.Point(744, 116);
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
            this.languageDropdown.Location = new System.Drawing.Point(429, 205);
            this.languageDropdown.Name = "languageDropdown";
            this.languageDropdown.Size = new System.Drawing.Size(259, 28);
            this.languageDropdown.TabIndex = 3;
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageLabel.Location = new System.Drawing.Point(425, 169);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(93, 23);
            this.languageLabel.TabIndex = 4;
            this.languageLabel.Text = "Language";
            // 
            // fieldListDropdown
            // 
            this.fieldListDropdown.FormattingEnabled = true;
            this.fieldListDropdown.Location = new System.Drawing.Point(45, 205);
            this.fieldListDropdown.Name = "fieldListDropdown";
            this.fieldListDropdown.Size = new System.Drawing.Size(259, 28);
            this.fieldListDropdown.TabIndex = 3;
            // 
            // fieldListLabel
            // 
            this.fieldListLabel.AutoSize = true;
            this.fieldListLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldListLabel.Location = new System.Drawing.Point(41, 169);
            this.fieldListLabel.Name = "fieldListLabel";
            this.fieldListLabel.Size = new System.Drawing.Size(89, 23);
            this.fieldListLabel.TabIndex = 2;
            this.fieldListLabel.Text = "Field List";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.resultLabel);
            this.panel2.Controls.Add(this.resultTextBox);
            this.panel2.Location = new System.Drawing.Point(150, 418);
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
            this.resultTextBox.Size = new System.Drawing.Size(793, 137);
            this.resultTextBox.TabIndex = 0;
            this.resultTextBox.Text = "";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(538, 29);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(153, 32);
            this.headerLabel.TabIndex = 5;
            this.headerLabel.Text = "Translation";
            // 
            // TranslationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 673);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TranslationForm";
            this.Text = "Translation Form";
            this.Load += new System.EventHandler(this.TranslationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemPathLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button translateBtn;
        private System.Windows.Forms.ComboBox languageDropdown;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.RichTextBox resultTextBox;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox itemPathTextbox;
        private System.Windows.Forms.Button getItemFieldsBtn;
        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.TextBox queryTextbox;
        private System.Windows.Forms.ComboBox fieldListDropdown;
        private System.Windows.Forms.Label fieldListLabel;
    }
}

