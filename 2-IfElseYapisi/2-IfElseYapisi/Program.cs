using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_IfElseYapisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Operatorler: <, >, <=, >=, ==, !=, &&, ||, !, ++, --, +, -, *, /, %, =
            // < : küçüktür, > : büyüktür, <= : küçük eşittir, >= : büyük eşittir, == : eşittir, != : eşit değildir, && : ve, || : veya, ! : değil, ++ : bir artırır, -- : bir azaltır, + : toplama, - : çıkarma, * : çarpma, / : bölme, % : mod alma, = : atama

            int sayi1;

            Console.Write("Bir sayı girin: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 < 0 || sayi1 > 0) // sayi1 0'dan küçük veya sayi1 0'dan büyük ise aşağıdaki mesajı yazdır , || : veya anlamına gelir.
            {
                Console.WriteLine("Sayı 0'dan farklı.");
            }
            else
            {
                Console.WriteLine("Sayı 0'dır.");
            }


            string userName, password;

            Console.Write("Kullanıcı Adınızı Giriniz: ");
            userName = Console.ReadLine();

            Console.Write("Şifrenizi Giriniz: ");
            password = Console.ReadLine();

            if(userName != null && password != null) // userName ve password null değilse aşağıdaki mesajı yazdır , && : ve anlamına gelir. 
            { 
                if(userName == "admin" && password == "1234") // userName ve password doğru ise aşağıdaki mesajı yazdır , == : eşittir anlamına gelir.
                {
                    Console.WriteLine("Giriş Başarılı");
                }
                else
                {
                    Console.WriteLine("Kullanıcı adı veya şifre hatalı.");
                }
            }
            else
            {
                Console.WriteLine("Kullanıcı adı veya şifre boş bırakılamaz.");
            }

        }
    }
}
