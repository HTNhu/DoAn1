using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class eXe // Kỷ 30/9/2018
    {
          
        private string tenXe ,maXe,loaiXe, mauXe,nuocSX, soKhung, soSuon, soPK;
        private double giaXe;
        private bool tinhTrang;
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

        public string LoaiXe
        {
            get
            {
                return loaiXe;
            }

            set
            {
                loaiXe = value;
            }
        }

        public string MauXe
        {
            get
            {
                return mauXe;
            }

            set
            {
                mauXe = value;
            }
        }

        public string NuocSX
        {
            get
            {
                return nuocSX;
            }

            set
            {
                nuocSX = value;
            }
        }

        public string SoKhung
        {
            get
            {
                return soKhung;
            }

            set
            {
                soKhung = value;
            }
        }

        public string SoSuon
        {
            get
            {
                return soSuon;
            }

            set
            {
                soSuon = value;
            }
        }

        public string SoPK
        {
            get
            {
                return soPK;
            }

            set
            {
                soPK = value;
            }
        }

        public double GiaXe
        {
            get
            {
                return giaXe;
            }

            set
            {
                giaXe = value;
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

        public eXe()
        {
            this.MaXe = "";
            this.LoaiXe = "";
            this.GiaXe = 0;
            this.SoKhung = "";
            this.SoPK = "";
            this.SoSuon = "";
            this.NuocSX = "";
            this.MauXe = "";
            this.TenXe = "";
            this.TinhTrang = true;
        }
        public eXe(string maxe,string ten, string sokhung, string sosuon, string sopk, string loaixe, string mau, string nuocsx, double gia, bool tt)
        {
            this.MauXe = mau;
            this.MaXe = maxe;
            this.SoKhung = sokhung;
            this.SoPK = sopk;
            this.SoSuon = sosuon;
            this.GiaXe = gia;
            this.NuocSX = nuocsx;
            this.LoaiXe = loaixe;
            this.tenXe = ten;
            this.tinhTrang = tt;
        }
    }
}
