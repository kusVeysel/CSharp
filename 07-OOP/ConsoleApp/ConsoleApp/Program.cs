using System;
using System.Collections.Generic;

namespace _7_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Motosiklet moto1 = new Motosiklet(); // Motosiklet nesnesi oluşturuldu , RAM üzerinde hazır hale getirildi (instance)
            moto1.Marka = "Yamaha";
            moto1.Model = "Nmax";
            moto1.AktarimTipi = "Kayış";
            moto1.KasaTipi = "Scooter";
            moto1.SilindirSayisi = 1;
            moto1.SilindirHacmi = 155;
            moto1.ModelYili = Convert.ToDateTime("05-07-2017");
            moto1.KullanimAlani = "Kara";

            Motosiklet moto2 = new Motosiklet()
            {
                Marka = "Peugeot",
                Model = "Geopolis",
                AktarimTipi = "Kayış",
                KasaTipi = "Scooter",
                SilindirSayisi = 1,
                SilindirHacmi = 250,
                ModelYili = Convert.ToDateTime("26-02-2013"),
                Renk = "Lacivert"
            }; // Nesne oluşturmanın 2.yöntemi

            Otomobil oto1 = new Otomobil();
            oto1.Marka = "Skoda";
            oto1.Model = "Favorit";
            oto1.ModelYili = Convert.ToDateTime("01-04-1993");
            oto1.Renk = "Gri";
            oto1.KullanimTipi = true;
            oto1.KasaTipi = "HatchBack";

            List<Motosiklet> mList = new List<Motosiklet> { moto1, moto2 };

            foreach (Motosiklet m in mList)
            {
                Console.WriteLine($"Marka: {m.Marka}"); // $ işareti string ile değişkeni beraber kuallanabilmemizi sağlar.
                Console.WriteLine($"Model: {m.Model}");
                Console.WriteLine($"Model Yılı: {m.ModelYili}");
            }

        }
    }
}