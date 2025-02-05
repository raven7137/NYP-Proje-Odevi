using HotelReservationandManagementSystem.DAL;
using HotelReservationandManagementSystem.EntityLayer;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelReservationandManagementSystem.ServiceLayer
{
    public class OtelService
    {
        private OtelDAL otelDAL = new OtelDAL();

        public List<Yoneticiler> YoneticileriGetir()
        {
            try
            {
                return otelDAL.YoneticileriGetir();
            }
            catch (Exception ex)
            {
                throw new Exception("Yöneticiler getirilirken hata oluştu: " + ex.Message);
            }
        }

        public void YoneticiEkle(Yoneticiler yonetici)
        {
            try
            {
                otelDAL.YoneticiEkle(yonetici);
            }
            catch (Exception ex)
            {
                throw new Exception("Yönetici eklenirken hata oluştu: " + ex.Message);
            }
        }

        public Yoneticiler YoneticiGiris(string tcNo, string sifre)
        {
            try
            {
                return otelDAL.YoneticiGiris(tcNo, sifre);
            }
            catch (Exception ex)
            {
                throw new Exception("Giriş yapılırken bir hata oluştu: " + ex.Message);
            }
        }

        public List<Musteriler> MusterileriGetir()
        {
            try
            {
                return otelDAL.MusterileriGetir();
            }
            catch (Exception ex)
            {
                throw new Exception("Müşteriler getirilirken hata oluştu: " + ex.Message);
            }
        }

        public void MusteriEkle(Musteriler musteri)
        {
            try
            {
                musteri.KayitTarihi = DateTime.Now;
                otelDAL.MusteriEkle(musteri);
            }
            catch (Exception ex)
            {
                throw new Exception("Müşteri eklenirken hata oluştu: " + ex.Message);
            }
        }

        public void MusteriGuncelle(Musteriler musteri)
        {
            try
            {
                otelDAL.MusteriGuncelle(musteri);
            }
            catch (Exception ex)
            {
                throw new Exception("Müşteri güncellenirken hata oluştu: " + ex.Message);
            }
        }

        public void MusteriSil(int musteriId)
        {
            try
            {
                otelDAL.MusteriSil(musteriId);
            }
            catch (Exception ex)
            {
                throw new Exception("Müşteri silinirken hata oluştu: " + ex.Message);
            }
        }

        public List<Odalar> OdalariGetir()
        {
            try
            {
                return otelDAL.OdalariGetir();
            }
            catch (Exception ex)
            {
                throw new Exception("Odalar getirilirken hata oluştu: " + ex.Message);
            }
        }

        public void OdaEkle(Odalar oda)
        {
            try
            {
                otelDAL.OdaEkle(oda);
            }
            catch (Exception ex)
            {
                throw new Exception("Oda eklenirken hata oluştu: " + ex.Message);
            }
        }

        public void OdaGuncelle(Odalar oda)
        {
            try
            {
                otelDAL.OdaGuncelle(oda);
            }
            catch (Exception ex)
            {
                throw new Exception("Oda güncellenirken hata oluştu: " + ex.Message);
            }
        }

        public void OdaSil(int odaId)
        {
            try
            {
                otelDAL.OdaSil(odaId);
            }
            catch (Exception ex)
            {
                throw new Exception("Oda silinirken hata oluştu: " + ex.Message);
            }
        }

        public List<Rezervasyonlar> RezervasyonlariGetir()
        {
            try
            {
                return otelDAL.RezervasyonlariGetir();
            }
            catch (Exception ex)
            {
                throw new Exception("Rezervasyonlar getirilirken hata oluştu: " + ex.Message);
            }
        }

        public void RezervasyonEkle(Rezervasyonlar rezervasyon)
        {
            try
            {
                otelDAL.RezervasyonEkle(rezervasyon);
            }
            catch (Exception ex)
            {
                throw new Exception("Rezervasyon eklenirken hata oluştu: " + ex.Message);
            }
        }

        public void RezervasyonSil(int rezervasyonId)
        {
            try
            {
                otelDAL.RezervasyonSil(rezervasyonId);
            }
            catch (Exception ex)
            {
                throw new Exception("Rezervasyon silinirken hata oluştu: " + ex.Message);
            }
        }


        public List<Faturalar> FaturalariGetir()
        {
            try
            {
                return otelDAL.FaturalariGetir();
            }
            catch (Exception ex)
            {
                throw new Exception("Faturalar getirilirken hata oluştu: " + ex.Message);
            }
        }

        public int RezervasyonVeFaturaEkle(Rezervasyonlar rezervasyon)
        {
            using (MySqlConnection baglanti = new dbBaglanti().BaglantiGetir())
            {
                baglanti.Open();
                using (MySqlTransaction transaction = baglanti.BeginTransaction())
                {
                    try
                    {
                        int rezervasyonId = otelDAL.RezervasyonEkleVeIdGetir(rezervasyon, baglanti, transaction);

                        Faturalar fatura = new Faturalar
                        {
                            RezervasyonID = rezervasyonId,
                            FaturaTarihi = DateTime.Now,
                            ToplamUcret = rezervasyon.ToplamUcret
                        };

                        otelDAL.FaturaEkleTransactionIle(fatura, baglanti, transaction);

                        transaction.Commit();
                        return rezervasyonId;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Rezervasyon ve fatura ekleme işlemi başarısız: " + ex.Message);
                    }
                }
            }
        }

    }
}
