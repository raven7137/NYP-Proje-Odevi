# Otel Yönetim Sistemi

## Proje Açıklaması

Bu proje, bir otel yönetim sistemini yönetmek için geliştirilen bir C# .NET Framework Windows Forms uygulamasıdır. N Katmanlı Mimari kullanılarak tasarlanmış olup, müşteri, oda, rezervasyon, fatura ve yönetici işlemlerini kapsamaktadır.

## Proje Katmanları

Proje N Katmanlı Mimari kullanılarak aşağıdaki katmanlara ayrılmıştır:

### Entity (Varlık) Katmanı:

 * Musteri.cs

 * Oda.cs

 * Rezervasyon.cs

 * Fatura.cs

 * Yonetici.cs

### Data Access Layer (DAL) - Veri Erişim Katmanı:

 * MusteriDAL.cs

 * OdaDAL.cs

 * RezervasyonDAL.cs

 * FaturaDAL.cs

 * YoneticiDAL.cs

 * DbBaglanti.cs (Veritabanı bağlantısı)

### Service Layer - İş Mantığı Katmanı:

 * MusteriService.cs

 * OdaService.cs

 * RezervasyonService.cs

 * FaturaService.cs

 * YoneticiService.cs

### Presentation Layer (UI) - Sunum Katmanı:

 * Windows Forms arayüzü (Müşteri, Oda, Rezervasyon vb. işlemleri için formlar)

## Kullanıcı Rolleri ve İşlevler

Proje, yönetici rolüne sahip kullanıcılar tarafından kullanılmaktadır. Yönetici aşağıdaki işlemleri gerçekleştirebilir:

1. Yönetici İşlemleri

 * Kayıt olma ve giriş yapma

![image](https://github.com/user-attachments/assets/7a832213-a3de-4a00-8958-a8fb4a0a2dce)

![image](https://github.com/user-attachments/assets/c1e6ea3a-2ed7-4c48-be93-3a4d24975bfe)

2. Müşteri Yönetimi

 * Yeni müşteri ekleme

 * Mevcut müşteri bilgilerini güncelleme

 * Müşteri silme

![image](https://github.com/user-attachments/assets/cf47826e-272e-4785-a7db-e9d4891bcf18)

3. Oda Yönetimi

 * Oda ekleme

 * Oda bilgilerini güncelleme

 * Oda silme

![image](https://github.com/user-attachments/assets/e3f5ff27-bed0-4abc-a855-72ad79ac0d43)

4. Rezervasyon Yönetimi

 * Yeni rezervasyon oluşturma

 * Rezervasyon silme

![image](https://github.com/user-attachments/assets/5e00e029-341a-477c-bab0-af3ff22513bf)

5. Fatura Yönetimi

 * Faturaları listeleme ve görüntüleme

![image](https://github.com/user-attachments/assets/c21fc7f0-a413-4c82-be30-e6797757de21)

![image](https://github.com/user-attachments/assets/d82c429e-f6a1-4cd3-b85f-41ae8cec5ae9)

## Veritabanı Tasarımı

Proje MySQL veritabanı kullanılarak geliştirilmiştir. Veritabanı Şeması:

` Musteriler (musteri_id, ad_soyad, telefon, email, kayit_tarihi) `

` Odalar (oda_id, oda_numarasi, oda_tipi, oda_fiyat, doluluk_durumu) `

` Rezervasyonlar (rezervasyon_id, musteri_id, oda_id, giris_tarihi, cikis_tarihi, toplam_ucret) `

` Faturalar (fatura_id, rezervasyon_id, fatura_tarihi, toplam_ucret) `

` Yoneticiler (yonetici_id, isim, soyisim, tc_no, sifre, telefon) `

![image](https://github.com/user-attachments/assets/7bdf574d-f977-44ca-9a76-3339e040d16d)

## Kullanılan Diyagramlar

### UML Diyagramı

![denizuml](https://github.com/user-attachments/assets/0b2e5d41-5de5-485f-a14f-b69a3dc7a815)

### ER Diyagramı

![denizer](https://github.com/user-attachments/assets/10e8d60e-c809-478a-8bc8-4e5f5db34bca)

### Use-Case Diyagramı

![denizusecase](https://github.com/user-attachments/assets/60c3cde3-4051-4234-8e20-acef98416cb5)


