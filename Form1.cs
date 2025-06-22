using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace POM_BENSIN_ALDILATEEF
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

        }
                                           
        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string koneksi = "Data Source=192.168.77.206;Initial Catalog=ALDILATEEF;User ID=sa;Password=2305;";
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Pastikan username berupa angka
            if (!int.TryParse(username, out int idPegawai))
            {
                MessageBox.Show("ID Pegawai harus berupa angka.");
                return;
            }

            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            using (SqlConnection conn = new SqlConnection(koneksi))
            {
                SqlCommand cmd = new SqlCommand("spLoginPegawai", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pegawai", idPegawai);
                cmd.Parameters.AddWithValue("@password", passwordBytes);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string namaPegawai = reader["nama_pegawai"].ToString();
                        string jabatan = reader["jabatan"].ToString();

                        // Simpan ke sesi
                        SesiPengguna.IdPegawai = idPegawai.ToString();
                        SesiPengguna.NamaPegawai = namaPegawai;
                        SesiPengguna.Kategori = jabatan;

                        MessageBox.Show("Login berhasil sebagai " + jabatan);

                        this.Hide();

                        if (jabatan == "Admin")
                            new FormMenuAdmin().ShowDialog();
                        else if (jabatan == "Kasir")
                            new FormMenuKasir().ShowDialog();
                        else
                            MessageBox.Show("Hak akses tidak dikenali.");

                        this.Show();
                        txtUsername.Clear();
                        txtPassword.Clear();
                    }
                    else
                    {
                        MessageBox.Show("ID Pegawai atau Password salah.");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }
            }
        }
    }
}
