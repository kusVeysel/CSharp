using SuTakip.BLL.Repository.Models;
using SuTakip.BLL.Repository.Service;
using System;
using System.Windows.Forms;

namespace SuTakip.UIForm
{
    public partial class Giris : Form
    {
        EntityService service;
        public Giris()
        {
            InitializeComponent();
            service = new EntityService();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kadi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            Result dbresult = service.AdminService.AdminCheck(kadi, sifre);

            if (dbresult.Gec == true)
            {
                MessageBox.Show(dbresult.Message);
                this.Hide();
                AnaMenu anaMenu = new AnaMenu();
                anaMenu.Show();
            }
            else if (dbresult.Gec == false && dbresult.BosVeri == false)
            {
                MessageBox.Show(dbresult.Message);
            }
            else
            {
                MessageBox.Show(dbresult.Message);
            }

        }
    }
}
