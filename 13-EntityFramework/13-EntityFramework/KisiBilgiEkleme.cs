using _13_EntityFramework.DB;
using System;
using System.Windows.Forms;

namespace _13_EntityFramework
{
    public partial class KisiBilgiEkleme : Form
    {
        public KisiBilgiEkleme()
        {
            InitializeComponent();
        }
        VeyselEntities db = new VeyselEntities();
        private void KisiBilgiEkleme_Load(object sender, EventArgs e)
        {
            grpMusteri.BringToFront();
            rdMusteriEkle.Checked = true;
        }
        private void rdMusteri_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdMusteriEkle.Checked == true)
            {
                grpMusteri.BringToFront();
                grpTedarikci.Visible = false;
                grpAdmin.Visible = false;
                grpMusteri.Visible = true;
            }
        }
        private void rdTedarikciEkle_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdTedarikciEkle.Checked == true)
            {
                grpTedarikci.BringToFront();
                grpMusteri.Visible = false;
                grpAdmin.Visible = false;
                grpTedarikci.Visible = true;
            }
        }
        private void rdAdminEkle_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdAdminEkle.Checked == true)
            {
                grpAdmin.BringToFront();
                grpMusteri.Visible = false;
                grpTedarikci.Visible = false;
                grpAdmin.Visible = true;
            }
        }
        private void btnTedarikciEkle_Click(object sender, EventArgs e)
        {
            string[] kontroller = { txtTedarikciAdi.Text, txtTedarikciTelefon.Text, txtTedarikciEmail.Text, txtTedarikciAdres.Text, txtTedarikciVergiDairesi.Text, txtTedarikciVergiNumarası.Text };
            string[] key = { "Tedarikçi Adı", "Tedarikçi Telefon Numarası", "Tedarikçi Email", "Tedarikçi Adres", "Tedarikçi Vergi Dairesi", "Tedarikçi Vergi Numarası" };
            bool izin = true;

            for (int i = 0; i < kontroller.Length; i++)
            {
                if (kontroller[i].Trim() == "")
                {
                    MessageBox.Show($"{key[i]} alanını doldurunuz");
                    izin = false;
                }
            }

            if (izin)
            {
                Tedarikci teda = new Tedarikci()
                {
                    TedarikciAdi = txtTedarikciAdi.Text,
                    Telefon = txtTedarikciTelefon.Text,
                    Email = txtTedarikciEmail.Text,
                    Adres = txtTedarikciAdres.Text,
                    VergiDairesi = txtTedarikciVergiDairesi.Text,
                    VergiNo = txtTedarikciVergiNumarası.Text,
                    AktifMi = cmbTedarikciAktifMi.Text.ToLower() == "aktif" ? true : false,
                };

                db.Tedarikci.Add(teda);
                db.SaveChanges();
                MessageBox.Show("Tedarikçi ekleme Başarılı");
            }
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            string[] kontroller = { txtMusteriFirma.Text, txtMusteriYetkiliAdSoyad.Text, txtMusteriEmaill.Text, txtMusteriTel.Text, txtMusteriAdress.Text };
            string[] key = { "Müşteri Firma", "Müşteri Yetkili Ad Soyad", "Müşteri Email", "Müşteri Telefon", "Müşteri Adres" };
            bool izin = true;

            for (int i = 0; i < kontroller.Length; i++)
            {
                if (kontroller[i].Trim() == "")
                {
                    MessageBox.Show($"{key[i]} alanını doldurunuz");
                    izin = false;
                }
            }
            if (izin)
            {
                Musteri mekle = new Musteri()
                {
                    MusteriFirma = txtMusteriFirma.Text,
                    YetkiliAdSoyad = txtMusteriYetkiliAdSoyad.Text,
                    Email = txtMusteriEmail.Text,
                    Telefon = txtMusteriTelefon.Text,
                    IskentoOran = Convert.ToInt32(nudiskonto.Value),
                    Adres = txtMusteriAdres.Text,
                    AktifMi = checkBox2.Checked,
                    Toptanmi = checkBox1.Checked
                };
                db.Musteri.Add(mekle);
                db.SaveChanges();
                MessageBox.Show("Müşteri ekleme Başarılı");
            }
        }

        private void btnAdminEkle_Click(object sender, EventArgs e)
        {
            string[] kontroller = { txtAdminKullaniciAdi.Text, txtAdminSifre.Text, txtAdminTelefon.Text, txtAdminEmail.Text };
            string[] key = { "Admin Kullanıcı Adı", "Admin Şifre", "Admin Telefon", "Admin Email" };
            bool izin = true;

            for (int i = 0; i < kontroller.Length; i++)
            {
                if (kontroller[i].Trim() == "")
                {
                    MessageBox.Show($"{key[i]} alanını doldurunuz");
                    izin = false;
                }
            }

            if (izin)
            {
                Admin adm = new Admin()
                {
                    UserName = txtAdminKullaniciAdi.Text,
                    Password = txtAdminSifre.Text,
                    Telefon = txtAdminTelefon.Text,
                    Email = txtAdminEmail.Text,
                    AktifMi = cmbAdminAktifMi.Text.ToLower() == "aktif" ? true : false
                };

                db.Admin.Add(adm);
                db.SaveChanges();  // Değişiklikleri DataBase'e kayıt eder
                MessageBox.Show("Admin ekleme Başarılı");
            }

        }
    }
}