using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_Án
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            
            InitializeComponent();
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                return;
            }
            else if (txtTenDangNhap.Text == "QuangHuy" && txtMatKhau.Text =="123456")
            {
                this.Hide();
                frmTrangChu trang_chu = new frmTrangChu();
                trang_chu.ShowDialog();
                trang_chu = null;

            }
            else if (txtTenDangNhap.Text !="QuangHuy")
            {
                MessageBox.Show("Tên đăng nhập không đúng!",
                    "Thông báo",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
            else
            {
                 MessageBox.Show("Mật khẩu không đúng!",
                    "Thông báo",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);

            }

        }

        private void chkMatKhau_CheckedChanged(object sender, EventArgs e)
        {

            if (chkMatKhau.Checked == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }
    }
}
