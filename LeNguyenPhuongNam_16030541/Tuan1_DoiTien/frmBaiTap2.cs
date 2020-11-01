using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan1_DoiTien
{
    public partial class frmBaiTap2 : Form
    {
        public frmBaiTap2()
        {
            InitializeComponent();
        }
        // chuyen VND sang USD
        private void btnVNDtoUSD_Click(object sender, EventArgs e)
        {
            float USD = 17861;
            float ketqua;
            ketqua = float.Parse(txtTienQuyDoi.Text) / USD;
            txtKetQua.Text = Math.Round(ketqua,2).ToString();
        }
        // chuyen USD sang VND
        private void btnUSDtoVND_Click(object sender, EventArgs e)
        {
            float USD = 17861;
            float ketqua;
            ketqua = float.Parse(txtTienQuyDoi.Text) * USD;
            txtKetQua.Text = Math.Round(ketqua, 2).ToString();
        }
        // chuyen VND sang EUR
        private void btnVNDtoEUR_Click(object sender, EventArgs e)
        {
            float EUR = 27043;
            float ketqua;
            ketqua = float.Parse(txtTienQuyDoi.Text) / EUR;
            txtKetQua.Text = Math.Round(ketqua, 2).ToString();
        }
        // chuyen EUR sang VND
        private void btnEURtoVND_Click(object sender, EventArgs e)
        {
            float EUR = 27043;
            float ketqua;
            ketqua = float.Parse(txtTienQuyDoi.Text) * EUR;
            txtKetQua.Text = Math.Round(ketqua, 2).ToString();
        }
    }
}
