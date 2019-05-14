using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eHoaDon // Kỷ 7/10/2018
    {
        private float khuyenMai;
        private string tenKH, tenNV, maHoaDon, maKH, maNV;
        private DateTime ngayLap;
        private double tongTien, tienThanhToan;
        private string soDT;

        public float KhuyenMai
        {
            get
            {
                return khuyenMai;
            }

            set
            {
                khuyenMai = value;
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

        public string MaHoaDon
        {
            get
            {
                return maHoaDon;
            }

            set
            {
                maHoaDon = value;
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

        public string MaNV
        {
            get
            {
                return maNV;
            }

            set
            {
                maNV = value;
            }
        }

        public DateTime NgayLap
        {
            get
            {
                return ngayLap;
            }

            set
            {
                ngayLap = value;
            }
        }

        public double TongTien
        {
            get
            {
                return tongTien;
            }

            set
            {
                tongTien = value;
            }
        }

        public double TienThanhToan
        {
            get
            {
                return tienThanhToan;
            }

            set
            {
                tienThanhToan = value;
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

        public eHoaDon()
        {
            this.maHoaDon = "";
            this.maKH = "";
            this.maNV = "";
            this.ngayLap = DateTime.Now;
            this.tenKH = "";
            this.tienThanhToan = 0;
            this.khuyenMai = 0;
            this.soDT = "";
            this.tenNV = "";
            this.tongTien = 0;
        }
        public eHoaDon(float km, string tenkh, string tennv, string mahd,string makh, string manv, DateTime ngaylap, double tongtien, double tientt, string sdt)
        {
            this.maHoaDon = mahd;
            this.maKH = makh;
            this.maNV = manv;
            this.ngayLap = ngaylap;
            this.tenKH = tenkh;
            this.tienThanhToan = tientt;
            this.khuyenMai = km;
            this.soDT = sdt;
            this.tenNV = tennv;
            this.tongTien = tongtien;

        }
    }
    
}
