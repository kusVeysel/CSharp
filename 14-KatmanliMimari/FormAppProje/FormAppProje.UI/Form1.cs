using FormAppProje.BLL.Repository.Service;
using FormAppProje.DAL.DB;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace FormAppProje.UI
{
    public partial class Form1 : Form
    {
        EntityService service;
        public Form1()
        {
            InitializeComponent();
            service = new EntityService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Admin> admList = service.AdminService.GetAll();

            foreach (Admin item in admList)
            {
                cmbAdminler.Items.Add(item.UserName);
            }
        }

        private void btnAdminEkle_Click(object sender, EventArgs e)
        {
            string[] degerler = { txtUserName.Text, txtPassword.Text, txtEmail.Text, txtPhone.Text };
            Admin adm = new Admin();

            foreach (string item in degerler)
            {
                if (string.IsNullOrEmpty(item))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                    return;
                }
            }
            adm.UserName = txtUserName.Text;
            adm.Password = txtPassword.Text;
            adm.Email = txtEmail.Text;
            adm.Telefon = txtPhone.Text;
            adm.AktifMi = true;
            service.AdminService.Insert(adm);
            MessageBox.Show("Kayıt Başarılı");
        }


    }
}
