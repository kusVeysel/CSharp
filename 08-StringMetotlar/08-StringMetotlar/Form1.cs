using System;
using System.Windows.Forms;

namespace _08_StringMetotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnContains_Click(object sender, EventArgs e)
        {
            string gelenVeri = txtData.Text;
            if (!gelenVeri.ToLower().Contains("veysel")) // Contains(): İçindeki veriyi içeriyor mu diye kontrol eder
            {
                MessageBox.Show("Girilen değer veysel bilgisini içermiyor");
            }
            else
            {
                MessageBox.Show("Girilen değer veysel bilgisini içeriyor");
            }
        }

        private void BtnToUpper_Click(object sender, EventArgs e)
        {
            string gelenVeri = txtData.Text;
            MessageBox.Show(gelenVeri.ToUpper()); // Tüm harfleri büyük yapar
        }

        private void BtnToLower_Click(object sender, EventArgs e)
        {
            string gelenVeri = txtData.Text;
            MessageBox.Show(gelenVeri.ToLower()); // Tüm harfleri küçük yapar
        }

        private void BtnLenght_Click(object sender, EventArgs e)
        {
            int karakterSayisi = txtData.Text.Length; // Karakter uzunluğunu döner
            MessageBox.Show("Gelen Veri Karakter Sayısı: " + karakterSayisi);
        }

        private void BtnTrim_Click(object sender, EventArgs e)
        {
            string gelenVeri = txtData.Text.Trim(); // Sağdan ve soldan boşlukları kaldırır
            MessageBox.Show("Boşlukları kaldırılmış karakter sayısı: " + gelenVeri.Length);
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string gelenVeri = txtData.Text;
            gelenVeri = gelenVeri.Replace(gelenVeri, "ilayda"); // Yer değiştirir, 1.parametre değişecek veri, 2.parametre değişilen veri
            txtData.Text = gelenVeri;
        }

        private void BtnSplit_Click(object sender, EventArgs e)
        {
            string mailto = "veysel@gmail.com;ilayda@gmail.com;milay@gmail.com";
            string[] mailList = mailto.Split(';'); // Belirtilen karakterden(separator'den) böler ve bir dizi döner
            /* foreach (var item in mailList) 
             {
                 MessageBox.Show(item);
             }*/
            for (int i = 0; i < mailList.Length; i++)
            {
                MessageBox.Show(mailList[i]);
            }
        }

        private void BtnSubstring_Click(object sender, EventArgs e)
        {
            string gelenVeri = txtData.Text;
            gelenVeri = gelenVeri.Substring(2, 2); // substring(x,y): x → kaçıncı indeksten bölünecek , y → x'ten itibaren(x dahil) kaç tane alınacak ,y yazılmaya bilir , yazılmazsa x'ten sonraki hepsini alır
            MessageBox.Show(gelenVeri);
            /* örnek
            v → 0
            e → 1
            y → 2
            s → 3
            e → 4
            l → 5
            Substring(2, 2) → ys yazar
             */
        }
    }
}
