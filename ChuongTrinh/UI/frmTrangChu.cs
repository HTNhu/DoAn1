using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BLL;
using xDialog;

namespace UI
{
    public partial class frmTrangChu : Form
    {
        /*
          Lê Thành Kỷ
           Hiển thị thanh menu , thông tin nhân viên sau khi đăng nhập vào hệ thống
           Cập nhật lần cuối ngày 10/10/2018 
         */
        TaiKhoanBLL tkbll;
        NhanVienBLL nvbll;
        private string tentk;
        private string mk;
        private string tennv, manv;
        public string Tentk
        {
            get
            {
                return tentk;
            }

            set
            {
                tentk = value;
            }
        }

        public string Mk
        {
            get
            {
                return mk;
            }

            set
            {
                mk = value;
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

        public frmTrangChu()
        {
            InitializeComponent();
            tkbll = new TaiKhoanBLL();
            nvbll = new NhanVienBLL();
             
        }
        
        public void ShowForm(Form frm)
        {
            PanelParent.Controls.Clear();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            PanelParent.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
        private void TrangChuForm_Load(object sender, EventArgs e)
        {
            PanelParent.Controls.Clear();
            frmMenu frm = new frmMenu(PanelParent, this);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Visible = true;
            PanelParent.Controls.Add(frm);

            this.label1.Visible = true;
            this.label7.Visible = false;

            tennv = lblTen.Text;
            if (tentk != null) // nếu đăng nhập thành công
            {
                frm.btnDangNhap.Visible = false;
                btnBanXe.Visible = true;
                btnQLNV.Visible = true;
                btnQLXe.Visible = true;
                btnBHTG.Visible = true;
                btnThongKe.Visible = true;
                btnQLKH.Visible = true;
                btnID.Visible = true;
                btnTrangChu.Visible = true;
                lblID.Visible = true;
                lblTen.Visible = true;
                this.label1.Visible = false;
                this.label7.Visible = true;
                // Show mã & phân loại chức năng theo nv
                eTaiKhoan tkdn = new eTaiKhoan();
                tkdn = tkbll.layTKBangTenTK(tentk);
                eNhanVien nv = nvbll.LayNVTheoMa(tkdn.MaNhanVien);
                lblID.Text = "ID: " + nv.MaNhanVien;
                lblTen.Text = "Xin chào " + nv.TenNV;
                if (nv != null)
                {
                    if (nv.ChucVu.TrimEnd() == "bh")
                    {

                        btnQLNV.Enabled = false;
                        btnQLXe.Enabled = false;
                        btnThongKe.Enabled = false;

                    }
                    else if (nv.ChucVu.TrimEnd() == "kt")
                    {
                        btnQLNV.Enabled = false;
                        btnBanXe.Enabled = false;
                        btnQLXe.Enabled = false;
                        btnQLKH.Enabled = false;
                        btnThongKe.Enabled = false;
                    }
                    else
                    {
                        btnBanXe.Enabled = false;
                        btnBHTG.Enabled = false;
                        btnQLKH.Enabled = false;
                    }
                }
                this.btnTrangChu.BackgroundImage = Properties.Resources._800px_COLOURBOX4829934;
                btnTrangChu.ForeColor = Color.White;
            }
            else // vào form đầu tiên
            {
                
                btnBanXe.Enabled = false;
                btnQLNV.Enabled = false;
                btnQLXe.Enabled = false;
                btnBHTG.Enabled = false;
                btnThongKe.Enabled = false;
                btnQLKH.Enabled = false;
                btnID.Visible = false;
                btnTrangChu.Enabled = false;
                lblID.Visible = false;
                lblTen.Visible = false;
            }
        }
        #region

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBHTG_Click_1(object sender, EventArgs e)
        {
        }

        private void btnQLNV_Click_1(object sender, EventArgs e)
        {
        }

        private void btnBanXe_Click_1(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion // Nhap // nhap
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            
        }
        #region
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
          
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void TSPbtnQL_ButtonClick(object sender, EventArgs e)
        {

        }
       
        private void TSMtQLNV_Click(object sender, EventArgs e)
        {
            
        }

        private void TSMtQLXe_Click(object sender, EventArgs e)
        {
            
        }

        private void TSMtQLKH_Click(object sender, EventArgs e)
        {
           
        }

        private void TSBtnTrangChu_Click(object sender, EventArgs e)
        {

        }

        private void TSBtnBanXe_Click(object sender, EventArgs e)
        {
            //frmMenu frmmn = new frmMenu();
            //frmHoaDon frm = new frmHoaDon(PanelParent, frmmn);
            

           
        }

        private void TSBtnBHTG_Click(object sender, EventArgs e)
        {
           

           
        }

        private void TSMnTKHDong_Click(object sender, EventArgs e)
        {
          
            
        }
        
        private void TSMnTKHDon_Click(object sender, EventArgs e)
        {

        }

        private void TSPBtnQuanLy_ButtonClick(object sender, EventArgs e)
        {

        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            
        }
#endregion
        private void btnQLXe_Click(object sender, EventArgs e)//Kỷ click vào btn quản lý xe hiển thị form quản lý xe 9/10
        {
            PanelParent.Controls.Clear();
            frmQuanLyXe frm = new frmQuanLyXe(PanelParent, this);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Visible = true;
            PanelParent.Controls.Add(frm);

            btnQLXe.ForeColor = Color.White;
            this.btnQLNV.ForeColor = Color.DarkBlue;
            this.btnQLKH.ForeColor = Color.DarkBlue;
            this.btnTrangChu.ForeColor = Color.DarkBlue;
            this.btnBanXe.ForeColor = Color.DarkBlue;
            this.btnBHTG.ForeColor = Color.DarkBlue;
            this.btnThongKe.ForeColor = Color.DarkBlue;
            this.btnBanXe.ForeColor = Color.DarkBlue;

            btnQLXe.BackgroundImage = Properties.Resources._800px_COLOURBOX4829934;
            this.btnQLKH.BackgroundImage = Properties.Resources.aqua_button_hi2;
            this.btnTrangChu.BackgroundImage = Properties.Resources.aqua_button_hi2;
            this.btnBanXe.BackgroundImage = Properties.Resources.aqua_button_hi2;
            this.btnBHTG.BackgroundImage = Properties.Resources.aqua_button_hi2;
            this.btnThongKe.BackgroundImage = Properties.Resources.aqua_button_hi2;
            this.btnQLNV.BackgroundImage = Properties.Resources.aqua_button_hi2;
        }

        private void btnBanXe_Click(object sender, EventArgs e)//Kỷ click vào btn bán xe hiển thị form Hóa đơn 
        {
            PanelParent.Controls.Clear();
            frmHoaDon frm = new frmHoaDon(PanelParent, this);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Visible = true;
            PanelParent.Controls.Add(frm);

            btnBanXe.ForeColor = Color.White;
            this.btnQLXe.ForeColor = Color.DarkBlue;
            this.btnQLKH.ForeColor = Color.DarkBlue;
            this.btnTrangChu.ForeColor = Color.DarkBlue;
            this.btnBHTG.ForeColor = Color.DarkBlue;
            this.btnThongKe.ForeColor = Color.DarkBlue;
            this.btnQLNV.ForeColor = Color.DarkBlue;

            btnBanXe.BackgroundImage = Properties.Resources._800px_COLOURBOX4829934;
            this.btnQLXe.BackgroundImage = Properties.Resources.aqua_button_hi2;
            this.btnQLKH.BackgroundImage = Properties.Resources.aqua_button_hi2;
            this.btnTrangChu.BackgroundImage = Properties.Resources.aqua_button_hi2;
            this.btnBHTG.BackgroundImage = Properties.Resources.aqua_button_hi2;
            this.btnThongKe.BackgroundImage = Properties.Resources.aqua_button_hi2;
            this.btnQLNV.BackgroundImage = Properties.Resources.aqua_button_hi2;

        }

        private void btnQLNV_Click(object sender, EventArgs e)//Kỷ click vào btn quản lí nhân viên hiển thị frmQuanLyNhanVien
        {
            PanelParent.Controls.Clear();
            frmQuanLyNhanVien frm = new frmQuanLyNhanVien(PanelParent, this);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Visible = true;
            PanelParent.Controls.Add(frm);

            btnQLNV.ForeColor = Color.White;
            this.btnQLXe.ForeColor = Color.DarkBlue;
            this.btnQLKH.ForeColor = Color.DarkBlue;
            this.btnTrangChu.ForeColor = Color.DarkBlue;
            this.btnBanXe.ForeColor = Color.DarkBlue;
            this.btnBHTG.ForeColor = Color.DarkBlue;
            this.btnThongKe.ForeColor = Color.DarkBlue;
            this.btnBanXe.ForeColor = Color.DarkBlue;

            this.btnQLNV.BackgroundImage = Properties.Resources._800px_COLOURBOX4829934;
            this.btnQLKH.BackgroundImage = Properties.Resources.aqua_button_hi2;
            this.btnTrangChu.BackgroundImage = Properties.Resources.aqua_button_hi2;
            this.btnBanXe.BackgroundImage = Properties.Resources.aqua_button_hi2;
            this.btnBHTG.BackgroundImage = Properties.Resources.aqua_button_hi2;
            this.btnThongKe.BackgroundImage = Properties.Resources.aqua_button_hi2;
            this.btnQLXe.BackgroundImage = Properties.Resources.aqua_button_hi2;

        }

        private void btnQLKH_Click(object sender, EventArgs e)//Kỷ click vào btn Quản lý khách hàng hiển thị form QuanLyKhachHang
        {
            PanelParent.Controls.Clear();
            frmQuanLyKhachHang frm = new frmQuanLyKhachHang(PanelParent, this);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Visible = true;
            PanelParent.Controls.Add(frm);

            btnQLKH.ForeColor = Color.White;
            this.btnQLNV.ForeColor = Color.DarkBlue;
            this.btnQLXe.ForeColor = Color.DarkBlue;
            this.btnTrangChu.ForeColor = Color.DarkBlue;
            this.btnBanXe.ForeColor = Color.DarkBlue;
            this.btnBHTG.ForeColor = Color.DarkBlue;
            this.btnThongKe.ForeColor = Color.DarkBlue;
            this.btnBanXe.ForeColor = Color.DarkBlue;

            btnQLKH.BackgroundImage = Properties.Resources._800px_COLOURBOX4829934;
            this.btnThongKe.BackgroundImage = Properties.Resources.aqua_button_hi2;
            this.btnTrangChu.BackgroundImage = Properties.Resources.aqua_button_hi2;
            this.btnBanXe.BackgroundImage = Properties.Resources.aqua_button_hi2;
            this.btnQLXe.BackgroundImage = Properties.Resources.aqua_button_hi2;
            this.btnBHTG.BackgroundImage = Properties.Resources.aqua_button_hi2;
            this.btnQLNV.BackgroundImage = Properties.Resources.aqua_button_hi2;
        }

        private void btnBHTG_Click(object sender, EventArgs e)//Kỷ click vào btnBảo hành & Trả góp hiển thị form Tìm hợp đồng
        {
            PanelParent.Controls.Clear();
            frmTimHopDong frm = new frmTimHopDong(PanelParent, this);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Visible = true;
            PanelParent.Controls.Add(frm);

            btnBHTG.ForeColor = Color.White;
            this.btnQLNV.ForeColor = Color.DarkBlue;
            this.btnQLXe.ForeColor = Color.DarkBlue;
            this.btnTrangChu.ForeColor = Color.DarkBlue;
            this.btnBanXe.ForeColor = Color.DarkBlue;
            this.btnQLKH.ForeColor = Color.DarkBlue;
            this.btnThongKe.ForeColor = Color.DarkBlue;
            this.btnBanXe.ForeColor = Color.DarkBlue;

            btnBHTG.BackgroundImage = Properties.Resources._800px_COLOURBOX4829934;
            this.btnQLKH.BackgroundImage = Properties.Resources.aqua_button_hi2;
            this.btnTrangChu.BackgroundImage = Properties.Resources.aqua_button_hi2;
            this.btnBanXe.BackgroundImage = Properties.Resources.aqua_button_hi2;
            this.btnQLXe.BackgroundImage = Properties.Resources.aqua_button_hi2;
            this.btnThongKe.BackgroundImage = Properties.Resources.aqua_button_hi2;
            this.btnQLNV.BackgroundImage = Properties.Resources.aqua_button_hi2;
        }

        private void btnThongKe_Click(object sender, EventArgs e)//Kỷ click vào btn Thông kê hiển thị form ThongKe
        {
            PanelParent.Controls.Clear();
            frmThongKe frm = new frmThongKe(PanelParent, this);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Visible = true;
            PanelParent.Controls.Add(frm);

            btnThongKe.ForeColor = Color.White;
            this.btnQLNV.ForeColor = Color.DarkBlue;
            this.btnQLXe.ForeColor = Color.DarkBlue;
            this.btnTrangChu.ForeColor = Color.DarkBlue;
            this.btnBanXe.ForeColor = Color.DarkBlue;
            this.btnQLKH.ForeColor = Color.DarkBlue;
            this.btnBHTG.ForeColor = Color.DarkBlue;
            this.btnBanXe.ForeColor = Color.DarkBlue;

            btnThongKe.BackgroundImage = Properties.Resources._800px_COLOURBOX4829934;
            this.btnQLKH.BackgroundImage = Properties.Resources.aqua_button_hi2;
            this.btnTrangChu.BackgroundImage = Properties.Resources.aqua_button_hi2;
            this.btnBanXe.BackgroundImage = Properties.Resources.aqua_button_hi2;
            this.btnQLXe.BackgroundImage = Properties.Resources.aqua_button_hi2;
            this.btnBHTG.BackgroundImage = Properties.Resources.aqua_button_hi2;
            this.btnQLNV.BackgroundImage = Properties.Resources.aqua_button_hi2;
        }

        private void xemThôngTinToolStripMenuItem_Click(object sender, EventArgs e) // Xem thong tin nv
        {
            string manv = lblID.Text.Substring(4);
            frmXemttNV frmxnv = new frmXemttNV(this, manv);
            frmxnv.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)//Đăng xuất
        {
            DialogResult result = MsgBox.Show("Bạn có muốn đăng xuất?", "Đăng xuất", MsgBox.Buttons.YesNo,
               MsgBox.Icon.Question, MsgBox.AnimateStyle.FadeIn);
            if(result == DialogResult.Yes)
            {
                tentk = "";
                frmLoading frm = new frmLoading();
                frm.Show();
                this.Visible = false;
            }
            
        }

        private void frmTrangChu_FormClosing(object sender, FormClosingEventArgs e)// Đóng trang chủ
        {
            DialogResult result = MsgBox.Show("Bạn có muốn thoát chương trình?", "Thoát", MsgBox.Buttons.YesNo,
                MsgBox.Icon.Question, MsgBox.AnimateStyle.FadeIn);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
          
        }

        private void btnID_MouseHover(object sender, EventArgs e)
        {
            btnID.Image = Properties.Resources.Setting_icon2;
            btnID.Height = 55;
            btnID.Width = 55;
            btnID.Location = new Point(933, -3);
        }

        private void btnID_MouseLeave(object sender, EventArgs e)
        {
            btnID.Image = Properties.Resources.Setting_icon1;
            btnID.Height = 40;
            btnID.Width = 40;
            btnID.Location = new Point(942, 1);
        }
        #region
        private void xemThôngTinToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            //xemThôngTinToolStripMenuItem.BackgroundImage = Properties.Resources.btnDangNhap3;
        }

        private void xemThôngTinToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            //xemThôngTinToolStripMenuItem.BackgroundImage = Properties.Resources.aqua_button_hi3;
        }

        private void toolStripMenuItem1_MouseLeave(object sender, EventArgs e)
        {
            //toolStripMenuItem1.BackgroundImage = Properties.Resources.btnDangNhap3;
        }

        private void toolStripMenuItem1_MouseMove(object sender, MouseEventArgs e)
        {
            //toolStripMenuItem1.BackgroundImage = Properties.Resources.aqua_button_hi3;
        }
        #endregion
        private void btnTrangChu_Click_1(object sender, EventArgs e)
        {
            PanelParent.Controls.Clear();
            frmMenu frm = new frmMenu(PanelParent, this);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Visible = true;
            
            frm.label3.Visible = false;
            frm.label4.Visible = false;
            frm.label5.Visible = false;
            frm.btnDangNhap.Visible = false;
            PanelParent.Controls.Add(frm);

            btnTrangChu.ForeColor = Color.White;
            this.btnQLNV.ForeColor = Color.DarkBlue;
            this.btnQLXe.ForeColor = Color.DarkBlue;
            this.btnThongKe.ForeColor = Color.DarkBlue;
            this.btnBanXe.ForeColor = Color.DarkBlue;
            this.btnQLKH.ForeColor = Color.DarkBlue;
            this.btnBHTG.ForeColor = Color.DarkBlue;
            this.btnBanXe.ForeColor = Color.DarkBlue;

            btnTrangChu.BackgroundImage = Properties.Resources._800px_COLOURBOX4829934;
            this.btnQLKH.BackgroundImage = Properties.Resources.aqua_button_hi2;
            this.btnThongKe.BackgroundImage = Properties.Resources.aqua_button_hi2;
            this.btnBanXe.BackgroundImage = Properties.Resources.aqua_button_hi2;
            this.btnQLXe.BackgroundImage = Properties.Resources.aqua_button_hi2;
            this.btnBHTG.BackgroundImage = Properties.Resources.aqua_button_hi2;
            this.btnQLNV.BackgroundImage = Properties.Resources.aqua_button_hi2;

            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)//Kỷ click vào btn Đăng nhập hiển thị frmDangNhap
        {
            
            frmDangNhap dn = new frmDangNhap();
            dn.Show();
            this.Visible = false;

        }
    }
}
