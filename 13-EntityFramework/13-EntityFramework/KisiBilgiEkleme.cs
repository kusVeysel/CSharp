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



        private void rdMusteri_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdMusteri.Checked == true)
            {
                grpMusteri.Visible = true;
                grpTedarikci.Visible = false;
                grpAdminEkle.Visible = false;
            }

        }

        private void KisiBilgiEkleme_Load(object sender, EventArgs e)
        {
            rdMusteri.Checked = true;

        }

        private void rdTedarikciEkle_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdTedarikciEkle.Checked == true)
            {
                grpTedarikci.Visible = true;
                grpMusteri.Visible = false;
                grpAdminEkle.Visible = false;
            }
        }

        private void rdAdminEkle_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdAdminEkle.Checked == true)
            {
                grpAdminEkle.Visible = true;
                grpMusteri.Visible = false;
                grpTedarikci.Visible = false;
            }
        }

        private void btnAdminEkle_Click_1(object sender, EventArgs e)
        {
            Admin adm = new Admin()
            {
                UserName = txtAdminEmail.Text,
                Password = txtAdminSifre.Text,
                Telefon = txtAdminTelefon.Text,
                Email = txtAdminEmail.Text
            };

            if (cmbAdminAktifMi.Text == "Aktif")
            {
                adm.AktifMi = true;
            }
            else
            {
                adm.AktifMi = false;
            }
            db.Admin.Add(adm);
            db.SaveChanges();  // Değişiklikleri DataBase'e kayıt eder
            MessageBox.Show("Admin ekleme Başarılı");

        }

        private void btnTedarikciEkle_Click_1(object sender, EventArgs e)
        {
            Tedarikci teda = new Tedarikci()
            {
                TedarikciAdi = txtTedarikciAdi.Text,
                Telefon = txtTedarikciTelefon.Text,
                Email = txtTedarikciEmail.Text,
                Adres = txtTedarikciAdres.Text,
                VergiDairesi = txtTedarikciVergiDairesi.Text,
                VergiNo = txtTedarikciVergiNumarası.Text
            };
            if (cmbTedarikciAktifMi.Text == "Aktif")
            {
                teda.AktifMi = true;
            }
            else
            {
                teda.AktifMi = false;
            }
            db.Tedarikci.Add(teda);
            db.SaveChanges();
            MessageBox.Show("Tedarikçi ekleme Başarılı");
        }

        private void btnMusteriEkle_Click_1(object sender, EventArgs e)
        {
            Musteri mekle = new Musteri()
            {
                MusteriFirma = txtMusteriFirma.Text,
                YetkiliAdSoyad = txtMusteriAdSoyad.Text,
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
}
