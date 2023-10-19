using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeOnline6.Data
{
    internal class SiparisDetay
    {
        public string UrunAd { get; set; } = "";

        public decimal BirimFiyat { get; set; }

        public int Adet { get; set; }

        public string TutarTl { get { return Tutar().ToString("c2"); } }

        public decimal Tutar()
        {
            return Adet * BirimFiyat;
        }
    }
}
