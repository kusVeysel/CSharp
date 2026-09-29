using System;
using System.Windows.Forms;


namespace _13_EntityFramework
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        private void btnKisiBilgiEkleme_Click_1(object sender, EventArgs e)
        {
            KisiBilgiEkleme kbe = new KisiBilgiEkleme();
            kbe.ShowDialog(); // ShowDialog ana forma erişim yapılamaz, aktif formun kapanması gerekir.
        }
        private void btnSetupFrom_Click_1(object sender, EventArgs e)
        {
            Setup setup = new Setup();
            MessageBox.Show("Verileri listeledikten sonra güncelleyeceğiniz veriye(DataGridView üzerinde) çift tıklayınız.");
            setup.ShowDialog(); // ShowDialog ana forma erişim yapılamaz, aktif formun kapanması gerekir.
        }

        private void btnStokForm_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.ShowDialog(); // ShowDialog ana forma erişim yapılamaz, aktif formun kapanması gerekir.
        }
    }
}