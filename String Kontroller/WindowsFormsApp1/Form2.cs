using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnContains_Click(object sender, EventArgs e)
        {
            string gelenVeri=txtData.Text;
            if (!gelenVeri.ToLower().Contains("veysel"))
            {
                MessageBox.Show("Girilen değer veysel bilgisini içermiyor");
            }
            else
            {
                MessageBox.Show("Girilen değer veysel bilgisini içeriyor"); 
            }
        }

        private void toUpper_Click(object sender, EventArgs e)
        {
            string gelenVeri=txtData.Text;
            MessageBox.Show(gelenVeri.ToUpper());
        }

        private void BtnToLower_Click(object sender, EventArgs e)
        {
            string gelenVeri = txtData.Text;
            MessageBox.Show(gelenVeri.ToLower());
        }

        private void BtnLenght_Click(object sender, EventArgs e)
        {
            int karakterSayisi = txtData.Text.Length;
            MessageBox.Show("Gelen Veri Karakter Sayısı: " + karakterSayisi);
        }

        private void BtnTrim_Click(object sender, EventArgs e)
        {
            string gelenVeri= txtData.Text.Trim();
            MessageBox.Show("Boşlukları kaldırılmış karakter sayısı: "+gelenVeri.Length);
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string gelenVeri = txtData.Text;
            gelenVeri = gelenVeri.Replace(gelenVeri,"ilayda");
            txtData.Text = gelenVeri;
        }

        private void BtnSplit_Click(object sender, EventArgs e)
        {
            string mailto = "veysel@gmail.com;ilayda@gmail.com;milay@gmail.com";
            string[] mailList = mailto.Split(';');
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
            gelenVeri = gelenVeri.Substring(2,2); // substring(x,y) x=> kaçıncı indeksten bölünecek , y=>x'ten itibaren kaç tane alınacak ,y yazılmaya bilir , yazılmazsa x'ten sonraki hepsini alır
            MessageBox.Show(gelenVeri);
            /*
            v => 0
            e => 1
            y => 2
            s => 3
            e => 4
            l => 5
             */
        }
    }
}
