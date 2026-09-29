using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AdoNet
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void btnKategoriEkle_Click_1(object sender, EventArgs e)
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