namespace POM_BENSIN_ALDILATEEF
{
    partial class FormMenuKasir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuKasir));
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMembership = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnPenukaranPoint = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnPenjualanProduk = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnPenjualanBensin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDashboardKasir = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLogoutKasir = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panelChildForm = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 302);
            this.panel1.TabIndex = 1;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.ErrorImage = null;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-25, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(498, 318);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(223)))), ((int)(((byte)(178)))));
            this.guna2Panel1.Controls.Add(this.btnMembership);
            this.guna2Panel1.Controls.Add(this.btnPenukaranPoint);
            this.guna2Panel1.Controls.Add(this.btnPenjualanProduk);
            this.guna2Panel1.Controls.Add(this.btnPenjualanBensin);
            this.guna2Panel1.Controls.Add(this.btnDashboardKasir);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Controls.Add(this.btnLogoutKasir);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(405, 1144);
            this.guna2Panel1.TabIndex = 1;
            // 
            // btnMembership
            // 
            this.btnMembership.Animated = true;
            this.btnMembership.AutoRoundedCorners = true;
            this.btnMembership.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMembership.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMembership.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMembership.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMembership.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMembership.FillColor = System.Drawing.Color.OliveDrab;
            this.btnMembership.FillColor2 = System.Drawing.Color.LightCoral;
            this.btnMembership.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMembership.ForeColor = System.Drawing.Color.White;
            this.btnMembership.Image = global::POM_BENSIN_ALDILATEEF.Properties.Resources.membership_card;
            this.btnMembership.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMembership.ImageOffset = new System.Drawing.Point(25, 0);
            this.btnMembership.ImageSize = new System.Drawing.Size(35, 35);
            this.btnMembership.Location = new System.Drawing.Point(28, 662);
            this.btnMembership.Name = "btnMembership";
            this.btnMembership.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnMembership.Size = new System.Drawing.Size(350, 70);
            this.btnMembership.TabIndex = 12;
            this.btnMembership.Text = "MEMBERSHIP";
            this.btnMembership.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMembership.Click += new System.EventHandler(this.btnMembership_Click);
            // 
            // btnPenukaranPoint
            // 
            this.btnPenukaranPoint.Animated = true;
            this.btnPenukaranPoint.AutoRoundedCorners = true;
            this.btnPenukaranPoint.BackColor = System.Drawing.Color.Transparent;
            this.btnPenukaranPoint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPenukaranPoint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPenukaranPoint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPenukaranPoint.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPenukaranPoint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPenukaranPoint.FillColor = System.Drawing.Color.OliveDrab;
            this.btnPenukaranPoint.FillColor2 = System.Drawing.Color.LightCoral;
            this.btnPenukaranPoint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPenukaranPoint.ForeColor = System.Drawing.Color.White;
            this.btnPenukaranPoint.Image = global::POM_BENSIN_ALDILATEEF.Properties.Resources.direct_marketing;
            this.btnPenukaranPoint.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPenukaranPoint.ImageOffset = new System.Drawing.Point(18, 0);
            this.btnPenukaranPoint.ImageSize = new System.Drawing.Size(45, 45);
            this.btnPenukaranPoint.Location = new System.Drawing.Point(28, 573);
            this.btnPenukaranPoint.Name = "btnPenukaranPoint";
            this.btnPenukaranPoint.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnPenukaranPoint.Size = new System.Drawing.Size(350, 70);
            this.btnPenukaranPoint.TabIndex = 11;
            this.btnPenukaranPoint.Text = "PENUKARAN POINT";
            this.btnPenukaranPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnPenjualanProduk
            // 
            this.btnPenjualanProduk.Animated = true;
            this.btnPenjualanProduk.AutoRoundedCorners = true;
            this.btnPenjualanProduk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPenjualanProduk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPenjualanProduk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPenjualanProduk.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPenjualanProduk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPenjualanProduk.FillColor = System.Drawing.Color.OliveDrab;
            this.btnPenjualanProduk.FillColor2 = System.Drawing.Color.LightCoral;
            this.btnPenjualanProduk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPenjualanProduk.ForeColor = System.Drawing.Color.White;
            this.btnPenjualanProduk.Image = global::POM_BENSIN_ALDILATEEF.Properties.Resources.trade;
            this.btnPenjualanProduk.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPenjualanProduk.ImageOffset = new System.Drawing.Point(18, 0);
            this.btnPenjualanProduk.ImageSize = new System.Drawing.Size(45, 45);
            this.btnPenjualanProduk.Location = new System.Drawing.Point(28, 486);
            this.btnPenjualanProduk.Name = "btnPenjualanProduk";
            this.btnPenjualanProduk.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnPenjualanProduk.Size = new System.Drawing.Size(350, 70);
            this.btnPenjualanProduk.TabIndex = 10;
            this.btnPenjualanProduk.Text = "PENJUALAN PRODUK";
            this.btnPenjualanProduk.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPenjualanProduk.Click += new System.EventHandler(this.btnPenjualanProduk_Click);
            // 
            // btnPenjualanBensin
            // 
            this.btnPenjualanBensin.Animated = true;
            this.btnPenjualanBensin.AutoRoundedCorners = true;
            this.btnPenjualanBensin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPenjualanBensin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPenjualanBensin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPenjualanBensin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPenjualanBensin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPenjualanBensin.FillColor = System.Drawing.Color.OliveDrab;
            this.btnPenjualanBensin.FillColor2 = System.Drawing.Color.LightCoral;
            this.btnPenjualanBensin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPenjualanBensin.ForeColor = System.Drawing.Color.White;
            this.btnPenjualanBensin.Image = global::POM_BENSIN_ALDILATEEF.Properties.Resources.gas_station;
            this.btnPenjualanBensin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPenjualanBensin.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnPenjualanBensin.ImageSize = new System.Drawing.Size(40, 40);
            this.btnPenjualanBensin.Location = new System.Drawing.Point(28, 401);
            this.btnPenjualanBensin.Name = "btnPenjualanBensin";
            this.btnPenjualanBensin.Padding = new System.Windows.Forms.Padding(53, 0, 0, 0);
            this.btnPenjualanBensin.Size = new System.Drawing.Size(350, 70);
            this.btnPenjualanBensin.TabIndex = 9;
            this.btnPenjualanBensin.Text = "PENJUALAN BENSIN";
            this.btnPenjualanBensin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPenjualanBensin.Click += new System.EventHandler(this.btnProduk_Click);
            // 
            // btnDashboardKasir
            // 
            this.btnDashboardKasir.Animated = true;
            this.btnDashboardKasir.AutoRoundedCorners = true;
            this.btnDashboardKasir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboardKasir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboardKasir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboardKasir.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboardKasir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboardKasir.FillColor = System.Drawing.Color.OliveDrab;
            this.btnDashboardKasir.FillColor2 = System.Drawing.Color.LightCoral;
            this.btnDashboardKasir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDashboardKasir.ForeColor = System.Drawing.Color.White;
            this.btnDashboardKasir.Image = global::POM_BENSIN_ALDILATEEF.Properties.Resources.dashboard;
            this.btnDashboardKasir.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboardKasir.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnDashboardKasir.ImageSize = new System.Drawing.Size(35, 35);
            this.btnDashboardKasir.Location = new System.Drawing.Point(28, 315);
            this.btnDashboardKasir.Name = "btnDashboardKasir";
            this.btnDashboardKasir.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btnDashboardKasir.Size = new System.Drawing.Size(350, 70);
            this.btnDashboardKasir.TabIndex = 8;
            this.btnDashboardKasir.Text = "DASHBOARD";
            this.btnDashboardKasir.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboardKasir.Click += new System.EventHandler(this.btnDashboardKasir_Click);
            // 
            // btnLogoutKasir
            // 
            this.btnLogoutKasir.Animated = true;
            this.btnLogoutKasir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogoutKasir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogoutKasir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogoutKasir.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogoutKasir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogoutKasir.FillColor = System.Drawing.Color.OliveDrab;
            this.btnLogoutKasir.FillColor2 = System.Drawing.Color.LightCoral;
            this.btnLogoutKasir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogoutKasir.ForeColor = System.Drawing.Color.White;
            this.btnLogoutKasir.Image = global::POM_BENSIN_ALDILATEEF.Properties.Resources.log_out;
            this.btnLogoutKasir.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogoutKasir.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnLogoutKasir.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLogoutKasir.Location = new System.Drawing.Point(0, 1110);
            this.btnLogoutKasir.Name = "btnLogoutKasir";
            this.btnLogoutKasir.Size = new System.Drawing.Size(405, 60);
            this.btnLogoutKasir.TabIndex = 5;
            this.btnLogoutKasir.Text = "LOGOUT";
            this.btnLogoutKasir.Click += new System.EventHandler(this.btnLogoutKasir_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.guna2PictureBox2);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(405, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1493, 1144);
            this.panelChildForm.TabIndex = 2;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.ErrorImage = null;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(0, 54);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(1537, 1116);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 0;
            this.guna2PictureBox2.TabStop = false;
            // 
            // FormMenuKasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(245)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(1898, 1144);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "FormMenuKasir";
            this.Text = "FormMenuKasir";
            this.Load += new System.EventHandler(this.FormMenuKasir_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btnPenukaranPoint;
        private Guna.UI2.WinForms.Guna2GradientButton btnPenjualanProduk;
        private Guna.UI2.WinForms.Guna2GradientButton btnPenjualanBensin;
        private Guna.UI2.WinForms.Guna2GradientButton btnDashboardKasir;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogoutKasir;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnMembership;
        private Guna.UI2.WinForms.Guna2Panel panelChildForm;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}