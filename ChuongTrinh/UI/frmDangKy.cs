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
using System.Text.RegularExpressions;
namespace UI
{
    public partial class frmDangKy : Form
    {
       // List<eTaiKhoan> tklist;
        
        TaiKhoanBLL tkbll;
        NhanVienBLL nvbll;
        frmQuanLyNhanVien frmqlnv = null;
        frmTrangChu frmtc = null;
        private string manvshow ="";
        private string tennvshow="";
        private string manv;
        private string tennv;
        private string sdt;
        private string diachi;
        private string chucvu;
        private string calam;
        private string cmnd;
        //private bool tinhTrang;
        #region

        public string Manv
        {
            get
            {
                return manv;
            }

            set
            {
                manv = value;
            }
        }

        public string Tennv
        {
            get
            {
                return tennv;
            }

            set
            {
                tennv = value;
            }
        }

        public string Sdt
        {
            get
            {
                return sdt;
            }

            set
            {
                sdt = value;
            }
        }

        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }

        public string Chucvu
        {
            get
            {
                return chucvu;
            }

            set
            {
                chucvu = value;
            }
        }

        public string Calam
        {
            get
            {
                return calam;
            }

            set
            {
                calam = value;
            }
        }

        public string Cmnd
        {
            get
            {
                return cmnd;
            }

            set
            {
                cmnd = value;
            }
        }

        public string Manvshow
        {
            get
            {
                return manvshow;
            }

            set
            {
                manvshow = value;
            }
        }

        public string Tennvshow
        {
            get
            {
                return tennvshow;
            }

            set
            {
                tennvshow = value;
            }
        }
        #endregion
        public frmDangKy()
        {
            InitializeComponent();
            tkbll = new TaiKhoanBLL();
            nvbll = new NhanVienBLL();
            }
        public frmDangKy(frmTrangChu frmc, frmQuanLyNhanVien frm, string manv, string tennv)
        {
            InitializeComponent();
            tkbll = new TaiKhoanBLL();
            nvbll = new NhanVienBLL();
            manvshow = manv;
            tennvshow = tennv;
            frmqlnv = frm;
            frmtc = frmc;
        }
        public static bool KiemTraTenTK(string tentk) // Kiểm tra hợp lệ tên đăng nhập
        {
            string strRegex = "^[a-zA-z0-9._-]{8,15}$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(tentk))
                return true;
            else
                return false;
        }
        public static bool KiemTraMK(string matkhau)// Kiểm tra hợp lệ mật khẩu
        {
            string strRegex = "^[a-zA-z0-9._-]{5,12}$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(matkhau))
                return true;
            else
                return false;
        }
        #region
        //public bool KtraDangKy()
        //{
        //if (tkbll.layTKBangTenTK(txtTenTK.Text.Trim()) != null )
        //{
        //    MessageBox.Show("Tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    return false;
        //}
        //else
        //{
        //    if (txtTenTK.Text == "" ||txtMK.Text == "" || txtNLMK.Text == "")
        //    {
        //        MessageBox.Show("Không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return false;

        //    }
        //    else
        //    {
        //        if (txtMK.ToString().Trim() == txtNLMK.ToString().Trim())
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //}
        // }
        #endregion
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if(lblTBLoiMK.Text == "" && lblTBLoiTenTK.Text =="" && lblTBLoiNLMK.Text =="")
            {
                eNhanVien nvmoi = new eNhanVien();
                nvmoi.MaNhanVien = manvshow;
                nvmoi.TenNV = tennvshow;
                nvmoi.SoDT = sdt;
                nvmoi.DiaChi = diachi;
                nvmoi.ChucVu = chucvu;
                nvmoi.CaLam = calam;
                nvmoi.TinhTrang = true;
                nvmoi.CMND = cmnd;

                int a = nvbll.ThemNV(nvmoi);
                if (a == 1)
                {
                    eTaiKhoan tkmoi = new eTaiKhoan();
                    tkmoi.MaNhanVien = manvshow.Trim();
                    tkmoi.TenTaiKhoan = txtTenTK.Text.Trim();
                    tkmoi.MatKhau = txtMK.Text;
                    int kt = tkbll.ThemTK(tkmoi);
                    if (kt == 1)
                    {
                        MessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmQuanLyNhanVien frm = new frmQuanLyNhanVien(frmtc.PanelParent,frmtc);
                        frm.FormBorderStyle = FormBorderStyle.None;
                        frm.TopLevel = false;
                        frm.Dock = DockStyle.Fill;
                        frm.Show();
                       frmtc.PanelParent.Controls.Add(frm);
                    }
                }
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenTK.Focus();
            }
        }
        private void frmDangKy_Load(object sender, EventArgs e)
        {
           
            tkbll.LayTatCaGiaTri();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmqlnv.Visible = true;

        }
        #region
        private void txtTenTK_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtMK_Leave(object sender, EventArgs e)
        {
      
            
        }

        private void txtNLMK_Leave(object sender, EventArgs e)
        {
           
        }
        #endregion
        private void txtTenTK_KeyUp(object sender, KeyEventArgs e)
        {
            if (KiemTraTenTK(txtTenTK.Text.Trim()) == false)
            {
                lblTBLoiTenTK.Text = "Tên tài khoản phải có từ 8 - 15 ký tự\n và không có ký tự khoảng trắng";
            }
            else if (tkbll.layTKBangTenTK(txtTenTK.Text.Trim()) != null)
            {
                lblTBLoiTenTK.Text = "Tên tài khoản đã tồn tại";
            }
            else
            {
                lblTBLoiTenTK.Text = "";
            }
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {
            if (KiemTraMK(txtMK.Text) == false)
            {
                lblTBLoiMK.Text = "Mật khẩu phải có từ 5 - 12 ký tự\n và không có ký tự khoảng trắng";
            }
            else
            {
                lblTBLoiMK.Text = "";
            }
        }

        private void txtNLMK_TextChanged(object sender, EventArgs e)
        {
            if (txtMK.Text != "")
            {
                string strRegex = txtMK.Text;
                Regex re = new Regex(strRegex);
                if (re.IsMatch(txtNLMK.Text))
                    lblTBLoiNLMK.Text = "";
                else
                    lblTBLoiNLMK.Text = "Mật khẩu chưa khớp";
            }
            else
            {
                lblTBLoiNLMK.Text = "Vui lòng nhập mật khẩu trước";
            }
        }
    }
}
