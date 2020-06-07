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
    public partial class frmLapHoaDon : Form
    {
        public frmLapHoaDon()
        {
            InitializeComponent();
        }

        private void btnTaoMoiKhachHang_Click(object sender, EventArgs e)
        {
            btnTaoMoiKhachHang.Visible = false;
            btnLuuKH.Visible = true;
            txtTenKH.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
            txtTenKH.Focus();
        }

        private void btnLuuKH_Click(object sender, EventArgs e)
        {
            btnTaoMoiKhachHang.Visible = true;
            btnLuuKH.Visible = false;
            txtTenKH.Enabled = false;
            txtDiaChi.Enabled = false;
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}
