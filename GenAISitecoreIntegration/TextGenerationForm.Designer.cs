
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
            this.createItemBtn = new System.Windows.Forms.Button();
            this.templateTypeDropdown = new System.Windows.Forms.ComboBox();
            this.templateTypeLabel = new System.Windows.Forms.Label();
            this.itemTypeDropdown = new System.Windows.Forms.ComboBox();
            this.itemTypeLabel = new System.Windows.Forms.Label();
            this.pathDropdown = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(481, 11);
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
            this.panel1.Controls.Add(this.createItemBtn);
            this.panel1.Controls.Add(this.templateTypeDropdown);
            this.panel1.Controls.Add(this.templateTypeLabel);
            this.panel1.Controls.Add(this.itemTypeDropdown);
            this.panel1.Controls.Add(this.itemTypeLabel);
            this.panel1.Controls.Add(this.pathDropdown);
            this.panel1.Controls.Add(this.pathLabel);
            this.panel1.Location = new System.Drawing.Point(107, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 206);
            this.panel1.TabIndex = 6;
            // 
            // createItemBtn
            // 
            this.createItemBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.createItemBtn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createItemBtn.Location = new System.Drawing.Point(380, 142);
            this.createItemBtn.Name = "createItemBtn";
            this.createItemBtn.Size = new System.Drawing.Size(143, 45);
            this.createItemBtn.TabIndex = 6;
            this.createItemBtn.Text = "Create Item";
            this.createItemBtn.UseVisualStyleBackColor = false;
            // 
            // templateTypeDropdown
            // 
            this.templateTypeDropdown.FormattingEnabled = true;
            this.templateTypeDropdown.Location = new System.Drawing.Point(635, 71);
            this.templateTypeDropdown.Name = "templateTypeDropdown";
            this.templateTypeDropdown.Size = new System.Drawing.Size(222, 28);
            this.templateTypeDropdown.TabIndex = 3;
            // 
            // templateTypeLabel
            // 
            this.templateTypeLabel.AutoSize = true;
            this.templateTypeLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templateTypeLabel.Location = new System.Drawing.Point(631, 26);
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
            this.itemTypeDropdown.Location = new System.Drawing.Point(336, 71);
            this.itemTypeDropdown.Name = "itemTypeDropdown";
            this.itemTypeDropdown.Size = new System.Drawing.Size(222, 28);
            this.itemTypeDropdown.TabIndex = 3;
            // 
            // itemTypeLabel
            // 
            this.itemTypeLabel.AutoSize = true;
            this.itemTypeLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTypeLabel.Location = new System.Drawing.Point(332, 26);
            this.itemTypeLabel.Name = "itemTypeLabel";
            this.itemTypeLabel.Size = new System.Drawing.Size(96, 23);
            this.itemTypeLabel.TabIndex = 2;
            this.itemTypeLabel.Text = "Item Type";
            // 
            // pathDropdown
            // 
            this.pathDropdown.FormattingEnabled = true;
            this.pathDropdown.Location = new System.Drawing.Point(34, 71);
            this.pathDropdown.Name = "pathDropdown";
            this.pathDropdown.Size = new System.Drawing.Size(222, 28);
            this.pathDropdown.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.resultLabel);
            this.panel2.Controls.Add(this.resultTextBox);
            this.panel2.Location = new System.Drawing.Point(107, 340);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 222);
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
            this.resultTextBox.Size = new System.Drawing.Size(823, 137);
            this.resultTextBox.TabIndex = 0;
            this.resultTextBox.Text = "";
            // 
            // TextGenerationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 583);
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
        private System.Windows.Forms.ComboBox pathDropdown;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.RichTextBox resultTextBox;
    }
}