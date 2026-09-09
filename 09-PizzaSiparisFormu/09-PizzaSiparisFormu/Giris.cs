using System;
using System.Windows.Forms;

namespace _09_PizzaSiparisFormu
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kadi = txtAdi.Text;
            string sifre = txtSifre.Text;

            bool girisSonuc = Methodlar.GirisKontrol(kadi, sifre);

            if (girisSonuc == true)
            {
                this.Hide();
                SipMenu sipMenü = new SipMenu();
                sipMenü.Show();
            }
        }
    }
}
