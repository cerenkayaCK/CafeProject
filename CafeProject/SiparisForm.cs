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
    public partial class SiparisForm : Form
    {
        private readonly KafeVeri _db;
        private readonly Siparis _siparis;
        public SiparisForm(KafeVeri db, Siparis siparis)
        {
            _db = db;
            _siparis = siparis;
            InitializeComponent();
            cboUrun.DataSource = _db.Urunler;
            DetaylarıListele();



        }

        private void DetaylarıListele()
        {

            dgvDetaylar.DataSource = _siparis.SiparisDetaylar.ToList();
            Guncelle();
        }

        private void Guncelle()
        {
            Text = "Masa" + _siparis.MasaNo;
            lblMasaNo.Text = _siparis.MasaNo.ToString("00");
            lblOdemeTutari.Text = _siparis.ToplamTutarTl;
        }

        private void btnMasaTasi_Click(object sender, EventArgs e)
        {

        }

        private void btnDetayEkle_Click(object sender, EventArgs e)
        {
            if (cboUrun.SelectedItem == null) { return; }

            Urun urun = (Urun)cboUrun.SelectedItem;
            SiparisDetay sd = new SiparisDetay();
            sd.UrunAd = urun.UrunAd;
            sd.BirimFiyat = urun.BirimFiyat;
            sd.Adet = (int)nudAdet.Value;
            _siparis.SiparisDetaylar.Add(sd);
            DetaylarıListele();
        }

        private void dgvDetaylar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvDetaylar.SelectedRows.Count > 0)
            { //seçili satıra bağlı nesne
                SiparisDetay sd = (SiparisDetay)dgvDetaylar.SelectedRows[0].DataBoundItem;
                _siparis.SiparisDetaylar.Remove(sd);
                DetaylarıListele();

            }
        }

        private void btnAnasayfayaDon_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSiparisİptal_Click(object sender, EventArgs e)
        {
            SiparisiKapat(SiparisDurum.İptal, 0);
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            SiparisiKapat(SiparisDurum.Odendi, _siparis.ToplamTutar());
        }

        private void SiparisiKapat(SiparisDurum durum, decimal odenenTutar)
        {
            _siparis.KapanisZamani = DateTime.Now;
            _siparis.OdenenTutar = odenenTutar;
            _siparis.Durum = durum;
            _db.AktifSiparisler.Remove(_siparis);
            _db.GecmisSiparisler.Add(_siparis);
            Close();
        }



       

    
    }
}