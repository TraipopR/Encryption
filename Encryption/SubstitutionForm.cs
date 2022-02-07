using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption
{
    public partial class SubstitutionForm : Form
    {
        public SubstitutionForm()
        {
            InitializeComponent();
        }

        public MenuForm FormToShowOnClosing { get; internal set; }
        private readonly Dictionary<string, string> A2Z = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        private void SubstitutionForm_FormClosing(object sender, FormClosingEventArgs e)
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

            txtCipherText.Text = String.Join("", plainText.ToCharArray().Select(c =>
            {
                if (A2Z.TryGetValue(Convert.ToString(c), out var val))
                    return val;
                return Convert.ToString(c);
            }));
            txtCipherText1.Text = txtCipherText.Text;
        }

        private void Dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            string value = dataGridView.CurrentCell.Value?.ToString() ?? "";
            string key = dataGridView.Columns[e.ColumnIndex].HeaderText;
            if (A2Z.Any(val => val.Value == value && val.Key != key) && value != "")
            {
                MessageBox.Show($"{value} ซ้ำ", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvA2M.CurrentCell.Value = "";
                return;
            }
            A2Z[key] = value;
            dataGridView.ClearSelection();
        }

        private void SubstitutionForm_Load(object sender, EventArgs e)
        {
            dgvA2M.Rows.Add();
            dgvA2M.ClearSelection();
            dgvN2Z.Rows.Add();
            dgvN2Z.ClearSelection();
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            string cipherText = txtCipherText1.Text;
            if (string.IsNullOrEmpty(cipherText))
            {
                MessageBox.Show("โปรดกรอก Chipher text", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtPlainText1.Text = String.Join("", cipherText.ToCharArray().Select(c =>
            {
                return A2Z.FirstOrDefault(v => v.Value == Convert.ToString(c)).Key ?? Convert.ToString(c);
            }));

        }
    }
}
