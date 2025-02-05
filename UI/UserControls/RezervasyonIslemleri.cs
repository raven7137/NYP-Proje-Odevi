using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelReservationandManagementSystem.EntityLayer;
using HotelReservationandManagementSystem.ServiceLayer;

namespace nypdeniz.UI.UserControls
{
    public partial class RezervasyonIslemleri : UserControl
    {
        private OtelService otelService;
        private decimal mevcutOdaFiyati = 0;

        public RezervasyonIslemleri()
        {
            InitializeComponent();
            otelService = new OtelService();
            RezervasyonlariListele();

            // Salt okunur alanları ayarla
            idTxtbx.ReadOnly = true;
            toplamFiyatTxt.ReadOnly = true;

            // Tarih değişim olaylarını dinle
            girisTarihiDtp.ValueChanged += ToplamFiyatiGuncelle;
            cikisTarihiDtp.ValueChanged += ToplamFiyatiGuncelle;
            odaNoTxtbx.TextChanged += odaNoTxtbx_TextChanged; // Oda numarası değiştiğinde fiyatı güncelle
        }

        private void RezervasyonlariListele()
        {
            try
            {
                var rezervasyonlar = otelService.RezervasyonlariGetir();

                // Müşterileri ve odaları önceden çek
                var musteriler = otelService.MusterileriGetir();
                var odalar = otelService.OdalariGetir();

                // Yeni bir liste oluştur
                var rezervasyonListesi = rezervasyonlar.Select(r => new
                {
                    RezervasyonId = r.RezervasyonId,
                    MusteriAdSoyad = musteriler.FirstOrDefault(m => m.MusteriId == r.MusteriId)?.AdSoyad,
                    OdaNumarasi = odalar.FirstOrDefault(o => o.OdaId == r.OdaId)?.OdaNumarasi,
                    GirisTarihi = r.GirisTarihi,
                    CikisTarihi = r.CikisTarihi,
                    ToplamUcret = r.ToplamUcret
                }).ToList();

                rezervasyonDataGrid.DataSource = rezervasyonListesi;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Rezervasyonları listelerken hata oluştu: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToplamFiyatiGuncelle(object sender, EventArgs e)
        {
            try
            {
                // Konaklama süresini hesapla
                int gunSayisi = (cikisTarihiDtp.Value.Date - girisTarihiDtp.Value.Date).Days;

                // Tarih kontrolü yap
                if (gunSayisi < 0)
                {
                    MessageBox.Show("Çıkış tarihi giriş tarihinden önce olamaz.", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    toplamFiyatTxt.Text = "0";
                    return;
                }

                // Toplam ücreti hesapla
                decimal toplamFiyat = mevcutOdaFiyati * gunSayisi;
                toplamFiyatTxt.Text = toplamFiyat.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Toplam fiyat hesaplanırken hata oluştu: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                toplamFiyatTxt.Text = "0";
            }
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(isimSoyisimTxtbx.Text) ||
        string.IsNullOrWhiteSpace(odaNoTxtbx.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Müşteriyi bul
                var musteri = otelService.MusterileriGetir()
                    .FirstOrDefault(m => m.AdSoyad.ToLower() == isimSoyisimTxtbx.Text.ToLower());

                if (musteri == null)
                {
                    MessageBox.Show("Girilen isimde bir müşteri bulunamadı.", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Odayı bul
                var oda = otelService.OdalariGetir()
                    .FirstOrDefault(o => o.OdaNumarasi == odaNoTxtbx.Text);

                if (oda == null)
                {
                    MessageBox.Show("Girilen numarada bir oda bulunamadı.", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime girisTarihi = girisTarihiDtp.Value;
                DateTime cikisTarihi = cikisTarihiDtp.Value;

                // Aynı odada belirtilen tarihlerde rezervasyon var mı kontrol et
                bool rezervasyonVarMi = otelService.RezervasyonlariGetir()
                    .Any(r => r.OdaId == oda.OdaId &&
                              ((girisTarihi >= r.GirisTarihi && girisTarihi < r.CikisTarihi) ||
                               (cikisTarihi > r.GirisTarihi && cikisTarihi <= r.CikisTarihi) ||
                               (girisTarihi <= r.GirisTarihi && cikisTarihi >= r.CikisTarihi)));

                if (rezervasyonVarMi)
                {
                    MessageBox.Show("Bu tarih aralığında bu oda için zaten bir rezervasyon var.", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Rezervasyon oluştur
                Rezervasyonlar yeniRezervasyon = new Rezervasyonlar
                {
                    MusteriId = musteri.MusteriId,
                    OdaId = oda.OdaId,
                    MusteriAdSoyad = musteri.AdSoyad,
                    OdaNumarasi = oda.OdaNumarasi,
                    GirisTarihi = girisTarihi,
                    CikisTarihi = cikisTarihi,
                    ToplamUcret = decimal.Parse(toplamFiyatTxt.Text)
                };

                int rezervasyonId = otelService.RezervasyonVeFaturaEkle(yeniRezervasyon);

                MessageBox.Show("Rezervasyon ve fatura başarıyla oluşturuldu.", "Başarılı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                RezervasyonlariListele();
                FormuTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idTxtbx.Text))
            {
                MessageBox.Show("Lütfen silmek için bir rezervasyon seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int rezervasyonId = Convert.ToInt32(idTxtbx.Text);

                var onay = MessageBox.Show("Bu rezervasyonu silmek istediğinizden emin misiniz?", "Silme Onayı",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (onay == DialogResult.Yes)
                {
                    otelService.RezervasyonSil(rezervasyonId);

                    MessageBox.Show("Rezervasyon başarıyla silindi.", "Başarılı",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormuTemizle();
                    RezervasyonlariListele();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Rezervasyon silinirken hata oluştu: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormuTemizle()
        {
            idTxtbx.Clear();
            isimSoyisimTxtbx.Clear();
            odaNoTxtbx.Clear();
            toplamFiyatTxt.Clear();
            girisTarihiDtp.Value = DateTime.Now;
            cikisTarihiDtp.Value = DateTime.Now;
            mevcutOdaFiyati = 0;
        }

        private void rezervasyonDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    var secilenSatir = rezervasyonDataGrid.Rows[e.RowIndex];

                    idTxtbx.Text = secilenSatir.Cells["RezervasyonId"].Value?.ToString();
                    isimSoyisimTxtbx.Text = secilenSatir.Cells["MusteriAdSoyad"].Value?.ToString();
                    odaNoTxtbx.Text = secilenSatir.Cells["OdaNumarasi"].Value?.ToString();

                    if (DateTime.TryParse(secilenSatir.Cells["GirisTarihi"].Value?.ToString(), out DateTime girisTarihi))
                    {
                        girisTarihiDtp.Value = girisTarihi;
                    }

                    if (DateTime.TryParse(secilenSatir.Cells["CikisTarihi"].Value?.ToString(), out DateTime cikisTarihi))
                    {
                        cikisTarihiDtp.Value = cikisTarihi;
                    }

                    var oda = otelService.OdalariGetir()
                        .FirstOrDefault(o => o.OdaNumarasi == odaNoTxtbx.Text);
                    if (oda != null)
                    {
                        mevcutOdaFiyati = oda.OdaFiyati;
                        ToplamFiyatiGuncelle(null, null);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Rezervasyon bilgileri yüklenirken hata oluştu: {ex.Message}", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void odaNoTxtbx_TextChanged(object sender, EventArgs e)
        {
            if (odaNoTxtbx.Text.Length == 3)
            {
                var oda = otelService.OdalariGetir()
                    .FirstOrDefault(o => o.OdaNumarasi == odaNoTxtbx.Text);

                if (oda != null)
                {
                    mevcutOdaFiyati = oda.OdaFiyati; 
                    ToplamFiyatiGuncelle(null, null); 
                }
                else
                {
                    MessageBox.Show("Girilen numarada bir oda bulunamadı.", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mevcutOdaFiyati = 0; 
                    toplamFiyatTxt.Clear(); 
                }
            }
            else if (odaNoTxtbx.Text.Length < 3)
            {
                mevcutOdaFiyati = 0;
                toplamFiyatTxt.Clear();
            }
        }
    }
}