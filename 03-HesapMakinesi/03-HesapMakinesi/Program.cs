using System;

namespace _3_HesapMakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int Sayi1 = 0;
            int Sayi2 = 0;
            int islem = 0;
            int sonuc = 0;
            double sonucbolme = 0;

        basadon:

            Console.WriteLine("Yapmak İstediğiniz işlem:");
            Console.WriteLine("1-Toplama İşlemi");
            Console.WriteLine("2-Çıkarma İşlemi");
            Console.WriteLine("3-Çarpma İşlemi");
            Console.WriteLine("4-Bölme İşlemi");

            try
            {
                islem = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 gelen inputu int tipine dönüştürür

                Console.WriteLine("İşlem için 1.sayiyi giriniz");
                Sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("İşlem için 2.sayiyi giriniz");
                Sayi2 = Convert.ToInt32(Console.ReadLine());

                #region IF ELSE
                //if (islem == 1)
                //{
                //    sonuc = Sayi1 + Sayi2;
                //    Console.WriteLine("İşlem sonucunuz:" + sonuc);
                //}
                //else if (islem == 2)
                //{
                //    sonuc = Sayi1 - Sayi2;
                //    Console.WriteLine("İşlem sonucunuz:" + sonuc);
                //}
                //else if (islem == 3)
                //{
                //    sonuc = Sayi1 * Sayi2;
                //    Console.WriteLine("İşlem sonucunuz:" + sonuc);
                //}
                //else if (islem == 4)
                //{
                //    sonucbolme =Math.Round((double)Sayi1 / Sayi2,2);
                //    Console.WriteLine("İşlem sonucunuz:" +sonucbolme);
                //}
                //else
                //{
                //    Console.WriteLine("Seçtiğiniz İşlem Menüde Bulunmuyor");
                //}
                #endregion

                #region

                if (islem == 1)
                {
                    sonuc = Sayi1 + Sayi2;
                    Console.WriteLine("İşlem sonucunuz:" + sonuc);
                }
                else if (islem == 2)
                {
                    sonuc = Sayi1 - Sayi2;
                    Console.WriteLine("İşlem sonucunuz:" + sonuc);
                }
                else if (islem == 3)
                {
                    sonuc = Sayi1 * Sayi2;
                    Console.WriteLine("İşlem sonucunuz:" + sonuc);
                }
                else if (islem == 4)
                {
                    if (Sayi2 == 0)
                    {
                        Console.WriteLine("Tanımsız Bölme İşlemi");
                        Sayi1 = 0;
                        Sayi2 = 0;
                        islem = 0;
                        sonuc = 0;
                        goto yeniden;
                    }
                    sonucbolme = Math.Round((double)Sayi1 / Sayi2, 2);
                    Console.WriteLine("İşlem sonucunuz:" + sonucbolme);
                }
                else
                {
                    Console.WriteLine("Geçersiz İşlem Türü");
                    goto yeniden;
                }

                #endregion

                #region SWITCH CASE
                //switch (islem)
                //{
                //    case 1:
                //        sonuc = Sayi1 + Sayi2;
                //        Console.WriteLine("İşlem sonucunuz:" + sonuc);
                //        break;
                //    case 2:
                //        sonuc = Sayi1 - Sayi2;
                //        Console.WriteLine("İşlem sonucunuz:" + sonuc);
                //        break;
                //    case 3:
                //        sonuc = Sayi1 * Sayi2;
                //        Console.WriteLine("İşlem sonucunuz:" + sonuc);
                //        break;
                //    case 4:
                //        sonucbolme = Math.Round((double)Sayi1 / Sayi2, 2);
                //        Console.WriteLine("İşlem sonucunuz:" + sonucbolme);
                //        break;
                //    default:
                //        Console.WriteLine("Seçtiğiniz İşlem Menüde Bulunmuyor");
                //        break;
                //}
                #endregion

            yeniden:
                Console.WriteLine("Yeniden işlem yapmak ister misiniz? E/H");

                string tekrarislem = Console.ReadLine();

                if (tekrarislem == "E")
                {
                    Console.Clear();  // ekranı temizler
                    Sayi1 = 0;
                    Sayi2 = 0;
                    islem = 0;
                    sonuc = 0;
                    goto basadon; // döngüye benzer , değişkeni belirlenen yere döner
                }
                else if (tekrarislem == "H")
                {
                    Console.WriteLine("program kapatılacaktır");
                }
                else
                {
                    Console.WriteLine("Seçtiğiniz işlem menüde bulunmuyor");
                    goto yeniden;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Giriş yaptığınız veri hatalıdır");
                Console.WriteLine(ex.Message); // ex.Message hatanın ne olduğunu gösterir
            }
            finally
            {
                Console.WriteLine("finally bloğu çalıştırıldı");
            }
            // finally bloğu try catch blokları ile birlikte kullanılır.finally bloğu içinde hata oluşsa da oluşmasa da çalışır. finally bloğu içinde genellikle kaynakları serbest bırakmak için kullanılır. Örneğin dosya açma işlemi yapıldıysa dosya kapatma işlemi finally bloğu içinde yapılır. finally bloğu içinde hata oluşursa program sonlanır ve hata mesajı gösterilir.

            // try catch bloğu hataları yakalamak için kullanılır. try bloğu içinde hata oluşursa catch'e düşer ve hata mesajını gösterir. Hata verebilecek kodlar try bloğu içine yazılır. Hata oluşmazsa catch bloğu çalışmaz. Hata oluşursa catch bloğu çalışır ve hata mesajını gösterir.
        }
    }
}