using System;

namespace HotelReservationandManagementSystem.EntityLayer
{
    public class Faturalar
    {
        private int fatura_id;
        private int rezervasyon_id;
        private DateTime fatura_tarihi;
        private decimal toplam_ucret;

        public int FaturaId
        {
            get => fatura_id;
            set => fatura_id = value;
        }

        public int RezervasyonID
        {
            get => rezervasyon_id;
            set => rezervasyon_id = value;
        }

        public DateTime FaturaTarihi
        {
            get => fatura_tarihi;
            set => fatura_tarihi = value;
        }

        public decimal ToplamUcret
        {
            get => toplam_ucret;
            set => toplam_ucret = value;
        }
    }
}