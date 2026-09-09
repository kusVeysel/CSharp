using System.Collections.Generic;
using System.Windows.Forms;

namespace _10_SuStokTakipFormu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Materyal> materyals = Methodlar.MateryalDb();

        private void Form1_Load(object sender, System.EventArgs e)
        {
            Methodlar.UrunBilgiGetir(lstUrunBilgiler, materyals, true);
            Methodlar.UrunBilgiGetir(lstDetayliBilgi, materyals, false);
        }

        private void btnGeleniEkle_Click(object sender, System.EventArgs e)
        {
            int[] eskiGelen = { 13, 12, 27 };

            for (int i = 0; i < materyals.Count; i++)
            {
                materyals[i].Stok += eskiGelen[i];
                MessageBox.Show($"{materyals[i].UrunAdi} {eskiGelen[i]} Adet Yeni Ürün Geldi!");
            }

            Methodlar.UrunBilgiGetir(lstUrunBilgiler, materyals, true);
            Methodlar.UrunBilgiGetir(lstDetayliBilgi, materyals, false);
        }

        private void btnYeniGeleniEkle_Click(object sender, System.EventArgs e)
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