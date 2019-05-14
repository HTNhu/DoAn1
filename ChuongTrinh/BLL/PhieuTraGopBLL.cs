using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class PhieuTraGopBLL  //Như 10/10/2018
    {
        CuaHangBanXeMayDataContext db;
        public PhieuTraGopBLL()
        {
            db = new CuaHangBanXeMayDataContext();
        }
        public List<ePhieuTraGop> LayDuLieu()
        {
            var tglist = db.PhieuTraGops.ToList();
            List<ePhieuTraGop> ls = new List<ePhieuTraGop>();
            foreach (PhieuTraGop tg in tglist)
            {
                ePhieuTraGop t = new ePhieuTraGop();
                t.MaHopDong = tg.MaHopDong;
                t.MaNV = tg.MaNV;
                t.TenNgTra = tg.TenNguoiTra;
                t.TenNV = tg.NhanVienNhan;
                t.SoTien = double.Parse(tg.SoTienTG.ToString());
                t.NgayTra = DateTime.Parse(tg.NgayTra.ToString());
                t.LanTra = tg.LanTra;
                ls.Add(t);
            }
            return ls;
        }
        public int ThemPhieuTG(ePhieuTraGop tg) // Thêm nhân viên mới
        {

            PhieuTraGop t = new PhieuTraGop();
            t.MaHopDong = tg.MaHopDong;
            t.MaNV = tg.MaNV;
            t.TenNguoiTra = tg.TenNgTra;
            t.NhanVienNhan = tg.TenNV;
            t.SoTienTG = decimal.Parse(tg.SoTien.ToString());
            t.NgayTra = DateTime.Parse(tg.NgayTra.ToString());
            t.LanTra = tg.LanTra;
            db.PhieuTraGops.InsertOnSubmit(t);
            db.SubmitChanges();
            return 1;
        }
    }

}
