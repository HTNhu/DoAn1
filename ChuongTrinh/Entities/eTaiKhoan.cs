using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eTaiKhoan // Như 28/9/2018 
    {
        private string tenTaiKhoan;
        private string matKhau;
        private string maNhanVien;

        public string TenTaiKhoan
        {
            get
            {
                return tenTaiKhoan;
            }

            set
            {
                tenTaiKhoan = value;
            }
        }

        public string MatKhau
        {
            get
            {
                return matKhau;
            }

            set
            {
                matKhau = value;
            }
        }

        public string MaNhanVien
        {
            get
            {
                return maNhanVien;
            }

            set
            {
                maNhanVien = value;
            }
        }
        public eTaiKhoan()
        {
            this.tenTaiKhoan = "";
            this.matKhau = "";
            this.maNhanVien = "";
        }
        public eTaiKhoan(string tenTK, string mk, string maNV)
        {
            this.maNhanVien = maNV;
            this.tenTaiKhoan = tenTK;
            this.matKhau = mk;
        }
    }

}
