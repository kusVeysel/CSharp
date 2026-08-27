using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleMetotlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Başlık"; // Konsol'un başlığı için kullanılır
            Console.BackgroundColor = ConsoleColor.Green; // Konsol'un arka planının rengini değiştirir
            Console.ForegroundColor = ConsoleColor.Blue; // Konsol'un yazısının rengini değiştirir
            Console.ResetColor(); // Renkleri varsayılan ayarına döndürür

            Console.CursorTop = 2; // Konsol'a yazılacak yazının(imlecin) yukarıdan boşluğunu ayarlar
            Console.CursorLeft = 2; // Konsol'a yazılacak yazının(imlecin) soldan boşluğunu ayarlar
            Console.CursorVisible = false; // Konsol'daki imlecin görünürlüğünü ayarlar
            Console.SetCursorPosition(0, 0); // İmlecin pozisyonu

            Console.Beep(); // Beep sesi çıkarır 

            Console.Write("Yazı yazdım"); // Konsol'a çıktı yazdırmak için kullanlır ama yazdırdıktan sonra alt satıra geçmez (output)
            Console.WriteLine("Yine yazı yazdım"); // Konsol'a çıktı yazdırmak için kullanılır, otomatik alt satıra geçer (output)
            Console.Clear(); // Konsol'daki tüm yazıları siler

            Console.ReadLine(); // Konsol'dan string bilgi girişi için kullanılır (input)
            Console.Read(); // Konsol'a girilen ilk karakterin ASCII kodunu verir

        }
    }
}
