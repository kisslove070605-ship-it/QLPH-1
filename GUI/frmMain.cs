using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void menuQuanTri_Click(object sender, EventArgs e)
        {
            if (UserSession.Role != 0)
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng Quản trị!", "Thông báo");
                return;
            }
            foreach (TabPage tab in tabControlMain.TabPages)
            {
                if (tab.Text == "Quản Trị Hệ Thống")
                {
                    tabControlMain.SelectedTab = tab;
                    return;
                }
            }

            // 3. Khởi tạo Form Quản Trị
            TabPage tp = new TabPage("Quản Trị Hệ Thống");
            frmQuanTri f = new frmQuanTri();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None; // Bỏ khung viền Form con
            f.Dock = DockStyle.Fill; // Để Form con lấp đầy TabPage

            // 4. Thêm Form con vào TabPage và thêm TabPage vào TabControl của frmMain
            tp.Controls.Add(f);
            tabControlMain.TabPages.Add(tp);

            // 5. Hiển thị và chọn Tab vừa tạo
            f.Show();
            tabControlMain.SelectedTab = tp;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // 1. Hiển thị tên người dùng đã đăng nhập lên giao diện chính
            lblUserWelcome.Text = "Xin chào: " + UserSession.Username;
        }
    }
}