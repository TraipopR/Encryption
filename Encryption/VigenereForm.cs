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
    public partial class VigenereForm : Form
    {
        public MenuForm FormToShowOnClosing { get; internal set; }

        public VigenereForm()
        {
            InitializeComponent();
        }

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

        private void TxtKeyword_Leave(object sender, EventArgs e)
        {
            string keyword = txtKeyword.Text;
            if (keyword.Any(key => !char.IsLetter(key)))
            {
                MessageBox.Show("โปรดกรอก Keyword เฉพาะ A-Z หรือ a-z", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            string cipherText = txtCipherText1.Text;
            if (string.IsNullOrEmpty(cipherText))
            {
                MessageBox.Show("โปรดกรอก Cipher text", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtPlainText1.Text = Cipher(cipherText, false);
        }

        private string Cipher(string plainText, bool encrypt = true)
        {
            int nonLetter = 0;
            string keyword = txtKeyword.Text;

            return String.Join("", plainText.ToCharArray().Select((c, i) =>
            {
                if (!char.IsLetter(c))
                {
                    ++nonLetter;
                    return c;
                }
                char offset = char.IsUpper(c) ? 'A' : 'a';
                char temp = keyword[(i - nonLetter) % keyword.Length];
                int key = (char.IsUpper(temp) ? temp - 'A' : temp - 'a') * (encrypt ? 1: -1);

                // + 26 กับ % 26 ใช้สำหรับแก้ตอน Decrypt เมื่อค่าเป็นติดลบ
                return (char)((((c + key - offset) % 26 + 26) % 26) + offset);
            }));
        }

        private void VigenereForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (null != FormToShowOnClosing)
                FormToShowOnClosing.Show();
        }
    }
}
