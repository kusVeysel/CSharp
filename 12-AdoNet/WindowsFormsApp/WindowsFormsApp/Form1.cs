using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kadi = txtKadi.Text;
            string sifre = txtSifre.Text;

            string sorgu = $"SELECT * FROM TestTable WHERE UserName = '{kadi} AND Password = '{sifre}'";

            SqlCommand cmd = new SqlCommand(sorgu, ConnectService.ConnectSql()); // SqlCommand VeriTabanı ile .NET kodu arasındaki bağlantıdır , parametresi → (hangi sorgu sorulacak , hangi kapıdan geçecek)

            SqlDataReader rdr = cmd.ExecuteReader();
            // ExecuteReader: SELECT gibi birden fazla satır ve sütun döndürebilen sorguları çalıştırır ve geriye SqlDataReader nesnesi döndürür.
            // SqlDataReader: Verileri belleğe tamamen yüklemeden, veritabanından gelen sonuçları satır satır okur. Salt okunur (read-only) ve ileri yönlü (forward-only) çalışır.

            if (rdr.HasRows) // Okuyucuda en az 1 satır verinin olup olmadığını kontrol eder.
            {
                MessageBox.Show("Giriş başarılı!");
                this.Hide();
                Form2 frm = new Form2();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
            }

            // İşlem tamamlandıktan sonra okuyucu ve komutun bağlı olduğu bağlantı kapatılır.
            rdr.Close();
            ConnectService.ConnectSql().Close();
        }
    }
}
