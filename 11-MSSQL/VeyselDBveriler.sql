-- 1. Admin
INSERT Admin (UserName, Password, Email, Telefon, AktifMi) VALUES
('ahmet_admin', 'Pass123!', 'ahmet@firma.com', '05321112233', 1),
('mehmet_admin', 'Pass456!', 'mehmet@firma.com', '05332223344', 1),
('zeynep_sistem', 'SysAdmin2026!', 'zeynep@firma.com', '05343334455', 1),
('can_destek', 'Support99!', 'can@firma.com', '05354445566', 1),
('esra_depo', 'DepoPass1!', 'esra@firma.com', '05365556677', 0);

-- 2. LogTablo
INSERT LogTablo (AdminID, TabloAdi, YapilanIslem, IslemTarihi, Aciklama) VALUES
(1, 'Urun', 'INSERT', '2026-10-01 10:00:00', 'Yeni ürün eklendi'),
(2, 'Musteri', 'UPDATE', '2026-10-02 11:30:00', 'Müşteri telefonu güncellendi'),
(3, 'Siparis', 'INSERT', '2026-10-02 14:15:00', 'Demir Bilişim siparişi girildi'),
(1, 'Fatura', 'INSERT', '2026-10-03 09:00:00', 'Fatura kesildi'),
(4, 'StokTablo', 'UPDATE', '2026-10-03 16:45:00', 'Kritik stok uyarısı tetiklendi'),
(2, 'Satinalma', 'INSERT', '2026-10-05 11:00:00', 'Yeni hammadde alımı işlendi');

-- 3. Boyut
INSERT Boyut (BoyutAdi) VALUES
('Küçük (S)'),
('Orta (M)'),
('Büyük (L)'),
('Ekstra Büyük (XL)'),
('Standart');

-- 4. Materyal
INSERT Materyal (MateryalAdi) VALUES
('Ahşap'),
('Metal'),
('Plastik'),
('Cam'),
('Deri');

-- 5. Kategori
INSERT Kategori (KategoriAdi) VALUES
('Ofis Mobilyası'),
('Aksesuar'),
('Aydınlatma'),
('Masaüstü Düzenleyici'),
('Ergonomi');

-- 6. Urun
INSERT Urun (MateryalID, BoyutID, UrunAdi, Aciklama, AktifMi) VALUES
(1, 2, 'Ahşap Çalışma Masası', 'Meşe kaplama ofis masası', 1),
(2, 3, 'Metal Kitaplık', '5 raflı endüstriyel kitaplık', 1),
(3, 1, 'Plastik Kalemlik', 'Masaüstü düzenleyici', 1),
(4, 5, 'Masa Lambası Cam', 'Dokunmatik LED çalışma lambası', 1),
(5, 2, 'Deri Ofis Koltuğu', 'Ergonomik yönetici koltuğu', 1),
(2, 5, 'Metal Ayaklı Lambader', 'Köşe aydınlatma', 1),
(1, 5, 'Ahşap Evrak Rafı', '3 katlı dosya düzenleyici', 1),
(3, 2, 'Ortopedik Sırt Desteği', 'Sandalye için bel desteği', 1);

-- 7. KategoriUrun
INSERT KategoriUrun (UrunID, KategoriID) VALUES
(1, 1),
(2, 1),
(3, 2),
(4, 3),
(5, 1),
(5, 5),
(6, 3),
(7, 4),
(8, 5);

-- 8. Tedarikci
INSERT Tedarikci (TedarikciAdi, Telefon, Email, Adres, VergiDairesi, VergiNo, AktifMi) VALUES
('Ağaç A.Ş.', '02123334455', 'info@agacas.com', 'İstanbul', 'Maslak', '1234567890', 1),
('Metal Sanayi Ltd.', '02164445566', 'satis@metalsanayi.com', 'Kocaeli', 'Gebze', '0987654321', 1),
('Cam & Aydınlatma A.Ş.', '02325556677', 'iletisim@camaydinlatma.com', 'İzmir', 'Konak', '4567891230', 1),
('Plastik Kalıp San.', '02246667788', 'siparis@plastikkalip.com', 'Bursa', 'Nilüfer', '7891234560', 1),
('Deri Tekstil Ltd.', '02127778899', 'info@deritekstil.com', 'İstanbul', 'Zeytinburnu', '3216549870', 1);

-- 9. Satinalma
INSERT Satinalma (UrunID, TedarikciID, Adet, BirimFiyat, ToplamFiyat, KDVOrani, SatinAlmaTarihi) VALUES
(1, 1, 10, 1500.00, 15000.00, 20.00, '2026-09-15'),
(2, 2, 20, 800.00, 16000.00, 20.00, '2026-09-20'),
(4, 3, 30, 250.00, 7500.00, 20.00, '2026-09-22'),
(5, 5, 15, 3000.00, 45000.00, 20.00, '2026-09-25'),
(3, 4, 100, 40.00, 4000.00, 20.00, '2026-09-28'),
(7, 1, 25, 200.00, 5000.00, 20.00, '2026-09-30');

-- 10. StokTablo
INSERT StokTablo (UrunID, Stok, AlarmSeviyesi, StokAlarm) VALUES
(1, 15, 5, 0),
(2, 3, 5, 1),
(3, 50, 10, 0),
(4, 22, 5, 0),
(5, 8, 3, 0),
(6, 2, 4, 1),
(7, 18, 5, 0),
(8, 40, 10, 0);

-- 11. ListeFiyat
INSERT ListeFiyat (UrunID, BirimFiyat, GuncellemeTarihi) VALUES
(1, 2500.00, '2026-09-01'),
(2, 1200.00, '2026-09-01'),
(3, 150.00, '2026-09-01'),
(4, 500.00, '2026-09-01'),
(5, 5000.00, '2026-09-01'),
(6, 950.00, '2026-09-01'),
(7, 350.00, '2026-09-01'),
(8, 200.00, '2026-09-01');

-- 12. Musteri
INSERT Musteri (MusteriFirma, YetkiliAdSoyad, Telefon, Email, Adres, Toptanmi, IskontoOran, AktifMi) VALUES
('Yılmaz A.Ş.', 'Ali Yılmaz', '05551112233', 'ali@yilminas.com', 'Ankara', 1, 10.00, 1),
('Kaya Ticaret', 'Ayşe Kaya', '05552223344', 'ayse@kayaticaret.com', 'İzmir', 0, 0.00, 1),
('Demir Bilişim', 'Burak Demir', '05553334455', 'burak@demirbilisim.com', 'İstanbul', 1, 15.00, 1),
('Şahin Mimarlık', 'Selin Şahin', '05554445566', 'selin@sahinmimarlik.com', 'Bursa', 1, 5.00, 1),
('Öztürk Lojistik', 'Murat Öztürk', '05555556677', 'murat@ozturklojistik.com', 'Antalya', 0, 0.00, 1),
('Aydın Hukuk Bürosu', 'Ceren Aydın', '05556667788', 'ceren@aydinhukuk.com', 'Ankara', 0, 0.00, 1),
('Tekin Danışmanlık', 'Emre Tekin', '05557778899', 'emre@tekindanismanlik.com', 'Eskişehir', 1, 10.00, 1),
('Koç Mühendislik', 'Deniz Koç', '05558889900', 'deniz@kocmuhendislik.com', 'Kocaeli', 0, 0.00, 0);

-- 13. Siparis
INSERT Siparis (MusteriID, UrunID, Adet, ListeSatisFiyat, BirimFiyat, ToplamSatisFiyat, KDV, Aciklama, SiparisTarihi) VALUES
(1, 1, 2, 2500.00, 2250.00, 4500.00, 20.00, 'İskontolu toptan satış', '2026-10-01'),
(2, 3, 5, 150.00, 150.00, 750.00, 20.00, 'Perakende sipariş', '2026-10-02'),
(3, 5, 3, 5000.00, 4250.00, 12750.00, 20.00, 'Yönetici koltuğu alımı', '2026-10-02'),
(4, 2, 1, 1200.00, 1140.00, 1140.00, 20.00, '%5 özel indirim', '2026-10-03'),
(5, 4, 2, 500.00, 500.00, 1000.00, 20.00, 'Ofis aydınlatma', '2026-10-03'),
(6, 7, 4, 350.00, 350.00, 1400.00, 20.00, 'Masaüstü düzenleyici siparişi', '2026-10-04'),
(7, 1, 1, 2500.00, 2250.00, 2250.00, 20.00, 'Toptan indirimli', '2026-10-04'),
(1, 8, 10, 200.00, 180.00, 1800.00, 20.00, 'Sırt desteği toplu alım', '2026-10-05'),
(2, 6, 1, 950.00, 950.00, 950.00, 20.00, 'Hızlı teslimat rica edildi', '2026-10-05'),
(3, 3, 20, 150.00, 127.50, 2550.00, 20.00, 'Promosyon ürün alımı', '2026-10-06');

-- 14. OdemeTipi
INSERT OdemeTipi (OdemeTipiAdi) VALUES
('Kredi Kartı'),
('Havale/EFT'),
('Nakit'),
('Çek');

-- 15. Fatura
INSERT Fatura (FaturaNo, SiparisID, FaturaTarihi, OdenmeDurumu, OdemeTipiID, Aciklama) VALUES
('FAT2026000000001', 1, '2026-10-01', 1, 2, 'Ödeme alındı'),
('FAT2026000000002', 2, '2026-10-02', 0, 1, 'Ödeme bekleniyor'),
('FAT2026000000003', 3, '2026-10-02', 1, 4, '15 gün vadeli çek alındı'),
('FAT2026000000004', 4, '2026-10-03', 1, 1, 'Kredi kartı tek çekim'),
('FAT2026000000005', 5, '2026-10-03', 0, 2, 'Havale bekleniyor'),
('FAT2026000000006', 6, '2026-10-04', 1, 3, 'Nakit tahsil edildi'),
('FAT2026000000007', 7, '2026-10-04', 1, 2, 'EFT ile ödendi'),
('FAT2026000000008', 8, '2026-10-05', 0, 2, 'Ödeme vadesi 10 Ekim');



select * from Admin
select * from LogTablo
select * from Boyut
select * from Materyal
select * from Kategori
select * from Urun
select * from KategoriUrun
select * from Tedarikci
select * from SatinAlma
select * from StokTablo
select * from ListeFiyat
select * from Musteri
select * from Siparis
select * from OdemeTipi
select * from Fatura