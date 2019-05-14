namespace UI
{
    partial class frmQuanLyXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyXe));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxNuocSX = new System.Windows.Forms.ComboBox();
            this.lblLoiGia = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTenXe = new System.Windows.Forms.TextBox();
            this.cbxSoPK = new System.Windows.Forms.ComboBox();
            this.cbxLoaiXe = new System.Windows.Forms.ComboBox();
            this.cbxMauXe = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoSuon = new System.Windows.Forms.TextBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtGiaXe = new System.Windows.Forms.TextBox();
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.txtSoKhung = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvQLXe = new System.Windows.Forms.DataGridView();
            this.maXeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenXeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiXeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mauXeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nuocSXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaXeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soKhungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soPKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soSuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.eXeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbxNuocSX);
            this.groupBox1.Controls.Add(this.lblLoiGia);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtTenXe);
            this.groupBox1.Controls.Add(this.cbxSoPK);
            this.groupBox1.Controls.Add(this.cbxLoaiXe);
            this.groupBox1.Controls.Add(this.cbxMauXe);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtSoSuon);
            this.groupBox1.Controls.Add(this.lblGia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.txtGiaXe);
            this.groupBox1.Controls.Add(this.txtMaXe);
            this.groupBox1.Controls.Add(this.txtSoKhung);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 437);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin xe";
            // 
            // cbxNuocSX
            // 
            this.cbxNuocSX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNuocSX.FormattingEnabled = true;
            this.cbxNuocSX.Items.AddRange(new object[] {
            "Việt Nam",
            "Nhật Bản",
            "Hàn Quốc ",
            "Thái Lan",
            "Campuchia",
            "Trung Quốc",
            "Đài Loan",
            "Singapore",
            "Lào",
            "Philippines",
            "Indonesia"});
            this.cbxNuocSX.Location = new System.Drawing.Point(151, 184);
            this.cbxNuocSX.Name = "cbxNuocSX";
            this.cbxNuocSX.Size = new System.Drawing.Size(135, 24);
            this.cbxNuocSX.TabIndex = 62;
            // 
            // lblLoiGia
            // 
            this.lblLoiGia.AutoSize = true;
            this.lblLoiGia.Location = new System.Drawing.Point(152, 243);
            this.lblLoiGia.Name = "lblLoiGia";
            this.lblLoiGia.Size = new System.Drawing.Size(0, 16);
            this.lblLoiGia.TabIndex = 61;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(25, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 17);
            this.label12.TabIndex = 60;
            this.label12.Text = "Tên Xe :";
            // 
            // txtTenXe
            // 
            this.txtTenXe.Location = new System.Drawing.Point(151, 72);
            this.txtTenXe.MaxLength = 30;
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(135, 22);
            this.txtTenXe.TabIndex = 59;
            // 
            // cbxSoPK
            // 
            this.cbxSoPK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSoPK.FormattingEnabled = true;
            this.cbxSoPK.Items.AddRange(new object[] {
            "50cc",
            "125cc",
            "150cc",
            "200cc",
            "250cc"});
            this.cbxSoPK.Location = new System.Drawing.Point(151, 294);
            this.cbxSoPK.Name = "cbxSoPK";
            this.cbxSoPK.Size = new System.Drawing.Size(135, 24);
            this.cbxSoPK.TabIndex = 58;
            // 
            // cbxLoaiXe
            // 
            this.cbxLoaiXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLoaiXe.FormattingEnabled = true;
            this.cbxLoaiXe.Items.AddRange(new object[] {
            "Tay ga",
            "Số",
            "Tay côn",
            "PKL"});
            this.cbxLoaiXe.Location = new System.Drawing.Point(151, 108);
            this.cbxLoaiXe.Name = "cbxLoaiXe";
            this.cbxLoaiXe.Size = new System.Drawing.Size(135, 24);
            this.cbxLoaiXe.TabIndex = 57;
            // 
            // cbxMauXe
            // 
            this.cbxMauXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMauXe.FormattingEnabled = true;
            this.cbxMauXe.Items.AddRange(new object[] {
            "Đen",
            "Trắng",
            "Xanh Dương",
            "Xanh Lá",
            "Cam",
            "Đỏ",
            "Hồng",
            "Vàng "});
            this.cbxMauXe.Location = new System.Drawing.Point(151, 146);
            this.cbxMauXe.Name = "cbxMauXe";
            this.cbxMauXe.Size = new System.Drawing.Size(135, 24);
            this.cbxMauXe.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(25, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 55;
            this.label9.Text = "Số Sườn:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(25, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 54;
            this.label8.Text = "Số PK :";
            // 
            // txtSoSuon
            // 
            this.txtSoSuon.Location = new System.Drawing.Point(151, 332);
            this.txtSoSuon.MaxLength = 10;
            this.txtSoSuon.Name = "txtSoSuon";
            this.txtSoSuon.Size = new System.Drawing.Size(135, 22);
            this.txtSoSuon.TabIndex = 53;
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGia.Location = new System.Drawing.Point(25, 263);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(70, 17);
            this.lblGia.TabIndex = 52;
            this.lblGia.Text = "Số Khung:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(25, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 51;
            this.label5.Text = "Giá Xe :";
            // 
            // btnLuu
            // 
            this.btnLuu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.BackgroundImage")));
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(218, 381);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(68, 37);
            this.btnLuu.TabIndex = 43;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtGiaXe
            // 
            this.txtGiaXe.Location = new System.Drawing.Point(151, 222);
            this.txtGiaXe.Name = "txtGiaXe";
            this.txtGiaXe.Size = new System.Drawing.Size(135, 22);
            this.txtGiaXe.TabIndex = 45;
            this.txtGiaXe.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGiaXe_KeyUp);
            this.txtGiaXe.Leave += new System.EventHandler(this.txtGiaXe_Leave);
            // 
            // txtMaXe
            // 
            this.txtMaXe.Location = new System.Drawing.Point(151, 36);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(135, 22);
            this.txtMaXe.TabIndex = 44;
            // 
            // txtSoKhung
            // 
            this.txtSoKhung.Location = new System.Drawing.Point(151, 258);
            this.txtSoKhung.MaxLength = 10;
            this.txtSoKhung.Name = "txtSoKhung";
            this.txtSoKhung.Size = new System.Drawing.Size(135, 22);
            this.txtSoKhung.TabIndex = 46;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.BackgroundImage")));
            this.btnCapNhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Sitka Heading", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(118, 381);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(76, 37);
            this.btnCapNhat.TabIndex = 42;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(25, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "Màu Xe:";
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(26, 381);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(68, 37);
            this.btnThem.TabIndex = 41;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(25, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Nước Sản Xuất :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "Mã Xe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(25, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "Loại Xe :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(502, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "Tìm Kiếm :";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(579, 22);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(240, 20);
            this.txtTimKiem.TabIndex = 34;
            this.toolTip1.SetToolTip(this.txtTimKiem, "Nhập thông tin cần tìm\r\n");
            this.txtTimKiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvQLXe);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(318, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(665, 382);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách xe";
            // 
            // dgvQLXe
            // 
            this.dgvQLXe.AutoGenerateColumns = false;
            this.dgvQLXe.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvQLXe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvQLXe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLXe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQLXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maXeDataGridViewTextBoxColumn,
            this.tenXeDataGridViewTextBoxColumn,
            this.loaiXeDataGridViewTextBoxColumn,
            this.mauXeDataGridViewTextBoxColumn,
            this.nuocSXDataGridViewTextBoxColumn,
            this.giaXeDataGridViewTextBoxColumn,
            this.soKhungDataGridViewTextBoxColumn,
            this.soPKDataGridViewTextBoxColumn,
            this.soSuonDataGridViewTextBoxColumn,
            this.TinhTrang});
            this.dgvQLXe.DataSource = this.eXeBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQLXe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQLXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQLXe.EnableHeadersVisualStyles = false;
            this.dgvQLXe.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvQLXe.Location = new System.Drawing.Point(3, 18);
            this.dgvQLXe.MultiSelect = false;
            this.dgvQLXe.Name = "dgvQLXe";
            this.dgvQLXe.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLXe.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQLXe.RowHeadersWidth = 40;
            this.dgvQLXe.Size = new System.Drawing.Size(659, 361);
            this.dgvQLXe.TabIndex = 22;
            this.dgvQLXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLXe_CellClick);
            this.dgvQLXe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLXe_CellDoubleClick);
            this.dgvQLXe.SelectionChanged += new System.EventHandler(this.dgvQLXe_SelectionChanged);
            this.dgvQLXe.Click += new System.EventHandler(this.dgvQLXe_Click);
            this.dgvQLXe.DoubleClick += new System.EventHandler(this.dgvQLXe_DoubleClick);
            this.dgvQLXe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvQLXe_MouseClick);
            // 
            // maXeDataGridViewTextBoxColumn
            // 
            this.maXeDataGridViewTextBoxColumn.DataPropertyName = "MaXe";
            this.maXeDataGridViewTextBoxColumn.HeaderText = "Mã Xe";
            this.maXeDataGridViewTextBoxColumn.Name = "maXeDataGridViewTextBoxColumn";
            this.maXeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenXeDataGridViewTextBoxColumn
            // 
            this.tenXeDataGridViewTextBoxColumn.DataPropertyName = "TenXe";
            this.tenXeDataGridViewTextBoxColumn.HeaderText = "Tên Xe";
            this.tenXeDataGridViewTextBoxColumn.Name = "tenXeDataGridViewTextBoxColumn";
            this.tenXeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loaiXeDataGridViewTextBoxColumn
            // 
            this.loaiXeDataGridViewTextBoxColumn.DataPropertyName = "LoaiXe";
            this.loaiXeDataGridViewTextBoxColumn.HeaderText = "Loại Xe";
            this.loaiXeDataGridViewTextBoxColumn.Name = "loaiXeDataGridViewTextBoxColumn";
            this.loaiXeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mauXeDataGridViewTextBoxColumn
            // 
            this.mauXeDataGridViewTextBoxColumn.DataPropertyName = "MauXe";
            this.mauXeDataGridViewTextBoxColumn.HeaderText = "Màu Xe";
            this.mauXeDataGridViewTextBoxColumn.Name = "mauXeDataGridViewTextBoxColumn";
            this.mauXeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nuocSXDataGridViewTextBoxColumn
            // 
            this.nuocSXDataGridViewTextBoxColumn.DataPropertyName = "NuocSX";
            this.nuocSXDataGridViewTextBoxColumn.HeaderText = "Nước Sản Xuất";
            this.nuocSXDataGridViewTextBoxColumn.Name = "nuocSXDataGridViewTextBoxColumn";
            this.nuocSXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giaXeDataGridViewTextBoxColumn
            // 
            this.giaXeDataGridViewTextBoxColumn.DataPropertyName = "GiaXe";
            this.giaXeDataGridViewTextBoxColumn.HeaderText = "Giá Xe";
            this.giaXeDataGridViewTextBoxColumn.Name = "giaXeDataGridViewTextBoxColumn";
            this.giaXeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soKhungDataGridViewTextBoxColumn
            // 
            this.soKhungDataGridViewTextBoxColumn.DataPropertyName = "SoKhung";
            this.soKhungDataGridViewTextBoxColumn.HeaderText = "Số Khung";
            this.soKhungDataGridViewTextBoxColumn.Name = "soKhungDataGridViewTextBoxColumn";
            this.soKhungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soPKDataGridViewTextBoxColumn
            // 
            this.soPKDataGridViewTextBoxColumn.DataPropertyName = "SoPK";
            this.soPKDataGridViewTextBoxColumn.HeaderText = "Số PK";
            this.soPKDataGridViewTextBoxColumn.Name = "soPKDataGridViewTextBoxColumn";
            this.soPKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soSuonDataGridViewTextBoxColumn
            // 
            this.soSuonDataGridViewTextBoxColumn.DataPropertyName = "SoSuon";
            this.soSuonDataGridViewTextBoxColumn.HeaderText = "Số Sườn";
            this.soSuonDataGridViewTextBoxColumn.Name = "soSuonDataGridViewTextBoxColumn";
            this.soSuonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            // 
            // eXeBindingSource
            // 
            this.eXeBindingSource.DataSource = typeof(Entities.eXe);
            // 
            // frmQuanLyXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::UI.Properties.Resources.aqua_button_hi2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 439);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmQuanLyXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý xe";
            this.Load += new System.EventHandler(this.frmQuanLyXe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxNuocSX;
        private System.Windows.Forms.Label lblLoiGia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.ComboBox cbxSoPK;
        private System.Windows.Forms.ComboBox cbxLoaiXe;
        private System.Windows.Forms.ComboBox cbxMauXe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoSuon;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtGiaXe;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.TextBox txtSoKhung;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvQLXe;
        private System.Windows.Forms.BindingSource eXeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maXeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenXeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiXeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mauXeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nuocSXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaXeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soKhungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soPKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soSuonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TinhTrang;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}