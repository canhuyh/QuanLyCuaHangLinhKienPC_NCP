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
    public partial class frmNhapHang : Form
    {
        public frmNhapHang()
        {
            InitializeComponent();
        }

        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn tạo phiếu không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                //panel thông tin sản phẩm
                cboMaSP.Enabled = true;
                txtTenSP.Enabled = true;
                dtpNgayNhap.Enabled = true;
                cboLoai.Enabled = true;
                numericSoLuong.Enabled = true;
                txtGiaGoc.Enabled = true;
                txtGiaBan.Enabled = true;
                cboBaoHanh.Enabled = true;
                numericKhuyenMai.Enabled = true;
                cboXuatXu.Enabled = true;
                cboMaSP.Focus();

                //panel thông tin phiếu nhập
                txtMaPhieu.Enabled = false;
                dtpNgayNhapOfTTPN.Enabled = false;
                cboNhaCungCapOfTTPN.Enabled = false;
                numericSoLuongNhapOfTTPN.Enabled = false;
                cboMaNhanVien.Enabled = false;
                txtTenNhanVien.Enabled = false;
                //...


                btnTaoPhieu.Visible = false;
                btnHuyPhieu.Visible = true;
                cboMaSP.Focus();
            }

        }

        private void btnHuyPhieu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy phiếu không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //panel thông tin sản phẩm
                cboMaSP.Enabled = false;
                txtTenSP.Enabled = false;
                dtpNgayNhap.Enabled = false;
                cboLoai.Enabled = false;
                numericSoLuong.Enabled = false;
                txtGiaGoc.Enabled = false;
                txtGiaBan.Enabled = false;
                cboBaoHanh.Enabled = false;
                numericKhuyenMai.Enabled = false;
                cboXuatXu.Enabled = false;

                //panel thông tin phiếu nhập
                txtMaPhieu.Enabled = true;
                dtpNgayNhapOfTTPN.Enabled = true;
                cboNhaCungCapOfTTPN.Enabled = true;
                numericSoLuongNhapOfTTPN.Enabled = true;
                cboMaNhanVien.Enabled = true;
                txtTenNhanVien.Enabled = true;
                //...
                btnTaoPhieu.Visible = true;
                btnHuyPhieu.Visible = false;
                txtMaPhieu.Focus();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
