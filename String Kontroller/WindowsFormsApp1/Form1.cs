using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // txtAdSoyad.Text = "Veysel KUŞ";
            lblHesap.Text = "TL";
            cmbKatagori.Items.Add("Veysel KUŞ");
            cmbKatagori.Items.Add("İlayda KUŞ");
            cmbKatagori.Items.Add("Milay KUŞ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adSoyad = txtAdSoyad.Text.Trim(); // Trim() baştaki ve sondaki boşlukları siler
            if(adSoyad.ToLower() =="veysel kuş")
            {
                lblHesap.Text = "1000TL";
            }
            else if (adSoyad.ToLower().Contains("veys")) // yazılan text'in içinde veys geçiyorsa label 1000TL yazar
            {
                lblHesap.Text = "1000TL";
            }  
            else if(adSoyad.ToLower() =="ilayda kuş")
            {
                lblHesap.Text = "2000TL";
            }
            else
            {
                lblHesap.Text = "0TL";
            }
        }
    }
}
