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
using System.Text.RegularExpressions;
using xDialog;

namespace UI
{
    public partial class frmQuanLyKhachHang : Form
    {
        /*
     Thành Kỷ
      Form cho phép nhân viên bán hàng thêm, cập nhật, tìm kiếm khách hàng
      Cập nhật lần cuối 26/10/2018
      */

        public List<eKhachHang> lkh;
        KhachHangBLL khbll;
        private string tennv, manv;
        NhanVienBLL nvbll;

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
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
            lkh = new List<eKhachHang>();
            khbll = new KhachHangBLL();
            nvbll = new NhanVienBLL();
        }
        public frmQuanLyKhachHang(Panel p, frmTrangChu frm)
        {
            InitializeComponent();
            lkh = new List<eKhachHang>();
            khbll = new KhachHangBLL();
            nvbll = new NhanVienBLL();
        }
       
        public void LoadDataDgv(DataGridView gdv, List<eKhachHang> l)
        {
            gdv.DataSource = l;

        }
        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            txtTenKH.MaxLength = 30;
            txtSDT.MaxLength = 10;
            txtDiaChi.MaxLength = 50;
            lkh = khbll.LayDulieu();
            LoadDataDgv(dgvKhachHang, lkh);
            btnLuuKH.Enabled = false;
            txtMaKH.Enabled = false;
            txtTenKH.Enabled = false;
            txtSDT.Enabled = false;
            txtDiaChi.Enabled = false;
            int s = dgvKhachHang.CurrentCell.RowIndex;
            this.dgvKhachHang.Rows[s].Selected = true;
        }
        public bool KtraLuu()
        {
            if (txtDiaChi.Text == "" || txtSDT.Text == "" || txtTenKH.Text == "" )
            {
                 MsgBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnThemKH_Click(object sender, EventArgs e)//Thêm 1 Nhân viên mới 1/10/2018 Kỷ
        {
            txtTimKiemKH.Text = "";
            lkh = khbll.LayDulieu();
            LoadDataDgv(dgvKhachHang, lkh);
            if (btnThemKH.Text.Trim() == "Thêm")
            {
                btnThemKH.Text = "Hủy";
                btnThemKH.FlatAppearance.BorderColor = Color.Red;
                btnThemKH.FlatAppearance.BorderSize = 2;
                txtMaKH.Enabled = false;
                txtMaKH.Text = khbll.PhatSinhMa();
                txtDiaChi.Text = "";
                txtSDT.Text = "";
                txtTenKH.Text = "";
                txtTenKH.Enabled = true;
                txtSDT.Enabled = true;
                txtDiaChi.Enabled = true;
                btnCapNhatKH.Enabled = false;
                btnLuuKH.Enabled = true;
                dgvKhachHang.Enabled = false;
                //dgvKhachHang.CurrentCell.Selected = false;
                txtTimKiemKH.Enabled = false;
            }
            else
            {
                btnThemKH.Text = "Thêm";
                btnThemKH.FlatAppearance.BorderColor = Color.White;
                btnThemKH.FlatAppearance.BorderSize = 1;
                txtMaKH.Enabled = false;
                txtMaKH.Text = "";
                txtDiaChi.Text = "";
                txtSDT.Text = "";
                txtTenKH.Text = "";
                txtTenKH.Enabled = false;
                txtSDT.Enabled = false;
                txtDiaChi.Enabled = false;
                btnLuuKH.Enabled = false;
                btnCapNhatKH.Enabled = true;
                dgvKhachHang.CurrentRow.Selected = false;
                dgvKhachHang.CurrentRow.Selected = true;
                dgvKhachHang.Enabled = true;
                txtTimKiemKH.Enabled = true;
            }


        }

        private void btnLuuKH_Click(object sender, EventArgs e)//Lưu tt khách hàng sau khi thêm 1/10/2018 Kỷ
        {
            try
            {
                if (KtraLuu() == true)
                {
                    if (btnThemKH.Text == "Hủy")
                    {
                        eKhachHang khmoi = new eKhachHang();
                        khmoi.MaKH = txtMaKH.Text.Trim();
                        khmoi.TenKH = txtTenKH.Text;
                        khmoi.SoDT = txtSDT.Text;
                        khmoi.DiaChi = txtDiaChi.Text;
                        int kt = khbll.ThemKH(khmoi);
                        if (kt == 1)
                        {
                            MsgBox.Show("Thêm thành công", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                            lkh = khbll.LayDulieu();
                            LoadDataDgv(dgvKhachHang, lkh);
                            btnThemKH.Text = "Thêm";
                            btnLuuKH.Enabled = false;
                            dgvKhachHang.Enabled = true;
                            //dgvKhachHang.CurrentRow.Selected = true;
                            dgvKhachHang.CurrentRow.Selected = false;
                            dgvKhachHang.CurrentRow.Selected = true;
                            btnCapNhatKH.Enabled = true;
                            btnThemKH.ForeColor = Color.Black;
                            txtTimKiemKH.Enabled = true;
                        }
                        else
                            MsgBox.Show("Thêm không thành công", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                        btnThemKH.Enabled = true;
                    }
                    if (btnCapNhatKH.Text == "Hủy")
                    {
                        if (txtDiaChi.Text != "" && txtTenKH.Text != "" && txtSDT.Text != "")
                        {
                            khbll.CapNhatKH(txtMaKH.Text, txtTenKH.Text, txtSDT.Text, txtDiaChi.Text);
                            lkh = khbll.LayDulieu();
                            MsgBox.Show("Cập nhật thành công", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                            txtTimKiemKH.Enabled = true;
                            LoadDataDgv(dgvKhachHang, lkh);
                            btnCapNhatKH.Text = "Cập nhật";
                            btnCapNhatKH.ForeColor = Color.Black;
                            btnLuuKH.Enabled = false;
                            btnThemKH.Enabled = true;
                            dgvKhachHang.Enabled = true;
                            dgvKhachHang.CurrentRow.Selected = false;
                            dgvKhachHang.CurrentRow.Selected = true;
                        }
                        else
                        {
                            MsgBox.Show("Không để trống thông tin", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                        }

                    }
                    txtMaKH.Enabled = false;
                    txtTenKH.Enabled = false;
                    txtSDT.Enabled = false;
                    txtDiaChi.Enabled = false;
                    dgvKhachHang.Enabled = true;
                }

            }
            catch
            {
                MsgBox.Show("Lỗi.Lưu không thành công", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Error);
            }


        }
        
        private void btnCapNhatKH_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnCapNhatKH.Text.Trim() == "Cập nhật")
                {
                    btnCapNhatKH.Text = "Hủy";
                    btnCapNhatKH.FlatAppearance.BorderColor = Color.Red;
                    btnCapNhatKH.FlatAppearance.BorderSize = 2;
                    txtTenKH.Enabled = true;
                    txtSDT.Enabled = true;
                    txtDiaChi.Enabled = true;
                    btnLuuKH.Enabled = true;
                    btnThemKH.Enabled = false;
                    dgvKhachHang.Enabled = false;
                    dgvKhachHang.Enabled = false;
                    txtTimKiemKH.Enabled = false;
                }
                else
                {
                    btnCapNhatKH.Text = "Cập nhật";
                    btnCapNhatKH.FlatAppearance.BorderColor = Color.White;
                    btnCapNhatKH.FlatAppearance.BorderSize = 1;
                    txtTenKH.Enabled = false;
                    txtSDT.Enabled = false;
                    txtDiaChi.Enabled = false;
                    txtMaKH.Text = "";
                    txtTenKH.Text = "";
                    txtSDT.Text = "";
                    txtDiaChi.Text = "";
                    btnThemKH.Enabled = true;
                    btnLuuKH.Enabled = false;
                    dgvKhachHang.CurrentRow.Selected = false;
                    dgvKhachHang.CurrentRow.Selected = true;
                    dgvKhachHang.Enabled = true;
                    txtTimKiemKH.Enabled = true;
                }
            }
            catch
            {
                MsgBox.Show("Lỗi.Vui lòng chọn lại khách hàng", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Error);
            }


        }

        private void txtTimKiemKH_KeyUp(object sender, KeyEventArgs e)// tìm kiếm khách hàng
        {
            lkh = khbll.TimKiem(txtTimKiemKH.Text);
            LoadDataDgv(dgvKhachHang, lkh);
        }
        #region
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBanXe_Click(object sender, EventArgs e)
        {
            
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
          
        }
        private void btnQLXE_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBHTG_Click(object sender, EventArgs e)
        {
           
        }
        private void btnQLNV_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            
        }

        private void txtTimKiemKH_TextChanged(object sender, EventArgs e)
        {

        }
#endregion
        private void dgvKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            txtTenKH.Enabled = false;
            txtSDT.Enabled = false;
            txtDiaChi.Enabled = false;
            int index = this.dgvKhachHang.CurrentRow.Index;
            txtMaKH.Text = dgvKhachHang.Rows[index].Cells[0].Value.ToString();
            txtTenKH.Text = dgvKhachHang.Rows[index].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.Rows[index].Cells[2].Value.ToString();
            txtSDT.Text = dgvKhachHang.Rows[index].Cells[3].Value.ToString();
            
        }
        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = this.dgvKhachHang.CurrentCell.RowIndex;
            this.dgvKhachHang.Rows[a].Selected = true;
        }
        public bool KtraNhapTen(TextBox a)
        {
            if (Regex.IsMatch(a.Text, "[0-9]|[!@#$&*-]"))
            {
                a.Text = a.Text.Remove(a.Text.Length - 1);
                a.SelectionStart = a.Text.Length;
                return true;
            }
            return false;
        }
        public bool KtraNhapSo(TextBox a)
        {
            if (Regex.IsMatch(a.Text, "[^0-9]"))
            {
                a.Text = a.Text.Remove(a.Text.Length - 1);
                a.SelectionStart = a.Text.Length;
                return true;
            }
            return false;
        }
        private void txtTenKH_KeyUp(object sender, KeyEventArgs e)
        {
            if (KtraNhapTen(txtTenKH) == true)
            {
                lblLoiTen.Text = "Không nhập số";
                lblLoiTen.ForeColor = Color.Red;
            }
            else
            {
                lblLoiTen.Text = "";
            }
        }

        private void txtSDT_KeyUp(object sender, KeyEventArgs e)
        {
            if (KtraNhapSo(txtSDT) == true)
            {
                lblLoiSDT.Text = "Chỉ nhập số";
                lblLoiSDT.ForeColor = Color.Red;
            }
            else
            {
                lblLoiSDT.Text = "";
            }
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if(khbll.KtraTonTai(txtSDT.Text.Trim()) == true)
            {
                MsgBox.Show("Số điện thoại đã tồn tại", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Exclamation);
            }
        }

        private void dgvKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = this.dgvKhachHang.CurrentCell.RowIndex;
            this.dgvKhachHang.Rows[a].Selected = true;
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
           
        }
    }
}
