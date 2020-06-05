using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangLinhKienPC_NCP
{
    public partial class frmQuanLySanPham : Form
    {
        public frmQuanLySanPham()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            btnCapNhat.Visible = false;
            btnLuuCapNhat.Visible = true;
            txtTenSP.Enabled = true;
            dtpNgayNhap.Enabled = true;
            cboLoai.Enabled = true;
            numericSoLuong.Enabled = true;
            txtGiaGoc.Enabled = true;
            txtGiaBan.Enabled = true;
            cboBaoHanh.Enabled = true;
            numericKhuyenMai.Enabled = true;
            cboXuatXu.Enabled = true;
            txtTenSP.Focus();
        }

        private void btnLuuCapNhat_Click(object sender, EventArgs e)
        {
            btnCapNhat.Visible = true;
            btnLuuCapNhat.Visible = false;
            txtTenSP.Enabled = false;
            dtpNgayNhap.Enabled = false;
            cboLoai.Enabled = false;
            numericSoLuong.Enabled = false;
            txtGiaGoc.Enabled = false;
            txtGiaBan.Enabled = false;
            cboBaoHanh.Enabled = false;
            numericKhuyenMai.Enabled = false;
            cboXuatXu.Enabled = false;
            txtTenSP.Focus();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            frmNhapHang frmNH = new frmNhapHang();
            frmNH.Show();
        }
    }
}
