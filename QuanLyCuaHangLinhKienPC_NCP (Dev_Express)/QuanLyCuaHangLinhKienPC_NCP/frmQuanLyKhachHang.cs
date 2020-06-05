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
    public partial class frmQuanLyKhachHang : Form
    {
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            panelTTKHContent.Enabled = true;
            btnCapNhat.Visible = false;
            btnLuuCapNhat.Visible = true;
            txtSDT.Focus();
        }

        private void btnLuuCapNhat_Click(object sender, EventArgs e)
        {
            panelTTKHContent.Enabled = false;
            btnLuuCapNhat.Visible = false;
            btnCapNhat.Visible = true;
        }
    }
}
