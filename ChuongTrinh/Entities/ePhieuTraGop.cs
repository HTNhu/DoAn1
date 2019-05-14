using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ePhieuTraGop // Như 10/10/2018
    {
        private string maHopDong, tenNV,maNV,tenNgTra;
        private double soTien;
        private DateTime ngayTra;
        private int lanTra;

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

        public string TenNgTra
        {
            get
            {
                return tenNgTra;
            }

            set
            {
                tenNgTra = value;
            }
        }

        public double SoTien
        {
            get
            {
                return soTien;
            }

            set
            {
                soTien = value;
            }
        }

        public DateTime NgayTra
        {
            get
            {
                return ngayTra;
            }

            set
            {
                ngayTra = value;
            }
        }

        public int LanTra
        {
            get
            {
                return lanTra;
            }

            set
            {
                lanTra = value;
            }
        }
        public ePhieuTraGop()
        {
            this.MaHopDong = "";
            this.LanTra = 0;
            this.SoTien = 0;
            this.MaNV = "";
            this.TenNgTra = "";
            this.TenNV = "";
            this.NgayTra = DateTime.Now;
        }
        public ePhieuTraGop(string mahdong, string tennv,string manv,string tenngtra, double tien, DateTime ngaytra, int lantra)
        {
            this.maHopDong = mahdong;
            this.tenNgTra = tenngtra;
            this.maNV = manv;
            this.tenNV = tennv;
            this.soTien = tien;
            this.ngayTra = ngaytra;
            this.lanTra = lantra;
        }
    }
}
