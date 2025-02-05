using System;
using System.Windows.Forms;
using HotelReservationandManagementSystem.EntityLayer;
using nypdeniz.UI.UserControls;

namespace nypdeniz.UI.Forms
{
    public partial class AnaMenu : Form
    {
        // UserControl'leri tanımla
        private RezervasyonIslemleri rezervasyonIslemleri;
        private OdaControl odaControl;
        private FaturaBilgileri faturaBilgileri;
        private MusteriControl musteriler;

        public AnaMenu()
        {
            InitializeComponent();
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {
            // panel2'yi başlangıçta gizle
            panel2.Hide();

            // UserControl'leri oluştur ve panel2'nin boyutuna göre ayarla
            rezervasyonIslemleri = new RezervasyonIslemleri();
            rezervasyonIslemleri.Size = panel2.Size; // panel2'nin boyutunu al
            rezervasyonIslemleri.Location = panel2.Location;
            this.Controls.Add(rezervasyonIslemleri);

            odaControl = new OdaControl();
            odaControl.Size = panel2.Size; // panel2'nin boyutunu al
            odaControl.Location = panel2.Location;
            this.Controls.Add(odaControl);

            faturaBilgileri = new FaturaBilgileri();
            faturaBilgileri.Size = panel2.Size; // panel2'nin boyutunu al
            faturaBilgileri.Location = panel2.Location; // Lokasyon ayarı
            this.Controls.Add(faturaBilgileri);

            musteriler = new MusteriControl();
            musteriler.Size = panel2.Size; // panel2'nin boyutunu al
            musteriler.Location = panel2.Location; // Lokasyon ayarı
            this.Controls.Add(musteriler);

            // Başlangıçta tüm UserControl'leri gizle
            rezervasyonIslemleri.Hide();
            odaControl.Hide();
            faturaBilgileri.Hide();
            musteriler.Hide();
        }

        private void GizlemeIslemi()
        {
            // İşlem labelını gizle
            islemLbl.Hide();

            // Tüm UserControl'leri gizle
            rezervasyonIslemleri.Hide();
            odaControl.Hide();
            faturaBilgileri.Hide();
            musteriler.Hide();
        }

        private void rezervBtn_Click(object sender, EventArgs e)
        {
            GizlemeIslemi();
            rezervasyonIslemleri.Show();
        }

        private void odaBtn_Click(object sender, EventArgs e)
        {
            GizlemeIslemi();
            odaControl.Show();
        }

        private void musteriBtn_Click(object sender, EventArgs e)
        {
            GizlemeIslemi();
            musteriler.Show();
        }

        private void faturaBtn_Click(object sender, EventArgs e)
        {
            GizlemeIslemi();
            faturaBilgileri.Show();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            // Uygulamayı kapat
            Application.Exit();
        }

        private void yapilacakIslemLbl_Click(object sender, EventArgs e)
        {
            // Gerekirse bir şey yapılabilir
        }
    }
}