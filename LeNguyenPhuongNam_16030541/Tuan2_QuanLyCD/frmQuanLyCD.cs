using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan2_QuanLyCD
{
    public partial class frmQuanLyCD : Form
    {
        public frmQuanLyCD()
        {
            InitializeComponent();
            chkDungHan.Checked = true;
            for(int i=0;i<100;i++)
            {
                cboSoLuong.Items.Add(i);
            }
            cboSoLuong.SelectedIndex = 10;
        }

        private void frmQuanLyCD_Load(object sender, EventArgs e)
        {
            TaoListView(lvwDanhSach);
        }
        void TaoListView(ListView listview)
        {
            listview.GridLines = true;
            listview.FullRowSelect = true;
            listview.View = View.Details;
            listview.Columns.Add("Mã", 100);
            listview.Columns.Add("Tên", 150);
            listview.Columns.Add("Số lượng", 100);
            listview.Columns.Add("Đơn giá", 100);
            listview.Columns.Add("Giảm giá", 100);
            listview.Columns.Add("Thành tiền", 100);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTinhThue_Click(object sender, EventArgs e)
        {
            int soluong,dongia;
            double tradunghan,tinhtien;
            double trehan;
            double thanhtien;
            ListViewItem lvItem = new ListViewItem(txtMaKhachHang.Text); // khai bao listview
            lvItem.SubItems.Add(txtHoTenKhachHang.Text);
            soluong = Convert.ToInt32(cboSoLuong.SelectedIndex.ToString());
            dongia = Convert.ToInt32(txtDonGia.Text);
            lvItem.SubItems.Add(soluong.ToString());
            lvItem.SubItems.Add(dongia.ToString());
            if(chkDungHan.Checked== true)
            {
                tradunghan = ((soluong * dongia) - ((soluong * dongia) * 0.03));
                tinhtien = ((soluong * dongia) - tradunghan);
                lvItem.SubItems.Add(tinhtien.ToString("#,####0.0 VND"));
                lvItem.SubItems.Add(tradunghan.ToString());
            }
            else
            {
                trehan = ((soluong * dongia) * 0.05);
                thanhtien = ((soluong * dongia) + trehan);
                lvItem.SubItems.Add(trehan.ToString("#,####0.0 VND"));
                lvItem.SubItems.Add(thanhtien.ToString());
            }
            lvwDanhSach.Items.Add(lvItem);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lvwDanhSach.SelectedItems.Count>0)
            {
                DialogResult thongbao = MessageBox.Show("Bạn muốn xóa phải không ?", "Câu hỏi", MessageBoxButtons.YesNo);
                lvwDanhSach.SelectedItems[0].Remove();
            }
        }

        private void frmQuanLyCD_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult thongbao = MessageBox.Show("Ban muốn đóng form ?", "thông báo", MessageBoxButtons.YesNo);
            if(DialogResult.No == thongbao)
            {
                e.Cancel = true;
            }
        }

        private void btnTongTien_Click(object sender, EventArgs e)
        {
            double tong=0;
            // mong doi : tat ca trong listview + 
            // foreahc duyet toan bo tung phan tu trong tap
            foreach(ListViewItem item in lvwDanhSach.Items)
            {
                tong += Convert.ToInt32(item.SubItems[5].ToString());
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar<48 || e.KeyChar>57 && e.KeyChar==8)
            {
                e.Handled = true;
            }
        }
    }
}
