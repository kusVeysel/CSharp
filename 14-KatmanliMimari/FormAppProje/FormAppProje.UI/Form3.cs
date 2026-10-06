using FormAppProje.BLL.DTO;
using FormAppProje.BLL.Repository.Service;
using FormAppProje.DAL.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FormAppProje.UI
{
    public partial class Form3 : Form
    {
        EntityService service;
        public Form3()
        {
            InitializeComponent();
            service = new EntityService();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            List<Orders> ordList = service.OrderService.GetAll2();

            cmbSiparisIdList.DataSource = ordList;
            cmbSiparisIdList.ValueMember = "OrderID";
            cmbSiparisIdList.DisplayMember = "OrderID";

        }

        private void cmbSiparisIdList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSiparisIdList.SelectedValue is int)
            {
                int secilenSiparisId = (int)cmbSiparisIdList.SelectedValue;

                SiparisDetaySiparisDTO Siparisvm = service.OrderService.SiparisBilgiGetir(secilenSiparisId);
                Siparisvm.SiparisDetayListesi = service.OrderDetailService.SiparisDetayListeGetir(secilenSiparisId);

                Siparisvm.SiparisToplam = Siparisvm.SiparisDetayListesi.Sum(x => x.UrunToplam);

                lblMusteriAdi.Text = Siparisvm.MusteriAdi;
                lblSiparisTarihi.Text = Siparisvm.SiparisTarihi;
                lblKargoTarihi.Text = Siparisvm.KategoriTarihi;
                lblSiparisToplam.Text = Siparisvm.SiparisToplam.ToString() + " ₺";

                DataTable dt = new DataTable();
                dt.Columns.Add("Ürün Adı");
                dt.Columns.Add("Birim Fiyat");
                dt.Columns.Add("Adet");
                dt.Columns.Add("İndirim Oranı");
                dt.Columns.Add("Toplam Ürün Fiyat");

                foreach (DetayListe dto in Siparisvm.SiparisDetayListesi)
                {
                    DataRow row = dt.NewRow();
                    row["Ürün Adı"] = dto.UrunAdi;
                    row["Birim Fiyat"] = dto.BirimFiyat;
                    row["Adet"] = dto.Adet;
                    row["İndirim Oranı"] = dto.IndirimOrani;
                    row["Toplam Ürün Fiyat"] = dto.UrunToplam;

                    dt.Rows.Add(row);
                }



                dataGridView1.DataSource = dt;

            }
        }
    }
}
