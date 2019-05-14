using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eHopDong // Như 8/10/2018
    {
        private int  hinhThucTT ;
        private string tenXe, maHopDong, maKH, tenKH, tinhTrang, diaChi,tenNV;
        private DateTime ngayLap, hanBH;
        private double gia;
        
       

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

        public string TinhTrang
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

        public DateTime HanBH
        {
            get
            {
                return hanBH;
            }

            set
            {
                hanBH = value;
            }
        }

        public double Gia
        {
            get
            {
                return gia;
            }

            set
            {
                gia = value;
            }
        }

        public string MaHopDong
        {
            get
            {
                return maHopDong;
            }

            set
            {
                maHopDong = value;
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

        public int HinhThucTT
        {
            get
            {
                return hinhThucTT;
            }

            set
            {
                hinhThucTT = value;
            }
        }

        public string TenXe
        {
            get
            {
                return tenXe;
            }

            set
            {
                tenXe = value;
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

        public eHopDong()
        {
            
            this.MaHopDong = "";
            this.HinhThucTT = 0;
            this.MaKH = "";
            this.TenXe = "";
            this.tenKH = "";
            this.tinhTrang = "";
            this.diaChi = "";
            this.ngayLap = DateTime.Now;
            this.hanBH = DateTime.Now;
            this.gia = 0;
            this.tenNV = "";
        }
        public eHopDong(string mahopdong, int hinhthuctt, string makh, string tenxe,
            string tenkh , string tinhtrang, string diachi, DateTime ngaylap, DateTime hanbh, double gia,string tennv)
        {
            this.MaHopDong = mahopdong;
            this.hinhThucTT = hinhthuctt;
            this.maKH = makh;
            this.tenXe = tenxe;
            this.tenKH = tenkh;
            this.tinhTrang = tinhtrang;
            this.diaChi = diachi;
            this.ngayLap = ngaylap;
            this.hanBH = hanbh;
            this.gia = gia;
            this.tenNV = tennv;
        }
    }
}
