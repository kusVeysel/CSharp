using System;
using System.Collections.Generic;
using System.Linq;

namespace _5_HazirMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string> { "Ankara", "İstanbul", "Bursa", "İzmir", "Adana", "KahramanMaraş" }; // Listeye veri eklemek için başka bir yöntem.

            int ogeSayisi = sehirler.Count(); // Count() metodu, koleksiyondaki öğelerin sayısını döndürür
            Console.WriteLine("Şehir Sayısı: " + ogeSayisi);

            string ilkSehir = sehirler.First(); // First() metodu, koleksiyondaki ilk öğeyi döndürür.
            Console.WriteLine("İlk Şehir: " + ilkSehir);

            string sonSehir = sehirler.Last(); // Last() metodu, koleksiyondaki son öğeyi döndürür.
            Console.WriteLine("Son Şehir: " + sonSehir);

            var IlkUcSehir = sehirler.Take(3).ToList(); // Take() metodu, koleksiyondan belirtilen sayıda öğeyi alır. ToList() metodu ise List tipine dönüştürür.
            Console.Write("İlk 3 Şehir: ");
            foreach (var sehir in IlkUcSehir)
            {
                Console.Write(sehir + ", ");
            }

            sehirler.Reverse(); // Reverse() metodu, koleksiyondaki öğelerin sırasını tersine çevirir(en baştaki en sona geçer...).
            Console.Write("\nTers Sıra: ");
            foreach (var sehir in sehirler)
            {
                Console.Write(sehir + ", ");
            }

            bool sehirVarMi = sehirler.Contains("Bursa"); // Contains() metodu, koleksiyonun içinde belirtilen öğenin olup olmadığını kontrol eder.
            Console.WriteLine("\n" + "Bursa" + " Şehri Var Mı?: " + sehirVarMi);

            string silinenEleman = sehirler.Remove("Adana") ? "Adana" : "Silinecek Eleman Bulunamadı"; // Remove() metodu, koleksiyondan belirtilen öğeyi siler ve başarılı olup olmadığını döndürür.
            Console.WriteLine("Silinen Eleman: " + silinenEleman);

            sehirler.Clear(); // Clear() metodu, koleksiyonun içini komple siler(temizler).


            List<int> sayilar = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int toplam = sayilar.Sum(); // Sum() metodu, koleksiyondaki sayısal öğelerin toplamını döndürür.

            int enBuyuk = sayilar.Max(); // Max() metodu, koleksiyondaki en büyük değeri döndürür.

            int enKucuk = sayilar.Min(); // Min() metodu, koleksiyondaki en küçük değeri döndürür.

            double ortalama = sayilar.Average(); // Average() metodu, koleksiyondaki sayısal öğelerin ortalamasını döndürür.

            int carpim = sayilar.Aggregate((x, y) => x * y); // Aggregate() metodu, koleksiyondaki öğeleri birleştirerek tek bir değer döndürür. Bu örnekte, tüm sayıları çarparak tek bir değer elde ediyoruz.

            Console.WriteLine("Sayıların Toplamı: " + toplam);
            Console.WriteLine("Sayıların En Büyüğü: " + enBuyuk);
            Console.WriteLine("Sayıların En Küçüğü: " + enKucuk);
            Console.WriteLine("Sayıların Ortalaması: " + ortalama);
            Console.WriteLine("Sayıların Çarpımı: " + carpim);
        }
    }
}