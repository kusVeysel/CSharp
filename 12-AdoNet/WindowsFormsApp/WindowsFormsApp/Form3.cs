using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Methods.DgvRefreshData(this); // From3'ü, Methods adı altındaki DgvRefreshData methoduna gönderir.
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string karakter = txtKarakter.Text;
            int eklenecekStok = Convert.ToInt32(numericUpDown1.Value);
            string query = "";

            if (eklenecekStok <= 0)
            {
                MessageBox.Show("Stok Sayısı 0'dan Büyük Olmalı");
            }
            else
            {
                if (karakter.Trim() != "")
                {
                    query = $" update Products set UnitsInStock += {eklenecekStok} where ProductName like '{karakter}%'";
                }
                else
                {
                    query = $" update Products set UnitsInStock += {eklenecekStok}";
                }

                SqlCommand cmd = new SqlCommand(query, ConnectService.ConnectSql());
                cmd.ExecuteNonQuery();  // ExecuteNonQuery: Veritabanında INSERT, UPDATE ve DELETE gibi veri döndürmeyen SQL sorgularını çalıştırmak için kullanılır. Sorgunun sonucunda satır/sütun şeklinde veri döndürmez. Geriye, işlemden etkilenen satır sayısını int olarak döndürür.          
                Methods.DgvRefreshData(this);
            }
        }

        private void btnform4ac_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 frm4 = new Form4();
            frm4.Show();
        }

    }
}
