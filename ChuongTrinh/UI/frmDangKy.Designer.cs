namespace UI
{
    partial class frmDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangKy));
            this.lblDangKy = new System.Windows.Forms.Label();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtNLMK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTBLoiTenTK = new System.Windows.Forms.Label();
            this.lblTBLoiMK = new System.Windows.Forms.Label();
            this.lblTBLoiNLMK = new System.Windows.Forms.Label();
            this.btnLuuHD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDangKy
            // 
            this.lblDangKy.AutoSize = true;
            this.lblDangKy.BackColor = System.Drawing.Color.Transparent;
            this.lblDangKy.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDangKy.ForeColor = System.Drawing.Color.Navy;
            this.lblDangKy.Location = new System.Drawing.Point(30, 34);
            this.lblDangKy.Name = "lblDangKy";
            this.lblDangKy.Size = new System.Drawing.Size(348, 50);
            this.lblDangKy.TabIndex = 3;
            this.lblDangKy.Text = "Đăng Ký Tài Khoản";
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(170, 123);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(185, 20);
            this.txtTenTK.TabIndex = 4;
            this.txtTenTK.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTenTK_KeyUp);
            this.txtTenTK.Leave += new System.EventHandler(this.txtTenTK_Leave);
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(170, 179);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(185, 20);
            this.txtMK.TabIndex = 5;
            this.txtMK.TextChanged += new System.EventHandler(this.txtMK_TextChanged);
            this.txtMK.Leave += new System.EventHandler(this.txtMK_Leave);
            // 
            // txtNLMK
            // 
            this.txtNLMK.Location = new System.Drawing.Point(170, 237);
            this.txtNLMK.Name = "txtNLMK";
            this.txtNLMK.PasswordChar = '*';
            this.txtNLMK.Size = new System.Drawing.Size(185, 20);
            this.txtNLMK.TabIndex = 6;
            this.txtNLMK.TextChanged += new System.EventHandler(this.txtNLMK_TextChanged);
            this.txtNLMK.Leave += new System.EventHandler(this.txtNLMK_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(35, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên tài khoản :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(35, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mật khẩu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(34, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nhập lại mật khẩu :";
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(236, 318);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(104, 48);
            this.btnThoat.TabIndex = 64;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblTBLoiTenTK
            // 
            this.lblTBLoiTenTK.AutoSize = true;
            this.lblTBLoiTenTK.BackColor = System.Drawing.Color.Transparent;
            this.lblTBLoiTenTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTBLoiTenTK.ForeColor = System.Drawing.Color.Red;
            this.lblTBLoiTenTK.Location = new System.Drawing.Point(170, 147);
            this.lblTBLoiTenTK.Name = "lblTBLoiTenTK";
            this.lblTBLoiTenTK.Size = new System.Drawing.Size(0, 13);
            this.lblTBLoiTenTK.TabIndex = 65;
            // 
            // lblTBLoiMK
            // 
            this.lblTBLoiMK.AutoSize = true;
            this.lblTBLoiMK.BackColor = System.Drawing.Color.Transparent;
            this.lblTBLoiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTBLoiMK.ForeColor = System.Drawing.Color.Red;
            this.lblTBLoiMK.Location = new System.Drawing.Point(170, 202);
            this.lblTBLoiMK.Name = "lblTBLoiMK";
            this.lblTBLoiMK.Size = new System.Drawing.Size(0, 13);
            this.lblTBLoiMK.TabIndex = 66;
            // 
            // lblTBLoiNLMK
            // 
            this.lblTBLoiNLMK.AutoSize = true;
            this.lblTBLoiNLMK.BackColor = System.Drawing.Color.Transparent;
            this.lblTBLoiNLMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTBLoiNLMK.ForeColor = System.Drawing.Color.Red;
            this.lblTBLoiNLMK.Location = new System.Drawing.Point(170, 260);
            this.lblTBLoiNLMK.Name = "lblTBLoiNLMK";
            this.lblTBLoiNLMK.Size = new System.Drawing.Size(0, 13);
            this.lblTBLoiNLMK.TabIndex = 67;
            // 
            // btnLuuHD
            // 
            this.btnLuuHD.BackColor = System.Drawing.Color.Transparent;
            this.btnLuuHD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLuuHD.BackgroundImage")));
            this.btnLuuHD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLuuHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuHD.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuHD.ForeColor = System.Drawing.Color.White;
            this.btnLuuHD.Image = global::UI.Properties.Resources.save_512;
            this.btnLuuHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuHD.Location = new System.Drawing.Point(52, 318);
            this.btnLuuHD.Name = "btnLuuHD";
            this.btnLuuHD.Size = new System.Drawing.Size(100, 48);
            this.btnLuuHD.TabIndex = 68;
            this.btnLuuHD.Text = "Lưu";
            this.btnLuuHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuHD.UseVisualStyleBackColor = false;
            this.btnLuuHD.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(396, 406);
            this.Controls.Add(this.btnLuuHD);
            this.Controls.Add(this.lblTBLoiNLMK);
            this.Controls.Add(this.lblTBLoiMK);
            this.Controls.Add(this.lblTBLoiTenTK);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNLMK);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTenTK);
            this.Controls.Add(this.lblDangKy);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "frmDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Ký Tài Khoản";
            this.Load += new System.EventHandler(this.frmDangKy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDangKy;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtNLMK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblTBLoiTenTK;
        private System.Windows.Forms.Label lblTBLoiMK;
        private System.Windows.Forms.Label lblTBLoiNLMK;
        public System.Windows.Forms.Button btnLuuHD;
    }
}