using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BLL
{
    public class CTPhieuSuaBLL
    {
        CuaHangBanXeMayDataContext db;
        public CTPhieuSuaBLL()
        {
            db = new CuaHangBanXeMayDataContext();
        }
        public List<eCTPhieuSua> LayDulieu() // Lấy dữ liệu từ csdl sang lớp entity
        {
            var cthdlist = db.CT_PhieuSuas.ToList();
            List<eCTPhieuSua> ls = new List<eCTPhieuSua>();
            foreach (CT_PhieuSua ctps in cthdlist)
            {
                eCTPhieuSua t = new eCTPhieuSua();
                t.MaCTPS = ctps.MaCTPS;
                t.MaPS = ctps.MaPhieuSua;
                t.MaLK = ctps.MaLK;
                t.TenLK = ctps.TenLK;
                t.GiaTien = double.Parse(ctps.GiaTien.ToString());
                t.SoLuong = int.Parse(ctps.SoLuong.ToString());
                t.ThanhTien = double.Parse(ctps.ThanhTien.ToString());
                ls.Add(t);
            }
            return ls;
        }

        public int ThemCTPS(eCTPhieuSua ctps) // Thêm ct hóa đơn mới
        {

            CT_PhieuSua temp = new CT_PhieuSua();
            temp.MaCTPS = ctps.MaCTPS;
            temp.MaPhieuSua = ctps.MaPS;
            temp.MaLK = ctps.MaLK;
            temp.TenLK = ctps.TenLK;
            temp.GiaTien = decimal.Parse(ctps.GiaTien.ToString());
            temp.SoLuong = ctps.SoLuong;
            temp.ThanhTien = decimal.Parse(ctps.ThanhTien.ToString());
            db.CT_PhieuSuas.InsertOnSubmit(temp);
            db.SubmitChanges();
            return 1;
        }
    }
}
