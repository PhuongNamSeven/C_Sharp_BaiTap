using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Tuan3_QLCDObject
{
    public class DanhSachKhachThue
    {
        ArrayList ds;
        public DanhSachKhachThue()
        {
            ds = new ArrayList();
        }
        public bool ThemKhachThue(KhachThue khachthue)
        {
            if(ds.Contains(khachthue))
            {
                return false;
            }
            else
            {
                ds.Add(khachthue);
                return true;
            }
        }
        // mong doi : xoa , tim
        public KhachThue TimKhachThue(int maKhach)
        {
            foreach(KhachThue item in ds)
            {
                if(item.MaKhachHang == maKhach)
                {
                    return item;
                }
            }
            return null;
        }
        public bool XoaKhachThue(KhachThue khachthue)
        {

            if (khachthue != null)//tim thay
            {
                ds.Remove(khachthue);
                return true;
            }
            else
                return false;
        }
        public void SuaKhachThue(KhachThue khachthue)
        {
            int vitritim = ds.IndexOf(khachthue);
            if(vitritim >0)
            {
                ds[vitritim] = khachthue;
            }
        }
        public ArrayList GetAllDanhSach()
        {
            return ds;
        }
    }
}
