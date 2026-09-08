using System;

namespace _6_ClassYapisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Proje ismine sağ tıklayıp Add > Class diyerek yeni bir class ekleyebiliriz.

            Methodlar method = new Methodlar(); // Methodlar class'ından method adında bir nesne oluşturduk. RAM üzerine çıkarıldı. (instance)

            int sonuc = method.Topla(5, 10);
            Console.WriteLine(sonuc);

            int sonuc2 = method.Cikar(10, 5);
            Console.WriteLine(sonuc2);
        }
    }
}
