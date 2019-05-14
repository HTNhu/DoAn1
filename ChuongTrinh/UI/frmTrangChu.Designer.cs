namespace UI
{
    partial class frmTrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangChu));
            this.btnID = new System.Windows.Forms.Button();
            this.ctmTTNV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xemThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblID = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBanXe = new System.Windows.Forms.Button();
            this.btnQLKH = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnBHTG = new System.Windows.Forms.Button();
            this.btnQLXe = new System.Windows.Forms.Button();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.btnQLNV = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TSMtQLNV = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMtQLXe = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMtQLKH = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TSMtTKHDong = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMtTKHDon = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelParent = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ctmTTNV.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnID
            // 
            this.btnID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnID.BackgroundImage = global::UI.Properties.Resources.aqua_button_hi3;
            this.btnID.ContextMenuStrip = this.ctmTTNV;
            this.btnID.FlatAppearance.BorderSize = 0;
            this.btnID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnID.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnID.Image = global::UI.Properties.Resources.Setting_icon1;
            this.btnID.Location = new System.Drawing.Point(942, 1);
            this.btnID.Name = "btnID";
            this.btnID.Size = new System.Drawing.Size(40, 40);
            this.btnID.TabIndex = 94;
            this.toolTip1.SetToolTip(this.btnID, "Nhấp chuột phải");
            this.btnID.UseVisualStyleBackColor = true;
            this.btnID.MouseLeave += new System.EventHandler(this.btnID_MouseLeave);
            this.btnID.MouseHover += new System.EventHandler(this.btnID_MouseHover);
            // 
            // ctmTTNV
            // 
            this.ctmTTNV.AllowMerge = false;
            this.ctmTTNV.AutoSize = false;
            this.ctmTTNV.BackColor = System.Drawing.Color.Transparent;
            this.ctmTTNV.BackgroundImage = global::UI.Properties.Resources._800px_COLOURBOX4829934;
            this.ctmTTNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctmTTNV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ctmTTNV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemThôngTinToolStripMenuItem,
            this.toolStripMenuItem3});
            this.ctmTTNV.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.ctmTTNV.Name = "ctmTTNV";
            this.ctmTTNV.ShowImageMargin = false;
            this.ctmTTNV.Size = new System.Drawing.Size(110, 48);
            // 
            // xemThôngTinToolStripMenuItem
            // 
            this.xemThôngTinToolStripMenuItem.AutoSize = false;
            this.xemThôngTinToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.xemThôngTinToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xemThôngTinToolStripMenuItem.BackgroundImage")));
            this.xemThôngTinToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.xemThôngTinToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xemThôngTinToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.xemThôngTinToolStripMenuItem.Margin = new System.Windows.Forms.Padding(-20, 0, 0, 0);
            this.xemThôngTinToolStripMenuItem.Name = "xemThôngTinToolStripMenuItem";
            this.xemThôngTinToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 1, 20, 1);
            this.xemThôngTinToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.xemThôngTinToolStripMenuItem.Text = "Xem thông tin";
            this.xemThôngTinToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xemThôngTinToolStripMenuItem.Click += new System.EventHandler(this.xemThôngTinToolStripMenuItem_Click);
            this.xemThôngTinToolStripMenuItem.MouseLeave += new System.EventHandler(this.xemThôngTinToolStripMenuItem_MouseLeave);
            this.xemThôngTinToolStripMenuItem.MouseHover += new System.EventHandler(this.xemThôngTinToolStripMenuItem_MouseHover);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.AutoSize = false;
            this.toolStripMenuItem3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.BackgroundImage")));
            this.toolStripMenuItem3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Padding = new System.Windows.Forms.Padding(0, 1, 20, 1);
            this.toolStripMenuItem3.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItem3.Text = "Đăng Xuất";
            this.toolStripMenuItem3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            this.toolStripMenuItem3.MouseLeave += new System.EventHandler(this.toolStripMenuItem1_MouseLeave);
            this.toolStripMenuItem3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStripMenuItem1_MouseMove);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblID.Location = new System.Drawing.Point(757, 24);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(28, 17);
            this.lblID.TabIndex = 95;
            this.lblID.Text = "ID: ";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.BackColor = System.Drawing.Color.Transparent;
            this.lblTen.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTen.Location = new System.Drawing.Point(756, 2);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(29, 17);
            this.lblTen.TabIndex = 96;
            this.lblTen.Text = "Tên";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::UI.Properties.Resources.aqua_button_hi2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBanXe);
            this.panel1.Controls.Add(this.btnQLKH);
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Controls.Add(this.btnBHTG);
            this.panel1.Controls.Add(this.btnQLXe);
            this.panel1.Controls.Add(this.btnTrangChu);
            this.panel1.Controls.Add(this.btnQLNV);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblTen);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.btnID);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 140);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(48, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(905, 62);
            this.label1.TabIndex = 118;
            this.label1.Text = "Chương Trình Quản Lý Cửa Hàng Bán Xe Máy";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBanXe
            // 
            this.btnBanXe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBanXe.BackgroundImage")));
            this.btnBanXe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBanXe.CausesValidation = false;
            this.btnBanXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanXe.Font = new System.Drawing.Font("Sitka Heading", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanXe.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnBanXe.Image = global::UI.Properties.Resources._538720_disk_512x512;
            this.btnBanXe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanXe.Location = new System.Drawing.Point(120, 89);
            this.btnBanXe.Name = "btnBanXe";
            this.btnBanXe.Size = new System.Drawing.Size(103, 51);
            this.btnBanXe.TabIndex = 113;
            this.btnBanXe.Text = "Bán Xe";
            this.btnBanXe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBanXe.UseVisualStyleBackColor = true;
            this.btnBanXe.Click += new System.EventHandler(this.btnBanXe_Click);
            // 
            // btnQLKH
            // 
            this.btnQLKH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQLKH.BackgroundImage")));
            this.btnQLKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQLKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLKH.Font = new System.Drawing.Font("Sitka Heading", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLKH.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnQLKH.Image = global::UI.Properties.Resources.khachhang;
            this.btnQLKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKH.Location = new System.Drawing.Point(515, 89);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Size = new System.Drawing.Size(184, 51);
            this.btnQLKH.TabIndex = 113;
            this.btnQLKH.Text = " Quản Lý Khách Hàng";
            this.btnQLKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQLKH.UseVisualStyleBackColor = true;
            this.btnQLKH.Click += new System.EventHandler(this.btnQLKH_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThongKe.BackgroundImage")));
            this.btnThongKe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Sitka Heading", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongKe.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnThongKe.Image = global::UI.Properties.Resources.chart;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(860, 89);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(123, 51);
            this.btnThongKe.TabIndex = 117;
            this.btnThongKe.Text = "        Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnBHTG
            // 
            this.btnBHTG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBHTG.BackgroundImage")));
            this.btnBHTG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBHTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBHTG.Font = new System.Drawing.Font("Sitka Heading", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBHTG.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnBHTG.Image = global::UI.Properties.Resources.repair_icon;
            this.btnBHTG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBHTG.Location = new System.Drawing.Point(699, 89);
            this.btnBHTG.Name = "btnBHTG";
            this.btnBHTG.Size = new System.Drawing.Size(161, 51);
            this.btnBHTG.TabIndex = 116;
            this.btnBHTG.Text = "         Bảo Hành - Trả Góp";
            this.btnBHTG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBHTG.UseVisualStyleBackColor = true;
            this.btnBHTG.Click += new System.EventHandler(this.btnBHTG_Click);
            // 
            // btnQLXe
            // 
            this.btnQLXe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQLXe.BackgroundImage")));
            this.btnQLXe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQLXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLXe.Font = new System.Drawing.Font("Sitka Heading", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLXe.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnQLXe.Image = global::UI.Properties.Resources.Motorcycle_Insurance_512;
            this.btnQLXe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLXe.Location = new System.Drawing.Point(385, 89);
            this.btnQLXe.Name = "btnQLXe";
            this.btnQLXe.Size = new System.Drawing.Size(130, 51);
            this.btnQLXe.TabIndex = 115;
            this.btnQLXe.Text = "             Quản lý xe";
            this.btnQLXe.UseVisualStyleBackColor = true;
            this.btnQLXe.Click += new System.EventHandler(this.btnQLXe_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrangChu.BackgroundImage")));
            this.btnTrangChu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Sitka Heading", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnTrangChu.Image = global::UI.Properties.Resources.homepage_icon_png_22;
            this.btnTrangChu.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnTrangChu.Location = new System.Drawing.Point(0, 89);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(120, 51);
            this.btnTrangChu.TabIndex = 114;
            this.btnTrangChu.Text = "             Trang Chủ";
            this.btnTrangChu.UseVisualStyleBackColor = true;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click_1);
            // 
            // btnQLNV
            // 
            this.btnQLNV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQLNV.BackgroundImage")));
            this.btnQLNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQLNV.CausesValidation = false;
            this.btnQLNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNV.Font = new System.Drawing.Font("Sitka Heading", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNV.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnQLNV.Image = global::UI.Properties.Resources.worker_engineer_safety_engineering_builder_developer_architect_512;
            this.btnQLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNV.Location = new System.Drawing.Point(223, 89);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(162, 51);
            this.btnQLNV.TabIndex = 112;
            this.btnQLNV.Text = "         Quản lý nhân viên";
            this.btnQLNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQLNV.UseVisualStyleBackColor = true;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Sitka Heading", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(256, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(499, 69);
            this.label7.TabIndex = 103;
            this.label7.Text = "Cửa Hàng Bán Xe Máy";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TSMtQLNV
            // 
            this.TSMtQLNV.AutoSize = false;
            this.TSMtQLNV.BackColor = System.Drawing.Color.Transparent;
            this.TSMtQLNV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TSMtQLNV.BackgroundImage")));
            this.TSMtQLNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TSMtQLNV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSMtQLNV.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TSMtQLNV.Name = "TSMtQLNV";
            this.TSMtQLNV.Size = new System.Drawing.Size(184, 30);
            this.TSMtQLNV.Text = "      Nhân Viên";
            this.TSMtQLNV.ToolTipText = "Quản lý nhân viên";
            this.TSMtQLNV.Click += new System.EventHandler(this.TSMtQLNV_Click);
            // 
            // TSMtQLXe
            // 
            this.TSMtQLXe.AutoSize = false;
            this.TSMtQLXe.BackColor = System.Drawing.Color.Transparent;
            this.TSMtQLXe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TSMtQLXe.BackgroundImage")));
            this.TSMtQLXe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TSMtQLXe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSMtQLXe.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TSMtQLXe.Name = "TSMtQLXe";
            this.TSMtQLXe.Size = new System.Drawing.Size(184, 30);
            this.TSMtQLXe.Text = "      Xe";
            this.TSMtQLXe.ToolTipText = "Quản lý xe";
            this.TSMtQLXe.Click += new System.EventHandler(this.TSMtQLXe_Click);
            // 
            // TSMtQLKH
            // 
            this.TSMtQLKH.AutoSize = false;
            this.TSMtQLKH.BackColor = System.Drawing.Color.Transparent;
            this.TSMtQLKH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TSMtQLKH.BackgroundImage")));
            this.TSMtQLKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TSMtQLKH.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSMtQLKH.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TSMtQLKH.Name = "TSMtQLKH";
            this.TSMtQLKH.Size = new System.Drawing.Size(184, 30);
            this.TSMtQLKH.Text = "     Khách Hàng";
            this.TSMtQLKH.ToolTipText = "Quản lý khách hàng";
            this.TSMtQLKH.Click += new System.EventHandler(this.TSMtQLKH_Click);
            // 
            // TSMtTKHDong
            // 
            this.TSMtTKHDong.Name = "TSMtTKHDong";
            this.TSMtTKHDong.Size = new System.Drawing.Size(180, 22);
            this.TSMtTKHDong.Text = "toolStripMenuItem4";
            // 
            // TSMtTKHDon
            // 
            this.TSMtTKHDon.Name = "TSMtTKHDon";
            this.TSMtTKHDon.Size = new System.Drawing.Size(180, 22);
            this.TSMtTKHDon.Text = "toolStripMenuItem5";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.AutoSize = false;
            this.toolStripMenuItem4.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem4.BackgroundImage")));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(140, 30);
            this.toolStripMenuItem4.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.AutoSize = false;
            this.toolStripMenuItem5.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem5.BackgroundImage")));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(140, 30);
            this.toolStripMenuItem5.Text = "toolStripMenuItem2";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.AutoSize = false;
            this.toolStripMenuItem6.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem6.BackgroundImage")));
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(140, 30);
            this.toolStripMenuItem6.Text = "toolStripMenuItem3";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem7.Text = "toolStripMenuItem7";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem8.Text = "toolStripMenuItem8";
            // 
            // PanelParent
            // 
            this.PanelParent.BackColor = System.Drawing.Color.Transparent;
            this.PanelParent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PanelParent.Location = new System.Drawing.Point(0, 141);
            this.PanelParent.Name = "PanelParent";
            this.PanelParent.Size = new System.Drawing.Size(984, 438);
            this.PanelParent.TabIndex = 9;
            this.PanelParent.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.aqua_button_hi2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 581);
            this.Controls.Add(this.PanelParent);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTrangChu_FormClosing);
            this.Load += new System.EventHandler(this.TrangChuForm_Load);
            this.ctmTTNV.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnID;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.Label lblTen;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem TSMtTKHDong;
        private System.Windows.Forms.ToolStripMenuItem TSMtTKHDon;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem TSMtQLNV;
        private System.Windows.Forms.ToolStripMenuItem TSMtQLXe;
        private System.Windows.Forms.ToolStripMenuItem TSMtQLKH;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Panel PanelParent;
        private System.Windows.Forms.ToolStripMenuItem xemThôngTinToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip ctmTTNV;
        private System.Windows.Forms.Button btnQLKH;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnBHTG;
        private System.Windows.Forms.Button btnQLXe;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Button btnQLNV;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Button btnBanXe;
        private System.Windows.Forms.Label label1;
    }
}