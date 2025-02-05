using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OdaEntity = HotelReservationandManagementSystem.EntityLayer.Odalar;
using HotelReservationandManagementSystem.ServiceLayer;

namespace nypdeniz.UI.UserControls
{
    public partial class OdaControl : UserControl
    {
        private OtelService otelService;

        public OdaControl()
        {
            InitializeComponent();
            otelService = new OtelService();
            OdalariListele();
        }

        private void OdalariListele()
        {
            try
            {
                var odalar = otelService.OdalariGetir();
                odalarDatagrid.DataSource = odalar;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Odalar listelenirken hata oluştu: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(odaNoTxtbx.Text) ||
                string.IsNullOrWhiteSpace(odaTipiTxtbx.Text) ||
                string.IsNullOrWhiteSpace(odaFiyatiTxtbx.Text))
            {
                MessageBox.Show("Oda numarası, tipi ve fiyatı zorunlu alanlardır.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                OdaEntity yeniOda = new OdaEntity
                {
                    OdaNumarasi = odaNoTxtbx.Text.Trim(),
                    OdaTipi = odaTipiTxtbx.Text.Trim(),
                    OdaFiyati = decimal.Parse(odaFiyatiTxtbx.Text),
                    DolulukDurumu = false 
                };

                otelService.OdaEkle(yeniOda);
                MessageBox.Show("Oda başarıyla eklendi.", "Başarılı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormuTemizle();
                OdalariListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oda eklenirken hata oluştu: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(odaIdTxt.Text))
            {
                MessageBox.Show("Güncellenecek bir oda seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                OdaEntity guncellenecekOda = new OdaEntity()
                {
                    OdaId = int.Parse(odaIdTxt.Text), 
                    OdaNumarasi = odaNoTxtbx.Text.Trim(),
                    OdaTipi = odaTipiTxtbx.Text.Trim(),
                    OdaFiyati = decimal.Parse(odaFiyatiTxtbx.Text)
                };

                otelService.OdaGuncelle(guncellenecekOda);
                MessageBox.Show("Oda başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OdalariListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Güncelleme sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(odaIdTxt.Text))
            {
                MessageBox.Show("Silmek için bir oda seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var sonuc = MessageBox.Show("Odayı silmek istediğinize emin misiniz?", "Silme Onayı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                try
                {
                    otelService.OdaSil(int.Parse(odaIdTxt.Text)); 
                    MessageBox.Show("Oda silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    OdalariListele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Silme sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void odalarDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                OdaEntity secilenOda = (OdaEntity)odalarDatagrid.Rows[e.RowIndex].DataBoundItem;

                odaIdTxt.Text = secilenOda.OdaId.ToString();
                odaNoTxtbx.Text = secilenOda.OdaNumarasi;
                odaTipiTxtbx.Text = secilenOda.OdaTipi;
                odaFiyatiTxtbx.Text = secilenOda.OdaFiyati.ToString();
            }
        }

        private void FormuTemizle()
        {
            odaNoTxtbx.Clear();
            odaTipiTxtbx.Clear();
            odaFiyatiTxtbx.Clear();
        }
        private void odaFiyatiTxtbx_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(odaFiyatiTxtbx.Text, "[^0-9,]"))
            {
                MessageBox.Show("Lütfen sadece sayı giriniz.", "Uyarı");
                odaFiyatiTxtbx.Text = odaFiyatiTxtbx.Text.Remove(odaFiyatiTxtbx.Text.Length - 1);
            }
        }
    }
}