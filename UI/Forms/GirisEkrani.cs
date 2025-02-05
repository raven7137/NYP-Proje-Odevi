using System;
using System.Windows.Forms;
using HotelReservationandManagementSystem.ServiceLayer;
using HotelReservationandManagementSystem.EntityLayer;

namespace nypdeniz.UI.Forms
{
    public partial class GirisEkrani : Form
    {
        private OtelService otelService; // OtelService nesnesi

        public GirisEkrani()
        {
            InitializeComponent();
            otelService = new OtelService(); // OtelService nesnesini başlatıyoruz
        }

        private void kayitOlusturBtn_Click(object sender, EventArgs e)
        {
            YoneticiKayitEkrani yoneticiKayitFormu = new YoneticiKayitEkrani();
            yoneticiKayitFormu.Show();
            this.Hide();
        }

        private void girisYapBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcı giriş bilgilerini alıyoruz
                string TcNo = tcNoTxtbox.Text;
                string sifre = sifreTxtbox.Text;

                // Giriş metodunu çağırıyoruz
                Yoneticiler yonetici = otelService.YoneticiGiris(TcNo, sifre);

                if (yonetici != null)
                {

                    // Ana ekrana geçiş
                    AnaMenu anaEkran = new AnaMenu();
                    anaEkran.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Giriş sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
