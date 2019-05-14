using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    /*Thành Kỷ
        thêm phiếu sửa
         */
    public class PhieuSuaBHBLL
    {
        CuaHangBanXeMayDataContext db;
        
        public PhieuSuaBHBLL()
        {
            db = new CuaHangBanXeMayDataContext();

        }
        public List<ePhieuSuaBaoHanh> LayDuLieu()
        {
            var tglist = db.PhieuSuaBHs.ToList();
            List<ePhieuSuaBaoHanh> ls = new List<ePhieuSuaBaoHanh>();
            foreach (PhieuSuaBH tg in tglist)
            {
                ePhieuSuaBaoHanh t = new ePhieuSuaBaoHanh();
                t.MaPS = tg.MaPhieuSua;
                t.MaHDong = tg.MaHopDong;
                t.MaNV = tg.MaNV;
                t.TenNV = tg.TenNV;
                t.NgayLap = DateTime.Parse(tg.NgayLap.ToString());
                t.TongTien = double.Parse(tg.TongTien.ToString());
                t.LoiDoKhachHaySP = bool.Parse(tg.LoiDoKhachHaySP.ToString());
                ls.Add(t);
            }
            return ls;
        }
        public int ThemPhieuBH(ePhieuSuaBaoHanh tg) // Thêm nhân viên mới
        {
            PhieuSuaBH t = new PhieuSuaBH();
            t.MaPhieuSua = tg.MaPS;
            t.MaHopDong = tg.MaHDong;
            t.MaNV = tg.MaNV;
            t.TenNV = tg.TenNV;
            t.NgayLap = DateTime.Parse(tg.NgayLap.ToString());
            t.TongTien = decimal.Parse(tg.TongTien.ToString());
            t.LoiDoKhachHaySP = bool.Parse(tg.LoiDoKhachHaySP.ToString());
            db.PhieuSuaBHs.InsertOnSubmit(t);
            db.SubmitChanges();
            return 1;
        }

    }
}
