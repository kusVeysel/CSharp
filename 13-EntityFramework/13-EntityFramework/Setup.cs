using _13_EntityFramework.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace _13_EntityFramework
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
        }
        VeyselEntities db = new VeyselEntities(); //DataBase çağrılır
        int IdInfo = 0;


        private void btnAdminListele_Click_1(object sender, EventArgs e)
        {
            List<Admin> dbAdminListesi = db.Admin.ToList();

            DataTable dt = new DataTable(); // Ram üzerinde hayali bir tablo oluşturulur.
            dt.Columns.Add("ID");
            dt.Columns.Add("Kullanıcı Adı");
            dt.Columns.Add("Email");
            dt.Columns.Add("Telefon");
            dt.Columns.Add("Aktif Mi");

            foreach (Admin adm in dbAdminListesi)
            {
                DataRow row = dt.NewRow(); // Hayali tabloya eklenecek boş bir satır oluşturur.
                row["ID"] = adm.ID;
                row["Kullanıcı Adı"] = adm.UserName;
                row["Email"] = adm.Email;
                row["Telefon"] = adm.Telefon;
                row["Aktif Mi"] = adm.AktifMi == true ? "Aktif" : "False";

                dt.Rows.Add(row); // Hayali tablonun oluşturulan boş satırına bilgileri ekle.
            }
            dgvListele.DataSource = dt; // Hayali tablo içindeki bilgilerle beraber DataGridView içine aktarılır ,böylece veriler görünür hale gelir.
        }

        private void btnUrunListele_Click_1(object sender, EventArgs e)
        {

            List<Urun> dbUrunListesi = db.Urun.ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Ürün Adı");
            dt.Columns.Add("Boyut");
            dt.Columns.Add("Materyal");
            dt.Columns.Add("Aktif Mi");

            foreach (Urun urn in dbUrunListesi)
            {
                DataRow row = dt.NewRow();
                row["ID"] = urn.ID;
                row["Ürün Adı"] = urn.UrunAdi;
                row["Boyut"] = urn.Boyut.BoyutAdi;
                row["Materyal"] = urn.Materyal.MateryalAdi;
                row["Aktif Mi"] = urn.AktifMi == true ? "Aktif" : "Pasif";

                dt.Rows.Add(row);
            }
            dgvListele.DataSource = dt;
        }

        private void btnTedarikciListele_Click_1(object sender, EventArgs e)
        {
            List<Tedarikci> dbTedarikciListesi = db.Tedarikci.ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Tedarikçi Adı");
            dt.Columns.Add("Telefon");
            dt.Columns.Add("Vergi Dairesi");
            dt.Columns.Add("Vergi Numarası");
            dt.Columns.Add("Aktif Mi");

            foreach (Tedarikci teda in dbTedarikciListesi)
            {
                DataRow row = dt.NewRow();
                row["ID"] = teda.ID;
                row["Tedarikçi Adı"] = teda.TedarikciAdi;
                row["Telefon"] = teda.Telefon;
                row["Vergi Dairesi"] = teda.VergiDairesi;
                row["Vergi Numarası"] = teda.VergiNo;
                row["Aktif Mi"] = teda.AktifMi == true ? "Aktif" : "Pasif";

                dt.Rows.Add(row);
            }
            dgvListele.DataSource = dt;
        }

        private void btnAdminGuncelle_Click_1(object sender, EventArgs e)
        {
            Admin dbAdmin = db.Admin.Where(x => x.ID == IdInfo).FirstOrDefault();

            dbAdmin.UserName = txtAdminUserName.Text;
            dbAdmin.Telefon = txtAdminTelefon.Text;
            db.SaveChanges();
            btnAdminListele.PerformClick(); //Veriler kayıt edildikten sonra tekrardan admin listele butonuna basmadan listenin otomatik güncellenmesini sağlar.
        }

        private void btnTedarikciGuncelle_Click_1(object sender, EventArgs e)
        {
            Tedarikci dbTedarikci = db.Tedarikci.Where(x => x.ID == IdInfo).FirstOrDefault();

            dbTedarikci.TedarikciAdi = txtTedarikciAdi.Text;
            dbTedarikci.Email = txtTedarikciEmail.Text;
            db.SaveChanges();
            btnTedarikciGuncelle.PerformClick();
        }

        private void btnUrunGuncelle_Click_1(object sender, EventArgs e)
        {
            Urun dbUrun = db.Urun.FirstOrDefault(x => x.ID == IdInfo);

            dbUrun.UrunAdi = txtUrunAdi.Text;
            if (cmbUrunAktifMi.SelectedIndex == 0)
            {
                dbUrun.AktifMi = true;
            }
            else if (cmbUrunAktifMi.SelectedIndex == 1)
            {
                dbUrun.AktifMi = false;
            }
            else
            {
                MessageBox.Show("Lütfen ürünün aktiflik durumunu seçiniz.");
            }
            db.SaveChanges();
            btnUrunListele.PerformClick();
        }

        private void dgvListele_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {

            DataGridViewRow selectedRow = dgvListele.SelectedRows[0]; // Seçilen ilk satırı alır.
            IdInfo = Convert.ToInt16(selectedRow.Cells[0].Value);      // Seçilen satırın ilk hücredeki(ID) değerini değişkene atar.

            string sutunAdi = selectedRow.DataGridView.Columns[1].Name; // 2. sütunun adını değişkene atar

            if (sutunAdi == "Kullanıcı Adı")
            {
                txtAdminUserName.Text = selectedRow.Cells[1].Value.ToString();
                txtAdminTelefon.Text = selectedRow.Cells[3].Value.ToString();
            }
            else if (sutunAdi == "Tedarikçi Adı")
            {
                txtTedarikciAdi.Text = selectedRow.Cells[1].Value.ToString();
                txtTedarikciEmail.Text = selectedRow.Cells[3].Value.ToString();
            }
            else if (sutunAdi == "Ürün Adı")
            {
                txtUrunAdi.Text = selectedRow.Cells[1].Value.ToString();
                if (selectedRow.Cells[4].Value.ToString() == "Aktif")
                {
                    cmbUrunAktifMi.SelectedIndex = 0;
                }
                else
                {
                    cmbUrunAktifMi.SelectedIndex = 1;
                }
            }
        }
    }
}