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
    public partial class VernamForm : Form
    {
        public VernamForm()
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

            Random rand = new Random();
            string key = "";
            for (int i = 0; i < plainText.Length; i++)
            {
                key += (char)rand.Next(65, 90);
            }
            txtCipherText.Text = Cipher(plainText, key);
            txtKey.Text = key;
            txtCipherText1.Text = txtCipherText.Text;
            txtKey1.Text = txtKey.Text;
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            string cipherText = txtCipherText1.Text;
            if (string.IsNullOrEmpty(cipherText))
            {
                MessageBox.Show("โปรดกรอก Cipher text", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtPlainText1.Text = Cipher(cipherText, txtKey1.Text, false);
        }

        private string Cipher(string text, string keyword, bool encrypt = true)
        {
            int nonLetter = 0;

            return String.Join("", text.ToCharArray().Select((c, i) =>
            {
                if (!char.IsLetter(c))
                {
                    ++nonLetter;
                    return c;
                }
                char offset = char.IsUpper(c) ? 'A' : 'a';
                char temp = keyword[(i - nonLetter) % keyword.Length];
                int key = (char.IsUpper(temp) ? temp - 'A' : temp - 'a') * (encrypt ? 1 : -1);

                return (char)((((c - offset + key) % 26 + 26) % 26) + offset);
            }));
        }

        private void VernamForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (null != FormToShowOnClosing)
                FormToShowOnClosing.Show();
        }
    }
}
