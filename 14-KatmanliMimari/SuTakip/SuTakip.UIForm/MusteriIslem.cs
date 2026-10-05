using SuTakip.BLL.Repository.Models;
using SuTakip.BLL.Repository.Service;
using SuTakip.DAL.DB;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SuTakip.UIForm
{
    public partial class MusteriIslemleri : Form
    {
        EntityService service;
        public MusteriIslemleri()
        {
            InitializeComponent();
            service = new EntityService();
        }

        private void MusteriIslem_Load(object sender, EventArgs e)
        {
            List<Musteri> dbresult = service.MusteriService.GetAll();
            dgvMusteriListe.DataSource = dbresult;
        }

        private void dgvMusteriListe_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var seciliSatir = dgvMusteriListe.SelectedRows[0];
            MusteriGuncelleDTO dto = new MusteriGuncelleDTO();

            dto.ID = Convert.ToInt32(seciliSatir.Cells[0].Value);
            dto.FirmaAdi = seciliSatir.Cells[1].Value.ToString();
            dto.YetkiliAdSoyad = seciliSatir.Cells[2].Value.ToString();
            dto.Telefon = seciliSatir.Cells[3].Value.ToString();
            dto.Email = seciliSatir.Cells[4].Value.ToString();
            dto.Adres = seciliSatir.Cells[5].Value.ToString();
            dto.ToptanMi = Convert.ToBoolean(seciliSatir.Cells[6].Value);
            dto.Iskonto = Convert.ToInt32(seciliSatir.Cells[7].Value);
            dto.AktifMi = Convert.ToBoolean(seciliSatir.Cells[8].Value);

            MusteriUpdate musteriUpdate = new MusteriUpdate();
            musteriUpdate.musteriGuncelleDTO = dto;
            musteriUpdate.ShowDialog();
        }
    }
}
