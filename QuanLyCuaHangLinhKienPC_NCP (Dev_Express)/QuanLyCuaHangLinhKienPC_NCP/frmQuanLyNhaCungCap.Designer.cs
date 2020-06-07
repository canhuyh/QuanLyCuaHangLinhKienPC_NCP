namespace QuanLyCuaHangLinhKienPC_NCP
{
    partial class frmQuanLyNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyNhaCungCap));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblBannerNCC = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.colTenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMancc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDanhSachNV = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panelThongTinKhac = new System.Windows.Forms.Panel();
            this.btnLuuCapNhat = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCapNhat = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnXoa = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnThem = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtTenNCC = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtMaNCC = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblThongTinhKhac = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblMaNCC = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTenNCC = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtTimKiemNhanh = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblTimKiemNhanh = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNV)).BeginInit();
            this.panelThongTinKhac.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblBannerNCC
            // 
            this.lblBannerNCC.AutoSize = true;
            this.lblBannerNCC.Font = new System.Drawing.Font("SVN-Beast", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBannerNCC.ForeColor = System.Drawing.Color.White;
            this.lblBannerNCC.Location = new System.Drawing.Point(186, 9);
            this.lblBannerNCC.Name = "lblBannerNCC";
            this.lblBannerNCC.Size = new System.Drawing.Size(520, 51);
            this.lblBannerNCC.TabIndex = 5;
            this.lblBannerNCC.Text = "NHÀ CUNG CẤP SẢN PHẨM";
            // 
            // colTenNCC
            // 
            this.colTenNCC.HeaderText = "Tên nhà cung cấp";
            this.colTenNCC.Name = "colTenNCC";
            this.colTenNCC.ReadOnly = true;
            // 
            // colMancc
            // 
            this.colMancc.HeaderText = "Mã nhà cung cấp";
            this.colMancc.Name = "colMancc";
            this.colMancc.ReadOnly = true;
            // 
            // dgvDanhSachNV
            // 
            this.dgvDanhSachNV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SVN-Beast", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvDanhSachNV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachNV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(74)))), ((int)(((byte)(90)))));
            this.dgvDanhSachNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhSachNV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDanhSachNV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SVN-Beast", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachNV.ColumnHeadersHeight = 35;
            this.dgvDanhSachNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMancc,
            this.colTenNCC});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("SVN-Beast", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachNV.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSachNV.DoubleBuffered = true;
            this.dgvDanhSachNV.EnableHeadersVisualStyles = false;
            this.dgvDanhSachNV.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.dgvDanhSachNV.HeaderForeColor = System.Drawing.Color.White;
            this.dgvDanhSachNV.Location = new System.Drawing.Point(14, 117);
            this.dgvDanhSachNV.Name = "dgvDanhSachNV";
            this.dgvDanhSachNV.ReadOnly = true;
            this.dgvDanhSachNV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDanhSachNV.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(74)))), ((int)(((byte)(90)))));
            this.dgvDanhSachNV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDanhSachNV.RowTemplate.Height = 30;
            this.dgvDanhSachNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDanhSachNV.Size = new System.Drawing.Size(407, 214);
            this.dgvDanhSachNV.TabIndex = 24;
            // 
            // panelThongTinKhac
            // 
            this.panelThongTinKhac.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panelThongTinKhac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.panelThongTinKhac.Controls.Add(this.btnLuuCapNhat);
            this.panelThongTinKhac.Controls.Add(this.btnCapNhat);
            this.panelThongTinKhac.Controls.Add(this.btnXoa);
            this.panelThongTinKhac.Controls.Add(this.btnThem);
            this.panelThongTinKhac.Controls.Add(this.txtTenNCC);
            this.panelThongTinKhac.Controls.Add(this.txtMaNCC);
            this.panelThongTinKhac.Controls.Add(this.panel3);
            this.panelThongTinKhac.Controls.Add(this.lblMaNCC);
            this.panelThongTinKhac.Controls.Add(this.lblTenNCC);
            this.panelThongTinKhac.Location = new System.Drawing.Point(427, 117);
            this.panelThongTinKhac.Name = "panelThongTinKhac";
            this.panelThongTinKhac.Size = new System.Drawing.Size(447, 215);
            this.panelThongTinKhac.TabIndex = 25;
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
            this.btnLuuCapNhat.Location = new System.Drawing.Point(287, 138);
            this.btnLuuCapNhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuuCapNhat.Name = "btnLuuCapNhat";
            this.btnLuuCapNhat.Size = new System.Drawing.Size(110, 49);
            this.btnLuuCapNhat.TabIndex = 5;
            this.btnLuuCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLuuCapNhat.Visible = false;
            this.btnLuuCapNhat.Click += new System.EventHandler(this.btnLuuCapNhat_Click);
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
            this.btnCapNhat.Location = new System.Drawing.Point(287, 138);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(110, 49);
            this.btnCapNhat.TabIndex = 5;
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
            this.btnXoa.Location = new System.Drawing.Point(169, 138);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 49);
            this.btnXoa.TabIndex = 4;
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
            this.btnThem.Location = new System.Drawing.Point(51, 138);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 49);
            this.btnThem.TabIndex = 3;
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.txtTenNCC.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtTenNCC.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.txtTenNCC.BorderThickness = 2;
            this.txtTenNCC.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTenNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNCC.Enabled = false;
            this.txtTenNCC.Font = new System.Drawing.Font("SVN-Beast", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNCC.ForeColor = System.Drawing.Color.Silver;
            this.txtTenNCC.isPassword = false;
            this.txtTenNCC.Location = new System.Drawing.Point(189, 89);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNCC.MaxLength = 32767;
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(215, 28);
            this.txtTenNCC.TabIndex = 2;
            this.txtTenNCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.txtMaNCC.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtMaNCC.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.txtMaNCC.BorderThickness = 2;
            this.txtMaNCC.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMaNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNCC.Enabled = false;
            this.txtMaNCC.Font = new System.Drawing.Font("SVN-Beast", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNCC.ForeColor = System.Drawing.Color.Silver;
            this.txtMaNCC.isPassword = false;
            this.txtMaNCC.Location = new System.Drawing.Point(189, 53);
            this.txtMaNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNCC.MaxLength = 32767;
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(215, 28);
            this.txtMaNCC.TabIndex = 1;
            this.txtMaNCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.panel3.Controls.Add(this.lblThongTinhKhac);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(447, 35);
            this.panel3.TabIndex = 0;
            // 
            // lblThongTinhKhac
            // 
            this.lblThongTinhKhac.AutoSize = true;
            this.lblThongTinhKhac.Font = new System.Drawing.Font("SVN-Beast", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinhKhac.ForeColor = System.Drawing.Color.White;
            this.lblThongTinhKhac.Location = new System.Drawing.Point(177, 5);
            this.lblThongTinhKhac.Name = "lblThongTinhKhac";
            this.lblThongTinhKhac.Size = new System.Drawing.Size(112, 23);
            this.lblThongTinhKhac.TabIndex = 0;
            this.lblThongTinhKhac.Text = "Thông tin khác";
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Font = new System.Drawing.Font("SVN-Beast", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNCC.ForeColor = System.Drawing.Color.White;
            this.lblMaNCC.Location = new System.Drawing.Point(35, 53);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(147, 23);
            this.lblMaNCC.TabIndex = 0;
            this.lblMaNCC.Text = "Mã nhà cung cấp :";
            // 
            // lblTenNCC
            // 
            this.lblTenNCC.AutoSize = true;
            this.lblTenNCC.Font = new System.Drawing.Font("SVN-Beast", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNCC.ForeColor = System.Drawing.Color.White;
            this.lblTenNCC.Location = new System.Drawing.Point(35, 92);
            this.lblTenNCC.Name = "lblTenNCC";
            this.lblTenNCC.Size = new System.Drawing.Size(151, 23);
            this.lblTenNCC.TabIndex = 0;
            this.lblTenNCC.Text = "Tên nhà cung cấp :";
            // 
            // txtTimKiemNhanh
            // 
            this.txtTimKiemNhanh.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.txtTimKiemNhanh.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtTimKiemNhanh.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.txtTimKiemNhanh.BorderThickness = 2;
            this.txtTimKiemNhanh.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTimKiemNhanh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemNhanh.Font = new System.Drawing.Font("SVN-Beast", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemNhanh.ForeColor = System.Drawing.Color.Silver;
            this.txtTimKiemNhanh.isPassword = false;
            this.txtTimKiemNhanh.Location = new System.Drawing.Point(303, 82);
            this.txtTimKiemNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiemNhanh.MaxLength = 32767;
            this.txtTimKiemNhanh.Name = "txtTimKiemNhanh";
            this.txtTimKiemNhanh.Size = new System.Drawing.Size(350, 28);
            this.txtTimKiemNhanh.TabIndex = 0;
            this.txtTimKiemNhanh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblTimKiemNhanh
            // 
            this.lblTimKiemNhanh.AutoSize = true;
            this.lblTimKiemNhanh.Font = new System.Drawing.Font("SVN-Beast", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiemNhanh.ForeColor = System.Drawing.Color.White;
            this.lblTimKiemNhanh.Location = new System.Drawing.Point(175, 82);
            this.lblTimKiemNhanh.Name = "lblTimKiemNhanh";
            this.lblTimKiemNhanh.Size = new System.Drawing.Size(128, 23);
            this.lblTimKiemNhanh.TabIndex = 26;
            this.lblTimKiemNhanh.Text = "Tìm kiếm nhanh :";
            // 
            // frmQuanLyNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(891, 343);
            this.Controls.Add(this.txtTimKiemNhanh);
            this.Controls.Add(this.lblTimKiemNhanh);
            this.Controls.Add(this.panelThongTinKhac);
            this.Controls.Add(this.dgvDanhSachNV);
            this.Controls.Add(this.lblBannerNCC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyNhaCungCap";
            this.Text = "frmQuanLyNhaCungCap";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNV)).EndInit();
            this.panelThongTinKhac.ResumeLayout(false);
            this.panelThongTinKhac.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblBannerNCC;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvDanhSachNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMancc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNCC;
        private System.Windows.Forms.Panel panelThongTinKhac;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTenNCC;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMaNCC;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel lblThongTinhKhac;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMaNCC;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTenNCC;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTimKiemNhanh;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTimKiemNhanh;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLuuCapNhat;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCapNhat;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXoa;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThem;
    }
}