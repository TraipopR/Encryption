namespace Encryption
{
    partial class MenuForm
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
            this.btnSubstitution = new System.Windows.Forms.Button();
            this.btnCaesar = new System.Windows.Forms.Button();
            this.btnVigenere = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnColumnarTransposition = new System.Windows.Forms.Button();
            this.btnExclusiveOR = new System.Windows.Forms.Button();
            this.btnVernam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubstitution
            // 
            this.btnSubstitution.Location = new System.Drawing.Point(63, 63);
            this.btnSubstitution.Name = "btnSubstitution";
            this.btnSubstitution.Size = new System.Drawing.Size(75, 23);
            this.btnSubstitution.TabIndex = 0;
            this.btnSubstitution.Text = "Substitution";
            this.btnSubstitution.UseVisualStyleBackColor = true;
            this.btnSubstitution.Click += new System.EventHandler(this.BtnSubstitition_Click);
            // 
            // btnCaesar
            // 
            this.btnCaesar.Location = new System.Drawing.Point(144, 63);
            this.btnCaesar.Name = "btnCaesar";
            this.btnCaesar.Size = new System.Drawing.Size(75, 23);
            this.btnCaesar.TabIndex = 1;
            this.btnCaesar.Text = "Caesar";
            this.btnCaesar.UseVisualStyleBackColor = true;
            this.btnCaesar.Click += new System.EventHandler(this.BtnCaesar_Click);
            // 
            // btnVigenere
            // 
            this.btnVigenere.Location = new System.Drawing.Point(225, 63);
            this.btnVigenere.Name = "btnVigenere";
            this.btnVigenere.Size = new System.Drawing.Size(75, 23);
            this.btnVigenere.TabIndex = 2;
            this.btnVigenere.Text = "Vigenere";
            this.btnVigenere.UseVisualStyleBackColor = true;
            this.btnVigenere.Click += new System.EventHandler(this.BtnVigenere_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(99, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(168, 37);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "Encryption";
            // 
            // btnColumnarTransposition
            // 
            this.btnColumnarTransposition.Location = new System.Drawing.Point(63, 92);
            this.btnColumnarTransposition.Name = "btnColumnarTransposition";
            this.btnColumnarTransposition.Size = new System.Drawing.Size(237, 23);
            this.btnColumnarTransposition.TabIndex = 4;
            this.btnColumnarTransposition.Text = "Columnar Transposition";
            this.btnColumnarTransposition.UseVisualStyleBackColor = true;
            this.btnColumnarTransposition.Click += new System.EventHandler(this.BtnColumnarTransposition_Click);
            // 
            // btnExclusiveOR
            // 
            this.btnExclusiveOR.Location = new System.Drawing.Point(63, 121);
            this.btnExclusiveOR.Name = "btnExclusiveOR";
            this.btnExclusiveOR.Size = new System.Drawing.Size(115, 23);
            this.btnExclusiveOR.TabIndex = 5;
            this.btnExclusiveOR.Text = "Exclusive OR";
            this.btnExclusiveOR.UseVisualStyleBackColor = true;
            this.btnExclusiveOR.Click += new System.EventHandler(this.BtnExclusiveOR_Click);
            // 
            // btnVernam
            // 
            this.btnVernam.Location = new System.Drawing.Point(184, 121);
            this.btnVernam.Name = "btnVernam";
            this.btnVernam.Size = new System.Drawing.Size(115, 23);
            this.btnVernam.TabIndex = 6;
            this.btnVernam.Text = "Vernam";
            this.btnVernam.UseVisualStyleBackColor = true;
            this.btnVernam.Click += new System.EventHandler(this.BtnVernam_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 176);
            this.Controls.Add(this.btnVernam);
            this.Controls.Add(this.btnExclusiveOR);
            this.Controls.Add(this.btnColumnarTransposition);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnVigenere);
            this.Controls.Add(this.btnCaesar);
            this.Controls.Add(this.btnSubstitution);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(382, 215);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubstitution;
        private System.Windows.Forms.Button btnCaesar;
        private System.Windows.Forms.Button btnVigenere;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnColumnarTransposition;
        private System.Windows.Forms.Button btnExclusiveOR;
        private System.Windows.Forms.Button btnVernam;
    }
}

