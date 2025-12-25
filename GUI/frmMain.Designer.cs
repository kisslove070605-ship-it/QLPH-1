namespace GUI
{
    partial class frmMain
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

        private void InitializeComponent()
        {
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuDashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanTri = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUserWelcome = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDashboard,
            this.menuQuanTri,
            this.menuDanhMuc,
            this.menuQuanLy,
            this.menuTimKiem,
            this.menuThongKe});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(1136, 28);
            this.menuMain.TabIndex = 1;
            // 
            // menuDashboard
            // 
            this.menuDashboard.Name = "menuDashboard";
            this.menuDashboard.Size = new System.Drawing.Size(143, 24);
            this.menuDashboard.Text = "🏠 DASHBOARD";
            // 
            // menuQuanTri
            // 
            this.menuQuanTri.Name = "menuQuanTri";
            this.menuQuanTri.Size = new System.Drawing.Size(122, 24);
            this.menuQuanTri.Text = "🛡️ QUẢN TRỊ";
            this.menuQuanTri.Click += new System.EventHandler(this.menuQuanTri_Click);
            // 
            // menuDanhMuc
            // 
            this.menuDanhMuc.Name = "menuDanhMuc";
            this.menuDanhMuc.Size = new System.Drawing.Size(132, 24);
            this.menuDanhMuc.Text = "📂 DANH MỤC";
            // 
            // menuQuanLy
            // 
            this.menuQuanLy.Name = "menuQuanLy";
            this.menuQuanLy.Size = new System.Drawing.Size(114, 24);
            this.menuQuanLy.Text = "👥 QUẢN LÝ";
            // 
            // menuTimKiem
            // 
            this.menuTimKiem.Name = "menuTimKiem";
            this.menuTimKiem.Size = new System.Drawing.Size(118, 24);
            this.menuTimKiem.Text = "🔍 TÌM KIẾM";
            // 
            // menuThongKe
            // 
            this.menuThongKe.Name = "menuThongKe";
            this.menuThongKe.Size = new System.Drawing.Size(280, 24);
            this.menuThongKe.Text = "📊 THỐNG KÊ HIỆU SUẤT SỬ DỤNG";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Location = new System.Drawing.Point(12, 31);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1112, 468);
            this.tabControlMain.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUserWelcome});
            this.statusStrip1.Location = new System.Drawing.Point(0, 502);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1136, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUserWelcome
            // 
            this.lblUserWelcome.Name = "lblUserWelcome";
            this.lblUserWelcome.Size = new System.Drawing.Size(151, 20);
            this.lblUserWelcome.Text = "toolStripStatusLabel1";
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(1136, 528);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG QUẢN LÝ PHÒNG HỌC DNC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuDashboard, menuQuanTri, menuDanhMuc, menuQuanLy, menuTimKiem, menuThongKe;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUserWelcome;
    }
}