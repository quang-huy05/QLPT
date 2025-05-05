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
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắn chắn muốn thoát ?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                frmLogin Dang_nhap = new frmLogin();
                Dang_nhap.ShowDialog();
                Dang_nhap = null;

            }


        }

        private void btnThongTinPhong_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyPhong ThongTinPhong = new frmQuanLyPhong();
            ThongTinPhong.Show();
            ThongTinPhong = null;
            
        }

        private void btnQuanLyDichVu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyDichVu QuanLyDichVu = new frmQuanLyDichVu();
            QuanLyDichVu.Show();
            QuanLyDichVu = null;
        }
       // QUẢN LÝ KHÁCH HÀNG - FIX TỪ C#1
        private void btnQuanLyTienDien_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyKhachHang QuanLyKH = new frmQuanLyKhachHang();
            QuanLyKH.Show();
            QuanLyKH = null;
        }
        // QUẢN LÝ HỢP ĐỒNG - FIX TỪ C#1
        private void btnQuanLyTienNuoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyHopDong QuanLyTienNuoc = new frmQuanLyHopDong();
            QuanLyTienNuoc.Show();
            QuanLyTienNuoc = null;
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyHoaDon QLHDon = new frmQuanLyHoaDon();
            QLHDon.Show();
            QLHDon = null;
        }
    }
}
