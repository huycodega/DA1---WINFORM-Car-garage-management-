namespace GUI
{
    partial class frm_Cars
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_dong = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_huy = new Guna.UI2.WinForms.Guna2Button();
            this.txt_bsx = new System.Windows.Forms.TextBox();
            this.btn_luu = new Guna.UI2.WinForms.Guna2Button();
            this.btn_xoa = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_them = new Guna.UI2.WinForms.Guna2Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.data_xe = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bhx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sua = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.cbo_bhx = new System.Windows.Forms.ComboBox();
            this.cbo_csh = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tinhtrang = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_tk = new Guna.UI2.WinForms.Guna2Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_xe)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_dong
            // 
            this.btn_dong.AutoRoundedCorners = true;
            this.btn_dong.BorderRadius = 18;
            this.btn_dong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_dong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_dong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_dong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_dong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btn_dong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dong.ForeColor = System.Drawing.Color.Black;
            this.btn_dong.HoverState.CustomBorderColor = System.Drawing.Color.Silver;
            this.btn_dong.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_dong.Image = global::GUI.Properties.Resources.minus_circle;
            this.btn_dong.Location = new System.Drawing.Point(609, 12);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(91, 39);
            this.btn_dong.TabIndex = 5;
            this.btn_dong.Text = "Đóng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(558, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tình trạng";
            // 
            // btn_huy
            // 
            this.btn_huy.AutoRoundedCorners = true;
            this.btn_huy.BorderRadius = 18;
            this.btn_huy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_huy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_huy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_huy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_huy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_huy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btn_huy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.Color.Black;
            this.btn_huy.HoverState.CustomBorderColor = System.Drawing.Color.Silver;
            this.btn_huy.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_huy.Image = global::GUI.Properties.Resources.ban;
            this.btn_huy.Location = new System.Drawing.Point(491, 12);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(91, 39);
            this.btn_huy.TabIndex = 4;
            this.btn_huy.Text = "Huỷ";
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // txt_bsx
            // 
            this.txt_bsx.Location = new System.Drawing.Point(112, 53);
            this.txt_bsx.Name = "txt_bsx";
            this.txt_bsx.Size = new System.Drawing.Size(350, 22);
            this.txt_bsx.TabIndex = 5;
            // 
            // btn_luu
            // 
            this.btn_luu.AutoRoundedCorners = true;
            this.btn_luu.BorderRadius = 18;
            this.btn_luu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_luu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_luu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_luu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_luu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_luu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btn_luu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.Color.Black;
            this.btn_luu.HoverState.CustomBorderColor = System.Drawing.Color.Silver;
            this.btn_luu.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_luu.Image = global::GUI.Properties.Resources.disk;
            this.btn_luu.Location = new System.Drawing.Point(373, 12);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(91, 39);
            this.btn_luu.TabIndex = 3;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.AutoRoundedCorners = true;
            this.btn_xoa.BorderRadius = 18;
            this.btn_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_xoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_xoa.HoverState.CustomBorderColor = System.Drawing.Color.Silver;
            this.btn_xoa.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Image = global::GUI.Properties.Resources.cross_circle;
            this.btn_xoa.Location = new System.Drawing.Point(261, 12);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(91, 39);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Biển số";
            // 
            // btn_them
            // 
            this.btn_them.AutoRoundedCorners = true;
            this.btn_them.BorderRadius = 18;
            this.btn_them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_them.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_them.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_them.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_them.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_them.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.Black;
            this.btn_them.HoverState.CustomBorderColor = System.Drawing.Color.Silver;
            this.btn_them.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_them.Image = global::GUI.Properties.Resources.add;
            this.btn_them.Location = new System.Drawing.Point(28, 12);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(91, 39);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(103, 13);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(350, 22);
            this.txt_name.TabIndex = 1;
            // 
            // data_xe
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.data_xe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_xe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.data_xe.ColumnHeadersHeight = 40;
            this.data_xe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.data_xe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.bhx,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_xe.DefaultCellStyle = dataGridViewCellStyle3;
            this.data_xe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_xe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.data_xe.Location = new System.Drawing.Point(0, 232);
            this.data_xe.Name = "data_xe";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_xe.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.data_xe.RowHeadersVisible = false;
            this.data_xe.RowHeadersWidth = 51;
            this.data_xe.RowTemplate.Height = 50;
            this.data_xe.Size = new System.Drawing.Size(1099, 344);
            this.data_xe.TabIndex = 0;
            this.data_xe.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.data_xe.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.data_xe.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.data_xe.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.data_xe.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.data_xe.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.data_xe.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.data_xe.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.data_xe.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.data_xe.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_xe.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.data_xe.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.data_xe.ThemeStyle.HeaderStyle.Height = 40;
            this.data_xe.ThemeStyle.ReadOnly = false;
            this.data_xe.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.data_xe.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.data_xe.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_xe.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.data_xe.ThemeStyle.RowsStyle.Height = 50;
            this.data_xe.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.data_xe.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.data_xe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_xe_CellClick);
            this.data_xe.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.data_xe_CellFormatting);
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "id";
            this.Column6.HeaderText = "ID";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ten_xe";
            this.Column1.HeaderText = "Tên Xe";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "bienso";
            this.Column2.HeaderText = "Biển số xe";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "tinh_trang";
            this.Column3.HeaderText = "Tình trạng  xe";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // bhx
            // 
            this.bhx.DataPropertyName = "tt_bhx";
            this.bhx.HeaderText = "Bảo hiểm xe";
            this.bhx.MinimumWidth = 6;
            this.bhx.Name = "bhx";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "chu_so_huu";
            this.Column5.HeaderText = "Chủ sở hữu";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Xe";
            // 
            // btn_sua
            // 
            this.btn_sua.AutoRoundedCorners = true;
            this.btn_sua.BorderRadius = 18;
            this.btn_sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_sua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_sua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_sua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_sua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.Black;
            this.btn_sua.HoverState.CustomBorderColor = System.Drawing.Color.Silver;
            this.btn_sua.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_sua.Image = global::GUI.Properties.Resources.file_edit;
            this.btn_sua.Location = new System.Drawing.Point(145, 12);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(91, 39);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.cbo_bhx);
            this.guna2Panel2.Controls.Add(this.cbo_csh);
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Controls.Add(this.txt_tinhtrang);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Controls.Add(this.txt_bsx);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Controls.Add(this.txt_name);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 71);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1099, 161);
            this.guna2Panel2.TabIndex = 4;
            // 
            // cbo_bhx
            // 
            this.cbo_bhx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_bhx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_bhx.FormattingEnabled = true;
            this.cbo_bhx.Items.AddRange(new object[] {
            "Còn sử dụng",
            "Đã hết"});
            this.cbo_bhx.Location = new System.Drawing.Point(703, 10);
            this.cbo_bhx.Name = "cbo_bhx";
            this.cbo_bhx.Size = new System.Drawing.Size(202, 30);
            this.cbo_bhx.TabIndex = 13;
            // 
            // cbo_csh
            // 
            this.cbo_csh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_csh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_csh.FormattingEnabled = true;
            this.cbo_csh.Location = new System.Drawing.Point(138, 104);
            this.cbo_csh.Name = "cbo_csh";
            this.cbo_csh.Size = new System.Drawing.Size(293, 30);
            this.cbo_csh.TabIndex = 12;
            this.cbo_csh.SelectedIndexChanged += new System.EventHandler(this.cbo_csh_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Chủ sở hữu";
            // 
            // txt_tinhtrang
            // 
            this.txt_tinhtrang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tinhtrang.DefaultText = "";
            this.txt_tinhtrang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_tinhtrang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_tinhtrang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tinhtrang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tinhtrang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tinhtrang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tinhtrang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tinhtrang.Location = new System.Drawing.Point(703, 59);
            this.txt_tinhtrang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tinhtrang.Name = "txt_tinhtrang";
            this.txt_tinhtrang.PasswordChar = '\0';
            this.txt_tinhtrang.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_tinhtrang.PlaceholderText = "";
            this.txt_tinhtrang.SelectedText = "";
            this.txt_tinhtrang.Size = new System.Drawing.Size(254, 95);
            this.txt_tinhtrang.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(558, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bảo hiểm xe";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btn_tk);
            this.guna2Panel1.Controls.Add(this.textBox1);
            this.guna2Panel1.Controls.Add(this.btn_dong);
            this.guna2Panel1.Controls.Add(this.btn_huy);
            this.guna2Panel1.Controls.Add(this.btn_luu);
            this.guna2Panel1.Controls.Add(this.btn_xoa);
            this.guna2Panel1.Controls.Add(this.btn_sua);
            this.guna2Panel1.Controls.Add(this.btn_them);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1099, 71);
            this.guna2Panel1.TabIndex = 3;
            // 
            // btn_tk
            // 
            this.btn_tk.AutoRoundedCorners = true;
            this.btn_tk.BorderRadius = 18;
            this.btn_tk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_tk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_tk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_tk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_tk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btn_tk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tk.ForeColor = System.Drawing.Color.Black;
            this.btn_tk.HoverState.CustomBorderColor = System.Drawing.Color.Silver;
            this.btn_tk.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_tk.Image = global::GUI.Properties.Resources.search;
            this.btn_tk.Location = new System.Drawing.Point(920, 12);
            this.btn_tk.Name = "btn_tk";
            this.btn_tk.Size = new System.Drawing.Size(135, 39);
            this.btn_tk.TabIndex = 9;
            this.btn_tk.Text = "Tìm kiếm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(722, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 22);
            this.textBox1.TabIndex = 8;
            // 
            // frm_Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 576);
            this.Controls.Add(this.data_xe);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "frm_Cars";
            this.Text = "frm_Cars";
            this.Load += new System.EventHandler(this.frm_Cars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_xe)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btn_dong;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btn_huy;
        private System.Windows.Forms.TextBox txt_bsx;
        private Guna.UI2.WinForms.Guna2Button btn_luu;
        private Guna.UI2.WinForms.Guna2Button btn_xoa;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btn_them;
        private System.Windows.Forms.TextBox txt_name;
        private Guna.UI2.WinForms.Guna2DataGridView data_xe;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_sua;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_tinhtrang;
        private System.Windows.Forms.ComboBox cbo_csh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_bhx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn bhx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Guna.UI2.WinForms.Guna2Button btn_tk;
        private System.Windows.Forms.TextBox textBox1;
    }
}