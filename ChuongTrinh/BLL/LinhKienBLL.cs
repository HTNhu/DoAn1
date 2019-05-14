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
    
    public class LinhKienBLL
    {
        CuaHangBanXeMayDataContext db;
        public LinhKienBLL()
        {
            db = new CuaHangBanXeMayDataContext();
        }

        public List<eLinhKien> LayDulieu() // Lấy dữ liệu từ csdl sang lớp entity
        {
            var lklist = db.LinhKiens.ToList();
            List<eLinhKien> ls = new List<eLinhKien>();
            foreach (LinhKien lk in lklist)
            {
                eLinhKien t = new eLinhKien();
                t.Malk = lk.MaLK;
                t.Tenlk = lk.TenLK;
                t.Loailk = lk.Loai;
                t.Giatien = double.Parse(lk.GiaTien.ToString());
                ls.Add(t);
            }
            return ls;
        }
       
        public eLinhKien LayLKTheoTen(string tenlk) // Lấy dữ liệu của xe theo mã xe
        {
            LinhKien x = db.LinhKiens.Where(s => s.TenLK == tenlk).FirstOrDefault();
            if (x != null)
            {
                eLinhKien t = new eLinhKien();
                t.Malk = x.MaLK;
                t.Tenlk = x.TenLK;
                t.Loailk = x.Loai;
                t.Giatien = double.Parse(x.GiaTien.ToString());
                return t;
            }
            else
                return null;
        }
        public eLinhKien TimKiemLKTheoTen(string tenlk) // Lấy dữ liệu của xe theo mã xe
        {
            LinhKien x = db.LinhKiens.Where(s => s.TenLK.Contains(tenlk)).FirstOrDefault();
            if (x != null)
            {
                eLinhKien t = new eLinhKien();
                t.Malk = x.MaLK;
                t.Tenlk = x.TenLK;
                t.Loailk = x.Loai;
                t.Giatien = double.Parse(x.GiaTien.ToString());
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
