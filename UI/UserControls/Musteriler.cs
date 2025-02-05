using System;
using System.Windows.Forms;
using MusteriEntity = HotelReservationandManagementSystem.EntityLayer.Musteriler;
using HotelReservationandManagementSystem.ServiceLayer;

namespace nypdeniz.UI.UserControls
{
    public partial class MusteriControl : UserControl
    {
        private OtelService otelService;

        public MusteriControl()
        {
            InitializeComponent();
            otelService = new OtelService();
            MusterileriListele();
        }

        private void MusterileriListele()
        {
            try
            {
                var musteriler = otelService.MusterileriGetir();
                musterilerDatagrid.DataSource = musteriler;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Müşterileri listelerken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(musteriAdTxt.Text) ||
                string.IsNullOrWhiteSpace(musteriTelTxt.Text))
            {
                MessageBox.Show("Ad Soyad ve Telefon alanları zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                MusteriEntity yeniMusteri = new MusteriEntity()
                {
                    AdSoyad = musteriAdTxt.Text.Trim(),
                    Telefon = musteriTelTxt.Text.Trim(),
                    Email = musteriMailTxt.Text.Trim(), 
                    KayitTarihi = DateTime.Now 
                };

                otelService.MusteriEkle(yeniMusteri);

                MessageBox.Show("Müşteri başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TemizleFormAlanlari();
                MusterileriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Müşteri eklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TemizleFormAlanlari()
        {
            musteriAdTxt.Clear();
            musteriTelTxt.Clear();
            musteriMailTxt.Clear();
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(musteriIdTxt.Text))
            {
                MessageBox.Show("Güncellenecek bir müşteri seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                MusteriEntity guncellenecekMusteri = new MusteriEntity()
                {
                    MusteriId = int.Parse(musteriIdTxt.Text), 
                    AdSoyad = musteriAdTxt.Text.Trim(),
                    Telefon = musteriTelTxt.Text.Trim(),
                    Email = musteriMailTxt.Text.Trim()
                };

                otelService.MusteriGuncelle(guncellenecekMusteri);
                MessageBox.Show("Müşteri başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MusterileriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Güncelleme sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(musteriIdTxt.Text))
            {
                MessageBox.Show("Silmek için bir müşteri seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var sonuc = MessageBox.Show("Müşteriyi silmek istediğinize emin misiniz?", "Silme Onayı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                try
                {
                    otelService.MusteriSil(int.Parse(musteriIdTxt.Text)); 
                    MessageBox.Show("Müşteri silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MusterileriListele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Silme sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void musterilerDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MusteriEntity secilenMusteri = (MusteriEntity)musterilerDatagrid.Rows[e.RowIndex].DataBoundItem;

                musteriIdTxt.Text = secilenMusteri.MusteriId.ToString(); 
                musteriAdTxt.Text = secilenMusteri.AdSoyad;
                musteriTelTxt.Text = secilenMusteri.Telefon;
                musteriMailTxt.Text = secilenMusteri.Email;
            }
        }
    }
}