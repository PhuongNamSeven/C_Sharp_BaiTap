using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan2_NamAmLich
{
	public partial class frmBaiTap4 : Form
	{
		public frmBaiTap4()
		{
			InitializeComponent();
		}

		private void btnAmLich_Click(object sender, EventArgs e)
		{
			float year =  Convert.ToInt32(txtDuongLich.Text); // chuyen nam duong lich thanh so
			string can = "";
			string chi = "";
			switch (year % 10)
			{
                case 0:
                    can = "Canh";
                    break;
                case 1:
                    can = "Tân";
                    break;
                case 2:
                    can = "Nhâm";
                    break;
                case 3:
                    can = "Quý";
                    break;
                case 4:
                    can = "Giáp";
                    break;
                case 5:
                    can = "Ất";
                    break;
                case 6:
                    can = "Bính";
                    break;
                case 7:
                    can = "Đinh";
                    break;
                case 8:
                    can = "Mậu";
                    break;
                case 9:
                    can = "Kỷ";
                    break;
            }
            switch (year % 12)
            {
                case 0:
                    chi = "Thân";
                    break;
                case 1:
                    chi = "Dậu";
                    break;
                case 2:
                    chi = "Tuất";
                    break;
                case 3:
                    chi = "Hợi";
                    break;
                case 4:
                    chi = "Tý";
                    break;
                case 5:
                    chi = "Sửu";
                    break;
                case 6:
                    chi = "Dần";
                    break;
                case 7:
                    chi = "Mẹo";
                    break;
                case 8:
                    chi = "Thìn";
                    break;
                case 9:
                    chi = "Tỵ";
                    break;
                case 10:
                    chi = "Ngọ";
                    break;
                case 11:
                    chi = "Mùi";
                    break;
            }
            lblNamAmLich.Text = can + chi;
		}
	}
}
