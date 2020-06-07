namespace QuanLyCuaHangLinhKienPC_NCP
{
    partial class frmQuanLyHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyHoaDon));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblBannerQuanLyNhanVien = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtTimKiemNhanh = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblTimKiemNhanh = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvDanhSachNV = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.colMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhanVienLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDTKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnLapHoaDon = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNV)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblBannerQuanLyNhanVien
            // 
            this.lblBannerQuanLyNhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBannerQuanLyNhanVien.AutoSize = true;
            this.lblBannerQuanLyNhanVien.Font = new System.Drawing.Font("SVN-Beast", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBannerQuanLyNhanVien.ForeColor = System.Drawing.Color.White;
            this.lblBannerQuanLyNhanVien.Location = new System.Drawing.Point(336, 5);
            this.lblBannerQuanLyNhanVien.Name = "lblBannerQuanLyNhanVien";
            this.lblBannerQuanLyNhanVien.Size = new System.Drawing.Size(434, 51);
            this.lblBannerQuanLyNhanVien.TabIndex = 3;
            this.lblBannerQuanLyNhanVien.Text = "DANH SÁCH HÓA ĐƠN";
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
            this.txtTimKiemNhanh.Location = new System.Drawing.Point(490, 68);
            this.txtTimKiemNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiemNhanh.MaxLength = 32767;
            this.txtTimKiemNhanh.Name = "txtTimKiemNhanh";
            this.txtTimKiemNhanh.Size = new System.Drawing.Size(350, 28);
            this.txtTimKiemNhanh.TabIndex = 34;
            this.txtTimKiemNhanh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblTimKiemNhanh
            // 
            this.lblTimKiemNhanh.AutoSize = true;
            this.lblTimKiemNhanh.Font = new System.Drawing.Font("SVN-Beast", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiemNhanh.ForeColor = System.Drawing.Color.White;
            this.lblTimKiemNhanh.Location = new System.Drawing.Point(362, 68);
            this.lblTimKiemNhanh.Name = "lblTimKiemNhanh";
            this.lblTimKiemNhanh.Size = new System.Drawing.Size(128, 23);
            this.lblTimKiemNhanh.TabIndex = 33;
            this.lblTimKiemNhanh.Text = "Tìm kiếm nhanh :";
            // 
            // dgvDanhSachNV
            // 
            this.dgvDanhSachNV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SVN-Beast", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvDanhSachNV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.colMaHD,
            this.colNgayLap,
            this.colNhanVienLap,
            this.colSDTKhachHang});
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
            this.dgvDanhSachNV.Location = new System.Drawing.Point(12, 113);
            this.dgvDanhSachNV.Name = "dgvDanhSachNV";
            this.dgvDanhSachNV.ReadOnly = true;
            this.dgvDanhSachNV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDanhSachNV.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(74)))), ((int)(((byte)(90)))));
            this.dgvDanhSachNV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDanhSachNV.RowTemplate.Height = 30;
            this.dgvDanhSachNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDanhSachNV.Size = new System.Drawing.Size(1088, 585);
            this.dgvDanhSachNV.TabIndex = 32;
            // 
            // colMaHD
            // 
            this.colMaHD.HeaderText = "Mã hóa đơn";
            this.colMaHD.Name = "colMaHD";
            this.colMaHD.ReadOnly = true;
            // 
            // colNgayLap
            // 
            this.colNgayLap.HeaderText = "Ngày lập";
            this.colNgayLap.Name = "colNgayLap";
            this.colNgayLap.ReadOnly = true;
            // 
            // colNhanVienLap
            // 
            this.colNhanVienLap.HeaderText = "Nhân viên lập";
            this.colNhanVienLap.Name = "colNhanVienLap";
            this.colNhanVienLap.ReadOnly = true;
            // 
            // colSDTKhachHang
            // 
            this.colSDTKhachHang.HeaderText = "SDT Khách hàng";
            this.colSDTKhachHang.Name = "colSDTKhachHang";
            this.colSDTKhachHang.ReadOnly = true;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("SVN-Beast", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Yellow;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(8, 68);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(348, 23);
            this.bunifuCustomLabel4.TabIndex = 35;
            this.bunifuCustomLabel4.Text = "*Nhấp đúp một dòng để xem chi tiết hóa đơn";
            // 
            // btnLapHoaDon
            // 
            this.btnLapHoaDon.ActiveBorderThickness = 1;
            this.btnLapHoaDon.ActiveCornerRadius = 1;
            this.btnLapHoaDon.ActiveFillColor = System.Drawing.Color.Coral;
            this.btnLapHoaDon.ActiveForecolor = System.Drawing.Color.White;
            this.btnLapHoaDon.ActiveLineColor = System.Drawing.Color.Coral;
            this.btnLapHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnLapHoaDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLapHoaDon.BackgroundImage")));
            this.btnLapHoaDon.ButtonText = "Lập hóa đơn";
            this.btnLapHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLapHoaDon.Font = new System.Drawing.Font("SVN-Beast", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnLapHoaDon.IdleBorderThickness = 1;
            this.btnLapHoaDon.IdleCornerRadius = 1;
            this.btnLapHoaDon.IdleFillColor = System.Drawing.Color.OrangeRed;
            this.btnLapHoaDon.IdleForecolor = System.Drawing.Color.White;
            this.btnLapHoaDon.IdleLineColor = System.Drawing.Color.OrangeRed;
            this.btnLapHoaDon.Location = new System.Drawing.Point(965, 56);
            this.btnLapHoaDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLapHoaDon.Name = "btnLapHoaDon";
            this.btnLapHoaDon.Size = new System.Drawing.Size(134, 49);
            this.btnLapHoaDon.TabIndex = 36;
            this.btnLapHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLapHoaDon.Click += new System.EventHandler(this.btnLapHoaDon_Click);
            // 
            // frmQuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1112, 710);
            this.Controls.Add(this.btnLapHoaDon);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.txtTimKiemNhanh);
            this.Controls.Add(this.lblTimKiemNhanh);
            this.Controls.Add(this.dgvDanhSachNV);
            this.Controls.Add(this.lblBannerQuanLyNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyHoaDon";
            this.Text = "frmQuanLyHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblBannerQuanLyNhanVien;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTimKiemNhanh;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTimKiemNhanh;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvDanhSachNV;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLapHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhanVienLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDTKhachHang;
    }
}