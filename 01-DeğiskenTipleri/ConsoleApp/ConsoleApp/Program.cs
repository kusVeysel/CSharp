using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad = "Veysel"; // string veri tipinde bir değişken tanımladık ve adını "ad" olarak belirledik. Değişkenin değeri "Veysel" olarak atandı.
            int yas = 19; // int veri tipinde bir değişken tanımladık ve adını "yas" olarak belirledik. Değişkenin değeri 19 olarak atandı.
            bool evliMi = false; // bool veri tipinde bir değişken tanımladık ve adını "evliMi" olarak belirledik. Değişkenin değeri false olarak atandı.
            double boy = 1.77; // double veri tipinde bir değişken tanımladık ve adını "boy" olarak belirledik. Değişkenin değeri 1.77 olarak atandı.
            char cinsiyet = 'E'; // char veri tipinde bir değişken tanımladık ve adını "cinsiyet" olarak belirledik. Değişkenin değeri 'A' olarak atandı.


            Console.WriteLine("isim => " + ad + "| yas => " + yas + "| evli mi => " + evliMi + "| boy => " + boy + "| cinsiyet => " + cinsiyet); // Console.WriteLine() metodu ile değişkenlerin değerlerini ekrana yazdırdık.

            Console.Write("Bir şeyler giriniz: ");
            string input = Console.ReadLine(); // Console.ReadLine() metodu ile kullanıcıdan veri girişi aldık ve bu veriyi "input" değişkenine atadık.

            Console.WriteLine("Girdiğiniz değer: " + input); // Kullanıcının girdiği değeri ekrana yazdırdık.

        }
    }
}
