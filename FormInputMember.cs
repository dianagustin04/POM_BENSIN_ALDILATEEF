﻿using System;
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
    public partial class FormInputMember: Form
    {
        public FormInputMember()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            txtIdMember.Clear();
            txtNamaMember.Clear();
            txtNoTelepon.Clear();
            dtpTanggalBergabung.Value = DateTime.Now;
        }
    }
}
