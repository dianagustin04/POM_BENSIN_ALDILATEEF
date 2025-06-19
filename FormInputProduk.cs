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
    public partial class FormInputProduk: Form
    {
        public FormInputProduk()
        {
            InitializeComponent();
        }

        private void FormInputProduk_Load(object sender, EventArgs e)
        {

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            txtIdProduk.Clear();
            txtNamaProduk.Clear();
            cmbJenisProduk.Text = string.Empty;
            //cmbJenisProduk.SelectedIndex = 0;
            txtPointProduk.Clear();
            txtHargaProduk.Clear();
            dtpTanggalKadaluarsa.Value = DateTime.Now;
            txtStok.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
