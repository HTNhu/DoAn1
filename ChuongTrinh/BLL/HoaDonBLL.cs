using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BLL
{
    
    public class HoaDonBLL //Kỷ 7/10/2018
    {
        CuaHangBanXeMayDataContext db;
        public HoaDonBLL()
        {
            db = new CuaHangBanXeMayDataContext();
        }
        public List<eHoaDon> LayDuLieu()
        {
            var hdlist = db.HoaDons.ToList();
            List<eHoaDon> ls = new List<eHoaDon>();
            foreach (HoaDon hd in hdlist)
            {
                eHoaDon t = new eHoaDon();
                t.MaHoaDon = hd.MaHoaDon;
                t.MaKH = hd.MaKH;
                t.MaNV = hd.MaNV;
                t.NgayLap = DateTime.Parse(hd.NgayLap.ToString());
                t.TenKH = hd.TenKH;
                t.TenNV = hd.TenNV;
                t.KhuyenMai =float.Parse(hd.KhuyenMai.ToString());
               
                t.TienThanhToan = double.Parse(hd.TienThanhToan.ToString());
                t.TongTien = double.Parse(hd.TongTien.ToString());
                ls.Add(t);
            }
            return ls;
        }
        public int ThemHoaDon(eHoaDon hd) // Thêm hóa đơn mới
        {

            HoaDon t = new HoaDon();
            t.MaHoaDon = hd.MaHoaDon;
            t.MaKH = hd.MaKH;
            t.MaNV = hd.MaNV;
            t.NgayLap = DateTime.Parse(hd.NgayLap.ToString());
            t.TenKH = hd.TenKH;
            t.TenNV = hd.TenNV;
            t.KhuyenMai = float.Parse(hd.KhuyenMai.ToString());
            t.SdtKH = hd.SoDT;
            t.TienThanhToan = decimal.Parse(hd.TienThanhToan.ToString());
            t.TongTien = decimal.Parse(hd.TongTien.ToString());
            db.HoaDons.InsertOnSubmit(t);
            db.SubmitChanges();
            return 1;
        }
    }
}
