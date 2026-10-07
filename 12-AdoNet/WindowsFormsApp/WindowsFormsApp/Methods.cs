using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public static class Methods
    {
        public static void DgvRefreshData(Form3 frm3)
        {
            string command = "select * from Products";

            SqlCommand cmd = new SqlCommand(command, ConnectService.ConnectSql());

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach (Control c in frm3.Controls) // Form3'ün kontrolleri(ComboBox,TextBox,Label...) üzerinde dönülür.
            {
                if (c is DataGridView dgv) // Form3'ün kontrollerinde dönerken o anki kontrol DataGridView olup olmadığı kontrol eder.
                {
                    dgv.DataSource = null;
                    dgv.DataSource = dt;
                }
            }

            ConnectService.ConnectSql().Close();
        }
        public static void ClearControls(Form4 form4)
        {
            var cont = form4.Controls;

            foreach (Control item in cont)
            {
                if (item is TextBox txt)
                {
                    txt.Text = "";
                }
            }
        }
    }
}