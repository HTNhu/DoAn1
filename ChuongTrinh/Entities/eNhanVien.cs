using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eNhanVien //Như 28/9/2018 
    {
        private string maNhanVien;
        private string tenNV, soDT, diaChi, caLam, cMND, chucVu;
        private bool tinhTrang;

        public string CaLam
        {
            get
            {
                return caLam;
            }

            set
            {
                caLam = value;
            }
        }

        public string ChucVu
        {
            get
            {
                return chucVu;
            }

            set
            {
                chucVu = value;
            }
        }

        public string CMND
        {
            get
            {
                return cMND;
            }

            set
            {
                cMND = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
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

        public string SoDT
        {
            get
            {
                return soDT;
            }

            set
            {
                soDT = value;
            }
        }

        public string TenNV
        {
            get
            {
                return tenNV;
            }

            set
            {
                tenNV = value;
            }
        }

        public bool TinhTrang
        {
            get
            {
                return tinhTrang;
            }

            set
            {
                tinhTrang = value;
            }
        }
        public eNhanVien()
        {
            this.maNhanVien = "";
            this.tenNV = "";
            this.soDT = "";
            this.caLam = "";
            this.tinhTrang = true;
            this.cMND = "";
            this.chucVu = "";
            this.diaChi = "";
        }
        public eNhanVien(string ma,string ten, string sdt, string dc,
            string ca, string cmnd, string cv,bool tt)
        {
            this.maNhanVien = ma;
            this.tenNV = ten;
            this.soDT = sdt;
            this.diaChi = dc;
            this.caLam = ca;
            this.cMND = cmnd;
            this.chucVu = cv;
            this.tinhTrang = tt;
        }
    }
}
