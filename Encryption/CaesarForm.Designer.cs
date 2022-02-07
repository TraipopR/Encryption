namespace Encryption
{
    partial class CaesarForm
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
            this.lbPlainText = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.txtPlainText = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.lbCipherText = new System.Windows.Forms.Label();
            this.txtCipherText = new System.Windows.Forms.TextBox();
            this.gbEncrypt = new System.Windows.Forms.GroupBox();
            this.lbCipherText1 = new System.Windows.Forms.Label();
            this.txtCipherText1 = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lbPlainText1 = new System.Windows.Forms.Label();
            this.txtPlainText1 = new System.Windows.Forms.TextBox();
            this.gbDecrypt = new System.Windows.Forms.GroupBox();
            this.lbKey = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.gbEncrypt.SuspendLayout();
            this.gbDecrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPlainText
            // 
            this.lbPlainText.AutoSize = true;
            this.lbPlainText.Location = new System.Drawing.Point(13, 37);
            this.lbPlainText.Name = "lbPlainText";
            this.lbPlainText.Size = new System.Drawing.Size(50, 13);
            this.lbPlainText.TabIndex = 0;
            this.lbPlainText.Text = "Plain text";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(120, 37);
            this.lbTitle.TabIndex = 15;
            this.lbTitle.Text = "Caesar";
            // 
            // txtPlainText
            // 
            this.txtPlainText.Location = new System.Drawing.Point(86, 34);
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(591, 20);
            this.txtPlainText.TabIndex = 16;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(683, 32);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 17;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.BtnEncrypt_Click);
            // 
            // lbCipherText
            // 
            this.lbCipherText.AutoSize = true;
            this.lbCipherText.Location = new System.Drawing.Point(13, 73);
            this.lbCipherText.Name = "lbCipherText";
            this.lbCipherText.Size = new System.Drawing.Size(57, 13);
            this.lbCipherText.TabIndex = 18;
            this.lbCipherText.Text = "Cipher text";
            // 
            // txtCipherText
            // 
            this.txtCipherText.Location = new System.Drawing.Point(86, 70);
            this.txtCipherText.Name = "txtCipherText";
            this.txtCipherText.ReadOnly = true;
            this.txtCipherText.Size = new System.Drawing.Size(672, 20);
            this.txtCipherText.TabIndex = 19;
            // 
            // gbEncrypt
            // 
            this.gbEncrypt.Controls.Add(this.txtCipherText);
            this.gbEncrypt.Controls.Add(this.lbCipherText);
            this.gbEncrypt.Controls.Add(this.btnEncrypt);
            this.gbEncrypt.Controls.Add(this.txtPlainText);
            this.gbEncrypt.Controls.Add(this.lbPlainText);
            this.gbEncrypt.Location = new System.Drawing.Point(12, 96);
            this.gbEncrypt.Name = "gbEncrypt";
            this.gbEncrypt.Size = new System.Drawing.Size(776, 101);
            this.gbEncrypt.TabIndex = 20;
            this.gbEncrypt.TabStop = false;
            this.gbEncrypt.Text = "Encrypt";
            // 
            // lbCipherText1
            // 
            this.lbCipherText1.AutoSize = true;
            this.lbCipherText1.Location = new System.Drawing.Point(13, 38);
            this.lbCipherText1.Name = "lbCipherText1";
            this.lbCipherText1.Size = new System.Drawing.Size(57, 13);
            this.lbCipherText1.TabIndex = 21;
            this.lbCipherText1.Text = "Cipher text";
            // 
            // txtCipherText1
            // 
            this.txtCipherText1.Location = new System.Drawing.Point(86, 35);
            this.txtCipherText1.Name = "txtCipherText1";
            this.txtCipherText1.Size = new System.Drawing.Size(591, 20);
            this.txtCipherText1.TabIndex = 22;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(683, 33);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 23;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.BtnDecrypt_Click);
            // 
            // lbPlainText1
            // 
            this.lbPlainText1.AutoSize = true;
            this.lbPlainText1.Location = new System.Drawing.Point(13, 77);
            this.lbPlainText1.Name = "lbPlainText1";
            this.lbPlainText1.Size = new System.Drawing.Size(50, 13);
            this.lbPlainText1.TabIndex = 24;
            this.lbPlainText1.Text = "Plain text";
            // 
            // txtPlainText1
            // 
            this.txtPlainText1.Location = new System.Drawing.Point(86, 74);
            this.txtPlainText1.Name = "txtPlainText1";
            this.txtPlainText1.ReadOnly = true;
            this.txtPlainText1.Size = new System.Drawing.Size(672, 20);
            this.txtPlainText1.TabIndex = 25;
            // 
            // gbDecrypt
            // 
            this.gbDecrypt.Controls.Add(this.txtPlainText1);
            this.gbDecrypt.Controls.Add(this.lbPlainText1);
            this.gbDecrypt.Controls.Add(this.btnDecrypt);
            this.gbDecrypt.Controls.Add(this.txtCipherText1);
            this.gbDecrypt.Controls.Add(this.lbCipherText1);
            this.gbDecrypt.Location = new System.Drawing.Point(12, 213);
            this.gbDecrypt.Name = "gbDecrypt";
            this.gbDecrypt.Size = new System.Drawing.Size(775, 111);
            this.gbDecrypt.TabIndex = 26;
            this.gbDecrypt.TabStop = false;
            this.gbDecrypt.Text = "Decrypt";
            // 
            // lbKey
            // 
            this.lbKey.AutoSize = true;
            this.lbKey.Location = new System.Drawing.Point(25, 70);
            this.lbKey.Name = "lbKey";
            this.lbKey.Size = new System.Drawing.Size(25, 13);
            this.lbKey.TabIndex = 27;
            this.lbKey.Text = "Key";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(98, 67);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(46, 20);
            this.txtKey.TabIndex = 28;
            this.txtKey.Leave += new System.EventHandler(this.TxtKey_Leave);
            // 
            // CaesarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 342);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.lbKey);
            this.Controls.Add(this.gbDecrypt);
            this.Controls.Add(this.gbEncrypt);
            this.Controls.Add(this.lbTitle);
            this.MaximumSize = new System.Drawing.Size(816, 381);
            this.Name = "CaesarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CaesarForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CaesarForm_FormClosing);
            this.Load += new System.EventHandler(this.CaesarForm_Load);
            this.gbEncrypt.ResumeLayout(false);
            this.gbEncrypt.PerformLayout();
            this.gbDecrypt.ResumeLayout(false);
            this.gbDecrypt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPlainText;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox txtPlainText;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label lbCipherText;
        private System.Windows.Forms.TextBox txtCipherText;
        private System.Windows.Forms.GroupBox gbEncrypt;
        private System.Windows.Forms.Label lbCipherText1;
        private System.Windows.Forms.TextBox txtCipherText1;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lbPlainText1;
        private System.Windows.Forms.TextBox txtPlainText1;
        private System.Windows.Forms.GroupBox gbDecrypt;
        private System.Windows.Forms.Label lbKey;
        private System.Windows.Forms.TextBox txtKey;
    }
}