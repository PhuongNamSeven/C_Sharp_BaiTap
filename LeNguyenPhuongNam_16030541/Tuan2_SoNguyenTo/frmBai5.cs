using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan2_SoNguyenTo
{
	public partial class frmBai5 : Form
	{
		public frmBai5()
		{
			InitializeComponent();
		}

		private void btnKiemTraSNT_Click(object sender, EventArgs e)
		{
			float songuyen = Convert.ToInt32(txtSoNguyen.Text); // chuyen so nguyen thanh so
			int bien_dem = 0;
			for (int i = 1; i <= songuyen; i++)
				if (songuyen % i == 0)
					bien_dem++;

			if (bien_dem == 2)
				lblKiemTra.Text = "Số Nguyên tố";
			else
				lblKiemTra.Text = "Không là số nguyên tố";

		}
	}
}
