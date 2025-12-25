namespace GUI
{
    partial class frmDangKyTaiKhoan
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblPhanQuyen = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.cbPhanQuyen = new System.Windows.Forms.ComboBox();
            this.chkHienMatKhau = new System.Windows.Forms.CheckBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.z7359893045379_e1bad2a62df24426d627d9eba96a9ad3;
            this.pictureBox1.Location = new System.Drawing.Point(143, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(40, 28);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(397, 24);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "HỆ THỐNG QUẢN LÝ PHÒNG HỌC TTTT";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.Red;
            this.lblLogo.Image = global::GUI.Properties.Resources.z7359893045379_e1bad2a62df24426d627d9eba96a9ad3;
            this.lblLogo.Location = new System.Drawing.Point(126, 79);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(0, 98);
            this.lblLogo.TabIndex = 17;
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Location = new System.Drawing.Point(448, 73);
            this.lblTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(71, 16);
            this.lblTaiKhoan.TabIndex = 18;
            this.lblTaiKhoan.Text = "Tài Khoản:";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(448, 110);
            this.lblMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(65, 16);
            this.lblMatKhau.TabIndex = 19;
            this.lblMatKhau.Text = "Mật Khẩu:";
            // 
            // lblPhanQuyen
            // 
            this.lblPhanQuyen.AutoSize = true;
            this.lblPhanQuyen.Location = new System.Drawing.Point(448, 147);
            this.lblPhanQuyen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhanQuyen.Name = "lblPhanQuyen";
            this.lblPhanQuyen.Size = new System.Drawing.Size(83, 16);
            this.lblPhanQuyen.TabIndex = 20;
            this.lblPhanQuyen.Text = "Phân Quyền:";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(542, 69);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(199, 22);
            this.txtTaiKhoan.TabIndex = 21;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(542, 106);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(199, 22);
            this.txtMatKhau.TabIndex = 22;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // cbPhanQuyen
            // 
            this.cbPhanQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhanQuyen.FormattingEnabled = true;
            this.cbPhanQuyen.Location = new System.Drawing.Point(542, 143);
            this.cbPhanQuyen.Margin = new System.Windows.Forms.Padding(4);
            this.cbPhanQuyen.Name = "cbPhanQuyen";
            this.cbPhanQuyen.Size = new System.Drawing.Size(199, 24);
            this.cbPhanQuyen.TabIndex = 23;
            // 
            // chkHienMatKhau
            // 
            this.chkHienMatKhau.AutoSize = true;
            this.chkHienMatKhau.Location = new System.Drawing.Point(628, 175);
            this.chkHienMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.chkHienMatKhau.Name = "chkHienMatKhau";
            this.chkHienMatKhau.Size = new System.Drawing.Size(114, 20);
            this.chkHienMatKhau.TabIndex = 24;
            this.chkHienMatKhau.Text = "Hiện mật khẩu";
            this.chkHienMatKhau.UseVisualStyleBackColor = true;
            this.chkHienMatKhau.CheckedChanged += new System.EventHandler(this.chkHienMatKhau_CheckedChanged_1);
            // 
            // btnLoad
            // 
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(35, 221);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 28);
            this.btnLoad.TabIndex = 25;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapLai.Location = new System.Drawing.Point(450, 214);
            this.btnNhapLai.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(120, 28);
            this.btnNhapLai.TabIndex = 26;
            this.btnNhapLai.Text = "Nhập Lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXacNhan.Location = new System.Drawing.Point(621, 214);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(4);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(120, 28);
            this.btnXacNhan.TabIndex = 27;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click_1);
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AllowUserToAddRows = false;
            this.dgvDanhSach.AllowUserToDeleteRows = false;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(35, 257);
            this.dgvDanhSach.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.Size = new System.Drawing.Size(707, 246);
            this.dgvDanhSach.TabIndex = 28;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlContainer.Controls.Add(this.label1);
            this.pnlContainer.Controls.Add(this.dgvDanhSach);
            this.pnlContainer.Controls.Add(this.btnXacNhan);
            this.pnlContainer.Controls.Add(this.btnNhapLai);
            this.pnlContainer.Controls.Add(this.btnLoad);
            this.pnlContainer.Controls.Add(this.chkHienMatKhau);
            this.pnlContainer.Controls.Add(this.cbPhanQuyen);
            this.pnlContainer.Controls.Add(this.txtMatKhau);
            this.pnlContainer.Controls.Add(this.txtTaiKhoan);
            this.pnlContainer.Controls.Add(this.lblPhanQuyen);
            this.pnlContainer.Controls.Add(this.lblMatKhau);
            this.pnlContainer.Controls.Add(this.lblTaiKhoan);
            this.pnlContainer.Controls.Add(this.lblLogo);
            this.pnlContainer.Controls.Add(this.lblTitle);
            this.pnlContainer.Controls.Add(this.pictureBox1);
            this.pnlContainer.Location = new System.Drawing.Point(12, 12);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(776, 530);
            this.pnlContainer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(567, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Tạo Tài Khoản";
            // 
            // frmDangKyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.pnlContainer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDangKyTaiKhoan";
            this.Text = "Tạo Tài Khoản - Hệ thống Quản lý Phòng Học DNC";
            this.Load += new System.EventHandler(this.frmDangKyTaiKhoan_Load);
            this.Resize += new System.EventHandler(this.frmDangKyTaiKhoan_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.ResumeLayout(false);

        }
        // Đảm bảo có dòng này ở cuối file Designer
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblPhanQuyen;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.ComboBox cbPhanQuyen;
        private System.Windows.Forms.CheckBox chkHienMatKhau;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label label1;
    }
    #endregion
}