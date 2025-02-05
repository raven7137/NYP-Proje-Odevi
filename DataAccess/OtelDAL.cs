using MySql.Data.MySqlClient;
using HotelReservationandManagementSystem.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HotelReservationandManagementSystem.DAL
{
    public class OtelDAL
    {
        private dbBaglanti dbBaglanti = new dbBaglanti();

        public List<Yoneticiler> YoneticileriGetir()
        {
            List<Yoneticiler> yoneticiler = new List<Yoneticiler>();
            using (MySqlConnection baglanti = dbBaglanti.BaglantiGetir())
            {
                baglanti.Open();
                string sorgu = "SELECT * FROM Yoneticiler";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);

                using (MySqlDataReader reader = komut.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Yoneticiler yonetici = new Yoneticiler
                        {
                            YoneticiId = reader.GetInt32("yonetici_id"),
                            TcNo = reader.GetString("tc_no"),
                            Sifre = reader.GetString("sifre")
                        };
                        yoneticiler.Add(yonetici);
                    }
                }
            }
            return yoneticiler;
        }

        public void YoneticiEkle(Yoneticiler yonetici)
        {
            using (MySqlConnection baglanti = dbBaglanti.BaglantiGetir())
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "INSERT INTO Yoneticiler (isim, soyisim, tc_no, telefon, sifre) " +
                                   "VALUES (@Isim, @Soyisim, @TcNo, @Telefon, @Sifre)";
                    MySqlCommand komut = new MySqlCommand(sorgu, baglanti);

                    // Parametreler
                    komut.Parameters.AddWithValue("@Isim", yonetici.Isim);
                    komut.Parameters.AddWithValue("@Soyisim", yonetici.Soyisim);
                    komut.Parameters.AddWithValue("@TcNo", yonetici.TcNo);
                    komut.Parameters.AddWithValue("@Telefon", yonetici.Telefon);
                    komut.Parameters.AddWithValue("@Sifre", yonetici.Sifre);

                    komut.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Yönetici eklenirken hata oluştu: " + ex.Message);
                }
            }
        }


        public Yoneticiler YoneticiGiris(string tcno, string sifre)
        {
            Yoneticiler yonetici = null;
            using (MySqlConnection baglanti = dbBaglanti.BaglantiGetir())
            {
                baglanti.Open();
                string sorgu = "SELECT * FROM Yoneticiler WHERE tc_no = @TcNo AND sifre = @Sifre";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@TcNo", tcno);
                komut.Parameters.AddWithValue("@Sifre", sifre);

                using (MySqlDataReader reader = komut.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        yonetici = new Yoneticiler
                        {
                            YoneticiId = reader.GetInt32("yonetici_id"),
                            TcNo = reader.GetString("tc_no"),
                            Sifre = reader.GetString("sifre")
                        };
                    }
                }
            }
            return yonetici;
        }

        public List<Musteriler> MusterileriGetir()
        {
            List<Musteriler> musteriler = new List<Musteriler>();
            using (MySqlConnection baglanti = dbBaglanti.BaglantiGetir())
            {
                baglanti.Open();
                string sorgu = "SELECT * FROM Musteriler";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);

                using (MySqlDataReader reader = komut.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Musteriler musteri = new Musteriler
                        {
                            MusteriId = reader.GetInt32("musteri_id"),
                            AdSoyad = reader.GetString("ad_soyad"),
                            Telefon = reader.GetString("telefon"),
                            Email = reader.IsDBNull(reader.GetOrdinal("email")) ? null : reader.GetString("email"),
                            KayitTarihi = reader.GetDateTime("kayit_tarihi")
                        };
                        musteriler.Add(musteri);
                    }
                }
            }
            return musteriler;
        }

        public void MusteriEkle(Musteriler musteri)
        {
            using (MySqlConnection baglanti = dbBaglanti.BaglantiGetir())
            {
                baglanti.Open();
                string sorgu = "INSERT INTO Musteriler (ad_soyad, telefon, email, kayit_tarihi) VALUES (@AdSoyad, @Telefon, @Email, @KayitTarihi)";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@AdSoyad", musteri.AdSoyad);
                komut.Parameters.AddWithValue("@Telefon", musteri.Telefon);
                komut.Parameters.AddWithValue("@Email", musteri.Email ?? (object)DBNull.Value);
                komut.Parameters.AddWithValue("@KayitTarihi", musteri.KayitTarihi);
                komut.ExecuteNonQuery();
            }
        }

        public void MusteriGuncelle(Musteriler musteri)
        {
            using (MySqlConnection baglanti = dbBaglanti.BaglantiGetir())
            {
                baglanti.Open();
                string sorgu = "UPDATE Musteriler SET ad_soyad = @AdSoyad, telefon = @Telefon, email = @Email WHERE musteri_id = @MusteriId";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@AdSoyad", musteri.AdSoyad);
                komut.Parameters.AddWithValue("@Telefon", musteri.Telefon);
                komut.Parameters.AddWithValue("@Email", musteri.Email ?? (object)DBNull.Value);
                komut.Parameters.AddWithValue("@MusteriId", musteri.MusteriId);
                komut.ExecuteNonQuery();
            }
        }

        public void MusteriSil(int musteriId)
        {
            using (MySqlConnection baglanti = dbBaglanti.BaglantiGetir())
            {
                baglanti.Open();
                string sorgu = "DELETE FROM Musteriler WHERE musteri_id = @MusteriId";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@MusteriId", musteriId);
                komut.ExecuteNonQuery();
            }
        }

        public List<Odalar> OdalariGetir()
        {
            List<Odalar> odalar = new List<Odalar>();
            using (MySqlConnection baglanti = dbBaglanti.BaglantiGetir())
            {
                baglanti.Open();
                string sorgu = "SELECT * FROM Odalar";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);

                using (MySqlDataReader reader = komut.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Odalar oda = new Odalar
                        {
                            OdaId = reader.GetInt32("oda_id"),
                            OdaNumarasi = reader.GetString("oda_numarasi"),
                            OdaTipi = reader.GetString("oda_tipi"),
                            OdaFiyati = reader.GetDecimal("oda_fiyat"),
                            DolulukDurumu = reader.GetBoolean("doluluk_durumu")
                        };
                        odalar.Add(oda);
                    }
                }
            }
            return odalar;
        }

        public void OdaEkle(Odalar oda)
        {
            using (MySqlConnection baglanti = dbBaglanti.BaglantiGetir())
            {
                baglanti.Open();
                string sorgu = "INSERT INTO Odalar (oda_numarasi, oda_tipi, oda_fiyat, doluluk_durumu) " +
                               "VALUES (@OdaNumarasi, @OdaTipi, @OdaFiyati, @DolulukDurumu)";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@OdaNumarasi", oda.OdaNumarasi);
                komut.Parameters.AddWithValue("@OdaTipi", oda.OdaTipi);
                komut.Parameters.AddWithValue("@OdaFiyati", oda.OdaFiyati);
                komut.Parameters.AddWithValue("@DolulukDurumu", oda.DolulukDurumu);
                komut.ExecuteNonQuery();
            }
        }

        public void OdaGuncelle(Odalar oda)
        {
            using (MySqlConnection baglanti = dbBaglanti.BaglantiGetir())
            {
                baglanti.Open();
                string sorgu = "UPDATE Odalar SET oda_numarasi = @OdaNumarasi, oda_tipi = @OdaTipi, oda_fiyat = @OdaFiyati, doluluk_durumu = @DolulukDurumu WHERE oda_id = @OdaId";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@OdaNumarasi", oda.OdaNumarasi);
                komut.Parameters.AddWithValue("@OdaTipi", oda.OdaTipi);
                komut.Parameters.AddWithValue("@OdaFiyati", oda.OdaFiyati);
                komut.Parameters.AddWithValue("@DolulukDurumu", oda.DolulukDurumu);
                komut.Parameters.AddWithValue("@OdaId", oda.OdaId);
                komut.ExecuteNonQuery();
            }
        }

        public void OdaSil(int odaId)
        {
            using (MySqlConnection baglanti = dbBaglanti.BaglantiGetir())
            {
                baglanti.Open();
                string sorgu = "DELETE FROM Odalar WHERE oda_id = @OdaId";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@OdaId", odaId);
                komut.ExecuteNonQuery();
            }
        }

        public List<Rezervasyonlar> RezervasyonlariGetir()
        {
            List<Rezervasyonlar> rezervasyonlar = new List<Rezervasyonlar>();
            using (MySqlConnection baglanti = dbBaglanti.BaglantiGetir())
            {
                baglanti.Open();
                string sorgu = "SELECT * FROM Rezervasyonlar";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);

                using (MySqlDataReader reader = komut.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Rezervasyonlar rezervasyon = new Rezervasyonlar
                        {
                            RezervasyonId = reader.GetInt32("rezervasyon_id"),
                            MusteriId = reader.GetInt32("musteri_id"),
                            OdaId = reader.GetInt32("oda_id"),
                            GirisTarihi = reader.GetDateTime("giris_tarihi"),
                            CikisTarihi = reader.GetDateTime("cikis_tarihi"),
                            ToplamUcret = reader.GetDecimal("toplam_ucret")
                        };
                        rezervasyonlar.Add(rezervasyon);
                    }
                }
            }
            return rezervasyonlar;
        }

        public void RezervasyonEkle(Rezervasyonlar rezervasyon)
        {
            using (MySqlConnection baglanti = dbBaglanti.BaglantiGetir())
            {
                baglanti.Open();
                string sorgu = "INSERT INTO Rezervasyonlar (musteri_id, oda_id, giris_tarihi, cikis_tarihi, toplam_ucret) " +
                               "VALUES (@MusteriId, @OdaId, @GirisTarihi, @CikisTarihi, @ToplamUcret)";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@MusteriId", rezervasyon.MusteriId);
                komut.Parameters.AddWithValue("@OdaId", rezervasyon.OdaId);
                komut.Parameters.AddWithValue("@GirisTarihi", rezervasyon.GirisTarihi);
                komut.Parameters.AddWithValue("@CikisTarihi", rezervasyon.CikisTarihi);
                komut.Parameters.AddWithValue("@ToplamUcret", rezervasyon.ToplamUcret);
                komut.ExecuteNonQuery();
            }
        }

        public void RezervasyonSil(int rezervasyonId)
        {
            using (MySqlConnection baglanti = dbBaglanti.BaglantiGetir())
            {
                baglanti.Open();
                string sorgu = "DELETE FROM Rezervasyonlar WHERE rezervasyon_id = @RezervasyonId";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@RezervasyonId", rezervasyonId);
                komut.ExecuteNonQuery();
            }
        }

        public List<Faturalar> FaturalariGetir()
        {
            List<Faturalar> faturalar = new List<Faturalar>();
            using (MySqlConnection baglanti = dbBaglanti.BaglantiGetir())
            {
                baglanti.Open();
                string sorgu = "SELECT * FROM Faturalar";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);

                using (MySqlDataReader reader = komut.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Faturalar fatura = new Faturalar
                        {
                            FaturaId = reader.GetInt32("fatura_id"),
                            RezervasyonID = reader.GetInt32("rezervasyon_id"),
                            FaturaTarihi = reader.GetDateTime("fatura_tarihi"),
                            ToplamUcret = reader.GetDecimal("toplam_ucret")
                        };
                        faturalar.Add(fatura);
                    }
                }
            }
            return faturalar;
        }

        public void FaturaEkle(Faturalar fatura)
        {
            using (MySqlConnection baglanti = dbBaglanti.BaglantiGetir())
            {
                baglanti.Open();
                string sorgu = "INSERT INTO Faturalar (rezervasyon_id, fatura_tarihi, toplam_ucret) " +
                               "VALUES (@RezervasyonId, @FaturaTarihi, @ToplamUcret)";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@RezervasyonId", fatura.RezervasyonID);
                komut.Parameters.AddWithValue("@FaturaTarihi", fatura.FaturaTarihi);
                komut.Parameters.AddWithValue("@ToplamUcret", fatura.ToplamUcret);
                komut.ExecuteNonQuery();
            }
        }

        public int RezervasyonEkleVeIdGetir(Rezervasyonlar rezervasyon, MySqlConnection baglanti, MySqlTransaction transaction)
        {
            string sorgu = @"INSERT INTO Rezervasyonlar (musteri_id, oda_id, giris_tarihi, cikis_tarihi, toplam_ucret) 
                        VALUES (@MusteriId, @OdaId, @GirisTarihi, @CikisTarihi, @ToplamUcret);
                        SELECT LAST_INSERT_ID();";

            MySqlCommand komut = new MySqlCommand(sorgu, baglanti, transaction);
            komut.Parameters.AddWithValue("@MusteriId", rezervasyon.MusteriId);
            komut.Parameters.AddWithValue("@OdaId", rezervasyon.OdaId);
            komut.Parameters.AddWithValue("@GirisTarihi", rezervasyon.GirisTarihi);
            komut.Parameters.AddWithValue("@CikisTarihi", rezervasyon.CikisTarihi);
            komut.Parameters.AddWithValue("@ToplamUcret", rezervasyon.ToplamUcret);

            return Convert.ToInt32(komut.ExecuteScalar());
        }

        public void FaturaEkleTransactionIle(Faturalar fatura, MySqlConnection baglanti, MySqlTransaction transaction)
        {
            string sorgu = "INSERT INTO Faturalar (rezervasyon_id, fatura_tarihi, toplam_ucret) VALUES (@RezervasyonId, @FaturaTarihi, @ToplamUcret)";

            MySqlCommand komut = new MySqlCommand(sorgu, baglanti, transaction);
            komut.Parameters.AddWithValue("@RezervasyonId", fatura.RezervasyonID);
            komut.Parameters.AddWithValue("@FaturaTarihi", fatura.FaturaTarihi);
            komut.Parameters.AddWithValue("@ToplamUcret", fatura.ToplamUcret);

            komut.ExecuteNonQuery();
        }
    }
}
