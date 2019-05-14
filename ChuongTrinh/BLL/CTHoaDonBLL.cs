using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BLL
{
    public class CTHoaDonBLL // Kỷ 8/10/2018
    {
        CuaHangBanXeMayDataContext db;
        public CTHoaDonBLL()
        {
            db = new CuaHangBanXeMayDataContext();
        }
        public List<eCTHoaDon> LayDulieu() // Lấy dữ liệu từ csdl sang lớp entity
        {
            var cthdlist = db.CT_HoaDons.ToList();
            List<eCTHoaDon> ls = new List<eCTHoaDon>();
            foreach (CT_HoaDon cthd in cthdlist)
            {
                eCTHoaDon t = new eCTHoaDon();
                t.MaHoaDon = cthd.MaHoaDon;
                t.MaHopDong = cthd.MaHopDong;
                t.MaXe= cthd.MaXe;
                t.TenXe = cthd.TenXe;
                t.TienTT = double.Parse(cthd.TienTT.ToString());
                t.Gia = double.Parse(cthd.Gia.ToString());
                ls.Add(t);
            }
            return ls;
        }
       
        public int ThemCTHD(eCTHoaDon cthd) // Thêm ct hóa đơn mới
        {
            
            CT_HoaDon temp = new CT_HoaDon();
            temp.MaHoaDon = cthd.MaHoaDon;
            temp.MaHopDong = cthd.MaHopDong;
            temp.MaXe = cthd.MaXe;
            temp.TenXe = cthd.TenXe;
            temp.TienTT = decimal.Parse(cthd.TienTT.ToString());
            temp.Gia = decimal.Parse(cthd.Gia.ToString());
            db.CT_HoaDons.InsertOnSubmit(temp);
            db.SubmitChanges();
            return 1;
        }
    }
}
