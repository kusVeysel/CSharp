using Pizza.Modeller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class SipMenü : Form
    {
        public SipMenü()
        {
            InitializeComponent();
        }

        private void SipMenü_Load(object sender, EventArgs e)
        {
            cmbPizzaAdi.Items.Add("Lütfen Pizza Seçiniz...");
            cmbPizzaAdi.Items.Add("Karışık");
            cmbPizzaAdi.Items.Add("Sucuklu");
            cmbPizzaAdi.Items.Add("Peynirli");
            cmbPizzaAdi.SelectedIndex = 0;//ilk yazılan seçili olarak gelir

            cmbIcecekAdi.Items.Add("Lütfen İçecek Seçiniz...");
            cmbIcecekAdi.Items.Add("Fanta");
            cmbIcecekAdi.Items.Add("Ayran");
            cmbIcecekAdi.Items.Add("Pepsi");
            cmbIcecekAdi.SelectedIndex = 0;

            cmbPizzaBoyut.Items.Add("Pizza Boyutunu Seçiniz...");
            cmbPizzaBoyut.Items.Add("Orta");
            cmbPizzaBoyut.Items.Add("Büyük");
            cmbPizzaBoyut.SelectedIndex = 0;

            cmbIcecekBoyut.Items.Add("İçecek Boyutunu Seçiniz...");
            cmbIcecekBoyut.Items.Add("Küçük");
            cmbIcecekBoyut.Items.Add("Orta");
            cmbIcecekBoyut.Items.Add("Büyük");
            cmbIcecekBoyut.SelectedIndex = 0;
        }
        

        private void cmbPizzaAdi_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (cmbPizzaAdi.Text)
            {
                case "Karışık":
                    pictureBox1.Image = ımageList1.Images["Karışık.jpg"];
                    break;
                case "Sucuklu":
                    pictureBox1.Image = ımageList1.Images["Sucuklu.jpg"];
                    break;
                case "Peynirli":
                    pictureBox1.Image = ımageList1.Images["Peynirli.jpg"];
                    break;
                case "Lütfen Pizza Seçiniz...":
                    pictureBox1.Image = ımageList1.Images["pizzabulls.jpg"];
                    break;
                default:
                    pictureBox1.Image = ımageList1.Images["pizzabulls.jpg"];
                    break;
            }
        }

        private void btnOnSiparis_Click(object sender, EventArgs e)
        {
            List<Urun> urunListesi = new List<Urun>();

            Musteri musteri = new Musteri()
            {
                IsimSoyisim = txtİsim.Text,
                Email = txtEmail.Text,
                TelefonNo = txtTelefon.Text,
                Adres = txtAdres.Text
            };

            Urun pizza = new Urun()
            {
                UrunAdi = cmbPizzaAdi.Text,
                Boyut = cmbPizzaBoyut.Text,
                KatagoriAdi = "Pizza"
            };
            urunListesi.Add(pizza);

            Urun icecek = new Urun()
            {
                UrunAdi = cmbIcecekAdi.Text,
                Boyut = cmbIcecekBoyut.Text,
                KatagoriAdi = "İçecek"
            };
            urunListesi.Add(icecek);


            int pizzaAdet = Convert.ToInt32(txtPizzaAdet.Text);
            int icecekAdet = Convert.ToInt32(txtIcecekAdet.Text);

            SiparisMod adisyon = Methodlar.OnSiparisIsle(musteri, urunListesi, pizzaAdet, icecekAdet);

            lblMusteriBilgi.Text = $"{adisyon?.MusteriInfo?.IsimSoyisim}=>{adisyon?.MusteriInfo?.TelefonNo}=>{adisyon?.MusteriInfo?.Adres}";

            lblUrunBilgi.Text = $"Pizza=> {adisyon.UrunBilgileri.Where(x => x.KatagoriAdi == "Pizza").FirstOrDefault().UrunAdi}=>{adisyon.UrunBilgileri.Where(x => x.KatagoriAdi == "Pizza").FirstOrDefault().Boyut}\n İçecek=> {adisyon.UrunBilgileri.Where(x => x.KatagoriAdi == "İçecek").FirstOrDefault().UrunAdi}=>{ adisyon.UrunBilgileri.Where(x => x.KatagoriAdi == "İçecek").FirstOrDefault().Boyut} "; 

            lblPizzaBirim.Text=adisyon.UrunBilgileri.Where(x=>x.KatagoriAdi=="Pizza").FirstOrDefault().Fiyat.ToString()+"₺";
            lblIcecekBirim.Text=adisyon.UrunBilgileri.Where(x=>x.KatagoriAdi=="İçecek").FirstOrDefault().Fiyat.ToString()+"₺";
            lblToplam.Text = adisyon.ToplamTutar.ToString() + "₺";
        }


        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            List<Urun> urunListesi = new List<Urun>();

            Musteri musteri = new Musteri()
            {
                IsimSoyisim = txtİsim.Text,
                Email = txtEmail.Text,
                TelefonNo = txtTelefon.Text,
                Adres = txtAdres.Text
            };

            Urun pizza = new Urun()
            {
                UrunAdi = cmbPizzaAdi.Text,
                Boyut = cmbPizzaBoyut.Text,
                KatagoriAdi = "Pizza"
            };
            urunListesi.Add(pizza);

            Urun icecek = new Urun()
            {
                UrunAdi = cmbIcecekAdi.Text,
                Boyut = cmbIcecekBoyut.Text,
                KatagoriAdi = "İçecek"
            };
            urunListesi.Add(icecek);


            int pizzaAdet = Convert.ToInt32(txtPizzaAdet.Text);
            int icecekAdet = Convert.ToInt32(txtIcecekAdet.Text);

            SiparisMod adisyon = Methodlar.OnSiparisIsle(musteri, urunListesi, pizzaAdet, icecekAdet);

            Urun pizzaVeri = adisyon.UrunBilgileri.Where(x => x.KatagoriAdi == "Pizza").FirstOrDefault();
            Urun icecekVeri = adisyon.UrunBilgileri.Where(x => x.KatagoriAdi == "İçecek").FirstOrDefault();
            
            lstOnayli.Items.Add($"Müşteri Bilgisi=>{adisyon.MusteriInfo.IsimSoyisim}=>{adisyon.MusteriInfo.TelefonNo}=>{adisyon.MusteriInfo.Adres}");

            lstOnayli.Items.Add($"Pizza Bilgisi=>{pizzaVeri.UrunAdi}=>{pizzaVeri.Boyut}=>{pizzaVeri.Fiyat} ₺=>{pizzaAdet} Adet");
            lstOnayli.Items.Add($"İçecek Bilgisi=>{icecekVeri.UrunAdi}=>{icecekVeri.Boyut}=>{icecekVeri.Fiyat} ₺=>{icecekAdet} Adet");

            lstOnayli.Items.Add($"Toplam Tutar=>{adisyon.ToplamTutar} ₺");
        }
    }
}