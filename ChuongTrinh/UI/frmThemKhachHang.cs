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
using UI;
using Entities;
using System.Text.RegularExpressions;
using xDialog;

namespace UI
{
    public partial class frmThemKhachHang : Form
    {
        
        KhachHangBLL khbll;
        frmHoaDon frmhd = null;
        string tennv = "";
        string manv = "";
        public frmThemKhachHang(frmHoaDon frm,string ten,string ma )
        {
            InitializeComponent();
            khbll = new KhachHangBLL();
            frmhd = frm;
            tennv = ten;
            manv = ma;
            
        }
       
        private void btnThem_Click(object sender, EventArgs e)
        {

            eKhachHang khmoi = new eKhachHang();
            khmoi.MaKH = txtMaKH.Text;
            khmoi.TenKH = txtTenKH.Text;
            khmoi.SoDT = txtSDT.Text;
            khmoi.DiaChi = txtDiaChi.Text;
            if(txtTenKH.Text =="" || txtDiaChi.Text == "" || txtSDT.Text=="")
            {
                MessageBox.Show("Không để trống thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
            else
            {
                int kt = khbll.ThemKH(khmoi);
                if (kt == 1)
                {
                    MessageBox.Show("Thêm thành công !","Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Visible = false;
                    frmhd.cbxSDT.DataSource =  khbll.LayDulieu().ToList();
                    frmhd.cbxSDT.Text = txtSDT.Text;
                    frmhd.txtMaKH.Text = txtMaKH.Text;
                    frmhd.txtTenKH.Text = txtTenKH.Text;
                    frmhd.Visible = true;
                    
                }
                else
                    MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           

        }

        private void frmThemKhachHang_Load(object sender, EventArgs e)
        {
            lblTen.Text = "Xin chào" + tennv;
            lblMa.Text = "ID: " + manv;
            txtMaKH.Enabled = false;
            txtMaKH.Text = khbll.PhatSinhMa();
            txtSDT.MaxLength = 10;
            txtTenKH.MaxLength = 30;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmhd.Visible = true;
        }
        public bool KtraNhapTen(TextBox a)
        {
            if (Regex.IsMatch(a.Text, "[0-9]"))
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
            if (khbll.KtraTonTai(txtSDT.Text.Trim()) == true)
            {
                MessageBox.Show("Số điện thoại đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmThemKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void txtTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
