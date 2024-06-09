namespace GUI
{
    partial class frm_DkiLL
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
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_tuoi = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_bsx = new System.Windows.Forms.TextBox();
            this.cbo_dv = new System.Windows.Forms.ComboBox();
            this.cbo_ns = new System.Windows.Forms.ComboBox();
            this.date_phieu = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_them = new Guna.UI2.WinForms.Guna2Button();
            this.btn_huy = new Guna.UI2.WinForms.Guna2Button();
            this.cbo_xe = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Enabled = false;
            this.txt_tenkh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenkh.Location = new System.Drawing.Point(193, 131);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(297, 30);
            this.txt_tenkh.TabIndex = 0;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Enabled = false;
            this.txt_diachi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachi.Location = new System.Drawing.Point(193, 221);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(297, 30);
            this.txt_diachi.TabIndex = 1;
            // 
            // txt_tuoi
            // 
            this.txt_tuoi.Enabled = false;
            this.txt_tuoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tuoi.Location = new System.Drawing.Point(193, 177);
            this.txt_tuoi.Name = "txt_tuoi";
            this.txt_tuoi.Size = new System.Drawing.Size(100, 30);
            this.txt_tuoi.TabIndex = 2;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Enabled = false;
            this.txt_sdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.Location = new System.Drawing.Point(193, 271);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(191, 30);
            this.txt_sdt.TabIndex = 3;
            // 
            // txt_bsx
            // 
            this.txt_bsx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bsx.Location = new System.Drawing.Point(193, 391);
            this.txt_bsx.Name = "txt_bsx";
            this.txt_bsx.Size = new System.Drawing.Size(136, 30);
            this.txt_bsx.TabIndex = 5;
            // 
            // cbo_dv
            // 
            this.cbo_dv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_dv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_dv.FormattingEnabled = true;
            this.cbo_dv.Location = new System.Drawing.Point(683, 128);
            this.cbo_dv.Name = "cbo_dv";
            this.cbo_dv.Size = new System.Drawing.Size(194, 30);
            this.cbo_dv.TabIndex = 6;
            this.cbo_dv.SelectedIndexChanged += new System.EventHandler(this.cbo_dv_SelectedIndexChanged);
            // 
            // cbo_ns
            // 
            this.cbo_ns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_ns.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_ns.FormattingEnabled = true;
            this.cbo_ns.Location = new System.Drawing.Point(683, 194);
            this.cbo_ns.Name = "cbo_ns";
            this.cbo_ns.Size = new System.Drawing.Size(194, 30);
            this.cbo_ns.TabIndex = 7;
            this.cbo_ns.SelectedIndexChanged += new System.EventHandler(this.cbo_ns_SelectedIndexChanged);
            // 
            // date_phieu
            // 
            this.date_phieu.Checked = true;
            this.date_phieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_phieu.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_phieu.Location = new System.Drawing.Point(683, 257);
            this.date_phieu.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_phieu.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_phieu.Name = "date_phieu";
            this.date_phieu.Size = new System.Drawing.Size(286, 36);
            this.date_phieu.TabIndex = 8;
            this.date_phieu.Value = new System.DateTime(2024, 5, 12, 18, 39, 40, 311);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tuổi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tên xe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Biển số xe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(538, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Dịch vụ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(538, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "Người làm việc ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(538, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 22);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ngày hẹn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(328, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(320, 42);
            this.label10.TabIndex = 20;
            this.label10.Text = "PHIẾU LẬP LỊCH";
            // 
            // btn_them
            // 
            this.btn_them.AutoRoundedCorners = true;
            this.btn_them.BorderRadius = 28;
            this.btn_them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_them.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_them.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_them.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_them.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_them.FillColor = System.Drawing.Color.Silver;
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.Black;
            this.btn_them.HoverState.CustomBorderColor = System.Drawing.Color.Silver;
            this.btn_them.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_them.Image = global::GUI.Properties.Resources.add;
            this.btn_them.Location = new System.Drawing.Point(256, 455);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(149, 59);
            this.btn_them.TabIndex = 21;
            this.btn_them.Text = "Thêm phiếu";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.AutoRoundedCorners = true;
            this.btn_huy.BorderRadius = 28;
            this.btn_huy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_huy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_huy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_huy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_huy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_huy.FillColor = System.Drawing.Color.Silver;
            this.btn_huy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.Color.Black;
            this.btn_huy.HoverState.CustomBorderColor = System.Drawing.Color.Silver;
            this.btn_huy.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_huy.Image = global::GUI.Properties.Resources.cross_circle;
            this.btn_huy.Location = new System.Drawing.Point(528, 455);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(149, 59);
            this.btn_huy.TabIndex = 22;
            this.btn_huy.Text = "Huỷ";
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // cbo_xe
            // 
            this.cbo_xe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_xe.FormattingEnabled = true;
            this.cbo_xe.Location = new System.Drawing.Point(193, 350);
            this.cbo_xe.Name = "cbo_xe";
            this.cbo_xe.Size = new System.Drawing.Size(212, 24);
            this.cbo_xe.TabIndex = 23;
            this.cbo_xe.SelectedIndexChanged += new System.EventHandler(this.cbo_xe_SelectedIndexChanged);
            // 
            // frm_DkiLL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(981, 572);
            this.Controls.Add(this.cbo_xe);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date_phieu);
            this.Controls.Add(this.cbo_ns);
            this.Controls.Add(this.cbo_dv);
            this.Controls.Add(this.txt_bsx);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_tuoi);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_tenkh);
            this.Name = "frm_DkiLL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_DkiLL";
            this.Load += new System.EventHandler(this.frm_DkiLL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txt_tenkh;
        public System.Windows.Forms.TextBox txt_diachi;
        public System.Windows.Forms.TextBox txt_tuoi;
        public System.Windows.Forms.TextBox txt_sdt;
        public System.Windows.Forms.TextBox txt_bsx;
        public System.Windows.Forms.ComboBox cbo_dv;
        public System.Windows.Forms.ComboBox cbo_ns;
        public Guna.UI2.WinForms.Guna2DateTimePicker date_phieu;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public Guna.UI2.WinForms.Guna2Button btn_them;
        public Guna.UI2.WinForms.Guna2Button btn_huy;
        public System.Windows.Forms.ComboBox cbo_xe;
    }
}