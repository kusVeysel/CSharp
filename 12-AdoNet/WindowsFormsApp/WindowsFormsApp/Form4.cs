using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            if (txtAciklama.Text.Trim() == "" || txtKategoriAdi.Text == "")
            {
                MessageBox.Show("Gerekli bilgileri giriniz.");
            }
            else
            {
                string query = $"insert into Categories (CategoryName,Description) values('{txtKategoriAdi.Text}','{txtAciklama.Text}') ";

                SqlCommand cmd = new SqlCommand(query, ConnectService.ConnectSql());

                var result = cmd.ExecuteNonQuery();
                ConnectService.ConnectSql().Close();
                if (result > 0)
                {
                    MessageBox.Show("Ekleme İşlemi Başarılı");
                    Methods.ClearControls(this);
                }
                else
                {
                    MessageBox.Show("Ekleme İşlemi Başarısız");
                }
            }
        }
    }
}
