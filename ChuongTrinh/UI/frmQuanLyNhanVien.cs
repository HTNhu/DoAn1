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
using xDialog;

namespace UI
{
    /*
       Trần Như
       Form cho phép thêm, tạo tài khoản nhân viên mới, cập nhật, tìm kiếm nhân viên
       Cập nhật lần cuối 26/10/2018
    */
    public partial class frmQuanLyNhanVien : Form
    {
        List<eNhanVien> l;
        NhanVienBLL nvbll;
        TaiKhoanBLL tkbll;
        frmTrangChu frmtc = null;
        private string tennv, manv;

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
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
            l = new List<eNhanVien>();
            nvbll = new NhanVienBLL();
            tkbll = new TaiKhoanBLL();

        }
        public frmQuanLyNhanVien(Panel p, frmTrangChu frm)
        {
            InitializeComponent();
            l = new List<eNhanVien>();
            nvbll = new NhanVienBLL();
            tkbll = new TaiKhoanBLL();
            frmtc = frm;
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            txtTenNV.MaxLength = 30;
            txtDiaChi.MaxLength = 50;
            txtSDT.MaxLength = 10;
            txtCMND.MaxLength = 12;
            l = nvbll.LayDulieu();
            LoadDataDgv(dgvNhanVien, l);
            int s = dgvNhanVien.CurrentCell.RowIndex;
            this.dgvNhanVien.Rows[s].Selected = true;
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            txtSDT.Enabled = false;
            txtDiaChi.Enabled = false;
            cbxChucVu.Enabled = false;
            txtCMND.Enabled = false;
            cbxCaLam.Enabled = false;
            rbtnDangHD.Enabled = false;
            rbtnHetHD.Enabled = false;
            btnDangkyTK.Visible = false;
            btnQuayLai.Visible = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
           

        }
        public void LoadDataDgv(DataGridView gdv, List<eNhanVien> l)
        {
            gdv.DataSource = l;
            
        }
        

       
       // tạo mã phát sinh tự động Như 30/09/2018 5:00pm
        public string PhatSinhMa()
        {
            int so = dgvNhanVien.RowCount;
            int stt = 0;
            if(so == 0)
            {
                stt = 1;
            }
            else
            {
                stt = so + 1;
            }
            string ma;
            if (stt < 10)
                ma = "NV00" + stt.ToString();
            else if (stt < 100)
                ma = "NV0" + stt.ToString();
            else
                ma = "NV" + stt.ToString();
            return ma;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtTimKiemNV.Text = "";
            l = nvbll.LayDulieu();
            LoadDataDgv(dgvNhanVien, l);
    
            lblTinhTrang.Visible = false;
            txtMaNV.Enabled = false;
            txtMaNV.Text = PhatSinhMa();
            cbxChucVu.Text = "";
            txtCMND.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtTenNV.Text = "";
            cbxCaLam.Text = "";
            txtTenNV.Enabled = true;
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;
            cbxChucVu.Enabled = true;
            txtCMND.Enabled = true;
            cbxCaLam.Enabled = true;
            btnCapNhat.Visible = false;
            btnLuu.Visible = false;
            btnThem.Visible = false;
            btnDangkyTK.Visible = true;
            btnQuayLai.Visible = true;
            
            rbtnDangHD.Visible = false;
            rbtnHetHD.Visible = false;
            txtTimKiemNV.Enabled = false;
            dgvNhanVien.Enabled = false;
        }
        #region
        private void lblID_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion
        private void btnLuu_Click(object sender, EventArgs e)// Lưu sau khi cập nhật
        {
            bool tt;
            if (rbtnDangHD.Checked)
                tt = true;
            else
                tt = false;
            if (txtTenNV.Text != "" && txtSDT.Text != "" && txtDiaChi.Text != "" && cbxCaLam.Text != ""
                && txtCMND.Text != "" && cbxChucVu.Text != "")
            {
                nvbll.CapNhatNV(txtMaNV.Text, txtTenNV.Text, txtSDT.Text, cbxChucVu.Text, cbxCaLam.Text, txtCMND.Text, txtDiaChi.Text,tt);
                MsgBox.Show("Cập nhật thành công", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                l = nvbll.LayDulieu();
                txtMaNV.Text = "";
                cbxChucVu.Text = "";
                txtCMND.Text = "";
                txtDiaChi.Text = "";
                txtSDT.Text = "";
                txtTenNV.Text = "";
                cbxCaLam.Text = "";
                cbxChucVu.Text = "";
                btnCapNhat.Text = "Cập nhật";
                btnLuu.Enabled = true;
                btnCapNhat.FlatAppearance.BorderColor = Color.White;
                btnCapNhat.FlatAppearance.BorderSize = 1;
                txtTimKiemNV.Enabled = true;
                dgvNhanVien.Enabled = true;
                dgvNhanVien.CurrentRow.Selected = false;
                dgvNhanVien.CurrentRow.Selected = true;
                LoadDataDgv(dgvNhanVien, l);
            }
            else
                MsgBox.Show("Cập nhật không thành công", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Error);
      }
      private void btnDangkyTK_Click(object sender, EventArgs e) // Mở form đki tài khoản cho nv mới
        {
            if (txtTenNV.Text != "" && txtSDT.Text != "" && txtDiaChi.Text != "" && cbxCaLam.Text != ""
                && txtCMND.Text != "" )
            {
                string manv = txtMaNV.Text.Trim();
                string tennv = txtTenNV.Text.Trim();
                frmDangKy frmmoi = new frmDangKy(frmtc,this,manv,tennv);
              
                frmmoi.Chucvu = cbxChucVu.Text;
                frmmoi.Calam = cbxCaLam.Text;
                frmmoi.Sdt = txtSDT.Text;
                frmmoi.Cmnd = txtCMND.Text;
                frmmoi.Diachi = txtDiaChi.Text;
              
                frmmoi.Show();
                //frmtc.Visible = false;
                this.Visible = false;
                btnThem.Visible = false;
                btnCapNhat.Visible = false;
                btnLuu.Visible = false;
            }
            else
              MsgBox.Show("Không để trống các ô", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Error);
        }
        #region

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)// hiển thị thông tin từ gridview sang tẽtbox
        {
            
        }
        private void btnQLNV_Click(object sender, EventArgs e)
        {
          
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            
        }
        private void btnQLXe_Click(object sender, EventArgs e)
        {
           
        }
        #endregion
        private void btnCapNhat_Click(object sender, EventArgs e)// hiển thọi textbox cho cập nhật dữ liệu 1/10/2018
        {
            try
            {
                if (btnCapNhat.Text.Trim() == "Cập nhật")
                {
                    btnCapNhat.Text = "Hủy";
                    btnCapNhat.FlatAppearance.BorderColor = Color.Red;
                    btnCapNhat.FlatAppearance.BorderSize = 2;
                    btnLuu.Enabled = true;
                    txtTenNV.Enabled = true;
                    txtSDT.Enabled = true;
                    txtDiaChi.Enabled = true;
                    cbxChucVu.Enabled = true;
                    txtCMND.Enabled = true;
                    cbxCaLam.Enabled = true;
                    rbtnDangHD.Enabled = true;
                    rbtnHetHD.Enabled = true;
                    rbtnDangHD.Enabled = true;
                    rbtnHetHD.Enabled = true;
                    btnThem.Enabled = false;
                    dgvNhanVien.Enabled = false;
                    txtTimKiemNV.Enabled = false;
                }
                else

                {
                    btnCapNhat.Text = "Cập nhật";
                    btnCapNhat.FlatAppearance.BorderColor = Color.White;
                    btnCapNhat.FlatAppearance.BorderSize = 1;
                    btnLuu.Enabled = false;
                    btnThem.Enabled = true;
                    dgvNhanVien.Enabled = true;
                    txtTenNV.Enabled = false;
                    txtSDT.Enabled = false;
                    txtDiaChi.Enabled = false;
                    cbxChucVu.Enabled = false;
                    txtCMND.Enabled = false;
                    cbxCaLam.Enabled = false;
                    rbtnDangHD.Enabled = false;
                    rbtnHetHD.Enabled = false;
                    rbtnDangHD.Enabled = false;
                    rbtnHetHD.Enabled = false;
                    dgvNhanVien.CurrentRow.Selected = false;
                    dgvNhanVien.CurrentRow.Selected = true;
                    txtTimKiemNV.Enabled = true;
                }
            }
            catch
            {
                MsgBox.Show("Lỗi.Vui lòng chọn lại nhân viên", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Error);
            }
            
        }
        #region
        private void button3_Click(object sender, EventArgs e)// hien thi qly khách hàng
        {
            
        }

        private void txtMaNV_Enter(object sender, EventArgs e)
        {
         
        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenNV_Enter(object sender, EventArgs e)
        {
           
        }
        #endregion
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            //btnDangkyTK.Visible = false;
            btnThem.Visible = true;
            txtTimKiemNV.Enabled = true;
            btnCapNhat.Visible = true;
            btnLuu.Visible = true;
            btnQuayLai.Visible = false;
            txtMaNV.Text = "";
            cbxChucVu.Text = "";
            txtCMND.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtTenNV.Text = "";
            cbxCaLam.Text = "";
            rbtnDangHD.Visible = true;
            rbtnHetHD.Visible = true;
            rbtnDangHD.Checked = false;
            rbtnHetHD.Checked = false;
            lblTinhTrang.Visible = true;
            dgvNhanVien.Enabled = true;
            frmQuanLyNhanVien_Load(sender, e);

        }
        #region
        private void btnBHTG_Click(object sender, EventArgs e)
        {
         
        }

        private void txtTimKiemNV_KeyUp(object sender, KeyEventArgs e)
        {
            l = nvbll.TimKiem(txtTimKiemNV.Text);
            LoadDataDgv(dgvNhanVien, l);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBanXe_Click(object sender, EventArgs e)
        {
           
        }

        private void lblID_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
        
        }

        private void btnID_Click(object sender, EventArgs e)
        {

        }
        #endregion
        private void dgvNhanVien_SelectionChanged_1(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            txtSDT.Enabled = false;
            txtDiaChi.Enabled = false;
            cbxChucVu.Enabled = false;
            txtCMND.Enabled = false;
            cbxCaLam.Enabled = false;
            rbtnDangHD.Enabled = false;
            rbtnHetHD.Enabled = false;
            btnDangkyTK.Visible = false;
            btnQuayLai.Visible = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnCapNhat.Enabled = true;
            int index = this.dgvNhanVien.CurrentRow.Index;
            txtMaNV.Text = dgvNhanVien.Rows[index].Cells[0].Value.ToString();
            txtTenNV.Text = dgvNhanVien.Rows[index].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.Rows[index].Cells[2].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[index].Cells[3].Value.ToString();
            txtCMND.Text = dgvNhanVien.Rows[index].Cells[4].Value.ToString();
            cbxCaLam.Text = dgvNhanVien.Rows[index].Cells[5].Value.ToString().Trim();
            cbxChucVu.Text = dgvNhanVien.Rows[index].Cells[6].Value.ToString();
            if (bool.Parse(dgvNhanVien.Rows[index].Cells[7].Value.ToString()) == true)
            {
                rbtnDangHD.Checked = true;
            }

            else
                rbtnHetHD.Checked = true;
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = this.dgvNhanVien.CurrentCell.RowIndex;
            this.dgvNhanVien.Rows[a].Selected = true;
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
        private void txtTenNV_KeyUp(object sender, KeyEventArgs e)
        {
            if(KtraNhapTen(txtTenNV) == true)
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

        private void txtCMND_KeyUp(object sender, KeyEventArgs e)
        {
            if (KtraNhapSo(txtCMND) == true)
            {
                lblLoiCMND.Text = "Chỉ nhập số";
                lblLoiCMND.ForeColor = Color.Red;
            }
            else
            {
                lblLoiCMND.Text = "";
            }
        }
        #region
        private void dgvNhanVien_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = this.dgvNhanVien.CurrentCell.RowIndex;
            this.dgvNhanVien.Rows[a].Selected = true;
        }

        private void dgvNhanVien_DoubleClick(object sender, EventArgs e)
        {

        }

        private void frmQuanLyNhanVien_MouseClick(object sender, MouseEventArgs e)
        {
            //if(btnCapNhat.Text=="Hủy" || btnThem.Visible == false)
            //{
            //    MessageBox.Show("Vui lòng hoàn thành chức năng");
            //}
        }

        private void dgvNhanVien_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnThem.Visible == false || btnCapNhat.Text == "Hủy")
            {
                MessageBox.Show("......");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
          
        }
        #endregion
    }

}
