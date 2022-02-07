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
    public partial class CaesarForm : Form
    {
        public CaesarForm()
        {
            InitializeComponent();
        }

        public MenuForm FormToShowOnClosing { get; internal set; }
        private int _key = 3;

        private void CaesarForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (null != FormToShowOnClosing)
                FormToShowOnClosing.Show();
        }

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            string plainText = txtPlainText.Text;
            if (string.IsNullOrEmpty(plainText))
            {
                MessageBox.Show("โปรดกรอก Plain text", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtCipherText.Text = Cipher(plainText, _key);
            txtCipherText1.Text = txtCipherText.Text;
        }

        private string Cipher(string plainText, int key)
        {
            return String.Join("", plainText.ToCharArray().Select(c => {
                if (!char.IsLetter(c))
                    return c;
                char offset = char.IsUpper(c) ? 'A' : 'a';
                return (char)((c + key - offset) % 26 + offset);
            }));
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            string cipherText = txtCipherText1.Text;
            if (string.IsNullOrEmpty(cipherText))
            {
                MessageBox.Show("โปรดกรอก Cipher text", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtPlainText1.Text = Cipher(cipherText, 26 - _key);
        }

        private void CaesarForm_Load(object sender, EventArgs e)
        {
            txtKey.Text = _key.ToString();
        }

        private void TxtKey_Leave(object sender, EventArgs e)
        {
            bool wrong = false;
            string buffer = txtKey.Text;
            if (!int.TryParse(buffer, out _key))
                if (buffer.Length != 1)
                    wrong = true;
                else
                {
                    char temp = buffer[0];
                    if (char.IsLetter(temp))
                    {
                        _key = char.IsUpper(temp) ? temp - 'A' : temp - 'a'; // A: 65, a: 97
                    }
                    else
                    {
                        wrong = true;
                    }
                }
            if (wrong)
            {
                MessageBox.Show("โปรดกรอก Key 0-25 หรือ A-Z หรือ a-z", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKey.Text = _key.ToString();
                txtKey.Focus();
            }
        }
    }
}
