using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;
using System.Text.RegularExpressions;

namespace BLL
{
    public class XeBLL //Kỷ 1/10/2018
    {
        CuaHangBanXeMayDataContext db;
        public XeBLL()
        {
            db = new CuaHangBanXeMayDataContext();
        }
        public List<eXe> LayDulieu() // Lấy dữ liệu từ csdl sang lớp entity
        {
            var xelist = db.Xes.ToList();
            List<eXe> lx = new List<eXe>();
            foreach (Xe x in xelist)
            {
                eXe t = new eXe();
                t.MaXe = x.MaXe;
                t.LoaiXe = x.LoaiXe;
                t.MauXe = x.MauXe;
                t.NuocSX = x.NuocSX;
                t.GiaXe = double.Parse(x.GiaXe.ToString());
                t.SoKhung = x.SoKhung;
                t.SoPK = x.SoPK;
                t.SoSuon = x.SoSuon;
                t.TenXe = x.TenXe;
                t.TinhTrang = bool.Parse(x.TinhTrang.ToString());
                lx.Add(t);
            }
            return lx;
        }
      
       
        public int ThemXe(eXe xemoi) // Thêm nhân viên mới
        {
           
            Xe xetemp = new Xe();
            xetemp.MaXe = xemoi.MaXe;
            xetemp.LoaiXe = xemoi.LoaiXe;
            xetemp.MauXe = xemoi.MauXe;
            xetemp.NuocSX = xemoi.NuocSX;
            xetemp.GiaXe = decimal.Parse(xemoi.GiaXe.ToString());
            xetemp.SoKhung = xemoi.SoKhung;
            xetemp.SoPK = xemoi.SoPK;
            xetemp.SoSuon = xemoi.SoSuon;
            xetemp.TenXe = xemoi.TenXe;
            xetemp.TinhTrang = xemoi.TinhTrang;
            db.Xes.InsertOnSubmit(xetemp);
            db.SubmitChanges();
            return 1;
        }

        public void CapNhatXe(string maxe, string ten, string loaixe, string mauxe, string nuocsx, double giaxe, string sokhung, string sopk, string sosuon)
        {
            IQueryable<Xe> xe = db.Xes.Where(x => x.MaXe == maxe);
            // cập nhật dữ liệu 1/10/2018
            xe.First().MaXe = maxe;
            xe.First().LoaiXe = loaixe;
            xe.First().MauXe = mauxe;
            xe.First().NuocSX = nuocsx;
            xe.First().GiaXe = decimal.Parse(giaxe.ToString());
            xe.First().SoKhung = sokhung;
            xe.First().SoPK = sopk;
            xe.First().SoSuon = sosuon;
            xe.First().TenXe = ten;
            db.SubmitChanges();

        }
        public void CapNhatTTXe(string maxe, bool tt)
        {
            IQueryable<Xe> xe = db.Xes.Where(x => x.MaXe.Trim() == maxe.Trim());
            // cập nhật dữ liệu 1/10/2018
           // xe.First().MaXe = maxe;
            xe.First().TinhTrang = tt;
            db.SubmitChanges();
        }

       
        public List<eXe> TimKiemXeTheoMa(string ma)// tìm kiếm xe theo mã xe
        {
            var XeList = db.Xes.Where(delegate (Xe c)
            {
                if (ConvertToUnSign(c.MaXe + c.LoaiXe + c.MauXe + c.NuocSX + c.GiaXe + c.SoKhung + c.SoPK + c.SoSuon + c.TenXe).IndexOf(ma, StringComparison.CurrentCultureIgnoreCase) >= 0)
                    return true;
                else
                    return false;
            }).AsQueryable();
            List<eXe> lx = new List<eXe>();
            foreach (Xe x in XeList)
            {
                eXe t = new eXe();
                t.MaXe = x.MaXe;
                t.LoaiXe = x.LoaiXe;
                t.MauXe = x.MauXe;
                t.NuocSX = x.NuocSX;
                t.GiaXe = double.Parse(x.GiaXe.ToString());
                t.SoKhung = x.SoKhung;
                t.SoPK = x.SoPK;
                t.SoSuon = x.SoSuon;
                t.TenXe = x.TenXe;
                t.TinhTrang = bool.Parse(x.TinhTrang.ToString());
                lx.Add(t);
            }

            return lx;
        }
        public List<eXe> TimKiemXeTheoMaTTrang(string ma, bool tt)// Tìm Kiếm xe theo tình trạng 
        {
            var XeList = (from s in db.Xes
                          where s.MaXe.Contains(ma) && s.TinhTrang == true
                          select s).ToList();
            List<eXe> lx = new List<eXe>();
            foreach (Xe x in XeList)
            {
                eXe t = new eXe();
                t.MaXe = x.MaXe;
                t.LoaiXe = x.LoaiXe;
                t.MauXe = x.MauXe;
                t.NuocSX = x.NuocSX;
                t.GiaXe = double.Parse(x.GiaXe.ToString());
                t.SoKhung = x.SoKhung;
                t.SoPK = x.SoPK;
                t.SoSuon = x.SoSuon;
                t.TenXe = x.TenXe;
                t.TinhTrang = bool.Parse(x.TinhTrang.ToString());
                lx.Add(t);
            }

            return lx;
        }
        public eXe LayXeTheoMa(string ma) // Lấy dữ liệu của xe theo mã xe
        {
            Xe x = db.Xes.Where(s => s.MaXe.Trim() == ma.Trim()).FirstOrDefault();
            if (x != null)
            {
                eXe t = new eXe();
                t.MaXe = x.MaXe.Trim();
                t.LoaiXe = x.LoaiXe;
                t.MauXe = x.MauXe;
                t.NuocSX = x.NuocSX;
                t.GiaXe = double.Parse(x.GiaXe.ToString());
                t.SoKhung = x.SoKhung;
                t.SoPK = x.SoPK;
                t.SoSuon = x.SoSuon;
                t.TenXe = x.TenXe;
                t.TinhTrang = bool.Parse(x.TinhTrang.ToString());
                return t;
            }
            else
                return null;
        }
        private string ConvertToUnSign(string input)
        {
            input = input.Trim();
            for (int i = 0x20; i < 0x30; i++)
            {
                input = input.Replace(((char)i).ToString(), " ");
            }
            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
            string str = input.Normalize(NormalizationForm.FormD);
            string str2 = regex.Replace(str, string.Empty).Replace('đ', 'd').Replace('Đ', 'D');
            while (str2.IndexOf("?") >= 0)
            {
                str2 = str2.Remove(str2.IndexOf("?"), 1);
            }
            return str2;
        }
        public List<eXe> LayTTXeTheoTenMauXe(string ten, string mau, bool tt)
        {
            var XeList = (from s in db.Xes
                          where s.TenXe.ToUpper().Trim() == ten.Trim().ToUpper()
                                   && s.MauXe.ToUpper().Trim() == mau.ToUpper().Trim()
                                   && s.TinhTrang == tt
                          select s).ToList();
            List<eXe> lx = new List<eXe>();
            foreach (Xe x in XeList)
            {
                eXe t = new eXe();
                t.MaXe = x.MaXe;
                t.LoaiXe = x.LoaiXe;
                t.MauXe = x.MauXe;
                t.NuocSX = x.NuocSX;
                t.GiaXe = double.Parse(x.GiaXe.ToString());
                t.SoKhung = x.SoKhung;
                t.SoPK = x.SoPK;
                t.SoSuon = x.SoSuon;
                t.TenXe = x.TenXe;
                t.TinhTrang = bool.Parse(x.TinhTrang.ToString());
                lx.Add(t);
            }

            return lx;
        }
        public List<eXe> LayTTXeTheoTen(string tenxe,bool tt)// tìm kiếm xe theo tên xe tình trạng true
        {
            var XeList = (from s in db.Xes
                          where s.TenXe.ToUpper().Contains(tenxe.ToUpper()) && s.TinhTrang == tt
                          select s).ToList();

            List<eXe> lx = new List<eXe>();
            foreach (Xe x in XeList)
            {
                eXe t = new eXe();
                t.MaXe = x.MaXe;
                t.LoaiXe = x.LoaiXe;
                t.MauXe = x.MauXe;
                t.NuocSX = x.NuocSX;
                t.GiaXe = double.Parse(x.GiaXe.ToString());
                t.SoKhung = x.SoKhung;
                t.SoPK = x.SoPK;
                t.SoSuon = x.SoSuon;
                t.TenXe = x.TenXe;
                t.TinhTrang = bool.Parse(x.TinhTrang.ToString());
                lx.Add(t);
            }

            return lx;
        }
    }


}
