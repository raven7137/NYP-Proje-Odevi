using System;

namespace HotelReservationandManagementSystem.EntityLayer
{
    public class Yoneticiler
    {
        private int yonetici_id;
        private string isim;
        private string soyisim;
        private string tc_no;
        private string telefon;
        private string kullanici_adi;
        private string sifre;

        public int YoneticiId
        {
            get => yonetici_id;
            set => yonetici_id = value;
        }

        public string Isim
        {
            get => isim;
            set => isim = value;
        }

        public string Soyisim
        {
            get => soyisim;
            set => soyisim = value;
        }

        public string TcNo
        {
            get => tc_no;
            set => tc_no = value;
        }

        public string Telefon
        {
            get => telefon;
            set => telefon = value;
        }

        public string KullaniciAdi
        {
            get => kullanici_adi;
            set => kullanici_adi = value;
        }

        public string Sifre
        {
            get => sifre;
            set => sifre = value;
        }
    }
}
