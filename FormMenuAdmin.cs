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
            try
            {
                // 1. Tampilkan form anak
                FormBensin formBensin = new FormBensin();
                bukaFormAnak(formBensin);

                // 2. Koneksi ke database
                string connStr = "Data Source=192.168.77.206;Initial Catalog=ALDILATEEF;User ID=sa;Password=2305;";
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand cmd = new SqlCommand("spTampilBensin", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // 3. Tampilkan ke DataGridView
                    formBensin.dgvBensin.AutoGenerateColumns = true;
                    formBensin.dgvBensin.DataSource = dt;
                    formBensin.dgvBensin.ReadOnly = true;

                    // 4. Atur header kolom
                    formBensin.dgvBensin.Columns["id_bensin"].HeaderText = "ID";
                    formBensin.dgvBensin.Columns["nama_bensin"].HeaderText = "Nama Bensin";
                    formBensin.dgvBensin.Columns["oktan"].HeaderText = "Oktan";
                    formBensin.dgvBensin.Columns["harga_perliter"].HeaderText = "Harga/Liter";
                    formBensin.dgvBensin.Columns["point_bensin"].HeaderText = "Poin";
                    formBensin.dgvBensin.Columns["stok_bensin"].HeaderText = "Stok";
                    formBensin.dgvBensin.Columns["status"].HeaderText = "Status";
                    formBensin.dgvBensin.Columns["created_by"].HeaderText = "Dibuat Oleh";
                    formBensin.dgvBensin.Columns["created_date"].HeaderText = "Tanggal Buat";
                    formBensin.dgvBensin.Columns["modif_by"].HeaderText = "Diubah Oleh";
                    formBensin.dgvBensin.Columns["modif_date"].HeaderText = "Tanggal Ubah";

                    formBensin.dgvBensin.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
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
            try
            {
                // 1. Tampilkan form Pegawai
                FormPegawai formPegawai = new FormPegawai();
                bukaFormAnak(formPegawai); // Form anak atau MDI

                // 2. Koneksi ke DB
                string connectionString = "Data Source=192.168.77.206;Initial Catalog=ALDILATEEF;User ID=sa;Password=2305;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spTampilPegawai", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // 3. Tampilkan ke DataGridView
                    formPegawai.dgvPegawai.AutoGenerateColumns = true;
                    formPegawai.dgvPegawai.DataSource = dt;
                    formPegawai.dgvPegawai.ReadOnly = true;

                    // 4. Header Kolom (jika mau rapi)
                    formPegawai.dgvPegawai.Columns["id_pegawai"].HeaderText = "ID";
                    formPegawai.dgvPegawai.Columns["nama_pegawai"].HeaderText = "Nama";
                    formPegawai.dgvPegawai.Columns["jabatan"].HeaderText = "Jabatan";
                    formPegawai.dgvPegawai.Columns["no_telepon"].HeaderText = "Telepon";
                    formPegawai.dgvPegawai.Columns["status"].HeaderText = "Status";
                    formPegawai.dgvPegawai.Columns["created_by"].HeaderText = "Dibuat Oleh";
                    formPegawai.dgvPegawai.Columns["created_date"].HeaderText = "Tanggal Buat";
                    formPegawai.dgvPegawai.Columns["modif_by"].HeaderText = "Diubah Oleh";
                    formPegawai.dgvPegawai.Columns["modif_date"].HeaderText = "Tanggal Ubah";

                    // 5. Barulah Refresh dan Resize
                    formPegawai.dgvPegawai.AutoResizeColumns();
                    formPegawai.dgvPegawai.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }
    }
}
