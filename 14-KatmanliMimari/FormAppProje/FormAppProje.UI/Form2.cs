using FormAppProje.BLL.DTO;
using FormAppProje.BLL.Repository.Service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormAppProje.UI
{
    public partial class Form2 : Form
    {
        EntityService service;
        public Form2()
        {
            InitializeComponent();
            service = new EntityService();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<CalisanDTO> dtoList = service.EmpService.CalisanOzetGetir();

            dataGridView1.DataSource = dtoList;

        }
    }
}
