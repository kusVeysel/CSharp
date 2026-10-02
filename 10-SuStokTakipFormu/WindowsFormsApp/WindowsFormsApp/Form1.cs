using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Materyal> materyals = Methodlar.MateryalDb();
        bool eskiUrun = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            Methodlar.UrunBilgiGetir(lstUrunBilgiler, materyals, true);
            Methodlar.UrunBilgiGetir(lstDetayliBilgi, materyals, false);
        }
        private void btnEskiGeleniEkle_Click(object sender, EventArgs e)
        {
            if (eskiUrun)
            {
                int[] eskiGelen = { 13, 12, 27 };

                for (int i = 0; i < materyals.Count; i++)
                {
                    materyals[i].Stok += eskiGelen[i];
                    MessageBox.Show($"{materyals[i].UrunAdi} {eskiGelen[i]} Adet Yeni Ürün Geldi!");
                }

                Methodlar.UrunBilgiGetir(lstUrunBilgiler, materyals, true);
                Methodlar.UrunBilgiGetir(lstDetayliBilgi, materyals, false);
                eskiUrun = false;
            }
            else
            {
                MessageBox.Show("Eski Gelen Ürünler Eklendi Artık Mevcut Değil!");
            }
        }

        private void btnYeniGeleniEkle_Click(object sender, EventArgs e)
        {
            int lt3 = (int)nmrc3lt.Value;
            int lt5 = (int)nmrc5lt.Value;
            int lt10 = (int)nmrc10lt.Value;
            int[] yeniGelen = { lt3, lt5, lt10 };

            for (int i = 0; i < materyals.Count; i++)
            {
                materyals[i].Stok += yeniGelen[i];
                MessageBox.Show($"{materyals[i].UrunAdi} {yeniGelen[i]} Adet Yeni Ürün Geldi!");
            }

            Methodlar.UrunBilgiGetir(lstUrunBilgiler, materyals, true);
            Methodlar.UrunBilgiGetir(lstDetayliBilgi, materyals, false);
        }
    }
}
