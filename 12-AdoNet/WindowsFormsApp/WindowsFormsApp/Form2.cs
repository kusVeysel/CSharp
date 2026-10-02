using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnKategoriDataGetir_Click(object sender, EventArgs e)
        {
            string command = "select * from Categories";

            SqlCommand cmd = new SqlCommand(command, ConnectService.ConnectSql());

            SqlDataAdapter adapter = new SqlDataAdapter(cmd); // Verileri VeriTabanından çeker ve değişkene atar, SqlDataAdapter: Veri bir tabloya aktarılacaksa kullanılır.

            DataTable dt = new DataTable(); // Ram üzerinde hayali bir tablo oluşturulur.
            adapter.Fill(dt); // Veriler değişkenden alınır ve Ram üzerinde oluşturulan DataTable'ye(Hayali Tablo) eklenir.

            dgvData.DataSource = dt; // Veriler DataTable'den(Hayali Tablo) DataGridView'e(Bilgisayara) aktarılır.

            ConnectService.ConnectSql().Close();
        }

        private void btnUrunDataGetir_Click(object sender, EventArgs e)
        {
            string command = "select * from Products";

            SqlCommand cmd = new SqlCommand(command, ConnectService.ConnectSql());

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgvData.DataSource = dt;

            ConnectService.ConnectSql().Close();
        }

        private void Form3Ac_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm3 = new Form3();
            frm3.Show();
        }

    }
}
