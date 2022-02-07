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
    public partial class ColumnarTranspositionForm : Form
    {
        public MenuForm FormToShowOnClosing { get; internal set; }

        public ColumnarTranspositionForm()
        {
            InitializeComponent();
        }

        private void ColumnarTranspositionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (null != FormToShowOnClosing)
                FormToShowOnClosing.Show();
        }

        private void TxtKey_Leave(object sender, EventArgs e)
        {
            string key = txtKey.Text;
            if (!int.TryParse(key, out int val))
            {
                MessageBox.Show("โปรดกรอก Key เฉพาะตัวเลข", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKey.Focus();
            }
            else if (key.ToCharArray().GroupBy(c => c).Select(c => c.Count()).Any(c => c > 1))
            {
                MessageBox.Show("โปรดกรอก Key ห้ามซ้ำกัน", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKey.Focus();
            }
        }

        private readonly char padChar = '_';

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            string plainText = txtPlainText.Text;
            if (string.IsNullOrEmpty(plainText))
            {
                MessageBox.Show("โปรดกรอก Plain text", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string key = txtKey.Text;
            string rmSpace = plainText.Replace(" ", "");
            if (rmSpace.Length % key.Length != 0)
                rmSpace = rmSpace.PadRight(rmSpace.Length + key.Length - (rmSpace.Length % key.Length), padChar);
            string result = String.Join("", key
                .Select((c, index) => new
                {
                    key = c,
                    text = String.Join("", rmSpace
                        .Where((_, i) => i % key.Length == index)
                        .Select(k => Convert.ToString(k)))
                })
                .OrderBy(c => c.key)
                .Select(c => c.text)
            );
            plainText.Select((s, i) => s == ' ' ? i : -1).Where(s => s != -1).ToList().ForEach(i =>
            {
                result = result.Insert(i, " ");
            });
            txtCipherText.Text = result;
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

            string key = txtKey.Text;
            string rmSpace = cipherText.Replace(" ", "");
            string[] metrix = key
                .Select((c, index) => new
                {
                    key = c,
                    text = String.Join("", rmSpace
                        .Skip((int.Parse(c.ToString()) - 1) * (rmSpace.Length / key.Length))
                        .Take(rmSpace.Length / key.Length))
                })
                .Select(c => c.text)
                .ToArray();

            string result = "";
            for (int i = 0; i < (int)Math.Ceiling((decimal)rmSpace.Length / key.Length); i++)
            {
                for (int j = 0; j < key.Length; j++)
                {
                    try { result += metrix[j][i]; }
                    catch (Exception) { }
                }
            }
            cipherText.Select((s, i) => s == ' ' ? i : -1).Where(s => s != -1).ToList().ForEach(i =>
            {
                result = result.Insert(i, " ");
            });
            txtPlainText1.Text = result.Replace(padChar.ToString(), "");
        }

        //Wrong Pattern
        //private void BtnEncrypt_Click(object sender, EventArgs e)
        //{
        //    string plainText = txtPlainText.Text;
        //    if (string.IsNullOrEmpty(plainText))
        //    {
        //        MessageBox.Show("โปรดกรอก Plain text", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    string key = txtKey.Text;
        //    string rmSpace = plainText.Replace(" ", "");
        //    string[][] metrix = key
        //        .Select((c, index) => rmSpace
        //            .Where((_, i) => i % key.Length == index)
        //            .Select(k => Convert.ToString(k))
        //            .ToArray()
        //        )
        //        .ToArray();

        //    string result = "";
        //    for (int i = 0; i < (int)Math.Ceiling((decimal)rmSpace.Length / (decimal)key.Length); i++)
        //    {
        //        for (int j = 0; j < key.Length; j++)
        //        {
        //            try { result += metrix[int.Parse(key[j].ToString()) - 1][i]; }
        //            catch (Exception) {}
        //        }
        //    }

        //    plainText.Select((s, i) => s == ' ' ? i : -1).Where(s => s != -1).ToList().ForEach(i => { 
        //        result = result.Insert(i, " ");
        //    });
        //    txtCipherText.Text = result;
        //}

        //private void BtnDecrypt_Click(object sender, EventArgs e)
        //{
        //    string cipherText = txtCipherText1.Text;
        //    if (string.IsNullOrEmpty(cipherText))
        //    {
        //        MessageBox.Show("โปรดกรอก Cipher text", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    string key = txtKey.Text;
        //    string rmSpace = cipherText.Replace(" ", "");
        //    string tkText = String.Join("", rmSpace.Take(rmSpace.Length / key.Length * key.Length));
        //    string[] metrix = key
        //        .Select((c, index) => new
        //        {
        //            text = tkText
        //                .Where((_, i) => i % key.Length == index)
        //                .Select(k => Convert.ToString(k))
        //                .ToArray(),
        //            key = c
        //        })
        //        .Select((c, i) => {
        //            string left = "";
        //            try { left = $"{rmSpace[tkText.Length + i]}"; }
        //            catch (Exception) { }
        //            return new { text = String.Join("", c.text) + left, c.key };
        //        })
        //        .OrderBy(c => c.key)
        //        .Select(c => c.text)
        //        .ToArray();

        //    string result = "";
        //    for (int i = 0; i < (int)Math.Ceiling((decimal)rmSpace.Length / (decimal)key.Length); i++)
        //    {
        //        for (int j = 0; j < key.Length; j++)
        //        {
        //            try { result += metrix[j][i]; }
        //            catch (Exception) { }
        //        }
        //    }

        //    cipherText.Select((s, i) => s == ' ' ? i : -1).Where(s => s != -1).ToList().ForEach(i =>
        //    {
        //        result = result.Insert(i, " ");
        //    });
        //    txtPlainText1.Text = result;
        //}
    }
}
