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
            string koneksi = "Data Source=10.1.51.134;Initial Catalog=ALDILATEEF;User ID=sa;Password=2305;";
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            using (SqlConnection conn = new SqlConnection(koneksi))
            {
                string query = @"SELECT p.id_pegawai, p.Nama_Pegawai, s.kategori 
                         FROM Pegawai p 
                         JOIN Setting s ON p.id_setting = s.id_setting 
                         WHERE p.id_pegawai = @username AND p.Password = @password AND p.status = 1";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string idPegawai = reader["id_pegawai"].ToString();
                    string namaPegawai = reader["Nama_Pegawai"].ToString();
                    string role = reader["kategori"].ToString();

                    // Simpan ke session
                    SesiPengguna.IdPegawai = idPegawai;
                    SesiPengguna.NamaPegawai = namaPegawai;
                    SesiPengguna.Kategori = role;

                    MessageBox.Show("Login berhasil sebagai " + role);

                    this.Hide(); // Sembunyikan form login

                    if (role == "Admin")
                    {
                        FormMenuAdmin formMenuAdmin = new FormMenuAdmin();
                        formMenuAdmin.ShowDialog();
                        this.Show();
                    }
                    else if (role == "Kasir")
                    {
                        FormMenuKasir formMenuKasir = new FormMenuKasir();
                        formMenuKasir.ShowDialog();
                        this.Show();
                    }

                    txtUsername.Clear();
                    txtPassword.Clear();
                }
                else
                {
                    MessageBox.Show("ID Pegawai atau Password salah.");
                }
            }
        }
    }
}
