namespace UI
{
    partial class frmTimHopDong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimHopDong));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTG = new System.Windows.Forms.Button();
            this.btnBH = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvHDong = new System.Windows.Forms.DataGridView();
            this.MaHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhThucTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimHopDong = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnTG);
            this.panel1.Controls.Add(this.btnBH);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lblTimKiem);
            this.panel1.Controls.Add(this.txtTimHopDong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 439);
            this.panel1.TabIndex = 0;
            // 
            // btnTG
            // 
            this.btnTG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTG.BackgroundImage")));
            this.btnTG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTG.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTG.ForeColor = System.Drawing.Color.White;
            this.btnTG.Location = new System.Drawing.Point(554, 371);
            this.btnTG.Name = "btnTG";
            this.btnTG.Size = new System.Drawing.Size(104, 44);
            this.btnTG.TabIndex = 16;
            this.btnTG.Text = "Trả Góp";
            this.btnTG.UseVisualStyleBackColor = true;
            this.btnTG.Click += new System.EventHandler(this.btnTG_Click);
            // 
            // btnBH
            // 
            this.btnBH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBH.BackgroundImage")));
            this.btnBH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBH.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBH.ForeColor = System.Drawing.Color.White;
            this.btnBH.Location = new System.Drawing.Point(322, 371);
            this.btnBH.Name = "btnBH";
            this.btnBH.Size = new System.Drawing.Size(104, 44);
            this.btnBH.TabIndex = 15;
            this.btnBH.Text = "Bảo Hành";
            this.btnBH.UseVisualStyleBackColor = true;
            this.btnBH.Click += new System.EventHandler(this.btnBH_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHDong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 284);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hợp đồng";
            // 
            // dgvHDong
            // 
            this.dgvHDong.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvHDong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvHDong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHDong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHDong.ColumnHeadersHeight = 30;
            this.dgvHDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHopDong,
            this.TenNhanVien,
            this.MaKH,
            this.TenKH,
            this.NgayLap,
            this.Gia,
            this.HinhThucTT,
            this.HanBH,
            this.TinhTrang,
            this.DiaChi,
            this.TenXe});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHDong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHDong.EnableHeadersVisualStyles = false;
            this.dgvHDong.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvHDong.Location = new System.Drawing.Point(3, 18);
            this.dgvHDong.MultiSelect = false;
            this.dgvHDong.Name = "dgvHDong";
            this.dgvHDong.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHDong.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHDong.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvHDong.Size = new System.Drawing.Size(954, 263);
            this.dgvHDong.TabIndex = 24;
            this.dgvHDong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHDong_CellClick);
            this.dgvHDong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHDong_CellContentClick);
            this.dgvHDong.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHDong_CellDoubleClick);
            // 
            // MaHopDong
            // 
            this.MaHopDong.DataPropertyName = "maHopDong";
            this.MaHopDong.HeaderText = "Mã Hợp Đồng";
            this.MaHopDong.Name = "MaHopDong";
            this.MaHopDong.ReadOnly = true;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "TenNV";
            this.TenNhanVien.HeaderText = "Tên NV";
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.ReadOnly = true;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "maKH";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "tenKH";
            this.TenKH.HeaderText = "Tên KH";
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "ngayLap";
            this.NgayLap.HeaderText = "Ngày Lập";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá Tiền";
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // HinhThucTT
            // 
            this.HinhThucTT.DataPropertyName = "hinhThucTT";
            this.HinhThucTT.HeaderText = "Hình thức tt";
            this.HinhThucTT.Name = "HinhThucTT";
            this.HinhThucTT.ReadOnly = true;
            // 
            // HanBH
            // 
            this.HanBH.DataPropertyName = "hanBH";
            this.HanBH.HeaderText = "Hạn bảo hành";
            this.HanBH.Name = "HanBH";
            this.HanBH.ReadOnly = true;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "tinhTrang";
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "diaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // TenXe
            // 
            this.TenXe.DataPropertyName = "tenXe";
            this.TenXe.HeaderText = "Tên Xe";
            this.TenXe.Name = "TenXe";
            this.TenXe.ReadOnly = true;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.lblTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTimKiem.ForeColor = System.Drawing.Color.Black;
            this.lblTimKiem.Location = new System.Drawing.Point(327, 33);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(71, 17);
            this.lblTimKiem.TabIndex = 13;
            this.lblTimKiem.Text = "Tìm Kiếm :";
            // 
            // txtTimHopDong
            // 
            this.txtTimHopDong.Location = new System.Drawing.Point(404, 33);
            this.txtTimHopDong.Name = "txtTimHopDong";
            this.txtTimHopDong.Size = new System.Drawing.Size(242, 20);
            this.txtTimHopDong.TabIndex = 12;
            this.toolTip1.SetToolTip(this.txtTimHopDong, "Nhập thông tin cần tìm\r\n");
            this.txtTimHopDong.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTimHopDong_KeyUp);
            // 
            // frmTimHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.aqua_button_hi2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 439);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmTimHopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trả Góp & Bảo Hành";
            this.Load += new System.EventHandler(this.frmTimHopDong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimHopDong;
        private System.Windows.Forms.GroupBox groupBox1;
        protected internal System.Windows.Forms.DataGridView dgvHDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhThucTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenXe;
        private System.Windows.Forms.Button btnTG;
        private System.Windows.Forms.Button btnBH;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}