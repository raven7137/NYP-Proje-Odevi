using System;

namespace HotelReservationandManagementSystem.EntityLayer
{
    public class Rezervasyonlar
    {
        private int rezervasyon_id;
        private int musteri_id;
        private int oda_id;
        private DateTime giris_tarihi;
        private DateTime cikis_tarihi;
        private decimal toplam_ucret;

        public string MusteriAdSoyad { get; set; }
        public string OdaNumarasi { get; set; }

        public int RezervasyonId
        {
            get => rezervasyon_id;
            set => rezervasyon_id = value;
        }

        public int MusteriId
        {
            get => musteri_id;
            set => musteri_id = value;
        }

        public int OdaId
        {
            get => oda_id;
            set => oda_id = value;
        }

        public DateTime GirisTarihi
        {
            get => giris_tarihi;
            set => giris_tarihi = value;
        }

        public DateTime CikisTarihi
        {
            get => cikis_tarihi;
            set => cikis_tarihi = value;
        }

        public decimal ToplamUcret
        {
            get => toplam_ucret;
            set => toplam_ucret = value;
        }
    }
}
