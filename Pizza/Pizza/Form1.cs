using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kadi=txtAdi.Text;
            string sifre=txtSifre.Text;

            bool girisSonuc= Methodlar.GirisKontrol(kadi, sifre);

            if (girisSonuc==true)
            {
                this.Hide();
                SipMenü sipMenü = new SipMenü();
                sipMenü.Show();
            }

        }
    }
}
