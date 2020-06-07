namespace QuanLyCuaHangLinhKienPC_NCP
{
    partial class frmQuanLyKhachHang
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyKhachHang));
            this.elipForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblBannerKhachHang = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtTimKiemNhanh = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblTiemKiemNhanh = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvDanhSachKH = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.colSoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelThongTinKH = new System.Windows.Forms.Panel();
            this.btnLuuCapNhat = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panelTTKHContent = new System.Windows.Forms.Panel();
            this.txtDiaChi = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtSDT = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtHoTen = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblEmail = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDiaChi = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSDT = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblHoTen = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblThongTinChiTiet = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCapNhat = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnXoa = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnThem = new Bunifu.Framework.UI.BunifuThinButton2();
            this.elipDSKH = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKH)).BeginInit();
            this.panelThongTinKH.SuspendLayout();
            this.panelTTKHContent.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // elipForm
            // 
            this.elipForm.ElipseRadius = 5;
            this.elipForm.TargetControl = this;
            // 
            // lblBannerKhachHang
            // 
            this.lblBannerKhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBannerKhachHang.AutoSize = true;
            this.lblBannerKhachHang.Font = new System.Drawing.Font("SVN-Beast", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBannerKhachHang.ForeColor = System.Drawing.Color.White;
            this.lblBannerKhachHang.Location = new System.Drawing.Point(284, 9);
            this.lblBannerKhachHang.Name = "lblBannerKhachHang";
            this.lblBannerKhachHang.Size = new System.Drawing.Size(265, 51);
            this.lblBannerKhachHang.TabIndex = 3;
            this.lblBannerKhachHang.Text = "KHÁCH HÀNG";
            // 
            // txtTimKiemNhanh
            // 
            this.txtTimKiemNhanh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimKiemNhanh.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.txtTimKiemNhanh.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtTimKiemNhanh.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.txtTimKiemNhanh.BorderThickness = 2;
            this.txtTimKiemNhanh.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTimKiemNhanh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemNhanh.Font = new System.Drawing.Font("SVN-Beast", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemNhanh.ForeColor = System.Drawing.Color.Silver;
            this.txtTimKiemNhanh.isPassword = false;
            this.txtTimKiemNhanh.Location = new System.Drawing.Point(293, 77);
            this.txtTimKiemNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiemNhanh.MaxLength = 32767;
            this.txtTimKiemNhanh.Name = "txtTimKiemNhanh";
            this.txtTimKiemNhanh.Size = new System.Drawing.Size(350, 28);
            this.txtTimKiemNhanh.TabIndex = 1;
            this.txtTimKiemNhanh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblTiemKiemNhanh
            // 
            this.lblTiemKiemNhanh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTiemKiemNhanh.AutoSize = true;
            this.lblTiemKiemNhanh.Font = new System.Drawing.Font("SVN-Beast", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiemKiemNhanh.ForeColor = System.Drawing.Color.White;
            this.lblTiemKiemNhanh.Location = new System.Drawing.Point(165, 77);
            this.lblTiemKiemNhanh.Name = "lblTiemKiemNhanh";
            this.lblTiemKiemNhanh.Size = new System.Drawing.Size(128, 23);
            this.lblTiemKiemNhanh.TabIndex = 4;
            this.lblTiemKiemNhanh.Text = "Tìm kiếm nhanh :";
            // 
            // dgvDanhSachKH
            // 
            this.dgvDanhSachKH.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SVN-Beast", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvDanhSachKH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachKH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(74)))), ((int)(((byte)(90)))));
            this.dgvDanhSachKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhSachKH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDanhSachKH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SVN-Beast", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachKH.ColumnHeadersHeight = 35;
            this.dgvDanhSachKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSoDienThoai,
            this.colHoTen,
            this.colDiaChi,
            this.colEmail});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("SVN-Beast", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachKH.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSachKH.DoubleBuffered = true;
            this.dgvDanhSachKH.EnableHeadersVisualStyles = false;
            this.dgvDanhSachKH.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.dgvDanhSachKH.HeaderForeColor = System.Drawing.Color.White;
            this.dgvDanhSachKH.Location = new System.Drawing.Point(12, 112);
            this.dgvDanhSachKH.Name = "dgvDanhSachKH";
            this.dgvDanhSachKH.ReadOnly = true;
            this.dgvDanhSachKH.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDanhSachKH.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(74)))), ((int)(((byte)(90)))));
            this.dgvDanhSachKH.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDanhSachKH.RowTemplate.Height = 30;
            this.dgvDanhSachKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDanhSachKH.Size = new System.Drawing.Size(826, 265);
            this.dgvDanhSachKH.TabIndex = 5;
            // 
            // colSoDienThoai
            // 
            this.colSoDienThoai.HeaderText = "Số điện thoại";
            this.colSoDienThoai.Name = "colSoDienThoai";
            this.colSoDienThoai.ReadOnly = true;
            // 
            // colHoTen
            // 
            this.colHoTen.HeaderText = "Họ Tên";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            // 
            // colDiaChi
            // 
            this.colDiaChi.HeaderText = "Địa Chỉ";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // panelThongTinKH
            // 
            this.panelThongTinKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelThongTinKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.panelThongTinKH.Controls.Add(this.btnLuuCapNhat);
            this.panelThongTinKH.Controls.Add(this.panelTTKHContent);
            this.panelThongTinKH.Controls.Add(this.panel2);
            this.panelThongTinKH.Controls.Add(this.btnCapNhat);
            this.panelThongTinKH.Controls.Add(this.btnXoa);
            this.panelThongTinKH.Controls.Add(this.btnThem);
            this.panelThongTinKH.Location = new System.Drawing.Point(12, 383);
            this.panelThongTinKH.Name = "panelThongTinKH";
            this.panelThongTinKH.Size = new System.Drawing.Size(826, 265);
            this.panelThongTinKH.TabIndex = 7;
            // 
            // btnLuuCapNhat
            // 
            this.btnLuuCapNhat.ActiveBorderThickness = 1;
            this.btnLuuCapNhat.ActiveCornerRadius = 1;
            this.btnLuuCapNhat.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(155)))), ((int)(((byte)(169)))));
            this.btnLuuCapNhat.ActiveForecolor = System.Drawing.Color.White;
            this.btnLuuCapNhat.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(155)))), ((int)(((byte)(169)))));
            this.btnLuuCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.btnLuuCapNhat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLuuCapNhat.BackgroundImage")));
            this.btnLuuCapNhat.ButtonText = "Lưu cập nhật";
            this.btnLuuCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuCapNhat.Font = new System.Drawing.Font("SVN-Beast", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnLuuCapNhat.IdleBorderThickness = 1;
            this.btnLuuCapNhat.IdleCornerRadius = 1;
            this.btnLuuCapNhat.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(132)))), ((int)(((byte)(150)))));
            this.btnLuuCapNhat.IdleForecolor = System.Drawing.Color.White;
            this.btnLuuCapNhat.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(132)))), ((int)(((byte)(150)))));
            this.btnLuuCapNhat.Location = new System.Drawing.Point(475, 204);
            this.btnLuuCapNhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuuCapNhat.Name = "btnLuuCapNhat";
            this.btnLuuCapNhat.Size = new System.Drawing.Size(110, 49);
            this.btnLuuCapNhat.TabIndex = 8;
            this.btnLuuCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLuuCapNhat.Visible = false;
            this.btnLuuCapNhat.Click += new System.EventHandler(this.btnLuuCapNhat_Click);
            // 
            // panelTTKHContent
            // 
            this.panelTTKHContent.Controls.Add(this.txtDiaChi);
            this.panelTTKHContent.Controls.Add(this.txtEmail);
            this.panelTTKHContent.Controls.Add(this.txtSDT);
            this.panelTTKHContent.Controls.Add(this.txtHoTen);
            this.panelTTKHContent.Controls.Add(this.lblEmail);
            this.panelTTKHContent.Controls.Add(this.lblDiaChi);
            this.panelTTKHContent.Controls.Add(this.lblSDT);
            this.panelTTKHContent.Controls.Add(this.lblHoTen);
            this.panelTTKHContent.Enabled = false;
            this.panelTTKHContent.Location = new System.Drawing.Point(196, 41);
            this.panelTTKHContent.Name = "panelTTKHContent";
            this.panelTTKHContent.Size = new System.Drawing.Size(443, 151);
            this.panelTTKHContent.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.txtDiaChi.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtDiaChi.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.txtDiaChi.BorderThickness = 2;
            this.txtDiaChi.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.Font = new System.Drawing.Font("SVN-Beast", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.Silver;
            this.txtDiaChi.isPassword = false;
            this.txtDiaChi.Location = new System.Drawing.Point(130, 77);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.MaxLength = 32767;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(299, 28);
            this.txtDiaChi.TabIndex = 4;
            this.txtDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.txtEmail.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtEmail.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.txtEmail.BorderThickness = 2;
            this.txtEmail.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("SVN-Beast", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Silver;
            this.txtEmail.isPassword = false;
            this.txtEmail.Location = new System.Drawing.Point(130, 113);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(299, 28);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSDT
            // 
            this.txtSDT.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.txtSDT.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtSDT.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.txtSDT.BorderThickness = 2;
            this.txtSDT.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.Font = new System.Drawing.Font("SVN-Beast", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.ForeColor = System.Drawing.Color.Silver;
            this.txtSDT.isPassword = false;
            this.txtSDT.Location = new System.Drawing.Point(130, 5);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.MaxLength = 32767;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(122, 28);
            this.txtSDT.TabIndex = 2;
            this.txtSDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.txtHoTen.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtHoTen.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.txtHoTen.BorderThickness = 2;
            this.txtHoTen.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.Font = new System.Drawing.Font("SVN-Beast", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.ForeColor = System.Drawing.Color.Silver;
            this.txtHoTen.isPassword = false;
            this.txtHoTen.Location = new System.Drawing.Point(130, 41);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.MaxLength = 32767;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(194, 28);
            this.txtHoTen.TabIndex = 3;
            this.txtHoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("SVN-Beast", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(10, 113);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 23);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email :";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("SVN-Beast", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.ForeColor = System.Drawing.Color.White;
            this.lblDiaChi.Location = new System.Drawing.Point(10, 77);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(66, 23);
            this.lblDiaChi.TabIndex = 7;
            this.lblDiaChi.Text = "Địa chỉ :";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("SVN-Beast", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.ForeColor = System.Drawing.Color.White;
            this.lblSDT.Location = new System.Drawing.Point(10, 5);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(113, 23);
            this.lblSDT.TabIndex = 8;
            this.lblSDT.Text = "Số điện thoại :";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("SVN-Beast", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.ForeColor = System.Drawing.Color.White;
            this.lblHoTen.Location = new System.Drawing.Point(10, 41);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(67, 23);
            this.lblHoTen.TabIndex = 10;
            this.lblHoTen.Text = "Họ tên :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.lblThongTinChiTiet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(826, 35);
            this.panel2.TabIndex = 0;
            // 
            // lblThongTinChiTiet
            // 
            this.lblThongTinChiTiet.AutoSize = true;
            this.lblThongTinChiTiet.Font = new System.Drawing.Font("SVN-Beast", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinChiTiet.ForeColor = System.Drawing.Color.White;
            this.lblThongTinChiTiet.Location = new System.Drawing.Point(347, 4);
            this.lblThongTinChiTiet.Name = "lblThongTinChiTiet";
            this.lblThongTinChiTiet.Size = new System.Drawing.Size(125, 23);
            this.lblThongTinChiTiet.TabIndex = 0;
            this.lblThongTinChiTiet.Text = "Thông tin chi tiết";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.ActiveBorderThickness = 1;
            this.btnCapNhat.ActiveCornerRadius = 1;
            this.btnCapNhat.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(188)))), ((int)(((byte)(66)))));
            this.btnCapNhat.ActiveForecolor = System.Drawing.Color.White;
            this.btnCapNhat.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(188)))), ((int)(((byte)(66)))));
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.btnCapNhat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.BackgroundImage")));
            this.btnCapNhat.ButtonText = "Cập nhật";
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhat.Font = new System.Drawing.Font("SVN-Beast", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.IdleBorderThickness = 1;
            this.btnCapNhat.IdleCornerRadius = 1;
            this.btnCapNhat.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.btnCapNhat.IdleForecolor = System.Drawing.Color.White;
            this.btnCapNhat.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.btnCapNhat.Location = new System.Drawing.Point(475, 204);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(110, 49);
            this.btnCapNhat.TabIndex = 8;
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ActiveBorderThickness = 1;
            this.btnXoa.ActiveCornerRadius = 1;
            this.btnXoa.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.btnXoa.ActiveForecolor = System.Drawing.Color.White;
            this.btnXoa.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.ButtonText = "Xóa";
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Font = new System.Drawing.Font("SVN-Beast", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.IdleBorderThickness = 1;
            this.btnXoa.IdleCornerRadius = 1;
            this.btnXoa.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btnXoa.IdleForecolor = System.Drawing.Color.White;
            this.btnXoa.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btnXoa.Location = new System.Drawing.Point(357, 204);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 49);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThem
            // 
            this.btnThem.ActiveBorderThickness = 1;
            this.btnThem.ActiveCornerRadius = 1;
            this.btnThem.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(142)))), ((int)(((byte)(223)))));
            this.btnThem.ActiveForecolor = System.Drawing.Color.White;
            this.btnThem.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(142)))), ((int)(((byte)(223)))));
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.ButtonText = "Thêm";
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("SVN-Beast", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.IdleBorderThickness = 1;
            this.btnThem.IdleCornerRadius = 1;
            this.btnThem.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.btnThem.IdleForecolor = System.Drawing.Color.White;
            this.btnThem.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            this.btnThem.Location = new System.Drawing.Point(239, 204);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 49);
            this.btnThem.TabIndex = 6;
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // elipDSKH
            // 
            this.elipDSKH.ElipseRadius = 10;
            this.elipDSKH.TargetControl = this.dgvDanhSachKH;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // frmQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(850, 657);
            this.Controls.Add(this.panelThongTinKH);
            this.Controls.Add(this.txtTimKiemNhanh);
            this.Controls.Add(this.lblTiemKiemNhanh);
            this.Controls.Add(this.dgvDanhSachKH);
            this.Controls.Add(this.lblBannerKhachHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyKhachHang";
            this.Text = "frmQuanLyKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKH)).EndInit();
            this.panelThongTinKH.ResumeLayout(false);
            this.panelTTKHContent.ResumeLayout(false);
            this.panelTTKHContent.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipForm;
        private Bunifu.Framework.UI.BunifuCustomLabel lblBannerKhachHang;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTimKiemNhanh;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTiemKiemNhanh;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvDanhSachKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.Panel panelThongTinKH;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLuuCapNhat;
        private System.Windows.Forms.Panel panelTTKHContent;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSDT;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtHoTen;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEmail;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDiaChi;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSDT;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHoTen;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblThongTinChiTiet;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCapNhat;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXoa;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThem;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDiaChi;
        private Bunifu.Framework.UI.BunifuElipse elipDSKH;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}