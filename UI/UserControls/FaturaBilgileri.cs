using System;
using System.Linq;
using System.Windows.Forms;
using HotelReservationandManagementSystem.ServiceLayer;
using HotelReservationandManagementSystem.EntityLayer;
using System.Drawing;

namespace nypdeniz.UI.UserControls
{
    public partial class FaturaBilgileri : UserControl
    {
        private OtelService otelService;

        public FaturaBilgileri()
        {
            InitializeComponent();
            otelService = new OtelService();
            FaturalariListele();
        }

        private void FaturalariListele()
        {
            try
            {
                var faturalar = otelService.FaturalariGetir();

                var faturaListesi = faturalar.Select(f => new
                {
                    Fatura_No = f.FaturaId,
                    Rezervasyon_No = f.RezervasyonID,
                    Fatura_Tarihi = f.FaturaTarihi.ToString("dd.MM.yyyy"),
                    Toplam_Tutar = $"{f.ToplamUcret:C2}"
                }).ToList();

                dataGridFatura.DataSource = faturaListesi;
                dataGridFatura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridFatura.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Faturalar listelenirken hata oluştu: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FaturaDetayiniGoster(int faturaId)
        {
            try
            {
                var fatura = otelService.FaturalariGetir().FirstOrDefault(f => f.FaturaId == faturaId);
                if (fatura == null) return;

                var rezervasyon = otelService.RezervasyonlariGetir()
                    .FirstOrDefault(r => r.RezervasyonId == fatura.RezervasyonID);
                if (rezervasyon == null) return;

                var musteri = otelService.MusterileriGetir()
                    .FirstOrDefault(m => m.MusteriId == rezervasyon.MusteriId);
                var oda = otelService.OdalariGetir()
                    .FirstOrDefault(o => o.OdaId == rezervasyon.OdaId);

                int gunSayisi = (rezervasyon.CikisTarihi - rezervasyon.GirisTarihi).Days;

                using (Form faturaForm = new Form())
                {
                    // Form ayarları
                    faturaForm.Text = "Fatura Detayı";
                    faturaForm.Size = new System.Drawing.Size(450, 800); // Daha küçük boyut
                    faturaForm.StartPosition = FormStartPosition.CenterScreen;
                    faturaForm.BackgroundImage = nypdeniz.Properties.Resources.unfocussed_winter_background_with_snowflakes_1393_271;
                    faturaForm.BackgroundImageLayout = ImageLayout.Stretch;

                    // Ana başlık
                    Label lblBaslik = new Label
                    {
                        Text = "OTEL FATURASI",
                        Font = new System.Drawing.Font("Palatino Linotype", 19.8f, FontStyle.Regular),
                        ForeColor = Color.DarkSlateGray,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Top,
                        Height = 50,
                        BackColor = Color.Transparent
                    };

                    // İçerik paneli
                    Panel contentPanel = new Panel
                    {
                        Dock = DockStyle.Fill,
                        Padding = new Padding(15), // Padding'i azalttık
                        BackColor = Color.FromArgb(240, 248, 255), // Alice Blue
                        Margin = new Padding(15) // Margin'i azalttık
                    };

                    // İçerik panelini form kenarlarından biraz içeride tutmak için
                    Panel marginPanel = new Panel
                    {
                        Dock = DockStyle.Fill,
                        Padding = new Padding(20), // Padding'i azalttık
                        BackColor = Color.Transparent
                    };
                    marginPanel.Controls.Add(contentPanel);

                    // Fatura bilgileri için TableLayoutPanel
                    TableLayoutPanel tableLayout = new TableLayoutPanel
                    {
                        Dock = DockStyle.Fill,
                        ColumnCount = 2,
                        RowCount = 13, // Satır sayısını artırdık
                        BackColor = Color.Transparent,
                        AutoSize = true // Otomatik boyutlandırma ekledik
                    };

                    // Sütun genişliklerini ayarla
                    tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
                    tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));

                    // Her satır için eşit yükseklik
                    for (int i = 0; i < 13; i++)
                    {
                        tableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    }

                    // Ortak label stili
                    Font labelFont = new Font("Tahoma", 10.2f, FontStyle.Bold);
                    Color labelColor = Color.CadetBlue;

                    // Bilgileri ekle
                    AddTableRow(tableLayout, "Fatura No:", fatura.FaturaId.ToString(), 0, labelFont, labelColor);
                    AddTableRow(tableLayout, "Tarih:", fatura.FaturaTarihi.ToString("dd.MM.yyyy"), 1, labelFont, labelColor);

                    // Boşluk için boş satır
                    AddTableRow(tableLayout, "", "", 2, labelFont, labelColor);

                    AddTableRow(tableLayout, "MÜŞTERİ", "", 3, new Font("Tahoma", 11f, FontStyle.Bold), Color.DarkSlateGray);
                    AddTableRow(tableLayout, "Ad Soyad:", musteri?.AdSoyad, 4, labelFont, labelColor);
                    AddTableRow(tableLayout, "Telefon:", musteri?.Telefon, 5, labelFont, labelColor);

                    // Boşluk için boş satır
                    AddTableRow(tableLayout, "", "", 6, labelFont, labelColor);

                    AddTableRow(tableLayout, "KONAKLAMA", "", 7, new Font("Tahoma", 11f, FontStyle.Bold), Color.DarkSlateGray);
                    AddTableRow(tableLayout, "Oda No:", oda?.OdaNumarasi.ToString(), 8, labelFont, labelColor);
                    AddTableRow(tableLayout, "Oda Tipi:", oda?.OdaTipi, 9, labelFont, labelColor);
                    AddTableRow(tableLayout, "Giriş Tarihi:", rezervasyon.GirisTarihi.ToString("dd.MM.yyyy"), 10, labelFont, labelColor);
                    AddTableRow(tableLayout, "Çıkış Tarihi:", rezervasyon.CikisTarihi.ToString("dd.MM.yyyy"), 11, labelFont, labelColor);

                    // Boşluk için boş satır
                    AddTableRow(tableLayout, "", "", 12, labelFont, labelColor);

                    AddTableRow(tableLayout, "ÖDEME", "", 13, new Font("Tahoma", 11f, FontStyle.Bold), Color.DarkSlateGray);
                    AddTableRow(tableLayout, "Günlük Oda Ücreti:", oda?.OdaFiyati.ToString("C2"), 14, labelFont, labelColor);
                    AddTableRow(tableLayout, "Toplam Tutar:", fatura.ToplamUcret.ToString("C2"), 15, labelFont, labelColor);

                    contentPanel.Controls.Add(tableLayout);
                    faturaForm.Controls.Add(marginPanel);
                    faturaForm.Controls.Add(lblBaslik);

                    faturaForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fatura detayı gösterilirken hata oluştu: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddTableRow(TableLayoutPanel table, string label, string value, int row, Font font, Color color)
        {
            Label lblTitle = new Label
            {
                Text = label,
                Font = font,
                ForeColor = color,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleRight,
                Padding = new Padding(5),
                AutoSize = true, // Otomatik boyutlandırma ekledik
                MinimumSize = new Size(0, 30) // Minimum yükseklik ekledik
            };

            Label lblValue = new Label
            {
                Text = value,
                Font = font,
                ForeColor = color,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(5),
                AutoSize = true, // Otomatik boyutlandırma ekledik
                MinimumSize = new Size(0, 30) // Minimum yükseklik ekledik
            };

            table.Controls.Add(lblTitle, 0, row);
            table.Controls.Add(lblValue, 1, row);
        }


        private void gorBtn_Click(object sender, EventArgs e)
        {
            if (dataGridFatura.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir fatura seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int faturaId = Convert.ToInt32(dataGridFatura.SelectedRows[0].Cells["Fatura_No"].Value);
                FaturaDetayiniGoster(faturaId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fatura görüntülenirken hata oluştu: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridFatura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridFatura.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}