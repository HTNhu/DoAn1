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
    public partial class frmQuanLyXe : Form
    {
       /*
       Thành Kỷ
       Form cho phép nhân viên quản lý thêm, cập nhật, tìm kiếm xe
       Cập nhật lần cuối 26/10/2018
       */
        NhanVienBLL nvbll;
        private string tennv, manv;
        List<eXe> l;
        XeBLL xe;

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

        public frmQuanLyXe(Panel p , frmTrangChu frm)
        {
            InitializeComponent();
            l = new List<eXe>();
            xe = new XeBLL();
            nvbll = new NhanVienBLL();
            
        }
        public void LoadDataDgv(DataGridView gdv, List<eXe> l)
        {
            gdv.DataSource = l;

        }


        private void frmQuanLyXe_Load(object sender, EventArgs e) // Ham Load du lieu len datagridview
        {
            txtTenXe.MaxLength = 30;
            txtSoKhung.MaxLength = 10;
            txtSoSuon.MaxLength = 10;
            btnLuu.Enabled = false;
            this.cbxMauXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            l = xe.LayDulieu();
            LoadDataDgv(dgvQLXe, l);
            txtMaXe.Enabled = false;
            cbxLoaiXe.Enabled = false;
            cbxMauXe.Enabled = false;
            cbxNuocSX.Enabled = false;
            txtGiaXe.Enabled = false;
            txtSoKhung.Enabled = false;
            cbxSoPK.Enabled = false;
            txtSoSuon.Enabled = false;
            txtTenXe.Enabled = false;
            int s = dgvQLXe.CurrentCell.RowIndex;
            this.dgvQLXe.Rows[s].Selected = true;

            // Show mã & phân loại chức năng theo nv

        }
        public string PhatSinhMa()
        {
            int so = xe.LayDulieu().Count;
            int stt = 0;
            if (so == 0)
            {
                stt = 1;
            }
            else
            {
                stt = so + 1;
            }
            string ma;
            if (stt < 10)
                ma = "XE00" + stt.ToString();
            else if (stt < 100)
                ma = "XE0" + stt.ToString();
            else
                ma = "XE" + stt.ToString();
            return ma;
        }
        public bool KtraLuu()
        {
            if (cbxLoaiXe.Text == "" || cbxMauXe.Text == "" || txtTenXe.Text == ""|| cbxNuocSX.Text == "" || txtGiaXe.Text == "" 
                || txtSoKhung.Text == "" || cbxSoPK.Text == "" || txtSoSuon.Text == "")
            {
                  MsgBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                return false;

            }
            else if(lblLoiGia.Text != "")
            {
                 MsgBox.Show("Giá không hợp lệ", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e) // Ham Them Xe
        {
           
            if (btnThem.Text.Trim() == "Thêm")
            {
                btnThem.Text = "Hủy";
                btnThem.FlatAppearance.BorderColor = Color.Red;
                btnThem.FlatAppearance.BorderSize = 2;
                txtMaXe.Enabled = false;
                txtMaXe.Text = PhatSinhMa();
                cbxLoaiXe.Text = "";
                cbxMauXe.Text = "";
                cbxNuocSX.Text = "";
                txtSoKhung.Text = "";
                cbxLoaiXe.Text = "";
                txtGiaXe.Text = "";
                cbxSoPK.Text = "";
                txtSoSuon.Text = "";
                txtTenXe.Text = "";
                txtTenXe.Enabled = true;
                txtMaXe.Visible = true;
                cbxLoaiXe.Enabled = true;
                cbxMauXe.Enabled = true;
                cbxNuocSX.Enabled = true;
                txtGiaXe.Enabled = true;
                txtSoKhung.Enabled = true;
                cbxSoPK.Enabled = true;
                txtSoSuon.Enabled = true;

                btnCapNhat.Enabled = false;
                btnLuu.Enabled = true;
                dgvQLXe.Enabled = false;
                txtTimKiem.Enabled = false;
            }
            else
            {
                btnThem.Text = "Thêm";
                btnThem.FlatAppearance.BorderColor = Color.White;
                btnThem.FlatAppearance.BorderSize = 1;
                txtMaXe.Enabled = false;
                txtMaXe.Text = "";
                cbxLoaiXe.Text = "";
                cbxMauXe.Text = "";
                cbxNuocSX.Text = "";
                txtSoKhung.Text = "";
                cbxLoaiXe.Text = "";
                txtGiaXe.Text = "";
                cbxSoPK.Text = "";
                txtSoSuon.Text = "";
                txtTenXe.Text = "";
                txtTenXe.Enabled = false;
                cbxLoaiXe.Enabled = false;
                cbxMauXe.Enabled = false;
                cbxNuocSX.Enabled = false;
                txtGiaXe.Enabled = false;
                txtSoKhung.Enabled = false;
                cbxSoPK.Enabled = false;
                txtSoSuon.Enabled = false;

                btnCapNhat.Enabled = true;
                btnLuu.Enabled = false;
                txtTimKiem.Enabled = true;
                dgvQLXe.CurrentRow.Selected = false;
                dgvQLXe.CurrentRow.Selected = true;
                dgvQLXe.Enabled = true;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnCapNhat.Text.Trim() == "Cập nhật")
                {
                    if (bool.Parse(dgvQLXe.SelectedRows[0].Cells["TinhTrang"].Value.ToString().Trim()) == true)
                    {
                        btnCapNhat.Text = "Hủy";
                        btnCapNhat.FlatAppearance.BorderColor = Color.Red;
                        btnCapNhat.FlatAppearance.BorderSize = 2;
                        txtTenXe.Enabled = true;
                        cbxLoaiXe.Enabled = true;
                        cbxMauXe.Enabled = true;
                        cbxNuocSX.Enabled = true;
                        txtGiaXe.Enabled = true;
                        txtSoKhung.Enabled = true;
                        cbxSoPK.Enabled = true;
                        txtSoSuon.Enabled = true;

                        btnThem.Enabled = false;
                        btnLuu.Enabled = true;
                        dgvQLXe.Enabled = false;
                        txtTimKiem.Enabled = false;
                    }
                    else
                    {
                        MsgBox.Show("Xe đã bán không được cập nhật", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                    }

                }
                else
                {
                    btnCapNhat.Text = "Cập nhật";
                    btnCapNhat.FlatAppearance.BorderColor = Color.White;
                    btnCapNhat.FlatAppearance.BorderSize = 1;
                    txtTenXe.Enabled = false;

                    cbxLoaiXe.Enabled = false;
                    cbxMauXe.Enabled = false;
                    cbxNuocSX.Enabled = false;
                    txtGiaXe.Enabled = false;
                    txtSoKhung.Enabled = false;
                    cbxSoPK.Enabled = false;
                    txtSoSuon.Enabled = false;
                    btnThem.Enabled = true;
                    btnLuu.Enabled = false;
                    dgvQLXe.CurrentRow.Selected = false;
                    dgvQLXe.CurrentRow.Selected = true;
                    dgvQLXe.Enabled = true;
                    txtTimKiem.Enabled = true;
                }
            }
            catch
            {
                MsgBox.Show(" Lỗi.Vui lòng chọn lại xe", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Error);
            }
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (KtraLuu() == true)
                {
                    if (btnThem.Text == "Hủy")// luuw khi thêm
                    {
                        eXe xemoi = new eXe();
                        xemoi.MaXe = txtMaXe.Text;
                        xemoi.LoaiXe = cbxLoaiXe.Text;
                        xemoi.MauXe = cbxMauXe.Text;
                        xemoi.TenXe = txtTenXe.Text;
                        xemoi.NuocSX = cbxNuocSX.Text;
                        xemoi.GiaXe = double.Parse(txtGiaXe.Text.ToString());
                        xemoi.SoKhung = txtSoKhung.Text;
                        xemoi.SoPK = cbxSoPK.Text;
                        xemoi.SoSuon = txtSoSuon.Text;
                        int kt = xe.ThemXe(xemoi);
                        if (kt == 1)
                        {
                            MsgBox.Show("Thêm thành công", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                            txtTimKiem.Enabled = true;
                            l = xe.LayDulieu();
                            LoadDataDgv(dgvQLXe, l);
                            btnThem.Text = "Thêm";
                            btnLuu.Enabled = false;
                            dgvQLXe.CurrentRow.Selected = false;
                            dgvQLXe.CurrentRow.Selected = true;
                            dgvQLXe.Enabled = true;
                            btnThem.ForeColor = Color.Black;
                        }
                        else
                            MsgBox.Show("Thêm không thành công", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                        btnThem.Enabled = true;
                    }
                    else if (btnCapNhat.Text == "Hủy")//trương hợp lưu sau khi cập nhật
                    {
                        xe.CapNhatXe(txtMaXe.Text, txtTenXe.Text, cbxLoaiXe.Text, cbxMauXe.Text, cbxNuocSX.Text, double.Parse(txtGiaXe.Text), txtSoKhung.Text, cbxSoPK.Text, txtSoSuon.Text);
                        MsgBox.Show("Cập nhật thành công", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                        txtTimKiem.Enabled = true;
                        l = xe.LayDulieu();
                        LoadDataDgv(dgvQLXe, l);
                        btnCapNhat.Text = "Cập nhật";
                        btnCapNhat.ForeColor = Color.Black;
                        btnLuu.Enabled = false;
                        btnThem.Enabled = true;
                        dgvQLXe.CurrentRow.Selected = false;
                        dgvQLXe.CurrentRow.Selected = true;
                        dgvQLXe.Enabled = true;
                    }
                    btnCapNhat.Enabled = true;
                    dgvQLXe.Enabled = true;
                    txtTenXe.Enabled = false;
                    cbxLoaiXe.Enabled = false;
                    cbxMauXe.Enabled = false;
                    cbxNuocSX.Enabled = false;
                    txtGiaXe.Enabled = false;
                    txtSoKhung.Enabled = false;
                    cbxSoPK.Enabled = false;
                    txtSoSuon.Enabled = false;
                    btnCapNhat.Enabled = true;
                    btnLuu.Enabled = false;
                }
            }
            catch
            {
                MsgBox.Show("Lưu không thành công", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Info);
            }
            
        }
        #region
        #endregion
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            l = xe.TimKiemXeTheoMa(txtTimKiem.Text);
            LoadDataDgv(dgvQLXe, l);
        }
        #region
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBanXe_Click(object sender, EventArgs e)
        {
           
        }

        private void btnQLXe_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBHTG_Click(object sender, EventArgs e)
        {
           
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
           
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
          
        }
        #endregion
        private void dgvQLXe_SelectionChanged(object sender, EventArgs e)
        {
            int index = this.dgvQLXe.CurrentRow.Index;

            txtMaXe.Text = dgvQLXe.Rows[index].Cells[0].Value.ToString();
            txtTenXe.Text = dgvQLXe.Rows[index].Cells[1].Value.ToString();
            cbxLoaiXe.Text = dgvQLXe.Rows[index].Cells[2].Value.ToString();
            cbxMauXe.Text = dgvQLXe.Rows[index].Cells[3].Value.ToString();
            cbxNuocSX.Text = dgvQLXe.Rows[index].Cells[4].Value.ToString();
            txtGiaXe.Text = txtGiaXe.Text = string.Format("{0:#,##0}", double.Parse(dgvQLXe.Rows[index].Cells[5].Value.ToString()));
            txtSoKhung.Text = dgvQLXe.Rows[index].Cells[6].Value.ToString();
            cbxSoPK.Text = dgvQLXe.Rows[index].Cells[7].Value.ToString();
            txtSoSuon.Text = dgvQLXe.Rows[index].Cells[8].Value.ToString();
        }

        private void dgvQLXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = this.dgvQLXe.CurrentCell.RowIndex;
            this.dgvQLXe.Rows[a].Selected = true;
        }
        #region
        private void txtGiaXe_Leave(object sender, EventArgs e)
        {
            
            //if(double.Parse(txtGiaXe.Text) <= 0 )
            //{
            //    lblLoiGia.Text = "Giá trị không hợp lệ";
            //    lblLoiGia.ForeColor = Color.Red;
            //}
            //else
            //{
            //    lblLoiGia.Text = "";
            //}
        }
        #endregion
        public bool KtraGia(TextBox a)
        {
            if (Regex.IsMatch(a.Text, "(^0|[a-z]|[!@#$&*-])"))
            {
                a.Text = a.Text.Remove(a.Text.Length - 1);
                a.SelectionStart = a.Text.Length;
                return true;
            }
            return false;
        }

        private void dgvQLXe_Click(object sender, EventArgs e)
        {
            if (dgvQLXe.Enabled == false)
            {
                MessageBox.Show("Vui lòng chọn <<Hủy>> để kết thúc chức năng ");
            }
        }

        private void dgvQLXe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = this.dgvQLXe.CurrentCell.RowIndex;
            this.dgvQLXe.Rows[a].Selected = true;
        }

        private void dgvQLXe_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void dgvQLXe_DoubleClick(object sender, EventArgs e)
        {

        }

        private void txtGiaXe_KeyUp(object sender, KeyEventArgs e)
        {
            if (KtraGia(txtGiaXe) == true)
            {
                lblLoiGia.Text = "Chỉ nhập số";
                lblLoiGia.ForeColor = Color.Red;
            }
            else
            {
                lblLoiGia.Text = "";
                if (txtGiaXe.Text != "")
                {
                    txtGiaXe.Text = string.Format("{0:#,##0}", double.Parse(txtGiaXe.Text));
                    txtGiaXe.SelectionStart = txtGiaXe.Text.Length;
                }

            }
        }
        #region
        #endregion
    }
}
