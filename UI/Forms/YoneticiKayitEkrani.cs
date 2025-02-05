using HotelReservationandManagementSystem.EntityLayer;
using HotelReservationandManagementSystem.ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nypdeniz.UI.Forms
{
    public partial class YoneticiKayitEkrani : Form
    {
        public YoneticiKayitEkrani()
        {
            InitializeComponent();
        }

        private void kayitOlusturBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Yeni bir Yoneticiler nesnesi oluştur
                Yoneticiler yeniYonetici = new Yoneticiler
                {
                    Isim = isimTxtbox.Text,
                    Soyisim = soyisimTxtbox.Text,
                    TcNo = tcNo2Txtbox.Text,
                    Telefon = telNoTxtbox.Text,
                    Sifre = sifreTxtbox.Text
                };

                // OtelService üzerinden yönetici ekle
                OtelService otelService = new OtelService();
                otelService.YoneticiEkle(yeniYonetici);

                MessageBox.Show("Yönetici başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Kayıt ekranını kapat
                GirisEkrani girisEkrani = new GirisEkrani();
                girisEkrani.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
