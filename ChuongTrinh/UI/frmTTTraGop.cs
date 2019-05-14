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
    /*Trần như
     Tạo phiếu trả góp cho hợp đồng, cập nhật hợp đồng  sau khi trả góp
     cập nhật lần cuối 24/10
         */
    public partial class frmTTTraGop : Form
    {
        frmTimHopDong frmtg = null;
        frmTrangChu frmtc = null;
        List<eHopDong> lhdong;
        HopDongBLL hdongbll;
        PhieuTraGopBLL tgbll;
        List<ePhieuTraGop> ltg;
        public int hthuctt = 0;
        DateTime ngaylap;
        public frmTTTraGop()
        {
            
            InitializeComponent();
            hdongbll = new HopDongBLL();
            tgbll = new PhieuTraGopBLL();
            ltg = new List<ePhieuTraGop>();
            lhdong = new List<eHopDong>();
            
        }
        public frmTTTraGop(frmTrangChu frmt, frmTimHopDong frm , int lanTra, double sotien,string manv, string tennv, string mahdong, int hthuc,DateTime nglap)
        {   
            InitializeComponent();
            frmtg = frm;
            frmtc = frmt;
            txtMaHDong.Text = mahdong;
            txtTenNV.Text = tennv;
            txtMaNV.Text = manv;
            txtSoTien.Text = string.Format("{0:#,##0}", double.Parse(sotien.ToString()));
            numLanTra.Value = lanTra;
            hthuctt = hthuc;
            hdongbll = new HopDongBLL();
            tgbll = new PhieuTraGopBLL();
            ltg = new List<ePhieuTraGop>();
            ngaylap = nglap;
        }
        private void frmTTTraGop_Load(object sender, EventArgs e)
        {
            
            txtTenNgTra.MaxLength = 30;
            numLanTra.Enabled = false;
            txtMaHDong.Enabled = false;
            txtMaNV.Enabled = false;
            txtSoTien.Enabled = false;
            txtTenNV.Enabled = false;
            dtpNgayTra.Enabled = false;
            DateTime adatetime = new DateTime(ngaylap.Year, ngaylap.Month, ngaylap.Day);
            if(numLanTra.Value == 2)
            {
                dtpNgayTra.Value = adatetime.AddMonths(3);
            }
            else
            {
                dtpNgayTra.Value = adatetime.AddMonths(6);
            }
            
        }

        private void btnThanhToanTG_Click(object sender, EventArgs e)
        {
                tgbll.LayDuLieu();
                ePhieuTraGop tg = new ePhieuTraGop();
                tg.MaHopDong = txtMaHDong.Text.Trim();
                tg.MaNV = txtMaNV.Text.Trim();
                tg.TenNV = txtTenNV.Text;
                tg.SoTien = double.Parse(txtSoTien.Text);
                tg.LanTra = int.Parse(numLanTra.Value.ToString());
                tg.TenNgTra = txtTenNgTra.Text;
                 tg.NgayTra = dtpNgayTra.Value;
            if (txtTenNgTra.Text == "")  
            {
                MessageBox.Show("Vui lòng nhập tên người trả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                int a= tgbll.ThemPhieuTG(tg);
                if (a == 1)
                {
                    if (hthuctt == numLanTra.Value)
                    {
                        bool kt = hdongbll.CapNhatTTHDong(txtMaHDong.Text.Trim(), "Đã hoàn thành");
                        if (kt == true)
                        {
                            MessageBox.Show("Hợp đồng đã hoàn thành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }


                    }
                    else if (hthuctt > numLanTra.Value)
                    {
                        bool k = hdongbll.CapNhatTTHDong(txtMaHDong.Text.Trim(), "Đã thanh toán lần 2");
                        if (k == true)
                        {
                            MessageBox.Show("Đã hoàn thành thanh toán lần 2", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            

            
                
                frmTimHopDong frm = new frmTimHopDong(frmtc.PanelParent, frmtc);
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.Show();
                frmtc.PanelParent.Controls.Add(frm);
                this.Visible = false;
            }
}
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmtg.Visible = true;
        }
        public bool KtraNhapTen(TextBox a)//ktra nhập tên
        {
            if (Regex.IsMatch(a.Text, "[0-9]"))
            {
                a.Text = a.Text.Remove(a.Text.Length - 1);
                a.SelectionStart = a.Text.Length;
                return true;
            }
            return false;
        }
        private void txtTenNgTra_KeyUp(object sender, KeyEventArgs e)
        {
            if (KtraNhapTen(txtTenNgTra) == true)
            {
                lblLoiTen.Text = "Không nhập số";
                lblLoiTen.ForeColor = Color.Red;
            }
            else
            {
                lblLoiTen.Text = "";
            }
        }
        #region
        private void frmTTTraGop_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}

