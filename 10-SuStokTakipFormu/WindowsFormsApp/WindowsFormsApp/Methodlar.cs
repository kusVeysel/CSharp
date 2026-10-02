using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public static class Methodlar
    {
        public static List<Materyal> MateryalDb()
        {
            Materyal LT3 = new Materyal();
            LT3.UrunAdi = "3LT Bidon";
            LT3.Litre = 3;
            LT3.Fiyat = 5;
            LT3.Stok = 20;

            Materyal LT5 = new Materyal();
            LT5.UrunAdi = "5LT Bidon";
            LT5.Litre = 5;
            LT5.Fiyat = 7;
            LT5.Stok = 13;

            Materyal LT10 = new Materyal();
            LT10.UrunAdi = "10LT Bidon";
            LT10.Litre = 10;
            LT10.Fiyat = 10;
            LT10.Stok = 17;

            List<Materyal> materyals = new List<Materyal> { LT3, LT5, LT10 };

            return materyals;
        }

        public static void UrunBilgiGetir(ListBox lstUrunBilgiler, List<Materyal> materyals, bool guncelle)
        {
            double toplam = 0;

            if (guncelle)
            {
                lstUrunBilgiler.Items.Clear();
            }

            foreach (Materyal materyal in materyals)
            {
                lstUrunBilgiler.Items.Add($"Ürün Adı → {materyal.UrunAdi}");
                lstUrunBilgiler.Items.Add($"Ürün Litresi → {materyal.Litre}LT");
                lstUrunBilgiler.Items.Add($"Ürün Adeti → {materyal.Stok}");
                lstUrunBilgiler.Items.Add($"Ürün Adet Fiyatı → {materyal.Fiyat}₺");
                lstUrunBilgiler.Items.Add($"Toplam Fiyat → {materyal.Stok * materyal.Fiyat}₺");
                lstUrunBilgiler.Items.Add("");
                toplam += materyal.Stok * materyal.Fiyat;
            }

            if (guncelle)
            {
                lstUrunBilgiler.Items.Add($"Tüm Ürünler Toplam Fiyat → {toplam}₺");
            }
            if (!guncelle)
            {
                lstUrunBilgiler.Items.Add("------------------------------------------------");
                lstUrunBilgiler.Items.Add("");
            }
        }
    }
}