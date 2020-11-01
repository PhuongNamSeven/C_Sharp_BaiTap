using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan1_NameBirth
{
    public partial class frmBaiTap1 : Form
    {
        public frmBaiTap1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtYourName.Clear();
            txtYearOfBirth.Clear();
        }

        private void frmBaiTap1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult hienthi = MessageBox.Show("Ban muon dong form phai khong ???","Ex1",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (hienthi == DialogResult.No)
                e.Cancel = true;
        }

        private void txtYourName_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "ban phai nhap ten cua minh");
            else
                this.errorProvider1.Clear();
        }

        private void txtYearOfBirth_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
                this.errorProvider1.SetError(ctr, "ban phai nhap so vao !!!");
            else
                this.errorProvider1.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int age;
            string s;
            s = "Ten cua ban la : " + txtYourName.Text + "\n";
            age = DateTime.Now.Year - Convert.ToInt32(txtYearOfBirth.Text);
            s = s + "Tuoi ban la : " + age.ToString();
            MessageBox.Show(s);
        }
    }
}
