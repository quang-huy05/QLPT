using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace Đồ_Án
{

    public partial class frmQuanLyPhong : Form
    {
        
        public frmQuanLyPhong()
        {

            InitializeComponent();

        }
        KetNoi data = new KetNoi();

        private void loadData()
        {
            string strPhongTro = "Select* from Phongtro";
            SqlDataAdapter daPhongTro = new SqlDataAdapter(strPhongTro, data.GetConnect());
            DataTable dtPhongTro = new DataTable();
            daPhongTro.Fill(dtPhongTro);
            dgvTTP.DataSource = dtPhongTro;

            string strLoaiPhong = "Select* from LoaiPhong";
            SqlDataAdapter daLoaiPhong = new SqlDataAdapter(strLoaiPhong, data.GetConnect());
            DataTable dtLoaiPhong = new DataTable();
            daLoaiPhong.Fill(dtLoaiPhong);
            dgvLoaiPhong.DataSource = dtLoaiPhong;
        }

        private void frmThongTinPhong_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void btnTim_Click(object sender, EventArgs e)
        {
            // Initialize variables
            string TimLoaiPhong = "";
            string TinhTrangPhong = "";

            // Get room status based on radio button selection
            if (radTrong.Checked)
            {
                TinhTrangPhong = "Trống";
            }
            else if (radDaThue.Checked)
            {
                TinhTrangPhong = "Đã Thuê";
            }

            // Set TimLoaiPhong based on combobox selection
            if (cboLoaiPhong.SelectedIndex == 0)
            {
                TimLoaiPhong = "LP001";
            }
            else if (cboLoaiPhong.SelectedIndex == 1)
            {
                TimLoaiPhong = "LP002";
            }
            else if (cboLoaiPhong.SelectedIndex == 2)
            {
                TimLoaiPhong = "LP003";
            }
            else if (cboLoaiPhong.SelectedIndex == 3)
            {
                TimLoaiPhong = "LP004";
            }

            // Build the SQL query (initial simplified version)
            string query = "SELECT * FROM Phongtro WHERE 1=1";

            // Add conditions based on selected filters
            if (!string.IsNullOrEmpty(TimLoaiPhong))
            {
                query += " AND MaLoaiPhong = @loaiphong ";
            }
            if (!string.IsNullOrEmpty(TinhTrangPhong))
            {
                query += " AND TrangThaiPhong = @TinhTrangPhong";
            }

            // Check if any filters are selected, otherwise show a message
            if (!string.IsNullOrEmpty(TimLoaiPhong) || !string.IsNullOrEmpty(TinhTrangPhong))
            {
                // Create SqlDataAdapter and populate DataTable
                SqlDataAdapter da = new SqlDataAdapter(query, data.GetConnect());

                if (!string.IsNullOrEmpty(TimLoaiPhong))
                {
                    da.SelectCommand.Parameters.AddWithValue("@loaiphong", TimLoaiPhong);
                }
                if (!string.IsNullOrEmpty(TinhTrangPhong))
                {
                    da.SelectCommand.Parameters.AddWithValue("@Tinhtrangphong", TinhTrangPhong);
                }

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvTTP.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại phòng hoặc chọn tình trạng phòng để tìm kiếm.");
            }
        }







        private void lblTextRun_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void lblThongTinPhong_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int vitri = dgvTTP.CurrentCell.RowIndex;
                string MaPhong = txtMaPhong.Text;
                string LoaiPhong = txtLoaiPhong.Text;
                string TinhTrang = txtTinhTrang.Text;
                data.ExcuteNonquery("insert into phongtro values ('" + MaPhong + "', N'" + LoaiPhong + "',N'" + TinhTrang + "')");
                MessageBox.Show("Thêm phòng mới thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();

                txtMaPhong.Text = "";
                txtLoaiPhong.Text = "";
                txtTinhTrang.Text = "";
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
                int vitri = dgvTTP.CurrentCell.RowIndex;
                string MaPhong = dgvTTP.Rows[vitri].Cells[0].Value.ToString();
                string LoaiPhong = dgvTTP.Rows[vitri].Cells[1].Value.ToString();
                string TinhTrang = dgvTTP.Rows[vitri].Cells[2].Value.ToString();
             

                data.ExcuteNonquery("delete from phongtro where MaPhong = '" + MaPhong + "'");
                MessageBox.Show("Xóa Phòng " + MaPhong + " thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (dgvTTP.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng muốn sửa thông tin!");
                return;
            }

            try
            {
                int selectedIndex = dgvTTP.CurrentCell.RowIndex;
                string MaPhong = dgvTTP.Rows[selectedIndex].Cells[0].Value.ToString();

                if (txtMaLP.Enabled)
                {
                    // Cập nhật dữ liệu
                    using (SqlConnection conn = new SqlConnection(@"Data Source= LAPTOP-EK26VL1R\SQLEXPRESS; Initial Catalog = QLPhongTro; Integrated Security =True "))
                    {
                        conn.Open();


                        string query = "UPDATE Phongtro SET  Maloaiphong = @Maloaiphong, Trangthaiphong = @tinhtrang WHERE Maphong = @Maphong";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaPhong", txtMaPhong.Text);
                            cmd.Parameters.AddWithValue("@Maloaiphong", txtLoaiPhong.Text);
                            cmd.Parameters.AddWithValue("@tinhtrang", txtTinhTrang.Text);


                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Cập nhật giao diện
                                dgvTTP.Rows[selectedIndex].Cells[1].Value = txtLoaiPhong.Text;
                                dgvTTP.Rows[selectedIndex].Cells[2].Value = txtTinhTrang.Text;


                                dgvTTP.Rows[selectedIndex].DefaultCellStyle.BackColor = Color.White;

                                MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadData();

                                txtMaPhong.Text = "";
                                txtLoaiPhong.Text = "";
                                txtTinhTrang.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Không cập nhật được dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    txtMaPhong.Enabled = true;
                    txtLoaiPhong.Enabled = true;
                    txtTinhTrang.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        

        private void dgvTTP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvTTP.Rows[e.RowIndex];

                txtMaPhong.Text = selectedRow.Cells[0].Value.ToString();
                txtLoaiPhong.Text = selectedRow.Cells[1].Value.ToString();
                txtTinhTrang.Text = selectedRow.Cells[2].Value.ToString();

            }
        }


        private void lblMaPhong_Click(object sender, EventArgs e)
        {

        }

        private void lblLoaiPhong_Click(object sender, EventArgs e)
        {

        }

        private void lblGiaThue_Click(object sender, EventArgs e)
        {

        }

        private void lblSoNguoi_Click(object sender, EventArgs e)
        {

        }

        private void lblTinhTrang_Click(object sender, EventArgs e)
        {

        }

        private void txtTinhTrang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoNguoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGiaThue_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLoaiPhong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaPhong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQLP_Click_1(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnTrangChu_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmTrangChu TrangChu = new frmTrangChu();
            TrangChu.Show();
        }

        private void btnQLDV_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyDichVu QLDV = new frmQuanLyDichVu();
            QLDV.Show();
        }

        private void btnQLKH_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyKhachHang QLKH = new frmQuanLyKhachHang();
            QLKH.Show();
        }

        private void btnQLHD_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyHopDong QLHD = new frmQuanLyHopDong();
            QLHD.Show();
        }

        private void btnQLHDon_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyHoaDon QLHDon = new frmQuanLyHoaDon();
            QLHDon.Show();
        }

        private void btnDangXuat_Click_1(object sender, EventArgs e)
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

        private void btnXemPhong_Click(object sender, EventArgs e)
        {
            frmXemPhong XemPhong = new frmXemPhong();
            XemPhong.Show();
        }

        private void btnThemLP_Click(object sender, EventArgs e)
        {
            try
            {
                int vitri = dgvLoaiPhong.CurrentCell.RowIndex;
                string MaLoaiPhong = txtMaLP.Text;
                string GiaThue = txtGiaThueLP.Text;
                string SoNguoi = txtSoNguoi.Text;
                data.ExcuteNonquery("insert into Loaiphong values ('" + MaLoaiPhong + "', N'" + GiaThue + "','" + SoNguoi + "')");
                MessageBox.Show("Thêm loại phòng mới thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();

                txtMaLP.Text = "";
               txtGiaThueLP.Text = "";
                txtSoNguoi.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCapNhatLP_Click(object sender, EventArgs e)
        {
            if (dgvLoaiPhong.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn loại phòng muốn sửa thông tin!");
                return;
            }

            try
            {
                int selectedIndex = dgvLoaiPhong.CurrentCell.RowIndex;
                string MaHoaDon =dgvLoaiPhong.Rows[selectedIndex].Cells[0].Value.ToString();

                if (txtMaLP.Enabled) 
                {
                    // Cập nhật dữ liệu
                    using (SqlConnection conn = new SqlConnection(@"Data Source= LAPTOP-EK26VL1R\SQLEXPRESS; Initial Catalog = QLPhongTro; Integrated Security =True "))
                    {
                        conn.Open();


                        string query = "UPDATE Loaiphong SET  Giathue = @GiaThue, SoNguoi = @SoNguoi WHERE Maloaiphong = @Maloaiphong";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaLoaiPhong", txtMaLP.Text);
                            cmd.Parameters.AddWithValue("@GiaThue", txtGiaThueLP.Text);
                            cmd.Parameters.AddWithValue("@SoNguoi", txtSoNguoi.Text);


                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Cập nhật giao diện
                                dgvLoaiPhong.Rows[selectedIndex].Cells[1].Value = txtGiaThueLP.Text;
                                dgvLoaiPhong.Rows[selectedIndex].Cells[2].Value = txtSoNguoi.Text;


                                dgvLoaiPhong.Rows[selectedIndex].DefaultCellStyle.BackColor = Color.White;

                                MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadData();

                               txtMaLP.Text = "";
                                txtGiaThueLP.Text = "";
                                txtSoNguoi.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Không cập nhật được dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    txtMaLP.Enabled = true;
                    txtGiaThueLP.Enabled = true;
                    txtSoNguoi.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnXoaLP_Click(object sender, EventArgs e)
        {
            try
            {
                int vitri = dgvLoaiPhong.CurrentCell.RowIndex;
                string MaLoaiPhong = dgvLoaiPhong.Rows[vitri].Cells[0].Value.ToString();
                string GiaThue = dgvLoaiPhong.Rows[vitri].Cells[1].Value.ToString();
                string SoNguoi = dgvLoaiPhong.Rows[vitri].Cells[2].Value.ToString();
                

                data.ExcuteNonquery("delete from loaiphong where MaLoaiPhong = '" + MaLoaiPhong + "'");
                MessageBox.Show("Đã xóa Loại Phòng " + MaLoaiPhong + " khỏi danh sách !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvLoaiPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvLoaiPhong.Rows[e.RowIndex];

                txtMaLP.Text = selectedRow.Cells[0].Value.ToString();
                txtGiaThueLP.Text = selectedRow.Cells[1].Value.ToString();
                txtSoNguoi.Text = selectedRow.Cells[2].Value.ToString();

            }
        }
    }
}
