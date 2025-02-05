using System;

namespace HotelReservationandManagementSystem.EntityLayer
{
    public class Musteriler
    {
        private int musteri_id;
        private string ad_soyad;
        private string telefon;
        private string email;
        private DateTime kayit_tarihi;

        public int MusteriId
        {
            get => musteri_id;
            set => musteri_id = value;
        }

        public string AdSoyad
        {
            get => ad_soyad;
            set => ad_soyad = value;
        }

        public string Telefon
        {
            get => telefon;
            set => telefon = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public DateTime KayitTarihi
        {
            get => kayit_tarihi;
            set => kayit_tarihi = value;
        }
    }
}