using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eCTPhieuSua //Kỷ 10/10/2018
    {
        private string maCTPS,maPS, maLK, tenLK;
        private double  thanhTien, giaTien;
        private int soLuong;

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

        public string MaLK
        {
            get
            {
                return maLK;
            }

            set
            {
                maLK = value;
            }
        }

        public string TenLK
        {
            get
            {
                return tenLK;
            }

            set
            {
                tenLK = value;
            }
        }

       

        public double GiaTien
        {
            get
            {
                return giaTien;
            }

            set
            {
                giaTien = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
            }
        }

        public double ThanhTien
        {
            get
            {
                return thanhTien;
            }

            set
            {
                thanhTien = value;
            }
        }

        public string MaCTPS
        {
            get
            {
                return maCTPS;
            }

            set
            {
                maCTPS = value;
            }
        }

        public eCTPhieuSua()
        {
            this.MaPS = "";
            this.MaLK = "";
            this.TenLK = "";
            this.GiaTien = 0;
            this.SoLuong = 0;
            this.thanhTien = 0;
            this.maCTPS = "";
        }
        public eCTPhieuSua(string maps, string malk, string tenlk, double gia, int sl,double tt,string mact)
        {
            this.maPS = maps;
            this.tenLK = tenlk;
            this.maLK = malk;
            this.giaTien = gia;
            this.soLuong = sl;
            this.thanhTien = tt;
            this.maCTPS = mact;
        }
    }
}
