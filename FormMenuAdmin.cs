using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POM_BENSIN_ALDILATEEF
{
    public partial class FormMenuAdmin: Form
    {
        public FormMenuAdmin()
        {
            InitializeComponent();
        }

        private void FormMenuAdmin_Load(object sender, EventArgs e)
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

        private void btnBensinAdmin_Click(object sender, EventArgs e)
        {
            FormBensin formBensin = new FormBensin(); // Buat instance
            bukaFormAnak(formBensin); // Tampilkan

            try
            {
                string connectionString = "Data Source=10.1.51.134;Initial Catalog=ALDILATEEF;User ID=sa;Password=2305;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT oktan, harga_perliter, point_bensin, stok_bensin, status FROM Bensin";
                    SqlCommand com = new SqlCommand(query, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    formBensin.dgvBensin.DataSource = dt;
                    formBensin.dgvBensin.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan : " + ex.Message);
            }
        }

        private void btnLogoutAdmin_Click(object sender, EventArgs e)
        {
            //Keluar dari halaman menu Admin
            this.Close(); 
        }

        private void btnProdukAdmin_Click(object sender, EventArgs e)
        {
            bukaFormAnak(new FormProduk());
        }

        private void btnDashboardAdmin_Click(object sender, EventArgs e)
        {
            bukaFormAnak(new FormDashboardAdmin());
        }

        private void btnPegawaiAdmin_Click(object sender, EventArgs e)
        {
            bukaFormAnak(new FormPegawai());
        }
    }


}
