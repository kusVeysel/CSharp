using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void btnStokForm_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.ShowDialog(); // ShowDialog(): Formu modal olarak açar. Açılan form kapanmadan, formu açan ana forma geri dönülemez. Yani kullanıcı önce stock formundaki işlemi tamamlamalı veya stock formunu kapatmalıdır.
        }

        private void btnSetupFrom_Click(object sender, EventArgs e)
        {
            Setup setup = new Setup();
            MessageBox.Show("Verileri listeledikten sonra güncelleyeceğiniz veriye(DataGridView üzerinde) çift tıklayınız.");
            setup.ShowDialog();
        }

        private void btnKisiBilgiEkleme_Click(object sender, EventArgs e)
        {
            KisiBilgiEkleme kbe = new KisiBilgiEkleme();
            kbe.ShowDialog();
        }
    }
}
