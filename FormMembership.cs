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
    public partial class FormMembership: Form
    {
        public FormMembership()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormInputMember formTambahMember = new FormInputMember();
            formTambahMember.Location = new Point(500, 225);
            formTambahMember.Show();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            FormUpdateMember formUbahMember = new FormUpdateMember();
            formUbahMember.Location = new Point(500, 225);
            formUbahMember.Show();
        }
    }
}
