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
    
   public  class KhachHangBLL // Kỷ 1/10/2018
    {
        CuaHangBanXeMayDataContext db;
   
    public KhachHangBLL()
    {
        db = new CuaHangBanXeMayDataContext();
    }
        public string PhatSinhMa()
        {
            int so = db.KhachHangs.Count<KhachHang>();
            int stt = 0;
            if (so == 0)
            {
                stt = 1;
            }
            else
            {
                stt = so + 1;
            }
            string ma;
            if (stt < 10)
                ma = "KH00" + stt.ToString();
            else if (stt < 100)
                ma = "KH0" + stt.ToString();
            else
                ma = "KH" + stt.ToString();
            return ma;
        }
        public List<eKhachHang> LayDulieu() // Lấy dữ liệu từ csdl sang lớp entity
        {
            var khlist = db.KhachHangs.ToList();
            List<eKhachHang> ls = new List<eKhachHang>();
            foreach (KhachHang kh in khlist)
            {
                eKhachHang t = new eKhachHang();
                t.MaKH = kh.MaKH;
                t.TenKH = kh.TenKH;
                t.SoDT = kh.SDT;
                t.DiaChi = kh.DiaChi;
                ls.Add(t);
            }
            return ls;
        }
        public bool KtraTonTai(string sdt)// ktra mã nhân  viên có tồn tại trong hệ thống chưa 30/9/2018
        {
            KhachHang khtemp = new KhachHang();
            khtemp = db.KhachHangs.Where(s => s.SDT== sdt).FirstOrDefault();
            if (khtemp != null)
                return true;
            else
                return false;
        }
        public int ThemKH(eKhachHang khmoi) // Thêm khaachs hàng  mới
        {
            if (KtraTonTai(khmoi.SoDT))
                return 0;

            KhachHang temp = new KhachHang();
            temp.MaKH = khmoi.MaKH;
            temp.TenKH = khmoi.TenKH;
            temp.SDT = khmoi.SoDT;
            temp.DiaChi = khmoi.DiaChi;
            db.KhachHangs.InsertOnSubmit(temp);
            db.SubmitChanges();
            return 1;
        }
        public void CapNhatKH(string ma, string ten, string sdt, string diachi) // cập nhật dữ liệu khách hàng 
        {
            IQueryable<KhachHang> kh = db.KhachHangs.Where(x => x.MaKH == ma);
            kh.First().MaKH = ma;
            kh.First().TenKH = ten;
            kh.First().SDT = sdt;
            kh.First().DiaChi = diachi;
            db.SubmitChanges();
        }
        public List<eKhachHang> TimKiem(string tenkh) // tìm kiếm khách hàng theo tên 
        {
            var khlist = db.KhachHangs.Where(delegate (KhachHang c)
            {
                if (ConvertToUnSign(c.TenKH+c.DiaChi+c.SDT+c.MaKH).IndexOf(tenkh, StringComparison.CurrentCultureIgnoreCase) >= 0)
                    return true;
                else
                    return false;
            }).AsQueryable();

            //var khlist = (from s in db.KhachHangs
            //              where s.TenKH.Contains(tenkh)
            //              select s).ToList();
            List<eKhachHang> lkh = new List<eKhachHang>();
            foreach (KhachHang kh in khlist)
            {
                eKhachHang t = new eKhachHang();
                t.MaKH = kh.MaKH;
                t.TenKH = kh.TenKH;
                t.SoDT = kh.SDT;
                t.DiaChi = kh.DiaChi;
                lkh.Add(t);
            }
            return lkh;
        }
        public List<eKhachHang> TimKiemTheoSDT(string sdt)// tìm kiếm khách hàng theo sdt
        {
            var khlist = (from s in db.KhachHangs
                          where s.SDT.Contains(sdt)
                          select s).ToList();
            List<eKhachHang> lkh = new List<eKhachHang>();
            foreach (KhachHang kh in khlist)
            {
                eKhachHang t = new eKhachHang();
                t.MaKH = kh.MaKH;
                t.TenKH = kh.TenKH;
                t.SoDT = kh.SDT;
                t.DiaChi = kh.DiaChi;
                lkh.Add(t);
            }
            return lkh;
        }
        public eKhachHang LayKHTheoSDT(string sdt)// Lấy thong tin 1 khách hàng qua sdt
        {
            KhachHang kh = db.KhachHangs.Where(s => s.SDT == sdt).FirstOrDefault();
            if (kh != null)
            {
                eKhachHang t = new eKhachHang();
                t.MaKH = kh.MaKH;
                t.TenKH = kh.TenKH;
                t.DiaChi = kh.DiaChi;
                t.SoDT = kh.SDT;
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
    }
}
