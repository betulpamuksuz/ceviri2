namespace TranslateApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbSourceLanguage = new System.Windows.Forms.ComboBox();
            this.cmbTargetLanguage = new System.Windows.Forms.ComboBox();
            this.lblSourceLanguage = new System.Windows.Forms.Label();
            this.lblTargetLanguage = new System.Windows.Forms.Label();
            this.txtSourceText = new System.Windows.Forms.TextBox();
            this.txtTranslatedText = new System.Windows.Forms.TextBox();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbSourceLanguage
            // 
            this.cmbSourceLanguage.FormattingEnabled = true;
            this.cmbSourceLanguage.Location = new System.Drawing.Point(140, 62);
            this.cmbSourceLanguage.Name = "cmbSourceLanguage";
            this.cmbSourceLanguage.Size = new System.Drawing.Size(141, 24);
            this.cmbSourceLanguage.TabIndex = 0;
            // 
            // cmbTargetLanguage
            // 
            this.cmbTargetLanguage.FormattingEnabled = true;
            this.cmbTargetLanguage.Location = new System.Drawing.Point(388, 62);
            this.cmbTargetLanguage.Name = "cmbTargetLanguage";
            this.cmbTargetLanguage.Size = new System.Drawing.Size(137, 24);
            this.cmbTargetLanguage.TabIndex = 1;
            // 
            // lblSourceLanguage
            // 
            this.lblSourceLanguage.AutoSize = true;
            this.lblSourceLanguage.Location = new System.Drawing.Point(181, 26);
            this.lblSourceLanguage.Name = "lblSourceLanguage";
            this.lblSourceLanguage.Size = new System.Drawing.Size(71, 16);
            this.lblSourceLanguage.TabIndex = 2;
            this.lblSourceLanguage.Text = "Kaynak Dil";
            // 
            // lblTargetLanguage
            // 
            this.lblTargetLanguage.AutoSize = true;
            this.lblTargetLanguage.Location = new System.Drawing.Point(422, 26);
            this.lblTargetLanguage.Name = "lblTargetLanguage";
            this.lblTargetLanguage.Size = new System.Drawing.Size(63, 16);
            this.lblTargetLanguage.TabIndex = 3;
            this.lblTargetLanguage.Text = "Hedef Dil";
            // 
            // txtSourceText
            // 
            this.txtSourceText.Location = new System.Drawing.Point(140, 126);
            this.txtSourceText.Name = "txtSourceText";
            this.txtSourceText.Size = new System.Drawing.Size(137, 22);
            this.txtSourceText.TabIndex = 4;
            // 
            // txtTranslatedText
            // 
            this.txtTranslatedText.Location = new System.Drawing.Point(425, 126);
            this.txtTranslatedText.Name = "txtTranslatedText";
            this.txtTranslatedText.Size = new System.Drawing.Size(125, 22);
            this.txtTranslatedText.TabIndex = 5;
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(309, 125);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(75, 23);
            this.btnTranslate.TabIndex = 6;
            this.btnTranslate.Text = "Çevir";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 92);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(623, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 43);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.txtTranslatedText);
            this.Controls.Add(this.txtSourceText);
            this.Controls.Add(this.lblTargetLanguage);
            this.Controls.Add(this.lblSourceLanguage);
            this.Controls.Add(this.cmbTargetLanguage);
            this.Controls.Add(this.cmbSourceLanguage);
            this.Name = "MainForm";
            this.Text = "Çeviri Uygulaması";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox cmbSourceLanguage;
        private System.Windows.Forms.ComboBox cmbTargetLanguage;
        private System.Windows.Forms.Label lblSourceLanguage;
        private System.Windows.Forms.Label lblTargetLanguage;
        private System.Windows.Forms.TextBox txtSourceText;
        private System.Windows.Forms.TextBox txtTranslatedText;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}
