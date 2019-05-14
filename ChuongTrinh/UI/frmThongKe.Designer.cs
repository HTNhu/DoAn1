namespace UI
{
    partial class frmThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKe));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grbThongKe = new System.Windows.Forms.GroupBox();
            this.btnTKNV = new System.Windows.Forms.Button();
            this.btnTT = new System.Windows.Forms.Button();
            this.eNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chartTinhTrang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dtNgayBD = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtNgayKT = new System.Windows.Forms.DateTimePicker();
            this.grbBieuDo = new System.Windows.Forms.GroupBox();
            this.lblTT = new System.Windows.Forms.Label();
            this.lblNV = new System.Windows.Forms.Label();
            this.grbThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTinhTrang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.grbBieuDo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbThongKe
            // 
            this.grbThongKe.BackColor = System.Drawing.Color.Transparent;
            this.grbThongKe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbThongKe.Controls.Add(this.btnTKNV);
            this.grbThongKe.Controls.Add(this.btnTT);
            this.grbThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbThongKe.Location = new System.Drawing.Point(1, 1);
            this.grbThongKe.Name = "grbThongKe";
            this.grbThongKe.Size = new System.Drawing.Size(223, 431);
            this.grbThongKe.TabIndex = 1;
            this.grbThongKe.TabStop = false;
            this.grbThongKe.Text = "Thống kê theo";
            // 
            // btnTKNV
            // 
            this.btnTKNV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTKNV.BackgroundImage")));
            this.btnTKNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTKNV.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTKNV.ForeColor = System.Drawing.Color.White;
            this.btnTKNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTKNV.Location = new System.Drawing.Point(24, 153);
            this.btnTKNV.Name = "btnTKNV";
            this.btnTKNV.Size = new System.Drawing.Size(180, 45);
            this.btnTKNV.TabIndex = 109;
            this.btnTKNV.Text = "Theo nhân viên";
            this.btnTKNV.UseVisualStyleBackColor = true;
            this.btnTKNV.Click += new System.EventHandler(this.btnTKNV_Click_1);
            // 
            // btnTT
            // 
            this.btnTT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTT.BackgroundImage")));
            this.btnTT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTT.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTT.ForeColor = System.Drawing.Color.White;
            this.btnTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTT.Location = new System.Drawing.Point(24, 247);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(180, 49);
            this.btnTT.TabIndex = 110;
            this.btnTT.Text = "Theo Tình Trạng";
            this.btnTT.UseVisualStyleBackColor = true;
            this.btnTT.Click += new System.EventHandler(this.btnTT_Click);
            // 
            // eNhanVienBindingSource
            // 
            this.eNhanVienBindingSource.DataSource = typeof(Entities.eNhanVien);
            // 
            // chartTinhTrang
            // 
            this.chartTinhTrang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chartTinhTrang.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartTinhTrang.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Title = "Ghi chú";
            this.chartTinhTrang.Legends.Add(legend1);
            this.chartTinhTrang.Location = new System.Drawing.Point(383, 16);
            this.chartTinhTrang.Name = "chartTinhTrang";
            this.chartTinhTrang.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Số lượng \\nhợp đồng ";
            series1.XValueMember = "TinhTrang";
            series1.YValueMembers = "SoHopDong";
            this.chartTinhTrang.Series.Add(series1);
            this.chartTinhTrang.Size = new System.Drawing.Size(364, 371);
            this.chartTinhTrang.TabIndex = 103;
            this.chartTinhTrang.Text = "chart2";
            this.chartTinhTrang.Click += new System.EventHandler(this.chartTinhTrang_Click);
            // 
            // chart1
            // 
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea2.Name = "chartarea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "tyty";
            legend2.Title = "Ghi chú: ";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(6, 16);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "chartarea1";
            series2.IsValueShownAsLabel = true;
            series2.Legend = "tyty";
            series2.Name = "Số lượng \\nhợp đồng";
            series2.XValueMember = "TenNV";
            series2.YValueMembers = "SOCHIEC";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(364, 371);
            this.chart1.TabIndex = 102;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Controls.Add(this.btnThongKe);
            this.groupBox3.Controls.Add(this.dtNgayBD);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dtNgayKT);
            this.groupBox3.Location = new System.Drawing.Point(236, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(748, 38);
            this.groupBox3.TabIndex = 102;
            this.groupBox3.TabStop = false;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackgroundImage = global::UI.Properties.Resources._800px_COLOURBOX4829934;
            this.btnThongKe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Sitka Heading", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(636, 7);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(75, 29);
            this.btnThongKe.TabIndex = 113;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dtNgayBD
            // 
            this.dtNgayBD.Location = new System.Drawing.Point(73, 11);
            this.dtNgayBD.Name = "dtNgayBD";
            this.dtNgayBD.Size = new System.Drawing.Size(180, 20);
            this.dtNgayBD.TabIndex = 112;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 111;
            this.label5.Text = "Toi ngay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 110;
            this.label4.Text = "Tu ngay";
            // 
            // dtNgayKT
            // 
            this.dtNgayKT.Location = new System.Drawing.Point(409, 11);
            this.dtNgayKT.Name = "dtNgayKT";
            this.dtNgayKT.Size = new System.Drawing.Size(183, 20);
            this.dtNgayKT.TabIndex = 109;
            this.dtNgayKT.ValueChanged += new System.EventHandler(this.dtNgayKT_ValueChanged);
            // 
            // grbBieuDo
            // 
            this.grbBieuDo.BackColor = System.Drawing.Color.Transparent;
            this.grbBieuDo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbBieuDo.Controls.Add(this.lblTT);
            this.grbBieuDo.Controls.Add(this.lblNV);
            this.grbBieuDo.Controls.Add(this.chart1);
            this.grbBieuDo.Controls.Add(this.chartTinhTrang);
            this.grbBieuDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbBieuDo.Location = new System.Drawing.Point(230, 39);
            this.grbBieuDo.Name = "grbBieuDo";
            this.grbBieuDo.Size = new System.Drawing.Size(753, 393);
            this.grbBieuDo.TabIndex = 111;
            this.grbBieuDo.TabStop = false;
            this.grbBieuDo.Text = "Biểu đồ thống kê";
            // 
            // lblTT
            // 
            this.lblTT.AutoSize = true;
            this.lblTT.BackColor = System.Drawing.Color.White;
            this.lblTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTT.Location = new System.Drawing.Point(420, 368);
            this.lblTT.Name = "lblTT";
            this.lblTT.Size = new System.Drawing.Size(302, 13);
            this.lblTT.TabIndex = 105;
            this.lblTT.Text = "Biểu đồ thống kê số lượng hợp đồng theo tình trạng";
            // 
            // lblNV
            // 
            this.lblNV.AutoSize = true;
            this.lblNV.BackColor = System.Drawing.Color.White;
            this.lblNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNV.Location = new System.Drawing.Point(23, 369);
            this.lblNV.Name = "lblNV";
            this.lblNV.Size = new System.Drawing.Size(329, 13);
            this.lblNV.TabIndex = 104;
            this.lblNV.Text = "Biểu đồ thống kê số lượng hợp đồng theo nhân viên lập ";
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.aqua_button_hi2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 439);
            this.Controls.Add(this.grbBieuDo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grbThongKe);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê hợp đồng";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.grbThongKe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTinhTrang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grbBieuDo.ResumeLayout(false);
            this.grbBieuDo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongKe;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource eNhanVienBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtNgayKT;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTinhTrang;
        private System.Windows.Forms.DateTimePicker dtNgayBD;
        private System.Windows.Forms.Button btnTT;
        private System.Windows.Forms.Button btnTKNV;
        private System.Windows.Forms.GroupBox grbBieuDo;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label lblTT;
        private System.Windows.Forms.Label lblNV;
    }
}