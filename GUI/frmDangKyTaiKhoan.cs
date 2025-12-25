using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    public partial class frmDangKyTaiKhoan : Form
    {
        // Chuỗi kết nối lấy chính xác từ server máy bạn
        string strCon = @"Data Source=DESKTOP-PMT4SBU\SQLEXPRESS01;Initial Catalog=QuanLyPhongHoc;Integrated Security=True;TrustServerCertificate=True";

        public frmDangKyTaiKhoan()
        {
            InitializeComponent();
            // Khởi tạo ComboBox phân quyền
            cbPhanQuyen.Items.Add("1 - Nhân viên");
            cbPhanQuyen.Items.Add("0 - Admin");
            cbPhanQuyen.SelectedIndex = 0;
            LoadData();
        }
        private void CenterInterface()
        {
            if (pnlContainer != null)
            {
                // Công thức căn giữa chính xác:
                // Tọa độ X (Left) = (Chiều rộng Form - Chiều rộng Panel) / 2
                // Tọa độ Y (Top) = (Chiều cao Form - Chiều cao Panel) / 2

                pnlContainer.Left = (this.ClientSize.Width - pnlContainer.Width) / 2;
                pnlContainer.Top = (this.ClientSize.Height - pnlContainer.Height) / 2;
            }
        }
        private void frmDangKyTaiKhoan_Load(object sender, EventArgs e)
        {
            CenterInterface();
        }

        // Sự kiện khi kích thước Form thay đổi

        void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(strCon))
            {
                try
                {
                    string sql = "SELECT Username as [Tên Tài Khoản], Password as [Mật Khẩu], Role as [Quyền] FROM Account";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDanhSach.DataSource = dt;
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        // --- CÁC HÀM XỬ LÝ SỰ KIỆN ---
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(strCon))
            {
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO Account (Username, Password, Role) VALUES (@u, @p, @r)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@u", txtTaiKhoan.Text);
                    cmd.Parameters.AddWithValue("@p", txtMatKhau.Text);
                    cmd.Parameters.AddWithValue("@r", cbPhanQuyen.Text.Substring(0, 1));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!");
                    LoadData();
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !chkHienMatKhau.Checked;
        }

        private void lblTitle_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void lblLogo_Click(object sender, EventArgs e) { }

        private void frmDangKyTaiKhoan_Resize(object sender, EventArgs e)
        {
            CenterInterface();
        }

        private void btnXacNhan_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaiKhoan.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }

            using (SqlConnection conn = new SqlConnection(strCon))
            {
                try
                {
                    conn.Open();
                    // Kiểm tra trùng tài khoản
                    string checkSql = "SELECT COUNT(*) FROM Account WHERE Username = @u";
                    SqlCommand checkCmd = new SqlCommand(checkSql, conn);
                    checkCmd.Parameters.AddWithValue("@u", txtTaiKhoan.Text);
                    if ((int)checkCmd.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("Tài khoản này đã tồn tại!");
                        return;
                    }

                    // Thực hiện thêm mới
                    string sql = "INSERT INTO Account (Username, Password, Role) VALUES (@u, @p, @r)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@u", txtTaiKhoan.Text);
                    cmd.Parameters.AddWithValue("@p", txtMatKhau.Text);
                    // Lấy số 0 hoặc 1 từ chuỗi "0 - Nhân viên" hoặc "1 - Quản trị"
                    cmd.Parameters.AddWithValue("@r", cbPhanQuyen.Text.Substring(0, 1));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tạo tài khoản thành công!", "Thành công");
                    LoadData();
                    btnNhapLai_Click(null, null); // Xóa trắng ô nhập sau khi thêm
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi SQL: " + ex.Message);
                }
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
            cbPhanQuyen.SelectedIndex = 0;
            txtTaiKhoan.Focus();
        }

        private void chkHienMatKhau_CheckedChanged_1(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !chkHienMatKhau.Checked;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}