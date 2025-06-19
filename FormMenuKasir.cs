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
    public partial class FormMenuKasir: Form
    {
        public FormMenuKasir()
        {
            InitializeComponent();
        }

        private void FormMenuKasir_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        //Method untuk isi panel samping menu
        private Form formAktif = null;
        private void bukaFormAnak(Form formAnak)
        {
            if (formAktif != null)
                formAktif.Close();
            formAktif = formAnak;
            formAnak.TopLevel = false;
            formAnak.FormBorderStyle = FormBorderStyle.None;
            formAnak.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(formAnak);
            panelChildForm.Tag = formAnak;
            formAnak.BringToFront();
            formAnak.Show();
        }

        private void btnProduk_Click(object sender, EventArgs e)
        {
            bukaFormAnak(new FormInputPenjualanBensin());
        }

        private void btnDashboardKasir_Click(object sender, EventArgs e)
        {
            bukaFormAnak(new FormDashboardKasir());
        }

        private void btnPenjualanProduk_Click(object sender, EventArgs e)
        {
            bukaFormAnak(new FormPenjualanProduk());
        }

        private void btnLogoutKasir_Click(object sender, EventArgs e)
        {
            //Keluar dari halaman menu kasir
            this.Close();
        }

        private void btnMembership_Click(object sender, EventArgs e)
        {
            bukaFormAnak(new FormMembership());
        }
    }
}
