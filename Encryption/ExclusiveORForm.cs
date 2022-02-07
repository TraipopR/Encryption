using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption
{
    public partial class ExclusiveORForm : Form
    {
        public ExclusiveORForm()
        {
            InitializeComponent();
        }

        public MenuForm FormToShowOnClosing { get; internal set; }

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            string plainText = txtPlainText.Text;
            if (string.IsNullOrEmpty(plainText))
            {
                MessageBox.Show("โปรดกรอก Plain text", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtCipherText.Text = Cipher(plainText);
            txtCipherText1.Text = txtCipherText.Text;
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            string cipherText = txtCipherText1.Text;
            if (string.IsNullOrEmpty(cipherText))
            {
                MessageBox.Show("โปรดกรอก Cipher text", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtPlainText1.Text = Cipher(cipherText);
        }

        private string Cipher(string text)
        {
            string key = txtKey.Text;
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                var temp = (char)((uint)text[i] ^ key[i % key.Length]);
                if (temp == '\0') result += text[i];
                else result += (char)((uint)text[i] ^ key[i % key.Length]);
            }

            return result;
        }

        private void ExclusiveORForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (null != FormToShowOnClosing)
                FormToShowOnClosing.Show();
        }
    }
}
