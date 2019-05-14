using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    
    public class eLinhKien
    {
        private double giatien;
        private string tenlk, loailk, malk;

       

        public double Giatien
        {
            get
            {
                return giatien;
            }

            set
            {
                giatien = value;
            }
        }

        public string Loailk
        {
            get
            {
                return loailk;
            }

            set
            {
                loailk = value;
            }
        }

        public string Malk
        {
            get
            {
                return malk;
            }

            set
            {
                malk = value;
            }
        }

        public string Tenlk
        {
            get
            {
                return tenlk;
            }

            set
            {
                tenlk = value;
            }
        }

        public eLinhKien()
        {
            this.malk = "";
            this.tenlk = "";
            this.loailk = "";
            this.giatien = 0;

        }
        public eLinhKien(string malk, string tenlk, string loailk, double giatien)
        {
            this.malk = malk;
            this.tenlk = tenlk;
            this.loailk = loailk;
            this.giatien = giatien;
        }
    }
}
