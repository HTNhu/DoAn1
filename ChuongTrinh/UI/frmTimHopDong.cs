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
      Thành Kỷ
      Form cho phép tìm kiếm hợp đồng để thực hiện thanh toán trả góp hoặc bảo hành
      Cập nhật lần cuối 21/10/2018
      */
    public partial class frmTimHopDong : Form
    {

        TaiKhoanBLL tkbll;
        NhanVienBLL nvbll;
        HopDongBLL hdongbll;
        List<eHopDong> lhdong;
        private string tennv, manv;
        frmTrangChu frmtc = null;
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

        public frmTimHopDong(Panel p , frmTrangChu frm )
        {
            InitializeComponent();
            nvbll = new NhanVienBLL();
            hdongbll = new HopDongBLL();
            frmtc = frm;
        }
        public void LoadDataToDgvHDong(DataGridView dgv, List<eHopDong> l)
        {
            dgv.DataSource = l;
        }
        #region
        private void button2_Click(object sender, EventArgs e)
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

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            
        }
        #endregion
        private void txtTimHopDong_KeyUp(object sender, KeyEventArgs e)
        {
            lhdong = hdongbll.TimKiemTheoMaHD(txtTimHopDong.Text.Trim());
            LoadDataToDgvHDong(dgvHDong, lhdong);
        }
        public bool KtraTTHDong()
        {

            if (dgvHDong.SelectedRows[0].Cells["TinhTrang"].Value.ToString().Trim() == "Đã hoàn thành" ||
                dgvHDong.SelectedRows[0].Cells["TinhTrang"].Value.ToString().Trim() == "Đã hủy")
            {
                return true;
            }
            else
                return false;
        }
        public bool KtraHanBH()
        {
            
            if (DateTime.Parse(dgvHDong.SelectedRows[0].Cells["HanBH"].Value.ToString().TrimEnd()) >= DateTime.Now)
            {
                return true;
            }
            return false;
        }
        private void btnTG_Click(object sender, EventArgs e)
        {
            try {
                int lantra;
                if (dgvHDong.SelectedRows.Count == 1)
                {
                    if (KtraTTHDong() == true)
                        MsgBox.Show("Hợp Đòng không đủ điều kiện lập phiếu trả góp", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                    else
                    {
                        if (dgvHDong.SelectedRows[0].Cells["TinhTrang"].Value.ToString().Trim() == "Đã thanh toán lần 1")
                        {
                            lantra = 2;
                        }
                        else
                            lantra = 3;

                        string mahdong = dgvHDong.SelectedRows[0].Cells["MaHopDong"].Value.ToString().Trim();
                        int hthuctt = int.Parse(dgvHDong.SelectedRows[0].Cells["HinhThucTT"].Value.ToString());
                        double sotien = double.Parse(dgvHDong.SelectedRows[0].Cells["Gia"].Value.ToString()) / int.Parse(dgvHDong.SelectedRows[0].Cells["HinhThucTT"].Value.ToString());
                        DateTime nglap = DateTime.Parse(dgvHDong.SelectedRows[0].Cells["NgayLap"].Value.ToString());
                        manv = frmtc.lblID.Text.Substring(4);
                        tennv = frmtc.lblTen.Text.Substring(8);
                        frmTTTraGop tg = new frmTTTraGop(frmtc, this, lantra, sotien, manv, tennv, mahdong, hthuctt, nglap);
                        tg.Show();
                        this.Visible = false;
                    }
                }

                else
                    MsgBox.Show("Chọn hợp đồng", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Info);
            }
            catch
            {
                MsgBox.Show("Lỗi. Vui lòng chọn lại hợp đồng", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Info);
            }
            

        }

        private void dgvHDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = this.dgvHDong.CurrentCell.RowIndex;
            this.dgvHDong.Rows[a].Selected = true;
        }
        
        private void btnBH_Click(object sender, EventArgs e)
        {
            
            if (dgvHDong.SelectedRows.Count == 1)
            {
                if (KtraTTHDong() == true)
                    MsgBox.Show("Hợp Đòng không đủ điều kiện để lập phiếu bảo hành", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Info);
               else  if (KtraHanBH() == false)
                  MsgBox.Show("Hợp đồng đã hết hạn bảo hành", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                else
                {
                    string mahdong = dgvHDong.SelectedRows[0].Cells["MaHopDong"].Value.ToString().Trim();
                    manv = frmtc.lblID.Text.Substring(4);
                    tennv = frmtc.lblTen.Text.Substring(8);
                    this.Visible = false;
                    frmPhieuSua ps = new frmPhieuSua(frmtc, this,  mahdong,  manv,  tennv);
                    ps.Show();
                   
                }
            }

            else
               MsgBox.Show("Chọn hợp đồng", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Info);
           
        }

        private void dgvHDong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = this.dgvHDong.CurrentCell.RowIndex;
            this.dgvHDong.Rows[a].Selected = true;
        }

        private void dgvHDong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmTimHopDong_Load(object sender, EventArgs e)
        {
            eNhanVien nv = nvbll.LayNVTheoMa(frmtc.lblID.Text.Substring(4));
            
            if (nv != null)
            {
                if (nv.ChucVu.TrimEnd() == "bh")
                {
                    btnBH.Enabled = false;
                    btnTG.Enabled = true;
                }
                else if(nv.ChucVu.TrimEnd() == "kt")
                {
                    btnTG.Enabled = false;
                    btnBH.Enabled = true;
                }
                
            }
            lhdong = hdongbll.LayDulieuTTHopDong();
            LoadDataToDgvHDong(dgvHDong, lhdong);
             

        }

    }
}
