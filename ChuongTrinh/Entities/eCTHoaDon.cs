using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eCTHoaDon //Kỷ 7/10/2018
    {
        private string maHopDong, maXe, maHoaDon, tenXe;
        private double tienTT,gia;

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

        public string MaXe
        {
            get
            {
                return maXe;
            }

            set
            {
                maXe = value;
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

        public double TienTT
        {
            get
            {
                return tienTT;
            }

            set
            {
                tienTT = value;
            }
        }

        public eCTHoaDon()
        {
            this.maHoaDon = "";
            this.maHopDong = "";
            this.maXe = "";
            this.tenXe = "";
            this.gia = 0;
            this.tienTT = 0;
        }
        public eCTHoaDon(string mahopdong, string maxe, string mahoadon, string tenxe, double gia,double tientt)
        {
            this.maHopDong = mahopdong;
            this.maXe = maxe;
            this.maHoaDon = mahoadon;
            this.gia = gia;
            this.tenXe = tenxe;
            this.tienTT = tientt;
        }
    }
}
