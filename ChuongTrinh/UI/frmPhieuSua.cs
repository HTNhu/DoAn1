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
    /*Thành Kỷ 
     Tạo phiếu sửa cho hợp đồng còn hạn bảo hành
     Cập nhật lần cuối 23/10
         */
    public partial class frmPhieuSua : Form
    {
        public List<ePhieuSuaBaoHanh> lps;
        List<eCTPhieuSua> lctps;
        List<eLinhKien> llk;
        LinhKienBLL lkbll;
        HopDongBLL hdbll;
        PhieuSuaBHBLL psbll;
        frmTrangChu frmtc;
        frmTimHopDong frmtg;
        CTPhieuSuaBLL ctpsbll;

        public frmPhieuSua()
        {
            InitializeComponent();
            lps = new List<ePhieuSuaBaoHanh>();
            psbll = new PhieuSuaBHBLL();
            lkbll = new LinhKienBLL();
           

        }
        public frmPhieuSua(frmTrangChu frmt, frmTimHopDong frm,string mahdong, string manv, string tennv)
        {
            InitializeComponent();
            frmtg = frm;
            frmtc = frmt;
            txtMaHDong.Text = mahdong;
            txtMaNV.Text = manv;
            txtTenNV.Text = tennv;
            llk = new List<eLinhKien>();
            hdbll = new HopDongBLL();
            psbll = new PhieuSuaBHBLL();
            lps = new List<ePhieuSuaBaoHanh>();
            lkbll = new LinhKienBLL();
            ctpsbll = new CTPhieuSuaBLL();
            lctps = new List<eCTPhieuSua>();
            eLinhKienBindingSource.DataSource = lkbll.LayDulieu().ToList();
        }
        public void LoadDataDgv(DataGridView gdv, List<eLinhKien> l)
        {
            gdv.DataSource = l;

        }
        #region
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        #endregion
        public string TuPhatSinhMaPS()
        {
            lps = psbll.LayDuLieu();
            int so = lps.Count();
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
                ma = "PS-00" + stt.ToString();
            else if (stt < 100)
                ma = "PS-0" + stt.ToString();
            else
                ma = "PS" + stt.ToString();
            return ma;
        }
        public string TuPhatSinhMaCTPS()
        {
            lctps = ctpsbll.LayDulieu();
            int so = lctps.Count();
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
                ma = "CTPS-00" + stt.ToString();
            else if (stt < 100)
                ma = "CTPS-0" + stt.ToString();
            else
                ma = "CTPS" + stt.ToString();
            return ma;
        }
        private void frmPhieuSua_Load(object sender, EventArgs e)
        {
            rbtnSP.Checked = true;
            cbxTenLK.Text = "";
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.CustomFormat = "MM, dd, yyyy ";
            txtMPS.Enabled = false;
            txtMaHDong.Enabled = false;
            txtMaNV.Enabled = false;
            txtGiaTien.Enabled = false;
            txtTenNV.Enabled = false;
            dtpNgayLap.Enabled = false;
            txtMaNV.Text = frmtc.lblID.Text.Substring(4);
            txtTenNV.Text = frmtc.lblTen.Text.Substring(8);
            txtMPS.Text = TuPhatSinhMaPS();
            dgvLinhKien.Rows.Clear();
            dgvLinhKien.AllowUserToAddRows = false;
            btnLuu.Enabled = false;
        }
        #region
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
        private void cbxTenLK_SelectedIndexChanged(object sender, EventArgs e)
        {
            eLinhKien x = lkbll.LayLKTheoTen(cbxTenLK.Text.Trim());
            if(x != null)
            {
                txtMaLK.Text = x.Malk;
                txtLoaiLK.Text = x.Loailk;
                txtGiaTien.Text = string.Format("{0:#,##0}", double.Parse(x.Giatien.ToString()));
            }
           
        }

        private void cbxTenLK_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
        public bool KtraLKTonTai(eLinhKien lk)
        {
            if (dgvLinhKien.RowCount >= 1)
            {
                for (int i = 0; i <= dgvLinhKien.Rows.Count - 1; i++)
                {
                    if (dgvLinhKien.Rows[i].Cells["MaLK"].Value.ToString().Trim() == lk.Malk.Trim())
                    {
                        return true;
                        break;
                    }
                }
            }
            return false;
        }
        public double TinhTongTien() // tính tổng tiền hóa đơn
        {
            double t = 0;
            if (this.dgvLinhKien.RowCount < 1)
            {
                return 0;
            }
            else
            {
                for(int i =0; i<= dgvLinhKien.Rows.Count - 1; i++)
                {
                    t = t +  double.Parse(dgvLinhKien.Rows[i].Cells["ThanhTien"].Value.ToString());
                }
                return t;
            }
            
        }
        private void btnChonLinhKien_Click(object sender, EventArgs e)
        {
            eLinhKien lk = lkbll.LayLKTheoTen(cbxTenLK.Text.Trim());
            if (cbxTenLK.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập linh kiện ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxTenLK.Focus();
            }
            else
            {
                btnLuu.Enabled = true;
               
                if (dgvLinhKien.RowCount < 1 )
                {
                    double giatien = double.Parse(txtGiaTien.Text) * int.Parse(numSL.Value.ToString());
                    dgvLinhKien.Rows.Add(txtMaLK.Text.Trim(), cbxTenLK.Text, string.Format("{0:#,##0}", double.Parse(txtGiaTien.Text)),int.Parse(numSL.Value.ToString()), string.Format("{0:#,##0}", double.Parse(giatien.ToString())));
                    if (rbtnKH.Checked == true)
                    {
                        txtTongTien.Text = string.Format("{0:#,##0}", double.Parse(TinhTongTien().ToString()));
                    }
                   else
                    {
                        txtTongTien.Text = "0";
                    }
                  
                    
                }
                else
                {
                    if (KtraLKTonTai(lk) == false )
                    {
                        double giatien = double.Parse(txtGiaTien.Text) * int.Parse(numSL.Value.ToString());
                        dgvLinhKien.Rows.Add(txtMaLK.Text.Trim(), cbxTenLK.Text, string.Format("{0:#,##0}", double.Parse(txtGiaTien.Text)), int.Parse(numSL.Value.ToString()), string.Format("{0:#,##0}", double.Parse(giatien.ToString())));
                        if (rbtnKH.Checked == true)
                        {
                            txtTongTien.Text = string.Format("{0:#,##0}", double.Parse(TinhTongTien().ToString()));
                        }
                        else
                        {
                            txtTongTien.Text = "0";
                        }

                    }
                      
                    else
                        MessageBox.Show("Vui lòng chọn linh kiện khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.dgvLinhKien.CurrentCell.Selected = false;
            }
        }

        private void dgvLinhKien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = this.dgvLinhKien.CurrentCell.RowIndex;
            this.dgvLinhKien.CurrentRow.Selected = true;
            //if (this.dgvLinhKien.Rows[index].Cells["MaHopDong"].Value.ToString().Trim() != "Chưa tạo hợp đồng")
            //{
            //    btnLapHopDong.Text = "Xem hợp đồng";
            //}
            //else
            //{
            //    btnLapHopDong.Text = "Lập hợp đồng";
            //}
        }
        
        private void frmPhieuSua_Shown(object sender, EventArgs e)
        {
            this.dgvLinhKien.CurrentCell.Selected = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(dgvLinhKien.RowCount >= 1)
            {
                if(txtLDBH.Text != "")
                {
                    ePhieuSuaBaoHanh ps = new ePhieuSuaBaoHanh();
                    ps.MaPS = txtMPS.Text.Trim();
                    ps.MaHDong = txtMaHDong.Text.Trim();
                    ps.MaNV = txtMaNV.Text.Trim();
                    ps.TenNV = txtTenNV.Text.Trim();
                    ps.NgayLap = DateTime.Parse(dtpNgayLap.Value.ToString());
                    if (txtTongTien.Text == "")
                    {
                        ps.TongTien = 0;
                    }
                    else
                        ps.TongTien = double.Parse(txtTongTien.Text);
                    if (rbtnKH.Checked)
                    {
                        ps.LoiDoKhachHaySP = false; // loii do khách hàng
                    }
                    else
                        ps.LoiDoKhachHaySP = true; // lỗi do sp
                    int a = psbll.ThemPhieuBH(ps);
                    if (a == 1)
                    {
                        MessageBox.Show("Thêm hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        for (int i = 0; i <= dgvLinhKien.Rows.Count - 2; i++)
                        {
                            eCTPhieuSua ct = new eCTPhieuSua();
                            ct.MaCTPS = TuPhatSinhMaCTPS();
                            ct.MaPS = txtMPS.Text.Trim();
                            ct.MaLK = dgvLinhKien.Rows[i].Cells["MaLK"].Value.ToString().Trim();
                            ct.TenLK = dgvLinhKien.Rows[i].Cells["TenLK"].Value.ToString().Trim();
                            ct.GiaTien = double.Parse(dgvLinhKien.Rows[i].Cells["DonGia"].Value.ToString());
                            ct.SoLuong = int.Parse(dgvLinhKien.Rows[i].Cells["SoLuong"].Value.ToString());
                            ct.ThanhTien = double.Parse(dgvLinhKien.Rows[i].Cells["ThanhTien"].Value.ToString());
                            ctpsbll.ThemCTPS(ct);
                        }
                        this.Visible = false;
                        frmTimHopDong frm = new frmTimHopDong(frmtc.PanelParent, frmtc);
                        frm.FormBorderStyle = FormBorderStyle.None;
                        frm.TopLevel = false;
                        frm.Dock = DockStyle.Fill;
                        frm.Show();
                        frmtc.PanelParent.Controls.Add(frm);
                    }    
                }
                else
                {
                    MessageBox.Show("Thêm lí do bảo hành xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLDBH.Focus();
                }
             
            }
           
        }

        private void dgvLinhKien_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void dgvLinhKien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvLinhKien.CurrentCell.RowIndex;
            if(txtTongTien.Text != "" )
            {
                double t = double.Parse(txtTongTien.Text) - double.Parse(dgvLinhKien.Rows[index].Cells["ThanhTien"].Value.ToString());
                txtTongTien.Text = string.Format("{0:#,##0}", double.Parse(t.ToString()));
                dgvLinhKien.Rows.RemoveAt(index);
                if (dgvLinhKien.RowCount < 1)
                    btnLuu.Enabled = false;
            }
           
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmtg.Visible = true ; 
           
        }
        #region
        private void frmPhieuSua_FormClosing(object sender, FormClosingEventArgs e)
        {
            

        }

        private void rbtnKH_Click(object sender, EventArgs e)
        {
            
        }

        private void rbtnSP_Click(object sender, EventArgs e)
        {
            
        }
        #endregion
        private void rbtnKH_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnKH.Checked == true)
                txtTongTien.Text = string.Format("{0:#,##0}", double.Parse(TinhTongTien().ToString()));
        }

        private void rbtnSP_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSP.Checked == true)
                txtTongTien.Text = "0";
        }
    }
   
}
