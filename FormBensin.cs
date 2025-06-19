using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POM_BENSIN_ALDILATEEF
{
    public partial class FormBensin: Form
    {
        public FormBensin()
        {
            InitializeComponent();
        }
        
        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormInputBensin formTambahBensin = new FormInputBensin();
            formTambahBensin.Location = new Point(500, 225);
            formTambahBensin.Show();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            FormUpdateBensin formUbahBensin = new FormUpdateBensin();
            formUbahBensin.Location = new Point(500, 225);
            formUbahBensin.Show();
        }

        private void dgvBensin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
