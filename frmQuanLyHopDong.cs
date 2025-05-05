using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Đồ_Án.frmQuanLyDichVu;
using static Đồ_Án.frmQuanLyHoaDon;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Đồ_Án
{
    public partial class frmQuanLyHopDong : Form
    {
        


        public frmQuanLyHopDong()
        {
            InitializeComponent();
           
        }
        KetNoi data = new KetNoi();

        private void loadData()
        {
            string strHopDong = "Select* from HopDong";
            SqlDataAdapter da1 = new SqlDataAdapter(strHopDong, data.GetConnect());
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dgvHopDong.DataSource = dt1;

            string strCTHDong = "Select* from ChiTietHopDong";
            SqlDataAdapter da2 = new SqlDataAdapter(strCTHDong, data.GetConnect());
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dgvCTHDong.DataSource = dt2;

        }
        private void frmQuanLyHopDong_Load(object sender, EventArgs e)
        {
            loadData();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblRunText.Text = lblRunText.Text.Substring(1, int.Parse(lblRunText.Text.Length.ToString()) - 1) + lblRunText.Text.Substring(0, 1);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source= LAPTOP-EK26VL1R\SQLEXPRESS; Initial Catalog = QLPhongTro; Integrated Security =True "))
                {
                    conn.Open();

                    string query = "INSERT INTO hopdong (MaHopDong, MaPhong, NgayLapHopDong, TrangThaiHopDong) VALUES (@MaHopDong, @MaPhong, @NgayLapHopDong, @TrangThaiHopDong)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaHopDong", txtMaHopDong.Text);
                        cmd.Parameters.AddWithValue("@MaPhong", txtMaPhong.Text);
                        cmd.Parameters.AddWithValue("@NgayLapHopDong", dateTimePicker1.Text); // Chuyển thành DateTime
                        cmd.Parameters.AddWithValue("@TrangThaiHopDong", txtTrangThaiHD.Text); // Chuyển thành DateTime


                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Thêm Hợp đồng mới thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();

                        txtMaHopDong.Text = "";
                        txtMaPhong.Text = "";
                        dateTimePicker1.Text = "";
                        txtTrangThaiHD.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvHopDong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvHopDong.Rows[e.RowIndex];

                txtMaHopDong.Text = selectedRow.Cells[0].Value.ToString();
                txtMaPhong.Text = selectedRow.Cells[1].Value.ToString();
                dateTimePicker1.Text = selectedRow.Cells[2].Value.ToString();
                txtTrangThaiHD.Text = selectedRow.Cells[3].Value.ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaHopDong.Text = "";
            txtMaPhong.Text = "";
            dateTimePicker1.Text = "";
            txtTrangThaiHD.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int vitri = dgvHopDong.CurrentCell.RowIndex;
                string MaHopDong = dgvHopDong.Rows[vitri].Cells[0].Value.ToString();
                string MaPhong = dgvHopDong.Rows[vitri].Cells[1].Value.ToString();
                string NgayLapHD = dgvHopDong.Rows[vitri].Cells[2].Value.ToString();
                string TrangThai = dgvHopDong.Rows[vitri].Cells[3].Value.ToString();

                data.ExcuteNonquery("delete from hopdong where MaHopDong = '" + MaHopDong + "'");
                MessageBox.Show("Xóa HopDong " + MaHopDong + " thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (dgvHopDong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng dữ liệu để sửa!");
                return;
            }


            try
            {
                int vitri = dgvHopDong.CurrentCell.RowIndex;
                string MaHopDong = dgvHopDong.Rows[vitri].Cells[0].Value.ToString();
                string MaPhong = dgvHopDong.Rows[vitri].Cells[1].Value.ToString();
                string NgayLapHD = dgvHopDong.Rows[vitri].Cells[2].Value.ToString();
                string TrangThai = dgvHopDong.Rows[vitri].Cells[3].Value.ToString();

                txtMaHopDong.Text = MaHopDong;
                txtMaPhong.Text = MaPhong;
                dateTimePicker1.Text = NgayLapHD;
                txtTrangThaiHD.Text = TrangThai;

                txtMaHopDong.Enabled = true;
                txtMaPhong.Enabled = true;
                dateTimePicker1.Enabled = true;
                txtTrangThaiHD.Enabled = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source= LAPTOP-EK26VL1R\SQLEXPRESS; Initial Catalog = QLPhongTro; Integrated Security =True "))
                {
                    conn.Open();

                    string query = "UPDATE hopdong SET MaPhong = @MaPhong, NgayLapHopDong = @NgayLapHopDong, TrangThaiHopDong = @TrangThaiHopDong WHERE MaHopDong = @MaHopDong";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaHopDong", txtMaHopDong.Text);
                        cmd.Parameters.AddWithValue("@MaPhong", txtMaPhong.Text);
                        cmd.Parameters.AddWithValue("@NgayLapHopDong", dateTimePicker1.Value); // Chuyển thành DateTime
                        cmd.Parameters.AddWithValue("@TrangThai", txtTrangThaiHD.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Sửa thông tin thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        loadData();

                        txtMaHopDong.Text = "";
                        txtMaPhong.Text = "";
                        dateTimePicker1.Text = "";
                        txtTrangThaiHD.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTrangChu TrangChu = new frmTrangChu();
            TrangChu.Show();
        }

        private void btnQLP_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyPhong ThongTinPhong = new frmQuanLyPhong();
            ThongTinPhong.Show();
        }

        private void btnQLDV_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyDichVu QuanLyDichVu = new frmQuanLyDichVu();
            QuanLyDichVu.Show();
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyKhachHang QLKH = new frmQuanLyKhachHang();
            QLKH.Show();
        }

        private void btnQLHD_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnQLHDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyHoaDon QLHDon = new frmQuanLyHoaDon();
            QLHDon.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắn chắn muốn đăng xuất ?",
                   "Thông báo",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                frmLogin DangNhap = new frmLogin();
                DangNhap.Show();
            }
        }

        private void txtMaHopDong_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblQuanLyTienNuoc_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMaPhong_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTrangThaiHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source= LAPTOP-EK26VL1R\SQLEXPRESS; Initial Catalog = QLPhongTro; Integrated Security =True "))
                {
                    conn.Open();

                    string query = "INSERT INTO chitiethopdong (MaChiTietHopDong, MaHopDong, NgayBatDau, NgayKetThuc,TienCoc) VALUES (@MaChiTietHopDong, @MaHopDong, @NgayBatDau, @NgayKetThuc,@TienCoc)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaChiTietHopDong", txtMaCTHD.Text);
                        cmd.Parameters.AddWithValue("@MaHopDong", txtMaHD_CTHD.Text);
                        cmd.Parameters.AddWithValue("@NgayBatDau", dateTimePickerNgayBD.Value); // Chuyển thành DateTime
                        cmd.Parameters.AddWithValue("@NgayKetThuc", dateTimePickerNgayKT.Value); // Chuyển thành DateTime
                        cmd.Parameters.AddWithValue("@TienCoc", txtTienCoc.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Thêm Hợp đồng chi tiết mới thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();

                        txtMaCTHD.Text = "";
                        txtMaHD_CTHD.Text = "";
                        dateTimePickerNgayBD.Text = "";
                        dateTimePickerNgayKT.Text = "";
                        txtTienCoc.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa2_Click(object sender, EventArgs e)
        {

            try
            {
            int vitri = dgvCTHDong.CurrentCell.RowIndex;
            string MaCTHD = dgvCTHDong.Rows[vitri].Cells[0].Value.ToString();
            string MaHopDong = dgvCTHDong.Rows[vitri].Cells[1].Value.ToString();
            string NgayBD = dgvCTHDong.Rows[vitri].Cells[2].Value.ToString();
            string NgayKT = dgvCTHDong.Rows[vitri].Cells[3].Value.ToString();
            string TienCoc = dgvCTHDong.Rows[vitri].Cells[4].Value.ToString();

               data.ExcuteNonquery("delete from ChiTietHopDong where MaChiTietHopDong = '" + MaCTHD + "'");
                MessageBox.Show("Xóa ChiTietHopDong " + MaCTHD + " thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void btnSua2_Click(object sender, EventArgs e)
        {
            if (dgvCTHDong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng dữ liệu để sửa!");
                return;
            }


            try
            {
                int vitri = dgvCTHDong.CurrentCell.RowIndex;
                string MaCTHD = dgvCTHDong.Rows[vitri].Cells[0].Value.ToString();
                string MaHopDong = dgvCTHDong.Rows[vitri].Cells[1].Value.ToString();
                string NgayBD = dgvCTHDong.Rows[vitri].Cells[2].Value.ToString();
                string NgayKT = dgvCTHDong.Rows[vitri].Cells[3].Value.ToString();
                string TienCoc = dgvCTHDong.Rows[vitri].Cells[4].Value.ToString();

                txtMaCTHD.Text = MaCTHD;
                txtMaHD_CTHD.Text = MaHopDong;
                dateTimePickerNgayBD.Text = NgayBD;
                dateTimePickerNgayKT.Text = NgayKT;
                txtTienCoc.Text = TienCoc;

                txtMaCTHD.Enabled = true;
                txtMaHD_CTHD.Enabled = true;
               dateTimePickerNgayBD.Enabled = true;
                dateTimePickerNgayKT.Enabled = true;
                txtTienCoc.Enabled = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLuu2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source= LAPTOP-EK26VL1R\SQLEXPRESS; Initial Catalog = QLPhongTro; Integrated Security =True "))
                {
                    conn.Open();

                    string query = "UPDATE ChiTietHopDong SET  MaHopDong = @MaHopDong, NgayBatDau = @NgayBatDau, NgayKetThuc = @NgayKetThuc, TienCoc = @Tiencoc WHERE MaChiTietHopDong = @MaChiTietHopDong";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@MaChiTietHopDong", txtMaCTHD.Text);
                        cmd.Parameters.AddWithValue("@MaHopDong", txtMaHD_CTHD.Text);
                        cmd.Parameters.AddWithValue("@NgayBatDau", dateTimePickerNgayBD.Value); // Chuyển thành DateTime
                        cmd.Parameters.AddWithValue("@NgayKetThuc", dateTimePickerNgayKT.Value); // Chuyển thành DateTime
                        cmd.Parameters.AddWithValue("@TienCoc", txtTienCoc.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Sửa thông tin chi tiết hợp đồng thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        loadData();

                        txtMaCTHD.Text = "";
                        txtMaHD_CTHD.Text = "";
                        dateTimePickerNgayBD.Text = "";
                        dateTimePickerNgayKT.Text = "";
                        txtTienCoc.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            txtMaCTHD.Text = "";
            txtMaHD_CTHD.Text = "";
            dateTimePickerNgayBD.Text = "";
            dateTimePickerNgayKT.Text = "";
            txtTienCoc.Text = "";
        }

        private void grpCTHDong_Enter(object sender, EventArgs e)
        {
        
        }

        private void dgvCTHDong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvCTHDong.Rows[e.RowIndex];

                txtMaCTHD.Text = selectedRow.Cells[0].Value.ToString();
                txtMaHD_CTHD.Text = selectedRow.Cells[1].Value.ToString();
                dateTimePickerNgayBD.Text = selectedRow.Cells[2].Value.ToString();
                dateTimePickerNgayKT.Text = selectedRow.Cells[3].Value.ToString();
                txtTienCoc.Text = selectedRow.Cells[4].Value.ToString();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string TimHD = txtTimPhong.Text;

            // Truy vấn lấy thông tin hợp đồng
            string queryHopDong = @"
        SELECT hd.MaHopDong, hd.MaPhong, hd.NgayLapHopDong, hd.TrangThaiHopDong
        FROM HopDong hd
        WHERE hd.MaPhong LIKE '%' + @MaPhong + '%'";

            // Truy vấn lấy thông tin chi tiết hợp đồng
            string queryChiTiet = @"
        SELECT ct.MaChiTietHopDong, ct.NgayBatDau, ct.NgayKetThuc, ct.TienCoc
        FROM HopDong hd
        INNER JOIN ChiTietHopDong ct ON hd.MaHopDong = ct.MaHopDong
        WHERE hd.MaPhong LIKE '%' + @MaPhong + '%'";

            using (SqlConnection conn = new SqlConnection(@"Data Source= LAPTOP-EK26VL1R\SQLEXPRESS; Initial Catalog = QLPhongTro; Integrated Security =True"))
            {
                using (SqlDataAdapter daHopDong = new SqlDataAdapter(queryHopDong, conn))
                {
                    using (SqlDataAdapter daChiTiet = new SqlDataAdapter(queryChiTiet, conn))
                    {
                        daHopDong.SelectCommand.Parameters.AddWithValue("@MaPhong", TimHD);
                        daChiTiet.SelectCommand.Parameters.AddWithValue("@MaPhong", TimHD);

                        DataTable dtHopDong = new DataTable();
                        daHopDong.Fill(dtHopDong);

                        DataTable dtChiTiet = new DataTable();
                        daChiTiet.Fill(dtChiTiet);

                        // Gán dữ liệu cho các DataGridView
                        dgvHopDong.DataSource = dtHopDong;
                        dgvCTHDong.DataSource = dtChiTiet;
                    }
                }
            }
        }
        private void btnResetdata_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
