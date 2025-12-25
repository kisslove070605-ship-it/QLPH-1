using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmQuanTri : Form
    {
        public frmQuanTri()
        {
            InitializeComponent();
        }
        private void LoadDangKyForm()
        {
            // 1. Xóa các linh kiện cũ đang có trong pnlContainer1 (nếu có)
            pnlContainer1.Controls.Clear();

            // 2. Khởi tạo Form Đăng ký tài khoản
            frmDangKyTaiKhoan f = new frmDangKyTaiKhoan();

            // 3. Thiết lập thuộc tính để nhúng vào Panel
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill; // Để Form lấp đầy Panel pnlContainer1

            // 4. Thêm Form vào Panel và hiển thị
            pnlContainer1.Controls.Add(f);
            f.Show();
        }
        private void CenterAllPanels()
        {
            // Căn giữa cho Tab Tạo Tài Khoản
            if (pnlContainer1 != null)
            {
                pnlContainer1.Left = (tabTaoTK.Width - pnlContainer1.Width) / 2;
                pnlContainer1.Top = (tabTaoTK.Height - pnlContainer1.Height) / 2;
            }
            // Căn giữa cho Tab Đổi Mật Khẩu
            if (pnlContainer2 != null)
            {
                pnlContainer2.Left = (tabDoiMK.Width - pnlContainer2.Width) / 2;
                pnlContainer2.Top = (tabDoiMK.Height - pnlContainer2.Height) / 2;
            }
            // Căn giữa cho Tab Reset Mật Khẩu
            if (pnlContainer3 != null)
            {
                pnlContainer3.Left = (tabResetMK.Width - pnlContainer3.Width) / 2;
                pnlContainer3.Top = (tabResetMK.Height - pnlContainer3.Height) / 2;
            }
        }

        // 2. Định nghĩa sự kiện Load (Sửa lỗi 'does not contain a definition')
        private void frmQuanTri_Load(object sender, EventArgs e)
        {
            LoadDangKyForm();
            CenterAllPanels();
        }

        // 3. Định nghĩa sự kiện Resize (Sửa lỗi 'does not contain a definition')
        private void frmQuanTri_Resize(object sender, EventArgs e)
        {
            CenterAllPanels();
        }
    }
}
