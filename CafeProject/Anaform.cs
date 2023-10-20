using KafeOnline6.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeProject
{
    public partial class Anaform : Form
    {
        KafeVeri db = new KafeVeri();
        public Anaform()
        {
            InitializeComponent();
            OrnekUrunleriYukle();
            MasalariYukle();


        }

        private void MasalariYukle()
        {
            for (int i = 0; i < db.MasaAdet; i++)
            {
                ListViewItem lvi = new ListViewItem();
                int masaNo = i + 1;
                lvi.Text = "Masa" + masaNo;
                lvi.Tag = masaNo;//boxing: değer tipi referans tipi olarak saklanır.
                lvi.ImageKey = "bos";
                IvwMasalar.Items.Add(lvi);
            }
        }

        private void IvwMasalar_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem lvi = IvwMasalar.SelectedItems[0];
            lvi.ImageKey = "dolu";
            int masaNo = (int)lvi.Tag;
            //MessageBox.Show("Tıklanan Masa Numarası: " + masaNo);
            Siparis? siparis = db.AktifSiparisler.FirstOrDefault(x => x.MasaNo == masaNo);
            if (siparis == null)
            {
                siparis = new Siparis() { MasaNo = masaNo };
                db.AktifSiparisler.Add(siparis);
            }



            //sipariş penceresini aç
            SiparisForm siparisForm = new SiparisForm(db, siparis);
            siparisForm.ShowDialog();

            if (siparis.Durum != SiparisDurum.Aktif)
            {
                lvi.ImageKey = "bos";
            }
        }
        private void OrnekUrunleriYukle()
        {
            if (db.Urunler.Count == 0)
            {
                db.Urunler.Add(new Urun() { UrunAd = "Çay", BirimFiyat = 20.00m });
                db.Urunler.Add(new Urun() { UrunAd = "Kola", BirimFiyat = 35.00m });
                db.Urunler.Add(new Urun() { UrunAd = "Omlet", BirimFiyat = 70.00m });
                db.Urunler.Add(new Urun() { UrunAd = "Gözleme", BirimFiyat = 120.00m });
            }
        }

        private void tsmiGecmisSiparisler_Click(object sender, EventArgs e)
        {
            new GecmisSiparislerForm(db).ShowDialog();
        }
    }
}
