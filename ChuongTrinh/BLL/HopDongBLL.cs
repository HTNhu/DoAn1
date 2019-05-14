using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;
using System.Text.RegularExpressions;

namespace BLL
{

    public class HopDongBLL // Như 8/10/2018
    {

       
        CuaHangBanXeMayDataContext db;

        public HopDongBLL()
        {
            db = new CuaHangBanXeMayDataContext();
        }
        public List<eHopDong> LayDulieuHopDong() // Lấy dữ liệu từ csdl sang lớp entity
        {
            var hdlist = db.HopDongs.ToList();
            List<eHopDong> ls = new List<eHopDong>();
            foreach (HopDong hd in hdlist)
            {
             
                eHopDong t = new eHopDong();
                t.MaKH = hd.MaKH;
                t.TenKH = hd.TenKH;
                t.TenNV = hd.TenNV;
                t.DiaChi = hd.DiaChi;
                t.HanBH = DateTime.Parse(hd.HanBH.ToString());
                t.HinhThucTT = hd.HinhThucTT;
                t.MaHopDong = hd.MaHopDong;
                t.NgayLap = DateTime.Parse(hd.NgayLap.ToString());
                t.TenXe = hd.TenXe;
                if(hd.TinhTrang == "")
                {
                    hd.TinhTrang = "Đã hủy";
                }
                t.TinhTrang = hd.TinhTrang;
                t.Gia = double.Parse(hd.Gia.ToString());
                ls.Add(t);
            }
            return ls;
        }

        public List<eHopDong> LayDulieuTTHopDong() // Lấy dữ liêu hợp đông với tình trạng khác đã hủy
        {
            var hdlist = db.HopDongs.ToList();
            List<eHopDong> ls = new List<eHopDong>();
            foreach (HopDong hd in hdlist)
            {
                if (hd.TinhTrang == "")
                {
                    hd.TinhTrang = "Đã hủy";
                }
                if (hd.TinhTrang != "Đã hủy")
                {
                    eHopDong t = new eHopDong();
                    t.MaKH = hd.MaKH;
                    t.TenKH = hd.TenKH;
                    t.TenNV = hd.TenNV;
                    t.DiaChi = hd.DiaChi;
                    t.HanBH = DateTime.Parse(hd.HanBH.ToString());
                    t.HinhThucTT = hd.HinhThucTT;
                    t.MaHopDong = hd.MaHopDong;
                    t.NgayLap = DateTime.Parse(hd.NgayLap.ToString());
                    t.TenXe = hd.TenXe;
                    
                    t.TinhTrang = hd.TinhTrang;
                    t.Gia = double.Parse(hd.Gia.ToString());
                    ls.Add(t);
                }
            }
               
            return ls;
        }
        public int ThemHDong(eHopDong hdongmoi) // Thêm nhân viên mới
        {
            HopDong temp = new HopDong();
            temp.MaKH = hdongmoi.MaKH;
            temp.TenKH = hdongmoi.TenKH;
            temp.TenNV = hdongmoi.TenNV;
            temp.DiaChi = hdongmoi.DiaChi;
            temp.HanBH = DateTime.Parse(hdongmoi.HanBH.ToString());
            temp.HinhThucTT = hdongmoi.HinhThucTT;
            temp.MaHopDong = hdongmoi.MaHopDong;
            temp.NgayLap = DateTime.Parse(hdongmoi.NgayLap.ToString());
            temp.TenXe = hdongmoi.TenXe;
            temp.TinhTrang = hdongmoi.TinhTrang;
            temp.Gia = decimal.Parse(hdongmoi.Gia.ToString());
            db.HopDongs.InsertOnSubmit(temp);
            db.SubmitChanges();
            return 1;
        }
       
        public List<eHopDong> ThongKeTheoNgayLap(DateTime ngaylap) // Thong ke hop dong theo ngay thang nam
        {
            var lhdong = db.HopDongs.Where(s => s.NgayLap == ngaylap).ToList();

            List<eHopDong> lhd = new List<eHopDong>();
            foreach (HopDong hd in lhdong)
            {
                eHopDong t = new eHopDong();
                t.MaKH = hd.MaKH;
                t.TenKH = hd.TenKH;
                t.TenNV = hd.TenNV;
                t.DiaChi = hd.DiaChi;
                t.HanBH = DateTime.Parse(hd.HanBH.ToString());
                t.HinhThucTT = hd.HinhThucTT;
                t.MaHopDong = hd.MaHopDong;
                t.NgayLap = DateTime.Parse(hd.NgayLap.ToString());
                t.TenXe = hd.TenXe;
                t.TinhTrang = hd.TinhTrang;
                t.Gia = double.Parse(hd.Gia.ToString());
               
                lhd.Add(t);
            }
            return lhd;
        }
        public List<eHopDong> ThongKeTheoNV(string tennv) // Thong ke hop dong theo tên nv
        {
            var hdlist = (from s in db.HopDongs
                          where s.TenNV.Contains(tennv)
                          select s).ToList();
            List<eHopDong> lhdong = new List<eHopDong>();
            foreach (HopDong hd in hdlist)
            {
                eHopDong t = new eHopDong();
                t.MaKH = hd.MaKH;
                t.TenKH = hd.TenKH;
                t.TenNV = hd.TenNV;
                t.DiaChi = hd.DiaChi;
                t.HanBH = DateTime.Parse(hd.HanBH.ToString());
                t.HinhThucTT = hd.HinhThucTT;
                t.MaHopDong = hd.MaHopDong;
                t.NgayLap = DateTime.Parse(hd.NgayLap.ToString());
                t.TenXe = hd.TenXe;
                t.TinhTrang = hd.TinhTrang;
                
                lhdong.Add(t);
            }
            return lhdong;
        }
        #region
        public List<eHopDong> ThongKeTheoTenKH(string tenkh) // Thong ke hop dong theo tên khách hàng
        {
            var hdlist = (from s in db.HopDongs
                          where s.TenKH.Contains(tenkh)
                          select s).ToList();
            List<eHopDong> lhdong = new List<eHopDong>();
            foreach (HopDong hd in hdlist)
            {
                eHopDong t = new eHopDong();
                t.MaKH = hd.MaKH;
                t.TenKH = hd.TenKH;
                t.TenNV = hd.TenNV;
                t.DiaChi = hd.DiaChi;
                t.HanBH = DateTime.Parse(hd.HanBH.ToString());
                t.HinhThucTT = hd.HinhThucTT;
                t.MaHopDong = hd.MaHopDong;
                t.NgayLap = DateTime.Parse(hd.NgayLap.ToString());
                t.TenXe = hd.TenXe;
                t.TinhTrang = hd.TinhTrang;

                lhdong.Add(t);
            }
            return lhdong;
        }
        public List<eHopDong> ThongKeTheoTinhTrangHD(string tinhtrang) // Thong ke hop dong theo tình trạng hợp đồng
        {
            var hdlist = (from s in db.HopDongs
                          where s.TinhTrang.Contains(tinhtrang)
                          select s).ToList();
            List<eHopDong> lhdong = new List<eHopDong>();
            foreach (HopDong hd in hdlist)
            {
                eHopDong t = new eHopDong();
                t.MaKH = hd.MaKH;
                t.TenKH = hd.TenKH;
                t.TenNV = hd.TenNV;
                t.DiaChi = hd.DiaChi;
                t.HanBH = DateTime.Parse(hd.HanBH.ToString());
                t.HinhThucTT = hd.HinhThucTT;
                t.MaHopDong = hd.MaHopDong;
                t.NgayLap = DateTime.Parse(hd.NgayLap.ToString());
                t.TenXe = hd.TenXe;
                t.TinhTrang = hd.TinhTrang;

                lhdong.Add(t);
            }
            return lhdong;
        }
        #endregion
        public bool CapNhatTTHDong(string mahdong, string tt)// Cập nhật tình trạng hợp đồng
        {
            IQueryable<HopDong> hdong = db.HopDongs.Where(x => x.MaHopDong == mahdong);
            // cập nhật dữ liệu 1/10/2018
            if (hdong != null)
            {
                hdong.First().TinhTrang = tt;
                db.SubmitChanges();
                return true;
            }
            return false;

        }

        public eHopDong LayHopDongTheoMaHDong(string mahdong)// Lấy 1 hợp dòng theo mã hợp đồng
        {
            HopDong hd = db.HopDongs.Where(s => s.MaHopDong.Trim() == mahdong).FirstOrDefault();
            if (hd != null)
            {
                eHopDong t = new eHopDong();
                t.MaKH = hd.MaKH;
                t.TenKH = hd.TenKH;
                t.DiaChi = hd.DiaChi;
                t.HanBH = DateTime.Parse(hd.HanBH.ToString());
                t.HinhThucTT = hd.HinhThucTT;
                t.MaHopDong = hd.MaHopDong;
                t.NgayLap = DateTime.Parse(hd.NgayLap.ToString());
                t.TenXe = hd.TenXe;
                t.TinhTrang = hd.TinhTrang;
                t.Gia = double.Parse(hd.Gia.ToString());
                t.TenNV = hd.TenNV;
                return t;
            }
            else
                return null;
        }
        public List<eHopDong> TimKiemTheoMaHD(string maHD) //Tim kiem hop dong theo tt hợp đồng
        {
            var hdlist = db.HopDongs.Where(delegate (HopDong c)
            {
                if (ConvertToUnSign(c.MaHopDong + c.MaKH + c.TenKH + c.TenNV + c.DiaChi + c.HanBH + c.HinhThucTT + c.NgayLap + c.TenXe + c.TinhTrang + c.Gia).IndexOf(maHD, StringComparison.CurrentCultureIgnoreCase) >= 0)
                    return true;
                else
                    return false;
            }).AsQueryable();
            List<eHopDong> lhdong = new List<eHopDong>();
            foreach (HopDong hd in hdlist)
            {
                eHopDong t = new eHopDong();
                t.MaKH = hd.MaKH;
                t.TenKH = hd.TenKH;
                t.TenNV = hd.TenNV;
                t.DiaChi = hd.DiaChi;
                t.HanBH = DateTime.Parse(hd.HanBH.ToString());
                t.HinhThucTT = hd.HinhThucTT;
                t.MaHopDong = hd.MaHopDong;
                t.NgayLap = DateTime.Parse(hd.NgayLap.ToString());
                t.TenXe = hd.TenXe;
                t.TinhTrang = hd.TinhTrang;
                t.Gia = double.Parse(hd.Gia.ToString());

                lhdong.Add(t);
            }
            return lhdong;
        }
        #region
        public List<eHopDong> ThongKeTheoTatCa(DateTime ngaylap,string tennv, string tenkh,string tinhtrang) // Thong ke hop dong theo tat ca
        {
           
            var hdlist = (from s in db.HopDongs
                          where s.NgayLap == ngaylap && s.TenNV.Contains(tennv)
                          && s.TenKH.Contains(tenkh)
                          && s.TinhTrang.Contains(tinhtrang)
                          select s).ToList();

            List<eHopDong> lhd = new List<eHopDong>();
            foreach (HopDong hd in hdlist)
            {
                eHopDong t = new eHopDong();
                t.MaKH = hd.MaKH;
                t.TenKH = hd.TenKH;
                t.TenNV = hd.TenNV;
                t.DiaChi = hd.DiaChi;
                t.HanBH = DateTime.Parse(hd.HanBH.ToString());
                t.HinhThucTT = hd.HinhThucTT;
                t.MaHopDong = hd.MaHopDong;
                t.NgayLap = DateTime.Parse(hd.NgayLap.ToString());
                t.TenXe = hd.TenXe;
                t.TinhTrang = hd.TinhTrang;
                t.Gia = double.Parse(hd.Gia.ToString());

                lhd.Add(t);
            }
            return lhd;
        }
        #endregion
        public List<TK_NVTheoNgayResult>TK_NVTheoNgay(DateTime ngaylap,DateTime ngaykt)
        {
          return  db.TK_NVTheoNgay(ngaylap,ngaykt).ToList();
        }
        public List<TK_TTTheoNgayResult> TK_TTTheoNgay(DateTime ngaylap, DateTime ngaykt)
        {
            return db.TK_TTTheoNgay(ngaylap, ngaykt).ToList();
        }
        public List<TK_TTHopDongResult> TK_TTHopDong()
        {
            return db.TK_TTHopDong().ToList();
        }
        public List<TK_NVBanxeResult> TK_NVBanXe()
        {
            return db.TK_NVBanxe().ToList();
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
    }

}
