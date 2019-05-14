using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entities;
using xDialog;

namespace UI
{
    /*
      Thành Kỷ
      Form cho phép nhập tên, tài khoản đăng nhập vào hệ thống
      Cập nhật lần cuối 26/10/2018
      */
    public partial class frmDangNhap : Form
    {

        TaiKhoanBLL tkbll;
        NhanVienBLL nvbll;
        frmTrangChu tc = new frmTrangChu();
        public frmDangNhap()
        {
            InitializeComponent();
            tkbll = new TaiKhoanBLL();
            nvbll = new NhanVienBLL();
        }
        #region
        private void label1_Click(object sender, EventArgs e)
        {

        }
        #endregion
        //dăng nhập 
        public void DangNhap() // đăng nhập vào hệ thống
        {
            eTaiKhoan tkdn = new eTaiKhoan();
            tkdn = tkbll.layTKBangTenTK(txtTenTaiKhoan.Text.Trim().ToUpper());
          
            if (tkdn != null)
            {
                eNhanVien nv = nvbll.LayNVTheoMa(tkdn.MaNhanVien.Trim());
                if (nv.TinhTrang == true)
                {
                    tkdn.MatKhau = txtMatKhau.Text.Trim();
                    if (tkbll.KtraTaiKhoan(tkdn) == true)
                    {
                        frmMenu mn = new frmMenu(tc.PanelParent, tc);
                        tc.Tentk = txtTenTaiKhoan.Text;
                        lblLoiMK.Text = "";
                        tc.Mk = txtMatKhau.Text;
                        tc.Show();
                        this.Visible = false;

                    }
                    else
                    {
                        lblLoiMK.Text = "*Mật khẩu không chính xác.";
                        lblLoiMK.ForeColor = Color.Red;
                        txtMatKhau.Text = "";
                        txtMatKhau.Focus();
                    }
                }
                else
                {
                    MsgBox.Show("Tài khoản đã hủy", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                    txtMatKhau.Text = "";
                    txtTenTaiKhoan.Focus();
                    lblLoiMK.Text = "";
                }
            }
            else
            {
                MsgBox.Show("Tài khoản không tồn tại", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                txtMatKhau.Text = "";
                txtTenTaiKhoan.Focus();
                lblLoiMK.Text = "";
            }


        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            lblLoiMK.Text = "";
        }
        #region
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void btnDangNhap_Enter(object sender, EventArgs e)
        {
        }
        private void frmDangNhap_Enter(object sender, EventArgs e)
        {
        }
        private void txtMatKhau_Enter(object sender, EventArgs e)
        {   
        }
        private void frmDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        private void frmDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtTenTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        #endregion

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DangNhap();
            }
        }

        private void btnDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DangNhap();
            }
        }
        #region
        private void frmDangNhap_MouseClick(object sender, MouseEventArgs e)
        {

        }
        #endregion

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MsgBox.Show("Bạn có muốn thoát chương trình?", "Thoát", MsgBox.Buttons.YesNo,
                MsgBox.Icon.Question, MsgBox.AnimateStyle.FadeIn);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
