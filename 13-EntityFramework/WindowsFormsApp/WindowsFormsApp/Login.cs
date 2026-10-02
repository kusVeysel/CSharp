using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp.DB;

namespace WindowsFormsApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        VeyselEntities db = new VeyselEntities();

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string email = txtUserName.Text;
            string sifre = txtPassword.Text;

            if (email != "")
            {
                if (sifre != "")
                {
                    Admin dbResult = db.Admin.Where(x => x.Email == email && x.Password == sifre).FirstOrDefault();
                    if (dbResult != null)
                    {
                        if (dbResult.AktifMi == true)
                        {
                            this.Hide();
                            AnaSayfa ana = new AnaSayfa();
                            ana.Show();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcınız Aktif Değil Yönetici İle iletişime Geçiniz!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifre veya email hatalı.");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen şifre alanını doldurunuz.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Email alanını doldurunuz.");
            }
        }
    }
}
