using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ePhieuSuaBaoHanh // Kỷ 10/10/2018
    {
        private string maPS, tenNV, maHDong, maNV;
        private double tongTien;
        private DateTime ngayLap;
        private bool loiDoKhachHaySP;//true là lỗi sp// false là lỗi khách hàng

        public string MaPS
        {
            get
            {
                return maPS;
            }

            set
            {
                maPS = value;
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

        public string MaHDong
        {
            get
            {
                return maHDong;
            }

            set
            {
                maHDong = value;
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

        public bool LoiDoKhachHaySP
        {
            get
            {
                return loiDoKhachHaySP;
            }

            set
            {
                loiDoKhachHaySP = value;
            }
        }
        public ePhieuSuaBaoHanh()
        {
            this.MaPS = "";
            this.MaHDong = "";
            this.TenNV = "";
            this.MaNV = "";
            this.NgayLap = DateTime.Now;
            this.TongTien = 0;
            this.LoiDoKhachHaySP = true;
        }
        public ePhieuSuaBaoHanh(string maps, string mahd, string manv, string tennv, double tt, DateTime ngaylap, bool loi)
        {
            this.maHDong = mahd;
            this.maPS = maps;
            this.maNV = manv;
            this.tenNV = tennv;
            this.tongTien = tt;
            this.ngayLap = ngaylap;
            this.LoiDoKhachHaySP = loi;
        }
    
    }
}
