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
using xDialog;

namespace UI
{
    /*
      Trần Như
      Form cho phép tạo 1 hóa đơn bán xe, có thông tin chi tiết của hóa đơn
      Cập nhật lần cuối 27/10/2018
      */
    public partial class frmHoaDon : Form
    {
        HoaDonBLL hoadonbll;
        HopDongBLL hdongbll;
        KhachHangBLL khbll;
        CTHoaDonBLL cthdbll;
        XeBLL xebll;
        List<eHoaDon> lhoadon;
        List<eKhachHang> lkh;
        List<eXe> lxe;
        NhanVienBLL nvbll;
        frmTrangChu frmtc = null;
        List<string> a;
        public string diachi = "";
        
        public frmHoaDon(Panel p, frmTrangChu frm)
        {
            InitializeComponent();
            hoadonbll = new HoaDonBLL();
            lhoadon = new List<eHoaDon>();
            lkh = new List<eKhachHang>();
            khbll = new KhachHangBLL();
            lxe = new List<eXe>();
            xebll = new XeBLL();
            cthdbll = new CTHoaDonBLL();
            nvbll = new NhanVienBLL();
            hdongbll = new HopDongBLL();
            frmtc = frm;
             a = new List<string>();
            // eXeBindingSource.DataSource = xebll.LayTTXeTheoTen(cbxTenXe.Text.Trim(),true).ToList();
            var soure = new BindingSource();
            lxe = xebll.LayTTXeTheoTen(cbxTenXe.Text.Trim(), true);
            
            for (int i = 0; i < lxe.Count; i++)
            {
               if (KtraTrungTen(lxe[i].TenXe.Trim().ToUpper())== true)
                { //cbxTenXe.Items.Add(lxe[i].TenXe.Trim());
                    a.Add(lxe[i].TenXe.Trim());
                }

            }
            soure.DataSource = a;
            cbxTenXe.DataSource = soure;
            eKhachHangBindingSource.DataSource = khbll.LayDulieu().ToList();
        }
        public string TaoMaHoaDon()
        {
            lhoadon = hoadonbll.LayDuLieu();
            int so = lhoadon.Count();
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
                ma = "HD-BH00" + stt.ToString();
            else if (stt < 100)
                ma = "HD-BH0" + stt.ToString();
            else
                ma = "HD-BH" + stt.ToString();
            return ma;
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dgvCTHD.Enabled = false;
            btnThanhToanTG.Enabled = false;
            cbxMaXe.Height = 20;
            cbxSDT.Height = 20;
            txtMaNV.Text = frmtc.lblID.Text.Substring(4);
            txtTenNV.Text = frmtc.lblTen.Text.Substring(8);
            txtMaHoaDon.Enabled = false;
            txtMaHoaDon.Text = TaoMaHoaDon();
            dgvCTHD.Columns["MaHopDong"].Width = 150;
            dgvCTHD.ForeColor = Color.Black;
            dgvCTHD.Rows.Clear();
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            txtTenKH.Enabled = false;
            cbxMaXe.Enabled = false;
            txtMaKH.Enabled = false;
            //cbxTenXe.Enabled = false;
            txbGiaXe.Enabled = false;
            dtpNgayLap.Enabled = false;
            txbNuocSX.Enabled = false;
            txbSoKhung.Enabled = false;
            txbSoPK.Enabled = false;
            txbSoSuon.Enabled = false;
            txtLoaiXe.Enabled = false;
            cbxMauXe.Enabled = false;
            cbxSDT.Text = "";
            cbxMaXe.Text = "";
            cbxTenXe.Text = "";
            dgvCTHD.AllowUserToAddRows = false;
            txtKhuyenMai.Enabled = false;
        }
        public bool KtraXeTonTai(eXe xe)// ktra xe đã đưa vào cthd hay chưa
        {
            if (dgvCTHD.RowCount >= 1)
            {
                for (int i = 0; i <= dgvCTHD.Rows.Count - 1; i++)
                {
                    if (dgvCTHD.Rows[i].Cells["MaXe"].Value.ToString().Trim() == xe.MaXe.Trim())
                    {
                        return true;
                        break;
                    }
                }
            }
            return false;
        }
        private void btnChonXe_Click(object sender, EventArgs e)
        {
            if ( cbxTenXe.Text =="" || cbxMaXe.Text == "" )// rỗng
            {
                MsgBox.Show("Vui lòng chọn xe ", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                cbxTenXe.Focus();
            }
            else
            {
                dgvCTHD.Enabled = true;
                btnThanhToanTG.Enabled = true;
                eXe x = xebll.LayXeTheoMa(cbxMaXe.Text.Trim());
                if (dgvCTHD.RowCount < 1)
                {
                    dgvCTHD.Rows.Add("Chưa tạo hợp đồng", cbxMaXe.Text.Trim(),cbxTenXe.Text,string.Format("{0:#,##0}", double.Parse(txbGiaXe.Text)));
                }
                else
                {
                    if (KtraXeTonTai(x) == false)

                        dgvCTHD.Rows.Add("Chưa tạo hợp đồng", cbxMaXe.Text.Trim(), cbxTenXe.Text, string.Format("{0:#,##0}", double.Parse(txbGiaXe.Text)));
                    else
                        MsgBox.Show("Vui lòng chọn xe khác", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                }
                this.dgvCTHD.CurrentCell.Selected = false;
               
                cbxMauXe.Enabled = false;
                cbxTenXe.Text = "";
                txbGiaXe.Text = "";
                cbxMauXe.Text = "";
                txbNuocSX.Text = "";
                txbSoKhung.Text = "";
                txbSoPK.Text = "";
                txbSoSuon.Text = "";
                txtLoaiXe.Text = "";
                cbxMaXe.Text = "";
                cbxMaXe.SelectedIndex = -1;
                cbxMauXe.SelectedIndex = -1;
                cbxMaXe.Enabled = false;

            }
        }
        #region
        //public void LoadDataToLstKhachHang(ListBox a , List<eKhachHang> lkh)
        //{
        //    cbxSDT.Items.Clear();

        //    foreach (eKhachHang kh in lkh)
        //    {
        //        a.Items.Add(kh.SoDT); 
        //    }
        //}
        //public void LoadDataToLstXe(ListBox a, List<eXe> lxe)
        //{
        //    cbxMaXe.Items.Clear();

        //    foreach (eXe xe in lxe)
        //    {
        //        a.Items.Add(xe.MaXe);
        //    }
        //}
        #endregion
        #region
        private void txtSDT_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void lstSDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            
          
        }

        private void txtMaXe_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
       
        private void cbxSDT_KeyUp(object sender, KeyEventArgs e)
        {

           
        }

        private void cbxSDT_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void cbxSDT_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtSDT_KeyDown(object sender, KeyEventArgs e)
        {
        }
#endregion
        private void btnLapHopDong_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxSDT.Text != "")
                {
                    if (this.dgvCTHD.SelectedRows.Count != 0)
                    {
                        if (btnLapHopDong.Text.Trim() == "Lập hợp đồng")
                        {
                            string Maxe = dgvCTHD.SelectedRows[0].Cells["MaXe"].Value.ToString().Trim();
                            string TenXe = dgvCTHD.SelectedRows[0].Cells["TenXe"].Value.ToString().Trim();
                            double GiaXe = double.Parse(dgvCTHD.SelectedRows[0].Cells["Gia"].Value.ToString());
                            string makh = txtMaKH.Text.Trim();
                            string tenKh = txtTenKH.Text.Trim();
                            string tennv = frmtc.lblTen.Text.Substring(8);
                            this.Visible = false;
                            frmHopDong hd = new frmHopDong(this, Maxe, TenXe, GiaXe, makh, tenKh, diachi, tennv);
                            hd.btnLuuHD.Visible = true;
                            hd.numSoLanTT.Enabled = true;
                            hd.Show();
                        }
                        else
                        {
                            eHopDong hdong = hdongbll.LayHopDongTheoMaHDong(this.dgvCTHD.SelectedRows[0].Cells["MaHopDong"].Value.ToString().Trim());
                            frmHopDong hd = new frmHopDong(this, "", hdong.TenXe, hdong.Gia, hdong.MaKH, hdong.TenKH, hdong.DiaChi, hdong.TenNV);
                            hd.btnLuuHD.Visible = false;
                            hd.numSoLanTT.Enabled = false;
                            hd.Show();
                        }
                    }
                    else
                    {
                        MsgBox.Show("Chọn xe cần lập hợp đòng", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                    }
                }
                else
                {
                    MsgBox.Show("Chưa có thông tin khách hàng", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                    cbxSDT.Focus();
                }
            }
            catch
            {
                MsgBox.Show("Lỗi. Vui lòng chọn lại", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Error);
            }
            
        }
        private void dgvCTHD_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        public bool KtraLapHopDong()
        {
            if(dgvCTHD.RowCount >= 1)
            {
                for (int i = 0; i <= dgvCTHD.RowCount - 1; i++)
                {
                    if (this.dgvCTHD.Rows[i].Cells["MaHopDong"].Value.ToString().Trim() == "Chưa tạo hợp đồng")
                        return false;
                }
            }
            
            return true;
        }
        public void CapNhatTTSauThanhToan()
        {
            for(int i = 0; i <= dgvCTHD.RowCount - 1; i++)
            {
                string ma = dgvCTHD.Rows[i].Cells["MaHopDong"].Value.ToString().Trim();
               eHopDong hdong =  hdongbll.LayHopDongTheoMaHDong(ma);
                if (hdong.HinhThucTT ==1 )
                {
                    hdongbll.CapNhatTTHDong(ma, "Đã hoàn thành");
                }
                else
                {
                    hdongbll.CapNhatTTHDong(ma, "Đã thanh toán lần 1");
                }
            }
        }
        private void btnThanhToanTG_Click(object sender, EventArgs e)
        { 
                if (KtraLapHopDong() == true)
                {
                    eHoaDon hd = new eHoaDon();
                    hd.SoDT = cbxSDT.Text;
                    hd.MaHoaDon = txtMaHoaDon.Text.Trim();
                    hd.MaKH = txtMaKH.Text.Trim();
                    hd.MaNV = txtMaNV.Text.Trim();
                    hd.NgayLap = dtpNgayLap.Value;
                    hd.SoDT = cbxMaXe.Text;
                    hd.TenKH = txtTenKH.Text;
                    hd.TenNV = txtTenNV.Text;
                    hd.TongTien = double.Parse(lblTongTien.Text);
                    hd.TienThanhToan = double.Parse(lblTongTien.Text);
                    if (txtKhuyenMai.Text == "")
                        txtKhuyenMai.Text = "0";
                    hd.KhuyenMai = float.Parse(txtKhuyenMai.Text);
                    int s = hoadonbll.ThemHoaDon(hd);
                    if (s == 1)
                    {
                        MsgBox.Show("Thêm hóa Đơn Thành công", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                        hoadonbll.LayDuLieu();
                        CapNhatTTSauThanhToan();
                        for (int i = 0; i <= dgvCTHD.Rows.Count - 1; i++)
                        {
                            eCTHoaDon cthd = new eCTHoaDon();
                            cthd.MaHoaDon = txtMaHoaDon.Text.Trim();
                            cthd.MaHopDong = dgvCTHD.Rows[i].Cells["MaHopDong"].Value.ToString().Trim();
                            cthd.MaXe = dgvCTHD.Rows[i].Cells["MaXe"].Value.ToString().Trim();
                            cthd.TenXe = dgvCTHD.Rows[i].Cells["TenXe"].Value.ToString();
                            cthd.Gia = double.Parse(dgvCTHD.Rows[i].Cells["Gia"].Value.ToString());
                            cthd.TienTT = double.Parse(dgvCTHD.Rows[i].Cells["TienTT"].Value.ToString());

                            int a = cthdbll.ThemCTHD(cthd);

                            if (a == 1)
                            {
                                xebll.CapNhatTTXe(cthd.MaXe.Trim(), false);

                            }

                            else
                            {
                                hdongbll.CapNhatTTHDong(cthd.MaHopDong = dgvCTHD.Rows[i].Cells["MaHopDong"].Value.ToString(), "Đã hủy");
                            }

                        }
                        this.Visible = false;
                        frmHoaDon frm = new frmHoaDon(frmtc.PanelParent, frmtc);
                        frm.FormBorderStyle = FormBorderStyle.None;
                        frm.TopLevel = false;
                        frm.Dock = DockStyle.Fill;

                        frmtc.PanelParent.Controls.Add(frm);
                        frm.Show();
                    }

                }
                else
                    MsgBox.Show("Chưa tạo hợp đồng", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Error);
           
           
        }
        #region
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtMaHoaDon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lstMaXe_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txbSoKhung_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMaXe_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txbNuocSX_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void txtMauXe_TextChanged(object sender, EventArgs e)
        {

        }
#endregion
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvCTHD.SelectedRows.Count != 0)
                {
                    string a = this.dgvCTHD.SelectedRows[0].Cells["MaHopDong"].Value.ToString().Trim();

                    if (a == "Chưa tạo hợp đồng")
                    {
                        dgvCTHD.Rows.RemoveAt(this.dgvCTHD.SelectedRows[0].Index);
                        if (dgvCTHD.RowCount < 1)
                        {
                            btnThanhToanTG.Enabled = false;
                            dgvCTHD.Enabled = false;
                        }
                    }
                    else
                    {
                        double tientt = double.Parse(this.dgvCTHD.SelectedRows[0].Cells["TienTT"].Value.ToString());
                        double gia = double.Parse(this.dgvCTHD.SelectedRows[0].Cells["Gia"].Value.ToString());
                        eHopDong hd = hdongbll.LayHopDongTheoMaHDong(a);
                        bool t = hdongbll.CapNhatTTHDong(hd.MaHopDong, "Đã hủy");
                        if (t == true)
                        {
                            dgvCTHD.Rows.RemoveAt(this.dgvCTHD.SelectedRows[0].Index);
                            if (dgvCTHD.RowCount < 1)
                            {
                                btnThanhToanTG.Enabled = false;
                                dgvCTHD.Enabled = false;
                            }
                            MsgBox.Show("Hơp đồng đã hủy", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                            double lbltientt = double.Parse(lblTienThanhToan.Text) - tientt;
                            lblTienThanhToan.Text = string.Format("{0:#,##0}", double.Parse(lbltientt.ToString()));
                            double lbltt = double.Parse(lblTongTien.Text) - gia;
                            lblTongTien.Text = string.Format("{0:#,##0}", double.Parse(lbltt.ToString()));

                        }
                        //this.dgvCTHD.CurrentCell.Selected = false;
                    }
                }
                else
                {
                    MsgBox.Show("Chọn xe cần xóa", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                }
            }
            catch
            {
                MsgBox.Show("Lỗi. Vui lòng chọn lại xe cần xóa", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Info);
            }
            

        }

        private void txtMaXe_MouseClick(object sender, MouseEventArgs e)
        {
            cbxSDT.Text = "";
        }
        #region
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {

        }

        private void btnBanXe_Click(object sender, EventArgs e)
        {
           
        }

        private void btnQLNV_Click(object sender, EventArgs e)
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

        private void dgvCTHD_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvCTHD_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        #endregion
        private void dgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = this.dgvCTHD.CurrentCell.RowIndex;
            this.dgvCTHD.CurrentRow.Selected = true;
            eXe a = xebll.LayXeTheoMa(dgvCTHD.SelectedRows[index].Cells["MaXe"].Value.ToString().Trim());
            if(a != null)
            {
                cbxTenXe.Text = a.TenXe;
                txbGiaXe.Text = a.GiaXe.ToString();
                txbNuocSX.Text = a.NuocSX;
                txbSoKhung.Text = a.SoKhung;
                txbSoPK.Text = a.SoPK;
                txbSoSuon.Text = a.SoSuon;
                txtLoaiXe.Text = a.LoaiXe;
                cbxMauXe.Enabled = false;
                cbxMaXe.Enabled = false;
                cbxMaXe.Text = a.MaXe.Trim();
                cbxMauXe.Text = a.MauXe.Trim();
            }
            if (this.dgvCTHD.Rows[index].Cells["MaHopDong"].Value.ToString().Trim() != "Chưa tạo hợp đồng")
            {
                btnLapHopDong.Text = "Xem hợp đồng";
            }
            else
            {
                btnLapHopDong.Text = "Lập hợp đồng";
            }
        }
        #region
        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void txtTenXe_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
        private void cbxSDT_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            eKhachHang kh = new eKhachHang();
            kh = khbll.LayKHTheoSDT(cbxSDT.Text);
            if (kh != null)
            {
                
                txtTenKH.Text = kh.TenKH;
                txtMaKH.Text = kh.MaKH;
                dtpNgayLap.Text = DateTime.Now.ToString();
                diachi = kh.DiaChi;
            }
           
        }

        private void cbxMaXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            eXe x = xebll.LayXeTheoMa(cbxMaXe.Text.Trim());
            if(x != null){
                cbxTenXe.Text = x.TenXe;
                cbxMauXe.Text = x.MauXe;
                txbSoKhung.Text = x.SoKhung;
                txbSoPK.Text = x.SoPK;
                txbSoSuon.Text = x.SoKhung;
                txbGiaXe.Text = string.Format("{0:#,##0}", double.Parse(x.GiaXe.ToString()));
                txbNuocSX.Text = x.NuocSX;
                txtLoaiXe.Text = x.LoaiXe;
            }
            
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            string manv = frmtc.lblID.Text.Substring(4);
            string tennv = frmtc.lblTen.Text.Substring(8);
            this.Visible = false;
            frmThemKhachHang frmkh = new frmThemKhachHang(this,tennv, manv);
            frmkh.Show();
           
        }
        #region
        private void label10_Click_1(object sender, EventArgs e)
        {

        }
        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvCTHD_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvCTHD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxTenXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxMauXe.Enabled = true;
            lxe = xebll.LayTTXeTheoTen(cbxTenXe.Text.Trim(),true);
            cbxMauXe.Items.Clear();
            for (int i = 0; i < lxe.Count; i++)
            {
                if (KtraTrungMau(lxe[i].MauXe.Trim().ToUpper()))
                    cbxMauXe.Items.Add(lxe[i].MauXe.Trim());
               
            }
            txbGiaXe.Text = "";
            dtpNgayLap.Text = "";
            txbNuocSX.Text = "";
            txbSoKhung.Text = "";
            txbSoPK.Text = "";
            txbSoSuon.Text = "";
            txtLoaiXe.Text = "";
            cbxMaXe.Text = "";
            cbxMauXe.Text = "";
        }

        private void cbxMauXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxMaXe.Enabled = true;
            lxe = xebll.LayTTXeTheoTenMauXe(cbxTenXe.Text.Trim(), cbxMauXe.Text.Trim(),true);
            cbxMaXe.Items.Clear();
            foreach (eXe xe in lxe)
            {
                cbxMaXe.Items.Add(xe.MaXe);
            }

        }
          
        public bool KtraTrungTen(string ten) //trung trả về false
        {
            for(int i = 0; i < a.Count; i++)
            {
                if (a[i].ToString().Trim().ToUpper() == ten.ToUpper().Trim())
                    return false;
            }
            return true;
        }
        public bool KtraTrungMau(string mau) //trung trả về false
        {
            for (int i = 0; i < cbxMauXe.Items.Count; i++)
            {
                if (cbxMauXe.Items[i].ToString().Trim().ToUpper() == mau.ToUpper())
                    return false;
            }
            return true;
        }
        private void cbxTenXe_KeyUp(object sender, KeyEventArgs e)
        {
            //lxe = xebll.LayTTXeTheoTen(cbxTenXe.Text.Trim(), true);
            //for(int i =0; i < lxe.Count; i++)
            //{
            //    if (KtraTrungTen(lxe[i].TenXe.Trim().ToUpper()))
            //        cbxTenXe.Items.Add(lxe[i].TenXe.Trim());
            //}
            cbxMauXe.Enabled = true;
            lxe = xebll.LayTTXeTheoTen(cbxTenXe.Text.Trim(), true);
            cbxMauXe.Items.Clear();
            for (int i = 0; i < lxe.Count; i++)
            {
                if (KtraTrungMau(lxe[i].MauXe.Trim().ToUpper()))
                    cbxMauXe.Items.Add(lxe[i].MauXe.Trim());
            }
            txbGiaXe.Text = "";
            dtpNgayLap.Text = "";
            txbNuocSX.Text = "";
            txbSoKhung.Text = "";
            txbSoPK.Text = "";
            txbSoSuon.Text = "";
            txtLoaiXe.Text = "";
            cbxMaXe.Text = "";
            cbxMauXe.Text = "";

        }

        private void cbxTenXe_TextUpdate(object sender, EventArgs e)
        {
           
        }

        private void cbxMauXe_KeyUp(object sender, KeyEventArgs e)
        {
            cbxMauXe.Enabled = true;
            lxe = xebll.LayTTXeTheoTen(cbxTenXe.Text.Trim(), true);
            cbxMauXe.Items.Clear();
            for (int i = 0; i < lxe.Count; i++)
            {
                if (KtraTrungMau(lxe[i].MauXe.Trim().ToUpper()))
                    cbxMauXe.Items.Add(lxe[i].MauXe.Trim());

            }
        }

        private void btnChonXe_MouseHover(object sender, EventArgs e)
        {
            this.btnChonXe.Image = Properties.Resources.right_left2;
        }
        private void btnChonXe_MouseLeave(object sender, EventArgs e)
        {
            this.btnChonXe.Image = Properties.Resources.right_left;
        }
    }
}