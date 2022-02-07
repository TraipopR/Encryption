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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void BtnSubstitition_Click(object sender, EventArgs e)
        {
            SubstitutionForm form = new SubstitutionForm();
            form.Show();
            form.FormToShowOnClosing = this;
            Hide();
        }

        private void BtnCaesar_Click(object sender, EventArgs e)
        {
            CaesarForm form = new CaesarForm();
            form.Show();
            form.FormToShowOnClosing = this;
            Hide();
        }

        private void BtnVigenere_Click(object sender, EventArgs e)
        {
            VigenereForm form = new VigenereForm();
            form.Show();
            form.FormToShowOnClosing = this;
            Hide();
        }

        private void BtnColumnarTransposition_Click(object sender, EventArgs e)
        {
            ColumnarTranspositionForm form = new ColumnarTranspositionForm();
            form.Show();
            form.FormToShowOnClosing = this;
            Hide();
        }

        private void BtnExclusiveOR_Click(object sender, EventArgs e)
        {
            ExclusiveORForm form = new ExclusiveORForm();
            form.Show();
            form.FormToShowOnClosing = this;
            Hide();
        }

        private void BtnVernam_Click(object sender, EventArgs e)
        {
            VernamForm form = new VernamForm();
            form.Show();
            form.FormToShowOnClosing = this;
            Hide();
        }
    }
}
