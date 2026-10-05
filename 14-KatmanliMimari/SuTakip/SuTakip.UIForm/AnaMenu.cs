using System;
using System.Windows.Forms;

namespace SuTakip.UIForm
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void btnMusteriFrom_Click(object sender, EventArgs e)
        {
            MusteriIslemleri musteriIslem = new MusteriIslemleri();
            var aa = MessageBox.Show("Müşteri İşlemleri açılıyor... Güncelleyeğiniz müşteri satırına doubleclick  yapınız!", "info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (aa == DialogResult.OK)
            {
                musteriIslem.ShowDialog();
            }
        }
    }
}
