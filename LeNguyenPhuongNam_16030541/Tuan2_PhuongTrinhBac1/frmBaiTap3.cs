using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan2_PhuongTrinhBac1
{
	public partial class frmBaiTap3 : Form
	{
		public frmBaiTap3()
		{
			InitializeComponent();
		}

		private void txtNhapA_TextChanged(object sender, EventArgs e)
		{
			Control ctr = (Control)sender;
			if (ctr.Text.Length > 0 && !char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
			{
				this.errorProvider1.SetError(ctr, "ban phai nhap vao so");
			}
			else if (ctr.Text.Length > 0 && char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
			{
				btnTinh.Enabled = true;
			}
			else
			{
				this.errorProvider1.Clear();
			}

		}

		private void txtNhapB_TextChanged(object sender, EventArgs e)
		{
			Control ctr = (Control)sender;
			if (ctr.Text.Length > 0 && !char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
			{
				this.errorProvider1.SetError(ctr, "ban phai nhap vao so");
			}
			else
			{
				this.errorProvider1.Clear();
			}
		}

		private void frmBaiTap3_Load(object sender, EventArgs e)
		{
			btnTinh.Enabled = false;
			btnXoa.Enabled = false;
		}

		private void btnTinh_Click(object sender, EventArgs e)
		{
			float nghiemPT;
			float a = Convert.ToInt32(txtNhapA.Text); // chuyen a thah so
			float b = Convert.ToInt32(txtNhapB.Text); // chuyen b thanh so
			if (a == 0)
			{
				if (b == 0)
					lblNghiemPT.Text = "Phuong trinh vo so nghiem";
				else
					lblNghiemPT.Text = "Phuong trinh vo nghiem";
			}
			else
			{
				nghiemPT = -b / a;
				lblNghiemPT.Text = "Nghiem cua phuong trinh la : " + nghiemPT.ToString();
			}
		}
	}
}
