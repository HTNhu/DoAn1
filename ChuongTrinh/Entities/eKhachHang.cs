using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eKhachHang //Kỷ 30/9/2018
    {
        private string maKH;
        private string tenKH, diaChi, soDT;

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

        public string MaKH
        {
            get
            {
                return maKH;
            }

            set
            {
                maKH = value;
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

        public string TenKH
        {
            get
            {
                return tenKH;
            }

            set
            {
                tenKH = value;
            }
        }
        public eKhachHang()
        {
            this.maKH = "";
            this.tenKH = "";
            this.diaChi = "";
            this.soDT = "";
        }
        public eKhachHang(string makh, string ten, string sdt, string diachi)
        {
            this.maKH = makh;
            this.tenKH = ten;
            this.soDT = sdt;
            this.diaChi = diachi;
        }
    }
}
