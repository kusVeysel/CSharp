using Pizza.Modeller;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public static class Methodlar
    {
        public static bool GirisKontrol(string kadi, string sif)
        {
            string kullaniciadi = "admin";
            string sifre = "1234";
            bool sonuc = false;

            if (kadi != "")
            {
                if (sifre != "")
                {
                    if (kadi.ToLower().Trim() == kullaniciadi.ToLower().Trim())
                    {
                        if (sif.ToLower().Trim() == sifre.ToLower().Trim())
                        {
                            sonuc = true;
                        }
                        else
                        {
                            MessageBox.Show("Şifreniz Hatalı");
                            sonuc = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adınız Hatalı");
                        sonuc = false;
                    }
                }
                else
                {
                    MessageBox.Show("Şifre Boş Geçilemez");
                    sonuc = false;
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Boş Geçilemez");
                sonuc = false;
            }
            return sonuc;
        }

        public static SiparisMod OnSiparisIsle(Musteri musteri, List<Urun> urunListesi, int pizzaA, int icecekA)
        {

            SiparisMod OnSiparis = new SiparisMod();
            OnSiparis.MusteriInfo = musteri;
            List<Urun> dburunliste = new List<Urun>();

            Urun PizzaDbBilgi = PizzaFiyatGetir(urunListesi.Where(x => x.KatagoriAdi == "Pizza").FirstOrDefault());
            Urun IcecekDbBilgi = IcecekFiyatGetir(urunListesi.Where(x => x.KatagoriAdi == "İçecek").FirstOrDefault());

            double pizzaToplamFiyat = PizzaDbBilgi.Fiyat * pizzaA;
            double icecekToplamFiyat = IcecekDbBilgi.Fiyat * icecekA;

            dburunliste.Add(PizzaDbBilgi);
            dburunliste.Add(IcecekDbBilgi);

            OnSiparis.UrunBilgileri = dburunliste;
            OnSiparis.ToplamTutar = pizzaToplamFiyat + icecekToplamFiyat;

            return OnSiparis;

        }

        public static Urun PizzaFiyatGetir(Urun pizzaBilgi)
        {
            #region Fiyatları Oluşturma ve Listeye Ekleme

            List<Urun> genelPizzaListesi = new List<Urun>();

            Urun pizzafoto1Kucuk = new Urun()
            {
                UrunAdi = "Karışık",
                Boyut = "Küçük",
                Fiyat = 300,
                KatagoriAdi = "Pizza"
            };
            Urun pizzafoto1Orta = new Urun()
            {
                UrunAdi = "Karışık",
                Boyut = "Orta",
                Fiyat = 400,
                KatagoriAdi = "Pizza"
            };
            Urun pizzafoto1Buyuk = new Urun()
            {
                UrunAdi = "Karışık",
                Boyut = "Büyük",
                Fiyat = 500,
                KatagoriAdi = "Pizza"
            };

            Urun pizzafoto2Kucuk = new Urun()
            {
                UrunAdi = "Sucuklu",
                Boyut = "Küçük",
                Fiyat = 350,
                KatagoriAdi = "Pizza"
            };
            Urun pizzafoto2Orta = new Urun()
            {
                UrunAdi = "Sucuklu",
                Boyut = "Orta",
                Fiyat = 450,
                KatagoriAdi = "Pizza"
            };
            Urun pizzafoto2Buyuk = new Urun()
            {
                UrunAdi = "Sucuklu",
                Boyut = "Büyük",
                Fiyat = 550,
                KatagoriAdi = "Pizza"
            };

            Urun pizzafoto3Kucuk = new Urun()
            {
                UrunAdi = "Peynirli",
                Boyut = "Küçük",
                Fiyat = 450,
                KatagoriAdi = "Pizza"
            };
            Urun pizzafoto3Orta = new Urun()
            {
                UrunAdi = "Peynirli",
                Boyut = "Orta",
                Fiyat = 550,
                KatagoriAdi = "Pizza"
            };
            Urun pizzafoto3Buyuk = new Urun()
            {
                UrunAdi = "Peynirli",
                Boyut = "Büyük",
                Fiyat = 600,
                KatagoriAdi = "Pizza"
            };

            genelPizzaListesi.Add(pizzafoto3Buyuk);
            genelPizzaListesi.Add(pizzafoto3Orta);
            genelPizzaListesi.Add(pizzafoto3Kucuk);
            genelPizzaListesi.Add(pizzafoto2Buyuk);
            genelPizzaListesi.Add(pizzafoto2Orta);
            genelPizzaListesi.Add(pizzafoto2Kucuk);
            genelPizzaListesi.Add(pizzafoto1Buyuk);
            genelPizzaListesi.Add(pizzafoto1Orta);
            genelPizzaListesi.Add(pizzafoto1Kucuk);
            #endregion

            //lambda expression sorgulama işlemi
            return genelPizzaListesi.Where(x => x.UrunAdi == pizzaBilgi.UrunAdi && x.Boyut == pizzaBilgi.Boyut).FirstOrDefault();
            // Sorgulama işlemi 2.yol
            /*   foreach (var item in genelPizzaListesi)
               {
                   if (item.UrunAdi==pizzaBilgi.UrunAdi && item.Boyut ==pizzaBilgi.Boyut)
                   {
                       sonuc = item.Fiyat;
                   }
               }*/

        }

        public static Urun IcecekFiyatGetir(Urun icecekBilgi)
        {
            #region Fiyatları Oluşturma ve Listeye Ekleme

            List<Urun> genelIcecekListesi = new List<Urun>();


            Urun pepsiKucuk = new Urun()
            {
                UrunAdi = "Pepsi",
                Boyut = "Küçük",
                Fiyat = 90,
                KatagoriAdi = "İçecek",
            };
            Urun pepsiOrta = new Urun()
            {
                UrunAdi = "Pepsi",
                Boyut = "Orta",
                Fiyat = 110,
                KatagoriAdi = "İçecek",
            };
            Urun pepsiBuyuk = new Urun()
            {
                UrunAdi = "Pepsi",
                Boyut = "Büyük",
                Fiyat = 130,
                KatagoriAdi = "İçecek",
            };
            Urun ayranKucuk = new Urun()
            {
                UrunAdi = "Ayran",
                Boyut = "Küçük",
                Fiyat = 60,
                KatagoriAdi = "İçecek",
            };
            Urun ayranOrta = new Urun()
            {
                UrunAdi = "Ayran",
                Boyut = "Orta",
                Fiyat = 80,
                KatagoriAdi = "İçecek",
            };
            Urun ayranBuyuk = new Urun()
            {
                UrunAdi = "Ayran",
                Boyut = "Büyük",
                Fiyat = 100,
                KatagoriAdi = "İçecek",
            };
            Urun fantaKucuk = new Urun()
            {
                UrunAdi = "Fanta",
                Boyut = "Küçük",
                Fiyat = 55,
                KatagoriAdi = "İçecek",
            };
            Urun fantaOrta = new Urun()
            {
                UrunAdi = "Fanta",
                Boyut = "Orta",
                Fiyat = 70,
                KatagoriAdi = "İçecek",
            };
            Urun fantaBuyuk = new Urun()
            {
                UrunAdi = "Fanta",
                Boyut = "Büyük",
                Fiyat = 90,
                KatagoriAdi = "İçecek",
            };

            genelIcecekListesi.Add(pepsiKucuk);
            genelIcecekListesi.Add(pepsiOrta);
            genelIcecekListesi.Add(pepsiBuyuk);
            genelIcecekListesi.Add(ayranKucuk);
            genelIcecekListesi.Add(ayranOrta);
            genelIcecekListesi.Add(ayranBuyuk);
            genelIcecekListesi.Add(fantaKucuk);
            genelIcecekListesi.Add(fantaOrta);
            genelIcecekListesi.Add(fantaBuyuk);

            #endregion

            //lambda expression sorgulama işlemi
            return genelIcecekListesi.Where(x => x.UrunAdi == icecekBilgi.UrunAdi && x.Boyut == icecekBilgi.Boyut).FirstOrDefault();

            // Sorgulama işlemi 2.yol
            /*   foreach (var item in genelIcecekListesi)
               {
                   if (item.UrunAdi==icecekBilgi.UrunAdi && item.Boyut ==icecekBilgi.Boyut)
                   {
                       sonuc = item.Fiyat;
                   }
               }*/
        }
    }
}
