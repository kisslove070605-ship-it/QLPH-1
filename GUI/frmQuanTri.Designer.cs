namespace GUI
{
    partial class frmQuanTri
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabTaoTK = new System.Windows.Forms.TabPage();
            this.pnlContainer1 = new System.Windows.Forms.Panel();
            this.tabDoiMK = new System.Windows.Forms.TabPage();
            this.pnlContainer2 = new System.Windows.Forms.Panel();
            this.tabResetMK = new System.Windows.Forms.TabPage();
            this.pnlContainer3 = new System.Windows.Forms.Panel();
            this.tabControlMain.SuspendLayout();
            this.tabTaoTK.SuspendLayout();
            this.tabDoiMK.SuspendLayout();
            this.tabResetMK.SuspendLayout();
            this.SuspendLayout();

            // tabControlMain
            this.tabControlMain.Controls.Add(this.tabTaoTK);
            this.tabControlMain.Controls.Add(this.tabDoiMK);
            this.tabControlMain.Controls.Add(this.tabResetMK);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1000, 700);

            // Tab Tạo Tài Khoản
            this.tabTaoTK.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabTaoTK.Controls.Add(this.pnlContainer1);
            this.tabTaoTK.Text = "Tạo Tài Khoản";

            // pnlContainer1: Panel chứa các ô nhập liệu Tab 1
            this.pnlContainer1.BackColor = System.Drawing.Color.White;
            this.pnlContainer1.Location = new System.Drawing.Point(100, 50);
            this.pnlContainer1.Name = "pnlContainer1";
            this.pnlContainer1.Size = new System.Drawing.Size(800, 500);

            // Tab Đổi Mật Khẩu
            this.tabDoiMK.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabDoiMK.Controls.Add(this.pnlContainer2);
            this.tabDoiMK.Text = "Đổi Mật Khẩu";

            this.pnlContainer2.BackColor = System.Drawing.Color.White;
            this.pnlContainer2.Size = new System.Drawing.Size(600, 400);
            this.pnlContainer2.Name = "pnlContainer2";

            // Tab Reset Mật Khẩu
            this.tabResetMK.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabResetMK.Controls.Add(this.pnlContainer3);
            this.tabResetMK.Text = "Reset Mật Khẩu";

            this.pnlContainer3.BackColor = System.Drawing.Color.White;
            this.pnlContainer3.Size = new System.Drawing.Size(500, 300);
            this.pnlContainer3.Name = "pnlContainer3";

            // frmQuanTri Settings
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.tabControlMain);
            this.Name = "frmQuanTri";
            this.Text = "Quản Trị Hệ Thống";
            this.Load += new System.EventHandler(this.frmQuanTri_Load);
            this.Resize += new System.EventHandler(this.frmQuanTri_Resize);
            this.tabControlMain.ResumeLayout(false);
            this.tabTaoTK.ResumeLayout(false);
            this.tabDoiMK.ResumeLayout(false);
            this.tabResetMK.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        // CÁC KHAI BÁO BIẾN ĐỂ HẾT LỖI "DOES NOT EXIST"
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabTaoTK;
        private System.Windows.Forms.TabPage tabDoiMK;
        private System.Windows.Forms.TabPage tabResetMK;
        private System.Windows.Forms.Panel pnlContainer1;
        private System.Windows.Forms.Panel pnlContainer2;
        private System.Windows.Forms.Panel pnlContainer3;
    }
}