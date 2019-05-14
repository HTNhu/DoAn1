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
    /* Trân Như 
        Tạo hợp đồng xe
        cập nhật lần cuối 26/10    
 */
{
    public partial class frmHopDong : Form
    {
        public string Maxe = "";
        public string TenXe = "";
        public double GiaXe = 0;
        public string makh = "";
        public string tenkh = "";
        public string diachi = "";
        
        frmHoaDon frmHoaDon = null;
        List<eHopDong> lhdong;
        HopDongBLL hdongbll ;
        public frmHopDong()
        {
            InitializeComponent();
            lhdong = new List<eHopDong>();
            hdongbll = new HopDongBLL();
        }
        public frmHopDong(frmHoaDon frm, string Maxe,string tenxe,double giaxe,string makh, string tenkh, string diachi,string tennv)
        {
            InitializeComponent();
            txtTenXe.Text = tenxe;
            txtGiaXe.Text = giaxe.ToString();
            txtDiaChi.Text = diachi;
            txtMaKH.Text = makh;
            txtTenKH.Text = tenkh;
            txtTenNV.Text = tennv;
            frmHoaDon = frm;
            lhdong = new List<eHopDong>();
            hdongbll = new HopDongBLL();
        }
        public string TaoMaHopDong()
        {
            lhdong = hdongbll.LayDulieuHopDong();
            int so = lhdong.Count();
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
                ma = "HDX-00" + stt.ToString();
            else if (stt < 100)
                ma = "HDX-0" + stt.ToString();
            else
                ma = "HDX-" + stt.ToString();
            return ma;
        }

        private void frmHopDong_Load(object sender, EventArgs e)
        {
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.CustomFormat = "MM, dd, yyyy ";
            dtpHanBH.Format = DateTimePickerFormat.Custom;
            dtpHanBH.CustomFormat = "MM, dd, yyyy ";
            dtpNgayLap.Value = DateTime.Now;
            txtMaHDong.Enabled = false;
            txtMaHDong.Text = TaoMaHopDong();
            dtpNgayLap.Enabled = false;
            txtMaKH.Enabled = false;
            txtTenNV.Enabled = false;
            txtTenKH.Enabled = false;
            txtTenXe.Enabled = false;
            txtDiaChi.Enabled = false;
            dtpHanBH.Enabled = false;
            txtGiaXe.Enabled = false;
            numSoLanTT.Value = 1;
            int ngay = dtpNgayLap.Value.Day;
            int thang = dtpNgayLap.Value.Month;
            int nam = dtpNgayLap.Value.Year + 1;
            dtpHanBH.Value = new DateTime(nam, thang, ngay);
        }
        public double TinhTienTG(int solan)// tính tiền thnah toán chpo các lần
        {
            double t;
            if (solan != 0)
            {
                t = double.Parse(txtGiaXe.Text) / solan;

            }
            else
                t = 0;
            return t;
        }
        public double TinhTongGia()// tổng giá 
        {
            double s = double.Parse(frmHoaDon.lblTongTien.Text);
            s = s + double.Parse(txtGiaXe.Text);
            return s;
        }
        public double TinhTongTienTT()
        {
            double s = double.Parse(frmHoaDon.lblTienThanhToan.Text);
            s = s + TinhTienTG(int.Parse(numSoLanTT.Value.ToString()));
            return s;
        }
        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            int s = int.Parse(numSoLanTT.Value.ToString());
            double t = TinhTienTG(s);
            frmHoaDon.btnThanhToanTG.Enabled = true;
            frmHoaDon.dgvCTHD.SelectedRows[0].Cells["TienTT"].Value = string.Format("{0:#,##0}", double.Parse(t.ToString()));
            frmHoaDon.dgvCTHD.SelectedRows[0].Cells["MaHopDong"].Value = txtMaHDong.Text;
            frmHoaDon.lblTongTien.Text = string.Format("{0:#,##0}", double.Parse(TinhTongGia().ToString()));
            frmHoaDon.lblTienThanhToan.Text = string.Format("{0:#,##0}", double.Parse(TinhTongTienTT().ToString()));
            eHopDong hd = new eHopDong();
            hd.MaHopDong = txtMaHDong.Text;
            hd.MaKH = txtMaKH.Text;
            hd.NgayLap = DateTime.Parse(dtpNgayLap.Value.ToString());
            hd.HanBH = DateTime.Parse(dtpHanBH.Value.ToString());
            hd.TenKH = txtTenKH.Text;
            hd.TenXe = txtTenXe.Text;
            hd.Gia = double.Parse(txtGiaXe.Text);
            hd.DiaChi = txtDiaChi.Text;
            hd.TenNV = txtTenNV.Text;
            hd.HinhThucTT = int.Parse(numSoLanTT.Value.ToString());
            hd.TinhTrang = "";
            int a = hdongbll.ThemHDong(hd);
            try
            {
                
                if(a == 1)
                {
                    this.Close();
                    frmHoaDon.dgvCTHD.CurrentCell.Selected = false;
                    frmHoaDon.Visible = true;
                }
               
            }
            catch
            {
                MessageBox.Show("Lưu không thành công");
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmHoaDon.dgvCTHD.CurrentCell.Selected = false;
            frmHoaDon.Visible = true;
        }
        #region
        private void numSoLanTT_ValueChanged(object sender, EventArgs e)
        {
            string a = TinhTienTG(int.Parse(numSoLanTT.Value.ToString())).ToString();
            lblSoTienTT.Text = string.Format("{0:#,##0}", double.Parse(a));
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtMaHDong_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
