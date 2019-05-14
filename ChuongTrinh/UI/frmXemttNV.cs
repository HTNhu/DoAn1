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
{
    public partial class frmXemttNV : Form
    {
        eNhanVien l;
        NhanVienBLL nvbll;
        TaiKhoanBLL tkbll;
        frmTrangChu frmtc = null;
        string manv1 = " ";
        
       
        public frmXemttNV(frmTrangChu frm, string manv)
        {
            InitializeComponent();
            l = new eNhanVien();
            nvbll = new NhanVienBLL();
            tkbll = new TaiKhoanBLL();
            manv1 = manv;
        }
        
        private void frmXemttNV_Load(object sender, EventArgs e)
        {
            l = nvbll.TimMotNhanVienTheoMa(manv1);

            txtMaNV.Text = l.MaNhanVien;
            txtTenNV.Text = l.TenNV;
            txtDiaChi.Text = l.DiaChi;
            txtCMND.Text = l.CMND;
            txtSDT.Text = l.SoDT;
            txtChucVu.Text = l.ChucVu;
            txtCaLam.Text = l.CaLam;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region
        private void btnThoat_MouseHover(object sender, EventArgs e)
        {
            
        }
        #endregion
        private void btnThoat_MouseLeave(object sender, EventArgs e)
        {
            btnThoat.BackColor = Color.Transparent;
        }
    }
}
