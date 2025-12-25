using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GIL
{
    public partial class ResetMatKhau : Form
    {
        private DataTable accountTable; // Dữ liệu giả lập

        public ResetMatKhau()
        {
            InitializeComponent();
            InitializeSampleData(); // Tạo dữ liệu mẫu
        }

        private void InitializeSampleData()
        {
            accountTable = new DataTable();
            accountTable.Columns.Add("Tên Tài Khoản");
            accountTable.Columns.Add("Mật Khẩu");

            accountTable.Rows.Add("admin", "1111");
            accountTable.Rows.Add("huynhiem", "1111");
            accountTable.Rows.Add("admin1", "admin1");
            accountTable.Rows.Add("liem", "1111");
            accountTable.Rows.Add("abc", "1111");

            dgvAccounts.DataSource = accountTable;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                dgvAccounts.DataSource = accountTable;
                return;
            }

            var filtered = accountTable.AsEnumerable()
                .Where(row => row.Field<string>("Tên Tài Khoản").ToLower().Contains(keyword))
                .CopyToDataTable();

            dgvAccounts.DataSource = filtered;
        }

        private void dgvAccounts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count > 0)
            {
                var row = dgvAccounts.SelectedRows[0];
                txtUsername.Text = row.Cells["Tên Tài Khoản"].Value?.ToString() ?? "";
                txtNewPassword.Clear();
                cmbRole.SelectedIndex = 0; // Mặc định là 0 (Quyền nhân viên)
                chkShowPassword.Checked = false;
                txtNewPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtUsername.Clear();
            txtNewPassword.Clear();
            cmbRole.SelectedIndex = 0;
            chkShowPassword.Checked = false;
            txtNewPassword.UseSystemPasswordChar = true;
            dgvAccounts.ClearSelection();
            dgvAccounts.DataSource = accountTable; // Reset lại danh sách
            txtSearch.Focus();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng chọn tài khoản từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập Mật Khẩu Mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return;
            }

            // Giả lập cập nhật mật khẩu
            var row = accountTable.AsEnumerable()
                .FirstOrDefault(r => r.Field<string>("Tên Tài Khoản") == txtUsername.Text);

            if (row != null)
            {
                row["Mật Khẩu"] = txtNewPassword.Text;
                MessageBox.Show($"Đã reset mật khẩu cho tài khoản '{txtUsername.Text}' thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnReset_Click(sender, e); // Reset form
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void ResetMatKhau_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
            this.Text = "ShareCode.vn - Hệ thống quản lý phòng học DNC";
            CenterPanel();
        }

        private void CenterPanel()
        {
            if (this.ClientSize.Width > panel1.Width && this.ClientSize.Height > panel1.Height)
            {
                panel1.Location = new Point(
                    (this.ClientSize.Width - panel1.Width) / 2,
                    (this.ClientSize.Height - panel1.Height) / 2
                );
            }
        }

        private void ResetMatKhau_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }
    }
}
