using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BLL;
namespace UI
{ /*
       Thành Kỷ
       Form hiển thị đăng nhập, giới thiệu thành viên
       Cập nhật lần cuối 16/10/2018
       */
    public partial class frmMenu : Form
    {
        string tentk = "";
        frmTrangChu tc = null;
        public frmMenu(Panel p, frmTrangChu frm)
        {
            InitializeComponent();
            tc = frm;
        }
        #region
        private void TSMtQLKH_Click(object sender, EventArgs e)
        {

        }

        private void TSMtQLXe_Click(object sender, EventArgs e)
        {

        }

        private void TSMtQLNV_Click(object sender, EventArgs e)
        {

        }

        private void TSMnTKHDong_Click(object sender, EventArgs e)
        {

        }

        private void TSBtnBHTG_Click(object sender, EventArgs e)
        {

        }

        private void TSBtnBanXe_Click(object sender, EventArgs e)
        {

        }

        private void TSBtnTrangChu_Click(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {

        }
        #endregion
        private void frmMenu_Load(object sender, EventArgs e)
        {
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            tc.Visible = false;
            frmDangNhap dn = new frmDangNhap();
            dn.Show();
        }
        #region
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion
    }
}
