using System;

namespace HotelReservationandManagementSystem.EntityLayer
{
    public class Odalar
    {
        private int oda_id;
        private string oda_numarasi;
        private string oda_tipi;
        private decimal oda_fiyat;
        private bool doluluk_durumu;

        public int OdaId
        {
            get => oda_id;
            set => oda_id = value;
        }

        public string OdaNumarasi
        {
            get => oda_numarasi;
            set => oda_numarasi = value;
        }

        public string OdaTipi
        {
            get => oda_tipi;
            set => oda_tipi = value;
        }

        public decimal OdaFiyati
        {
            get => oda_fiyat;
            set => oda_fiyat = value;
        }

        public bool DolulukDurumu
        {
            get => doluluk_durumu;
            set => doluluk_durumu = value;
        }
    }
}
