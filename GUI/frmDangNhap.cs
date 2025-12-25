using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Thư viện kết nối SQL Server
using System.Runtime.InteropServices; // Thư viện hỗ trợ di chuyển Form

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        // 1. Chuỗi kết nối đến máy của bạn
        string strCon = @"Data Source=DESKTOP-PMT4SBU\SQLEXPRESS01;Initial Catalog=QuanLyPhongHoc;Integrated Security=True;TrustServerCertificate=True";

        // 2. Code hỗ trợ kéo di chuyển Form (do FormBorderStyle = None)
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public frmDangNhap()
        {
            InitializeComponent();
        }

        // Sự kiện di chuyển Form khi nhấn giữ chuột vào panel bên trái
        private void panelLeft_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // 3. Xử lý nút Đăng nhập
        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(strCon))
            {
                try
                {
                    conn.Open();
                    // Lấy thông tin Role của user
                    string sql = "SELECT Role FROM Account WHERE Username=@u AND Password=@p";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@u", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@p", txtPassword.Text);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        // Lưu quyền vào Session để dùng cho frmMain
                        UserSession.Username = txtUsername.Text;
                        UserSession.Role = Convert.ToInt32(result);

                        MessageBox.Show("Đăng nhập thành công!");
                        frmMain main = new frmMain();
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                    }
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        // 4. Xử lý hiện/ẩn mật khẩu
        private void ckbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowPass.Checked)
                txtPassword.UseSystemPasswordChar = false; // Hiện mật khẩu
            else
                txtPassword.UseSystemPasswordChar = true;  // Ẩn mật khẩu (****)
        }

        // 5. Nút thoát ứng dụng
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}