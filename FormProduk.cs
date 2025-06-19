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
    public partial class FormProduk: Form
    {
        public FormProduk()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormInputProduk formTambahProduk = new FormInputProduk();
            formTambahProduk.Location = new Point(500, 225);
            formTambahProduk.Show();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            FormUpdateProduk formUbahProduk = new FormUpdateProduk();
            formUbahProduk.Location = new Point(500, 225);
            formUbahProduk.Show();
        }
    }
}
