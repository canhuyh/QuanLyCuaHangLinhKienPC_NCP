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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        #region Xử lý thao tác chuyển qua lại giữa 2 slide
        //private void btnDangNhapHeader_Click(object sender, EventArgs e)
        //{
        //    slideDangNhap.Visible = true;
        //    slideDangKy.Visible = false;
        //    slideDangNhap.Left = 40;

        //    separator.Left = btnDangNhapHeader.Left;
        //    separator.Width = btnDangNhapHeader.Width;
        //}

        //private void btnDangKyHeader_Click(object sender, EventArgs e)
        //{
        //    slideDangKy.Visible = true;
        //    slideDangNhap.Visible = false;
        //    slideDangKy.Left = 40;

        //    separator.Left = btnDangKyHeader.Left;
        //    separator.Width = btnDangKyHeader.Width;
        //}
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
