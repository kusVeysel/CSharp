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
            kbe.ShowDialog(); // .ShowDialog ana forma erişim yapılamaz , aktif formun kapanması gerekir

        }

        private void btnSetupFrom_Click_1(object sender, EventArgs e)
        {
            Setup setup = new Setup();
            setup.ShowDialog();

        }
    }
}
