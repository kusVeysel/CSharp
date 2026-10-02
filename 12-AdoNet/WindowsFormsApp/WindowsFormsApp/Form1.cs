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

            string sorgu = $"SELECT * FROM TestTable WHERE UserName = '{kadi}' AND Password = '{sifre}'";

            SqlCommand cmd = new SqlCommand(sorgu, ConnectService.ConnectSql()); // SqlCommand VeriTabanı ile .NET kodu arasındaki bağlantıdır , parametresi → (hangi sorgu sorulacak , hangi kapıdan geçecek)

            SqlDataReader rdr = cmd.ExecuteReader(); // VeriTabanından gelen sonuçlar bir okuyucu içine doldurulur, ExecuteReader: Geriye birden fazla satır/sütun dönecekse kullanılır , SqlDataReader = Veriyi okuyup geçsin.

            if (rdr.HasRows) // Okuyucuda en az 1 satır var mı
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

            rdr.Close();
            ConnectService.ConnectSql().Close();
            // Bağlantılar kapatılır.
        }
    }
}
