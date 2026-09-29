using _13_EntityFramework.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace _13_EntityFramework
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
            if (email != "" && sifre != "")
            {
                if (sifre != "")
                {
                    List<Admin> dbResult = db.Admin.Where(x => x.Email == email && x.Password == sifre).ToList();
                    if (dbResult.Count > 0)
                    {
                        Admin oneResult = dbResult.FirstOrDefault(x => x.Password == sifre);
                        if (oneResult != null)
                        {
                            if (oneResult.AktifMi == true)
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
                            MessageBox.Show("Şifre hatalı.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email hatalı.");
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
