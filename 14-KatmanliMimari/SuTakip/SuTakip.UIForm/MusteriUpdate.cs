using SuTakip.BLL.Repository.Models;
using SuTakip.BLL.Repository.Service;
using SuTakip.DAL.DB;
using System.Windows.Forms;

namespace SuTakip.UIForm
{
    public partial class MusteriUpdate : Form
    {
        public MusteriGuncelleDTO musteriGuncelleDTO;
        EntityService service;
        public MusteriUpdate()
        {
            InitializeComponent();
            service = new EntityService();
        }

        private void MusteriUpdate_Load(object sender, System.EventArgs e)
        {
            txtFirmaAdi.Text = musteriGuncelleDTO.FirmaAdi;
            txtYetkiliAdSoyad.Text = musteriGuncelleDTO.YetkiliAdSoyad;
            txtTelefon.Text = musteriGuncelleDTO.Telefon;
            txtEmail.Text = musteriGuncelleDTO.Email;
            txtAdres.Text = musteriGuncelleDTO.Adres;
            chkToptan.Checked = musteriGuncelleDTO.ToptanMi;
            nupIskonto.Value = musteriGuncelleDTO.Iskonto;
            chkAktif.Checked = musteriGuncelleDTO.AktifMi;
        }

        private void btnGuncelle_Click(object sender, System.EventArgs e)
        {
            Musteri updateMusteri = new Musteri
            {
                ID = musteriGuncelleDTO.ID,
                MusteriFirma = txtFirmaAdi.Text,
                YetkiliAdSoyad = txtYetkiliAdSoyad.Text,
                Telefon = txtTelefon.Text,
                Email = txtEmail.Text,
                Adres = txtAdres.Text,
                Toptanmi = chkToptan.Checked,
                IskontoOran = (int)nupIskonto.Value,
                AktifMi = chkAktif.Checked
            };
            string[] control = { updateMusteri.MusteriFirma, updateMusteri.YetkiliAdSoyad, updateMusteri.Telefon, updateMusteri.Email, updateMusteri.Adres };

            foreach (var item in control)
            {
                if (item.Trim() == "")
                {
                    MessageBox.Show("Tüm Alanları Doldurunuz!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            bool result = service.MusteriService.MusteriGuncelle(updateMusteri);
            if (result)
            {
                MessageBox.Show("Müşteri güncelleme Başarılı", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Müşteri güncelleme Başarısız", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }

}
