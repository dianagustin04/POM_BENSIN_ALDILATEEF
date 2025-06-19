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
    public partial class FormUpdatePegawai: Form
    {
        public FormUpdatePegawai()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtIdPegawai.Clear();
            txtNamaPegawai.Clear();
            txtNoTelepon.Clear();
            cmbJabatan.Text = string.Empty;
            //cmbJabatan.SelectedIndex = 0;
        }
    }
}
