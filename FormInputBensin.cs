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
    public partial class FormInputBensin: Form
    {
        public FormInputBensin()
        {
            InitializeComponent();
        }
        
        private void FormInputBensin_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                
        private void btnBatal_Click_1(object sender, EventArgs e)
        {
            txtIdBensin.Clear();
            txtNamaBensin.Clear();
            txtOktan.Clear();
            txtHargaPerliter.Clear();
            txtStokBensin.Clear();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {

        }
    }
}
