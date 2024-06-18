
namespace GenAISitecoreIntegration
{
    partial class HomeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textGenerationBtn = new System.Windows.Forms.Button();
            this.translationBtn = new System.Windows.Forms.Button();
            this.contentBtn = new System.Windows.Forms.Button();
            this.imageBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(350, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "GenAI Operations";
            // 
            // textGenerationBtn
            // 
            this.textGenerationBtn.BackColor = System.Drawing.Color.Crimson;
            this.textGenerationBtn.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGenerationBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textGenerationBtn.Location = new System.Drawing.Point(384, 153);
            this.textGenerationBtn.Name = "textGenerationBtn";
            this.textGenerationBtn.Size = new System.Drawing.Size(250, 58);
            this.textGenerationBtn.TabIndex = 1;
            this.textGenerationBtn.Text = "Content Ideation";
            this.textGenerationBtn.UseVisualStyleBackColor = false;
            this.textGenerationBtn.Click += new System.EventHandler(this.textGenerationBtn_Click);
            // 
            // translationBtn
            // 
            this.translationBtn.BackColor = System.Drawing.Color.Crimson;
            this.translationBtn.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translationBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.translationBtn.Location = new System.Drawing.Point(384, 217);
            this.translationBtn.Name = "translationBtn";
            this.translationBtn.Size = new System.Drawing.Size(250, 87);
            this.translationBtn.TabIndex = 1;
            this.translationBtn.Text = "Language Translation";
            this.translationBtn.UseVisualStyleBackColor = false;
            this.translationBtn.Click += new System.EventHandler(this.translationBtn_Click);
            // 
            // contentBtn
            // 
            this.contentBtn.BackColor = System.Drawing.Color.Crimson;
            this.contentBtn.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contentBtn.Location = new System.Drawing.Point(384, 310);
            this.contentBtn.Name = "contentBtn";
            this.contentBtn.Size = new System.Drawing.Size(250, 58);
            this.contentBtn.TabIndex = 1;
            this.contentBtn.Text = "Content Updation";
            this.contentBtn.UseVisualStyleBackColor = false;
            this.contentBtn.Click += new System.EventHandler(this.contentBtn_Click);
            // 
            // imageBtn
            // 
            this.imageBtn.BackColor = System.Drawing.Color.Crimson;
            this.imageBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imageBtn.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imageBtn.Location = new System.Drawing.Point(384, 374);
            this.imageBtn.Name = "imageBtn";
            this.imageBtn.Size = new System.Drawing.Size(250, 95);
            this.imageBtn.TabIndex = 1;
            this.imageBtn.Text = "Image To Text Generation";
            this.imageBtn.UseVisualStyleBackColor = false;
            this.imageBtn.Click += new System.EventHandler(this.imageBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Crimson;
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitBtn.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitBtn.Location = new System.Drawing.Point(384, 475);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(250, 58);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1032, 620);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.imageBtn);
            this.Controls.Add(this.contentBtn);
            this.Controls.Add(this.translationBtn);
            this.Controls.Add(this.textGenerationBtn);
            this.Controls.Add(this.label1);
            this.Name = "HomeForm";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button textGenerationBtn;
        private System.Windows.Forms.Button translationBtn;
        private System.Windows.Forms.Button contentBtn;
        private System.Windows.Forms.Button imageBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}