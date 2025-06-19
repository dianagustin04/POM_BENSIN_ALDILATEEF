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
    public partial class FormUpdateMember: Form
    {
        public FormUpdateMember()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtIdMember.Clear();
            txtNamaMember.Clear();
            txtNoTelepon.Clear();
            dtpTanggalBergabung.Value = DateTime.Now;
        }
    }
}
