using System;
using System.Collections.Generic;

namespace _4_DizilerGenericlistDonguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // değişkentipi[] değişken_adı = {"değişken1","değişken2","değişken3"...};
            // değişkentipi[] değişken_adı = new değişkentipi[değişkensayısı];

            int[] sayilar = { 1, 2, 3 };

            int[] sayilar2 = new int[3];
            sayilar2[0] = 1;
            sayilar2[1] = 2;
            sayilar2[2] = 3;

            string[] isimler = { "veysel", "ilayda", "milay" };

            string[] isimler2 = new string[3];
            isimler2[0] = "veysel2";
            isimler2[1] = "ilayda2";
            isimler2[2] = "milay2";

            // for (int i = 0; i < isimler2.Length; i++)
            // {
            //     Console.WriteLine(isimler2[i]);
            // }
            foreach (var item in isimler2)
            {
                Console.WriteLine(item);
            }
            // foreach: Koleksiyonun(collection) içindeki elemanları tek tek dolaşmak için kullanılan döngü yapısıdır.


            // Generic List Yapısı:

            // List<değişen_tipi> listeadı = new List<değişken_tipi>();

            // Generic List yapısı, dizilerden farklı olarak boyutları dinamik olarak değiştirilebilir. Yani, bir Generic List oluşturulduğunda, başlangıçta belirli bir boyuta sahip olabilir, ancak daha sonra eleman eklenerek boyutu artırılabilir.
            // Ekleme işlemi için Add() metodu kullanılır. Ayrıca, Generic List içerisindeki elemanlara indeksleme ile erişilebilir ve foreach döngüsü ile de elemanlar üzerinde işlem yapılabilir.

            List<string> names = new List<string>();
            names.Add("ilayda");
            names.Add("veysel");
            names.Add("milay");

            foreach (string name in names)
            {
                if (name == "veysel")
                {
                    Console.WriteLine(name);
                    break;
                }
                else
                {
                    Console.WriteLine(name);
                }
            }

            List<int> numbers = new List<int>();

            Console.WriteLine("10 adet tam sayı girin: ");
            for (int i = 0; i < 10; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                numbers.Add(number);
            }

            int toplam = 0;

            // foreach (int sayilarlar in sayi)
            // {
            //     toplam += sayilarlar;
            //     if (toplam > 20)
            //     {
            //         break;
            //     }
            // }
            // Console.WriteLine(toplam);

            for (int i = 0; i < numbers.Count; i++) // Generic List yapısında Length değil Count kullanılır
            {
                toplam += numbers[i];
                if (toplam > 20)
                {
                    break; // break ile döngüden çıkılır
                }
            }
            Console.WriteLine(toplam);

            List<string> farkli = new List<string> { "değer1", "değer2", "değer3" }; // List'e değer eklemenin 2.yöntemi , List yapısında başlangıçta değerler verilebilir
        }
    }
}