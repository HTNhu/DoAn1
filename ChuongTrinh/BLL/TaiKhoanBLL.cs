using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class TaiKhoanBLL // Như 6/10/2018
    {
        CuaHangBanXeMayDataContext db;
        
        public TaiKhoanBLL()
        {
            db = new CuaHangBanXeMayDataContext();
        }
       
        public bool KtraTaiKhoan(eTaiKhoan tk)// Kiểm tra tài khoản hợp lệ hay không
        {
            db = new CuaHangBanXeMayDataContext();
            TaiKhoan tktemp = db.TaiKhoans.Where(s => s.TenTK.Trim().ToUpper() == tk.TenTaiKhoan.Trim().ToUpper()).FirstOrDefault();
            if(tktemp != null )
            {
                if (tk.MatKhau.Trim() == tktemp.MatKhau.Trim())
                    return true;
                else
                    return false;
            }
           else
                return false;
        }
        public eTaiKhoan layTKBangTenTK(string tentk)// lấy 1 tài khoản bằng tên tài khoản
        {
            TaiKhoan a = db.TaiKhoans.Where(s => s.TenTK.ToUpper().Trim() == tentk.ToUpper().Trim()).FirstOrDefault();
            if(a != null)
            {
                eTaiKhoan tk = new eTaiKhoan();
                tk.MaNhanVien = a.MaNV;
                tk.TenTaiKhoan = a.TenTK;
                tk.MatKhau = a.MatKhau;
                return tk;
            }
            else
                return null;
            

        }
        public List<eTaiKhoan> LayTatCaGiaTri()// Lấy giá trị từ csdl
        {
            var taikhoanlist = db.TaiKhoans.ToList();
            List<eTaiKhoan> ls = new List<eTaiKhoan>();
            foreach (TaiKhoan tktemp in taikhoanlist)
            {
                eTaiKhoan tk = new eTaiKhoan();
                tk.MaNhanVien = tktemp.MaNV;
                tk.TenTaiKhoan = tktemp.TenTK;
                tk.MatKhau = tktemp.MatKhau;
                ls.Add(tk);

            }
            return ls;
        }
        public int ThemTK(eTaiKhoan tkmoi) // Thêm tài khoản mới
        {
            if (KtraTaiKhoan(tkmoi))
                return 0;

            TaiKhoan tktemp = new TaiKhoan();
            tktemp.MaNV = tkmoi.MaNhanVien;
            tktemp.TenTK = tkmoi.TenTaiKhoan;
            tktemp.MatKhau = tkmoi.MatKhau;
           
            db.TaiKhoans.InsertOnSubmit(tktemp);
            db.SubmitChanges();
            return 1;
        }
    }
}
