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
    public partial class frmQuanLyNhaCungCap : Form
    {
        public frmQuanLyNhaCungCap()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            txtMaNCC.Enabled = true;
            txtTenNCC.Enabled = true;
            btnLuuCapNhat.Visible = true;
            btnCapNhat.Visible = false;
            txtMaNCC.Focus();
        }

        private void btnLuuCapNhat_Click(object sender, EventArgs e)
        {
            txtMaNCC.Enabled = false;
            txtTenNCC.Enabled = false;
            btnLuuCapNhat.Visible = false;
            btnCapNhat.Visible = true;
        }
    }
}
