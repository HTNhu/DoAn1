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
    public class NhanVienBLL // Như 1/10/2018
    {
        CuaHangBanXeMayDataContext db;

        public NhanVienBLL()
        {
            db = new CuaHangBanXeMayDataContext();
        }

        public List<eNhanVien> LayDulieu() // Lấy dữ liệu từ csdl sang lớp entity
        {
            var nvlist = db.NhanViens.ToList();
            List<eNhanVien> ls = new List<eNhanVien>();
            foreach (NhanVien nv in nvlist)
            {
                eNhanVien t = new eNhanVien();
                t.MaNhanVien = nv.MaNV;
                t.TenNV = nv.TenNV;
                t.CMND = nv.CMND;
                t.DiaChi = nv.DiaChi;
                t.ChucVu = nv.ChucVu;
                t.CaLam = nv.CaLam;
                t.SoDT = nv.SDT;
                if (nv.TinhTrang == true)
                    t.TinhTrang = true;
                else
                    t.TinhTrang = false;
                ls.Add(t);
            }
            return ls;
        }
        public string KtraLoaiNV(string maNV) // ktra loại nhân viên 
        {
            NhanVien nv = db.NhanViens.Single(s => s.MaNV.Trim() == maNV.Trim());
     
                return nv.ChucVu;
            
        }
        public bool KtraTonTai(string manv)// ktra mã nhân  viên có tồn tạ trong hệ thống chưa 30/9/2018
        {
            NhanVien nvtemp = new NhanVien();
            nvtemp = db.NhanViens.Where(s => s.MaNV.Trim() == manv.Trim()).FirstOrDefault();
            if (nvtemp != null)
                return true;
            else
                return false;
        }
        public int ThemNV(eNhanVien nvmoi) // Thêm nhân viên mới
        {
            if (KtraTonTai(nvmoi.MaNhanVien.Trim()))
                return 0;

            NhanVien nvtemp = new NhanVien();
            nvtemp.MaNV = nvmoi.MaNhanVien;
            nvtemp.TenNV = nvmoi.TenNV;
            nvtemp.SDT = nvmoi.SoDT;
            nvtemp.DiaChi = nvmoi.DiaChi;
            nvtemp.ChucVu = nvmoi.ChucVu;
            nvtemp.CMND = nvmoi.CMND;
            nvtemp.CaLam = nvmoi.CaLam;
            nvtemp.TinhTrang = nvmoi.TinhTrang;
            db.NhanViens.InsertOnSubmit(nvtemp);
            db.SubmitChanges();
            return 1;
        }
        public void CapNhatNV(string manv, string ten, string sdt,string chucvu, string calam, string cmnd, string diachi, bool tinhtrang)
        {
            IQueryable<NhanVien> nv = db.NhanViens.Where(x => x.MaNV == manv);
            // cập nhật dữ liệu 1/10/2018
            nv.First().MaNV = manv;
            nv.First().TenNV = ten;
            nv.First().SDT = sdt;
            nv.First().CaLam = calam;
            nv.First().ChucVu = chucvu;
            nv.First().CMND = cmnd;
            nv.First().DiaChi = diachi;
            nv.First().TinhTrang = tinhtrang;

            db.SubmitChanges();
        }

        public eNhanVien LayNVTheoMa(string manv)// Lấy nhân viên theo mã nhân viên
        {
           
            NhanVien nv = db.NhanViens.Where(s => s.MaNV.Trim() == manv.Trim()).FirstOrDefault();
            if (nv != null)
            {
                eNhanVien nvt = new eNhanVien();
                nvt.MaNhanVien = nv.MaNV;
                nvt.TenNV = nv.TenNV;
                nvt.ChucVu = nv.ChucVu;
                nvt.TinhTrang = bool.Parse(nv.TinhTrang.ToString());
                return nvt;
            }
            else
                return null;
                
          
        }
        public eNhanVien TimMotNhanVienTheoMa(string manv)// Tìm 1 nhân viên theo mã nhân viên
        {

            NhanVien nv = db.NhanViens.Where(s => s.MaNV == manv).FirstOrDefault();
            if (nv != null)
            {
                eNhanVien nvt = new eNhanVien();
                nvt.MaNhanVien = nv.MaNV;
                nvt.TenNV = nv.TenNV;
                nvt.ChucVu = nv.ChucVu;
                nvt.CaLam = nv.CaLam;
                nvt.SoDT = nv.SDT;
                nvt.DiaChi = nv.DiaChi;
                nvt.CMND = nv.CMND;
                  return nvt;
            }
            else
                return null;


        }
        public List<eNhanVien> TimKiem(string tennv)//tim kiem nv theo ten nhân viên 
        {
            var nvlist = db.NhanViens.Where(delegate (NhanVien c)
            {
                if (ConvertToUnSign(c.MaNV + c.TenNV + c.CMND + c.DiaChi + c.ChucVu + c.CaLam + c.SDT ).IndexOf(tennv, StringComparison.CurrentCultureIgnoreCase) >= 0)
                    return true;
                else
                    return false;
            }).AsQueryable();
            List<eNhanVien> lnv = new List<eNhanVien>();
            foreach (NhanVien nv in nvlist)
            {
                eNhanVien t = new eNhanVien();
                t.MaNhanVien = nv.MaNV;
                t.TenNV = nv.TenNV;
                t.CMND = nv.CMND;
                t.DiaChi = nv.DiaChi;
                t.ChucVu = nv.ChucVu;
                t.CaLam = nv.CaLam;
                t.SoDT = nv.SDT;
                if (nv.TinhTrang == true)
                    t.TinhTrang = true;
                else
                    t.TinhTrang = false;
                lnv.Add(t);

            }
            return lnv;
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
