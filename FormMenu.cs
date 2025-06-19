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
    public partial class FormMenu: Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            //Memanggil customizeDesign
            customizeDesign();

        }

        //Untuk kustom design tampilan awal
        private void customizeDesign()
        {
            panelSubTransaksi.Visible = false;
            panelSubProduk.Visible = false;
            panelSubBensin.Visible = false;
            panelSubLaporan.Visible = false;
        }

        //Untuk hide sub menu ketika di klik
        private void hideSubMenu()
        {
            if (panelSubTransaksi.Visible == true)
                panelSubTransaksi.Visible = false;
            if (panelSubProduk.Visible == true)
                panelSubProduk.Visible = false;
            if (panelSubBensin.Visible == true)
                panelSubBensin.Visible = false;
            if (panelSubLaporan.Visible == true)
                panelSubBensin.Visible = false;
        }

        //kendali sub menu button
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                // ini untuk hide masing masing sub ketika ada yang di klik
                //hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        } 

        private void btnTransaksi_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelSubTransaksi);
        }

        private void btnTransaksiPenjualanBensin_Click(object sender, EventArgs e)
        {
            FormInputBensin formBensin = new FormInputBensin();
            formBensin.Show();
            //..
            //your codes
            //
            hideSubMenu();
        }

        private void btnTransaksiPenjualanProduk_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //
            hideSubMenu();
        }

        private void btnTransaksiPenukaranPoint_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //
            hideSubMenu();
        }

        private void btnProdukLihatProduk_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //
            hideSubMenu();
        }

        private void btnBensinLihatBensin_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //
            hideSubMenu();
        }

        private void btnLaporanPenjualanBensin_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //
            hideSubMenu();
        }

        private void btnLaporanPenjualanProduk_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //
            hideSubMenu();
        }

        private void btnLaporanPenukaranPoint_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //
            hideSubMenu();
        }

        private void btnProduk_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubProduk);
        }

        private void btnBensin_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubBensin);
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubLaporan);
        }
    }
}
