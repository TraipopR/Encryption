namespace Encryption
{
    partial class VernamForm
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.gbDecrypt = new System.Windows.Forms.GroupBox();
            this.txtKey1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlainText1 = new System.Windows.Forms.TextBox();
            this.lbPlainText1 = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtCipherText1 = new System.Windows.Forms.TextBox();
            this.lbCipherText1 = new System.Windows.Forms.Label();
            this.gbEncrypt = new System.Windows.Forms.GroupBox();
            this.txtCipherText = new System.Windows.Forms.TextBox();
            this.lbCipherText = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lbKey = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtPlainText = new System.Windows.Forms.TextBox();
            this.lbPlainText = new System.Windows.Forms.Label();
            this.gbDecrypt.SuspendLayout();
            this.gbEncrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(130, 37);
            this.lbTitle.TabIndex = 16;
            this.lbTitle.Text = "Vernam";
            // 
            // gbDecrypt
            // 
            this.gbDecrypt.Controls.Add(this.txtKey1);
            this.gbDecrypt.Controls.Add(this.label1);
            this.gbDecrypt.Controls.Add(this.txtPlainText1);
            this.gbDecrypt.Controls.Add(this.lbPlainText1);
            this.gbDecrypt.Controls.Add(this.btnDecrypt);
            this.gbDecrypt.Controls.Add(this.txtCipherText1);
            this.gbDecrypt.Controls.Add(this.lbCipherText1);
            this.gbDecrypt.Location = new System.Drawing.Point(12, 185);
            this.gbDecrypt.Name = "gbDecrypt";
            this.gbDecrypt.Size = new System.Drawing.Size(776, 133);
            this.gbDecrypt.TabIndex = 31;
            this.gbDecrypt.TabStop = false;
            this.gbDecrypt.Text = "Decrypt";
            // 
            // txtKey1
            // 
            this.txtKey1.Location = new System.Drawing.Point(86, 24);
            this.txtKey1.Name = "txtKey1";
            this.txtKey1.Size = new System.Drawing.Size(672, 20);
            this.txtKey1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Key";
            // 
            // txtPlainText1
            // 
            this.txtPlainText1.Location = new System.Drawing.Point(86, 95);
            this.txtPlainText1.Name = "txtPlainText1";
            this.txtPlainText1.ReadOnly = true;
            this.txtPlainText1.Size = new System.Drawing.Size(672, 20);
            this.txtPlainText1.TabIndex = 25;
            // 
            // lbPlainText1
            // 
            this.lbPlainText1.AutoSize = true;
            this.lbPlainText1.Location = new System.Drawing.Point(13, 98);
            this.lbPlainText1.Name = "lbPlainText1";
            this.lbPlainText1.Size = new System.Drawing.Size(50, 13);
            this.lbPlainText1.TabIndex = 24;
            this.lbPlainText1.Text = "Plain text";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(683, 57);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 23;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.BtnDecrypt_Click);
            // 
            // txtCipherText1
            // 
            this.txtCipherText1.Location = new System.Drawing.Point(86, 59);
            this.txtCipherText1.Name = "txtCipherText1";
            this.txtCipherText1.Size = new System.Drawing.Size(591, 20);
            this.txtCipherText1.TabIndex = 22;
            // 
            // lbCipherText1
            // 
            this.lbCipherText1.AutoSize = true;
            this.lbCipherText1.Location = new System.Drawing.Point(13, 62);
            this.lbCipherText1.Name = "lbCipherText1";
            this.lbCipherText1.Size = new System.Drawing.Size(57, 13);
            this.lbCipherText1.TabIndex = 21;
            this.lbCipherText1.Text = "Cipher text";
            // 
            // gbEncrypt
            // 
            this.gbEncrypt.Controls.Add(this.txtCipherText);
            this.gbEncrypt.Controls.Add(this.lbCipherText);
            this.gbEncrypt.Controls.Add(this.txtKey);
            this.gbEncrypt.Controls.Add(this.lbKey);
            this.gbEncrypt.Controls.Add(this.btnEncrypt);
            this.gbEncrypt.Controls.Add(this.txtPlainText);
            this.gbEncrypt.Controls.Add(this.lbPlainText);
            this.gbEncrypt.Location = new System.Drawing.Point(12, 49);
            this.gbEncrypt.Name = "gbEncrypt";
            this.gbEncrypt.Size = new System.Drawing.Size(776, 130);
            this.gbEncrypt.TabIndex = 30;
            this.gbEncrypt.TabStop = false;
            this.gbEncrypt.Text = "Encrypt";
            // 
            // txtCipherText
            // 
            this.txtCipherText.Location = new System.Drawing.Point(86, 101);
            this.txtCipherText.Name = "txtCipherText";
            this.txtCipherText.ReadOnly = true;
            this.txtCipherText.Size = new System.Drawing.Size(672, 20);
            this.txtCipherText.TabIndex = 19;
            // 
            // lbCipherText
            // 
            this.lbCipherText.AutoSize = true;
            this.lbCipherText.Location = new System.Drawing.Point(13, 104);
            this.lbCipherText.Name = "lbCipherText";
            this.lbCipherText.Size = new System.Drawing.Size(57, 13);
            this.lbCipherText.TabIndex = 18;
            this.lbCipherText.Text = "Cipher text";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(86, 65);
            this.txtKey.Name = "txtKey";
            this.txtKey.ReadOnly = true;
            this.txtKey.Size = new System.Drawing.Size(672, 20);
            this.txtKey.TabIndex = 29;
            // 
            // lbKey
            // 
            this.lbKey.AutoSize = true;
            this.lbKey.Location = new System.Drawing.Point(35, 68);
            this.lbKey.Name = "lbKey";
            this.lbKey.Size = new System.Drawing.Size(25, 13);
            this.lbKey.TabIndex = 28;
            this.lbKey.Text = "Key";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(683, 27);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 17;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.BtnEncrypt_Click);
            // 
            // txtPlainText
            // 
            this.txtPlainText.Location = new System.Drawing.Point(86, 29);
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(591, 20);
            this.txtPlainText.TabIndex = 16;
            // 
            // lbPlainText
            // 
            this.lbPlainText.AutoSize = true;
            this.lbPlainText.Location = new System.Drawing.Point(13, 32);
            this.lbPlainText.Name = "lbPlainText";
            this.lbPlainText.Size = new System.Drawing.Size(50, 13);
            this.lbPlainText.TabIndex = 0;
            this.lbPlainText.Text = "Plain text";
            // 
            // VernamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 330);
            this.Controls.Add(this.gbDecrypt);
            this.Controls.Add(this.gbEncrypt);
            this.Controls.Add(this.lbTitle);
            this.MaximumSize = new System.Drawing.Size(816, 369);
            this.Name = "VernamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VernamForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VernamForm_FormClosing);
            this.gbDecrypt.ResumeLayout(false);
            this.gbDecrypt.PerformLayout();
            this.gbEncrypt.ResumeLayout(false);
            this.gbEncrypt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox gbDecrypt;
        private System.Windows.Forms.TextBox txtPlainText1;
        private System.Windows.Forms.Label lbPlainText1;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtCipherText1;
        private System.Windows.Forms.Label lbCipherText1;
        private System.Windows.Forms.GroupBox gbEncrypt;
        private System.Windows.Forms.TextBox txtCipherText;
        private System.Windows.Forms.Label lbCipherText;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtPlainText;
        private System.Windows.Forms.Label lbPlainText;
        private System.Windows.Forms.TextBox txtKey1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lbKey;
    }
}