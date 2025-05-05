using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_Án
{
    public partial class frmQuanLyKhachHang : Form
    {
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
        }
        KetNoi data = new KetNoi();

        private void loadData()
        {
            string str = "Select* from KhachHang";
            SqlDataAdapter da = new SqlDataAdapter(str, data.GetConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvKH.DataSource = dt;

        }
        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int vitri = dgvKH.CurrentCell.RowIndex;
                string MaKH = txtTTMaKh.Text;
                string TenKH = txtTTTenKH.Text;
                string SDT = txtSDT.Text;
                string CCCD = txtCCCD.Text;
                string QueQuan = txtQueQuan.Text;
                string GioiTinh = txtGioiTinh.Text;
                string NamSinh = txtNamSinh.Text;
                string Nghe = txtCareer.Text;
                string NgayThue = dateTimePickerNgayThue.Text;
                string Phong = txtMaPhong.Text;
                data.ExcuteNonquery("insert into KhachHang values ('" + MaKH + "', N'" + TenKH + "','" + CCCD + "','" + SDT + "', N'" + NamSinh + "', N'" + QueQuan + "', '" + GioiTinh + "', N'" + Nghe+ "','" + NgayThue + "' , '" + Phong + "')");
                MessageBox.Show("Thêm Khách hàng mới thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();

                txtTTMaKh.Text = "";
                txtTTTenKH.Text = "";
                txtSDT.Text = "";
                txtCCCD.Text = "";
                txtGioiTinh.Text = "";
                txtNamSinh.Text = "";
                txtQueQuan.Text = "";
                txtCareer.Text = "";
                dateTimePickerNgayThue.Text = "";
                txtMaPhong.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int vitri = dgvKH.CurrentCell.RowIndex;
                string MaKH = dgvKH.Rows[vitri].Cells[0].Value.ToString();
                string TenKH = dgvKH.Rows[vitri].Cells[1].Value.ToString();
                string CCCD = dgvKH.Rows[vitri].Cells[2].Value.ToString();
                string SDT = dgvKH.Rows[vitri].Cells[3].Value.ToString();
                string NamSinh = dgvKH.Rows[vitri].Cells[4].Value.ToString();
                string QueQuan = dgvKH.Rows[vitri].Cells[5].Value.ToString();
                string GioiTinh = dgvKH.Rows[vitri].Cells[6].Value.ToString();
                string Nghe = dgvKH.Rows[vitri].Cells[7].Value.ToString();
                string NgayThue = dgvKH.Rows[vitri].Cells[8].Value.ToString();
                string MaPhong = dgvKH.Rows[vitri].Cells[9].Value.ToString();

                data.ExcuteNonquery("delete from KhachHang where Makhachhang = '" + MaKH + "'");
                MessageBox.Show("Xóa khách hàng " + TenKH + " thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKH.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng dữ liệu để sửa!");
                return;
            }


            try
            {
                int vitri = dgvKH.CurrentCell.RowIndex;
                string MaKH = dgvKH.Rows[vitri].Cells[0].Value.ToString();
                string TenKH = dgvKH.Rows[vitri].Cells[1].Value.ToString();
                string CCCD = dgvKH.Rows[vitri].Cells[2].Value.ToString();
                string SDT = dgvKH.Rows[vitri].Cells[3].Value.ToString();
                string NamSinh = dgvKH.Rows[vitri].Cells[4].Value.ToString();
                string QueQuan = dgvKH.Rows[vitri].Cells[5].Value.ToString();
                string GioiTinh = dgvKH.Rows[vitri].Cells[6].Value.ToString();
                string Nghe = dgvKH.Rows[vitri].Cells[7].Value.ToString();
                string NgayThue = dgvKH.Rows[vitri].Cells[8].Value.ToString();
                string MaPhong = dgvKH.Rows[vitri].Cells[9].Value.ToString();

                txtTTMaKh.Text = MaKH;
                txtTTTenKH.Text = TenKH;
                txtSDT.Text = SDT;
                txtCCCD.Text = CCCD;
                txtGioiTinh.Text = GioiTinh;
                txtNamSinh.Text = NamSinh;
                txtQueQuan.Text = QueQuan;
                txtCareer.Text = Nghe;
                dateTimePickerNgayThue.Text = NgayThue;
                txtMaPhong.Text = MaPhong;

                txtTTMaKh.Enabled = true;
                txtTTTenKH.Enabled = true;
                txtSDT.Enabled = true;
                txtCCCD.Enabled = true;
                txtGioiTinh.Enabled = true;
                txtNamSinh.Enabled = true;
                txtQueQuan.Enabled = true;
                txtCareer.Enabled = true;
                dateTimePickerNgayThue.Enabled = true;
                txtMaPhong.Enabled = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvKH.Rows[e.RowIndex];

                txtTTMaKh.Text = selectedRow.Cells[0].Value.ToString();
                txtTTTenKH.Text = selectedRow.Cells[1].Value.ToString();
                txtSDT.Text = selectedRow.Cells[2].Value.ToString();
                txtCCCD.Text = selectedRow.Cells[3].Value.ToString();
                txtNamSinh.Text = selectedRow.Cells[4].Value.ToString();
                txtQueQuan.Text = selectedRow.Cells[5].Value.ToString();
                txtGioiTinh.Text = selectedRow.Cells[6].Value.ToString();
                txtCareer.Text = selectedRow.Cells[7].Value.ToString();
                dateTimePickerNgayThue.Text = selectedRow.Cells[8].Value.ToString();
                txtMaPhong.Text = selectedRow.Cells[9].Value.ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string MaKH = txtTTMaKh.Text;
            string TenKH = txtTTTenKH.Text;
            string SDT = txtSDT.Text;
            string CCCD = txtCCCD.Text;
            string DiaChi = txtQueQuan.Text;
            string GioiTinh = txtGioiTinh.Text;
            string NamSinh = txtNamSinh.Text;
            string Nghe = txtCareer.Text;

            // Get the date from DateTimePicker in a format suitable for SQL Server
            DateTime ngayThue = dateTimePickerNgayThue.Value;  // Assuming dateTimePickerNgayThue is a DateTimePicker control

            string Phong = txtMaPhong.Text;

            // Improved SQL statement with parameter for NgheNghiep
            string query = "UPDATE Khachhang SET TenKhachHang = @TenKH, SoDienthoai = @SDT, CCCD =@CCCD, DiaChi = @QueQuan, GioiTinh = @GioiTinh, NamSinh = @NamSinh, NgheNghiep = @NgheNghiep, NgayThue = @NgayThue, MaPhong = @MaPhong WHERE MaKhachHang = @MaKH";

            using (SqlConnection conn = new SqlConnection(@"Data Source= LAPTOP-EK26VL1R\SQLEXPRESS; Initial Catalog = QLPhongTro; Integrated Security =True "))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaKH", MaKH);
                        cmd.Parameters.AddWithValue("@TenKH", TenKH);
                        cmd.Parameters.AddWithValue("@SDT", SDT);
                        cmd.Parameters.AddWithValue("@CCCD",
         CCCD);
                        cmd.Parameters.AddWithValue("@QueQuan", DiaChi);
                        cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                        cmd.Parameters.AddWithValue("@NamSinh", NamSinh);
                        cmd.Parameters.AddWithValue("@NgheNghiep", Nghe);  // Correct parameter name
                        cmd.Parameters.AddWithValue("@NgayThue", ngayThue);  // Use DateTime value directly
                        cmd.Parameters.AddWithValue("@MaPhong", Phong);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sửa thông tin thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            loadData(); 

            txtTTMaKh.Text = "";
            txtTTTenKH.Text = "";
            txtSDT.Text = "";
            txtCCCD.Text = "";
            txtGioiTinh.Text = "";
            txtNamSinh.Text = "";
            txtQueQuan.Text = "";
            txtCareer.Text = "";
            dateTimePickerNgayThue.Text = ""; 
            txtMaPhong.Text = "";
        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            string TimTenKH = txtTKKH.Text;
            string GioiTinh = "";


            if (radNam.Checked)
            {
                GioiTinh = "Nam";
            }
            else if (radNu.Checked)
            {
                GioiTinh = "Nữ";
            }

            string query = "SELECT * FROM KhachHang WHERE 1=1"; // Use 1=1 to simplify adding conditions

            if (!string.IsNullOrEmpty(TimTenKH))
            {
                query += " AND TenKhachhang LIKE '%' + @TenKH + '%'";
            }

 
            if (!string.IsNullOrEmpty(GioiTinh))
            {
                query += " AND GioiTinh = @GioiTinh";
            }


            if (!string.IsNullOrEmpty(TimTenKH) || !string.IsNullOrEmpty(GioiTinh))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, data.GetConnect());

                if (!string.IsNullOrEmpty(TimTenKH))
                {
                    da.SelectCommand.Parameters.AddWithValue("@TenKH", TimTenKH);
                }
                if (!string.IsNullOrEmpty(GioiTinh))
                {
                    da.SelectCommand.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                }

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvKH.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng hoặc chọn giới tính để tìm kiếm.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnSourcePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                picAnhKH.Image = Image.FromFile(filePath);

                picAnhKH.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắn chắn muốn đăng xuất ?",
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

        private void mnuTrangChu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTrangChu TrangChu = new frmTrangChu();
            TrangChu.Show();
        }

        private void mnuQLDV_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyDichVu QLDV = new frmQuanLyDichVu();
            QLDV.Show();
        }

        private void mnuQuanLyPhong_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyPhong TTP = new frmQuanLyPhong();
            TTP.Show();
        }

        private void mnuQLHD_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyHopDong QuanLyHopDong = new frmQuanLyHopDong();
            QuanLyHopDong.Show();
        }

        private void mnuQLHDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyHoaDon QLHDon = new frmQuanLyHoaDon();
            QLHDon.Show();
        }
    }
}
