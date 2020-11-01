using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan4_XemPhim
{
    public partial class frmXemPhim : Form
    {
        int BTN_A = 100;
        int BTN_B = 200;
        public frmXemPhim()
        {
            InitializeComponent();
        }

        private void frmXemPhim_Load(object sender, EventArgs e)
        {
            TaoBangButton(20);
        }

        public void TaoBangButton(int n)
        {
            Button btn;
            for(int i=1;i<=n;i++)
            {
                btn = new Button();
                btn.Text = i.ToString();
                btn.Width = 60;
                btn.Height = 60;
                btn.BackColor = Color.White;
                btn.Click += new EventHandler(btnClickShow);
                flowLayoutPanel1.Controls.Add(btn);
            }
        }
        public void btnClickShow(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int tongtien = 0;
            if(btn.Enabled==true)
            {
                if(btn.BackColor != Color.DeepSkyBlue)
                {
                    btn.BackColor = Color.DeepSkyBlue;
                }
                else
                {
                    btn.BackColor = Color.White;
                }
                tongtien = TinhTien();
                lblTinhTien.Text = tongtien.ToString("#.##0");
            }
        }
        int TinhTien()
        {
            int giatien =0;
            foreach(Button btn in flowLayoutPanel1.Controls)
            {
                if(btn.BackColor == Color.DeepSkyBlue)
                {
                    int soButton = Convert.ToInt32(btn.Text);
                    if(soButton <10)
                    {
                        giatien += BTN_A;
                    }
                    else if( soButton < 20)
                    {
                        giatien += BTN_B;
                    }
                }
            }
            return giatien;
        }
        int TongTien()
        {
            int giatien = 0;
            foreach (Button btn in flowLayoutPanel1.Controls)
            {
                if (btn.BackColor == Color.Red)
                {
                    int soButton = Convert.ToInt32(btn.Text);
                    if (soButton < 10)
                    {
                        giatien += BTN_A;
                    }
                    else if (soButton < 20)
                    {
                        giatien += BTN_B;
                    }
                }
            }
            return giatien;
        }
        private void btnChon_Click(object sender, EventArgs e)
        {
            foreach(Button btn in flowLayoutPanel1.Controls)
            {
                if(btn.BackColor == Color.DeepSkyBlue)
                {
                    btn.Enabled = false;
                    btn.BackColor = Color.Red;
                }
            }
            lblTongTien.Text = TongTien().ToString("#,##0");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            foreach(Button btn in flowLayoutPanel1.Controls)
            {
                if(btn.BackColor == Color.DeepSkyBlue)
                {
                    btn.BackColor = Color.White;
                }
            }
            lblTinhTien.Text = "";
        }
    }
}
