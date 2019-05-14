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
      Form cho phép thống kê số lượng hợp đồng 
      Cập nhật lần cuối 21/10/2018
      */
    public partial class frmThongKe : Form
    {
        TaiKhoanBLL tkbll;
        NhanVienBLL nvbll;
        HopDongBLL hdongbll;
        List<eHopDong> lhdong;
        private string tennv, manv;
        public frmThongKe(Panel p, frmTrangChu frm)
        {
            lhdong = new List<eHopDong>();
            InitializeComponent();
            nvbll = new NhanVienBLL();
            hdongbll = new HopDongBLL();
            
            eNhanVienBindingSource.DataSource = nvbll.LayDulieu().ToList();

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
       public void LoadDataToDgv(DataGridView a , List<eHopDong> l)
        {
         
            a.DataSource = l;
            
        }
       
        private void frmThongKe_Load(object sender, EventArgs e)
        {
            chartTinhTrang.Visible = false;
            chart1.Visible = false;
            lblTT.Visible = false;
            lblNV.Visible = false;  
           
        }
      
        #region
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

        private void btnQLKH_Click(object sender, EventArgs e)
        {
         
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
           
        }
        #endregion
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
         
        }
        #region
        private void dtpNgayLapHopDong_ValueChanged(object sender, EventArgs e)// chọn ngày lập hợp đồng cần thống kê
        {
            
           
        }
       
        private void cbxTKNV_KeyUp(object sender, KeyEventArgs e)
        {
           

        }
   
        private void txtTKNV_KeyUp(object sender, KeyEventArgs e)// nhập tên nhân viên lập hợp đồng cần thống kê
        {
            
        }

        private void lstTenNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void grbChucNang_Enter(object sender, EventArgs e)
        {

        }
        #endregion
        private void txtTKKH_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
        #region
        private void label1_Click(object sender, EventArgs e)
        {

        }
      
        private void cbxTKTTrang_SelectedIndexChanged(object sender, EventArgs e) 
        {
           
          
        }
        
        private void cbxTenNV_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dtNgayKT_ValueChanged(object sender, EventArgs e)
        {
            if (dtNgayKT.Value < dtNgayBD.Value)
            {
                MsgBox.Show("Ngày không phù hợp", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Info);
            }


        }

        private void btnTKNV_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnTKNV_Click_1(object sender, EventArgs e)// theo nhân viên
        {
            chart1.Visible = true;
            lblNV.Visible = true;
            chartTinhTrang.Visible = false;
            lblTT.Visible = false;
            chart1.DataSource = hdongbll.TK_NVBanXe();
            chart1.DataBind();
        }

        private void btnTT_Click(object sender, EventArgs e)// theo tình trạng
        {
            chart1.Visible = false;
            lblNV.Visible = false;
            chartTinhTrang.Visible = true;
            lblTT.Visible = true;
            chartTinhTrang.DataSource = hdongbll.TK_TTHopDong();
            chartTinhTrang.DataBind();
        
        }

        private void chartTinhTrang_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e) // thống kê từ ngày đễn ngày
        {
            chart1.Visible = true;
            lblNV.Visible = true;
            lblTT.Visible = true;
            chartTinhTrang.Visible = true;
            if (dtNgayKT.Value >= dtNgayBD.Value)
            {
                chart1.DataSource = hdongbll.TK_NVTheoNgay(dtNgayBD.Value, dtNgayKT.Value);
                chart1.DataBind();
                chartTinhTrang.DataSource = hdongbll.TK_TTTheoNgay(dtNgayBD.Value, dtNgayKT.Value);
                chartTinhTrang.DataBind();

            }
            else
            {
                 MsgBox.Show("Ngày không phù hợp", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Info);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
          
            
        }
        #endregion
    }

}
