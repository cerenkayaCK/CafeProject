using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeOnline6.Data
{
    public class Siparis
    {
        public int MasaNo { get; set; }
        public SiparisDurum Durum { get; set; } = SiparisDurum.Aktif;

        public decimal OdenenTutar { get; set; }

        public DateTime AcilisZamani { get; set; }

        public DateTime KapanisZamani { get; set; }

        public  List<SiparisDetay> SiparisDetaylar = new List<SiparisDetay>();

        public string ToplamTutarTl => ToplamTutar().ToString("c2");
            //get tamımlanmış olur.
         
        public decimal ToplamTutar()
        {
            return SiparisDetaylar.Sum(sd => sd.Tutar());
        }
    }
}
