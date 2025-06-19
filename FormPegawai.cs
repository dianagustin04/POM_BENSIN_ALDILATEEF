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
    public partial class FormPegawai: Form
    {
        public FormPegawai()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormInputPegawai formTambahPegawai = new FormInputPegawai();
            formTambahPegawai.Location = new Point(500, 225);
            formTambahPegawai.Show();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            FormUpdatePegawai formUbahPegawai = new FormUpdatePegawai();
            formUbahPegawai.Location = new Point(500, 225);
            formUbahPegawai.Show();
        }
    }
}
