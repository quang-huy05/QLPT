using Microsoft.ReportingServices.ReportProcessing.OnDemandReportObjectModel;
using PdfSharp.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System;
using System.Windows.Forms;


namespace Đồ_Án
{
    public partial class frmQuanLyHoaDon : Form
    {
        public frmQuanLyHoaDon()
        {
            InitializeComponent();
        }
        KetNoi data = new KetNoi();

        private void loadData()
        {
            string strHDD = "Select* from HoaDonDien";
            SqlDataAdapter daHDD = new SqlDataAdapter(strHDD, data.GetConnect());
            DataTable dtHDD = new DataTable();
            daHDD.Fill(dtHDD);
            dgvHDD.DataSource = dtHDD;

            string strHDN = "Select* from HoaDonNuoc";
            SqlDataAdapter daHDN = new SqlDataAdapter(strHDN, data.GetConnect());
            DataTable dtHDN = new DataTable();
            daHDN.Fill(dtHDN);
            dgvHDN.DataSource = dtHDN;

            string strHDDV = "Select* from HoaDonDichVu";
            SqlDataAdapter daHDDV = new SqlDataAdapter(strHDDV, data.GetConnect());
            DataTable dtHDDV = new DataTable();
            daHDDV.Fill(dtHDDV);
            dgvHDDV.DataSource = dtHDDV;

            string strHDT = "Select* from HoaDonTong";
            SqlDataAdapter daHDT = new SqlDataAdapter(strHDT, data.GetConnect());
            DataTable dtHDT = new DataTable();
            daHDT.Fill(dtHDT);
            dgvHoaDonTong.DataSource = dtHDT;
        }
        private void frmQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            loadData();
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string TimHD = txtTimHoaDon.Text;

            // Truy vấn cho từng loại hóa đơn
            string queryHoaDonDien = @"
        SELECT * FROM HoaDonDien WHERE MaPhong LIKE '%' + @MaPhong + '%'";
            string queryHoaDonNuoc = @"
        SELECT * FROM HoaDonNuoc WHERE MaPhong LIKE '%' + @MaPhong + '%'";
            string queryHoaDonTong = @"
        SELECT * FROM HoaDonTong WHERE MaPhong LIKE '%' + @MaPhong + '%'";
            string queryHoaDonDichVu = @"
        SELECT HDDV.* FROM HoaDonDichVu HDDV
        INNER JOIN HoaDonTong HDT ON HDDV.MaHoaDon = HDT.MaHoaDon
        WHERE HDT.MaPhong LIKE '%' + @MaPhong + '%'";

            using (SqlConnection conn = new SqlConnection(@"Data Source= LAPTOP-EK26VL1R\SQLEXPRESS; Initial Catalog = QLPhongTro; Integrated Security =True"))
            {
                conn.Open();

                // Tạo các SqlDataAdapter và DataTable tương ứng
                using (SqlDataAdapter daHoaDonDien = new SqlDataAdapter(queryHoaDonDien, conn))
                using (SqlDataAdapter daHoaDonNuoc = new SqlDataAdapter(queryHoaDonNuoc, conn))
                using (SqlDataAdapter daHoaDonTong = new SqlDataAdapter(queryHoaDonTong, conn))
                using (SqlDataAdapter daHoaDonDichVu = new SqlDataAdapter(queryHoaDonDichVu, conn))
                {
                    daHoaDonDien.SelectCommand.Parameters.AddWithValue("@MaPhong", TimHD);
                    daHoaDonNuoc.SelectCommand.Parameters.AddWithValue("@MaPhong", TimHD);
                    daHoaDonTong.SelectCommand.Parameters.AddWithValue("@MaPhong", TimHD);
                    daHoaDonDichVu.SelectCommand.Parameters.AddWithValue("@MaPhong", TimHD);

                    DataTable dtHoaDonDien = new DataTable();
                    DataTable dtHoaDonNuoc = new DataTable();
                    DataTable dtHoaDonTong = new DataTable();
                    DataTable dtHoaDonDichVu = new DataTable();

                    daHoaDonDien.Fill(dtHoaDonDien);
                    daHoaDonNuoc.Fill(dtHoaDonNuoc);
                    daHoaDonTong.Fill(dtHoaDonTong);
                    daHoaDonDichVu.Fill(dtHoaDonDichVu);

                    // Gán dữ liệu cho các DataGridView
                    dgvHDD.DataSource = dtHoaDonDien;
                    dgvHDN.DataSource = dtHoaDonNuoc;
                    dgvHoaDonTong.DataSource = dtHoaDonTong;
                    dgvHDDV.DataSource = dtHoaDonDichVu;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTrangChu TrangChu = new frmTrangChu();
            TrangChu.Show();
        }
        private void mnuQuanLyPhong_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyPhong QLP = new frmQuanLyPhong();
            QLP.Show();
        }


        private void mnuQLDV_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyDichVu QLDV = new frmQuanLyDichVu();
            QLDV.Show();
        }

        private void mnuQLKH_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyKhachHang QLKH = new frmQuanLyKhachHang();
            QLKH.Show();
        }

        private void mnuQLHDong_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyHopDong QuanLyHopDong = new frmQuanLyHopDong();
            QuanLyHopDong.Show();
        }

        private void mnuQLHD_Click(object sender, EventArgs e)
        {
            this.Show();
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
                frmLogin DangNhap = new frmLogin();
                DangNhap.Show();
            }
        }

        private void btnXemDV_Click(object sender, EventArgs e)
        {
            frmDSDV DanhSachDichVu = new frmDSDV();
            DanhSachDichVu.Show();
        }


        private void btnThem1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source= LAPTOP-EK26VL1R\SQLEXPRESS; Initial Catalog = QLPhongTro; Integrated Security =True "))
                {
                    conn.Open();

                    string query = "INSERT INTO HoaDonDien (MaHoaDonDien, MaPhong, ChiSoCu, ChiSoMoi, ThoiGian) VALUES (@MaHoaDonDien, @MaPhong, @ChiSoCu, @ChiSoMoi, @ThoiGian)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaHoaDonDien", txtMaHDD.Text);
                        cmd.Parameters.AddWithValue("@MaPhong", txtPhongDien.Text);
                        
                        cmd.Parameters.AddWithValue("@ChiSoCu", Convert.ToInt32(txtCSCDien.Text));
                        cmd.Parameters.AddWithValue("@ChiSoMoi", Convert.ToInt32(txtCSMDien.Text));
                        cmd.Parameters.AddWithValue("@ThoiGian", dateTimePickerDien.Value);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Thêm Hóa đơn điện mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();

                        txtMaHDD.Text = "";
                        txtPhongDien.Text = "";
                        dateTimePickerDien.Text = "";
                        txtCSCDien.Text = "";
                        txtCSMDien.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua1_Click(object sender, EventArgs e)
        {
            if (dgvHDD.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn muốn sửa!");
                return;
            }

            try
            {
                int selectedIndex = dgvHDD.CurrentCell.RowIndex;
                string MaHoaDonDien = dgvHDD.Rows[selectedIndex].Cells[0].Value.ToString();

                if (txtMaHDD.Enabled) // Kiểm tra xem có đang sửa hay không
                {
                    // Cập nhật dữ liệu
                    using (SqlConnection conn = new SqlConnection(@"Data Source= LAPTOP-EK26VL1R\SQLEXPRESS; Initial Catalog = QLPhongTro; Integrated Security =True "))
                    {
                        conn.Open();

                        // Tính toán thành tiền (nếu cần thiết, có thể bỏ qua nếu đã tính toán trong SQL)
                        int chiSoCu = Convert.ToInt32(txtCSCDien.Text);
                        int chiSoMoi = Convert.ToInt32(txtCSMDien.Text);
                        decimal giaTien = 3500;

                        decimal thanhTien = (chiSoMoi - chiSoCu) * giaTien;
                        // Loại bỏ cột ThanhTien khỏi câu lệnh UPDATE
                        string query = "UPDATE HoaDonDien SET MaPhong = @MaPhong, ChiSoCu = @ChiSoCu, ChiSoMoi = @CSM, Thoigian = @Thoigian WHERE MaHoaDonDien = @MaHoaDonDien";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaHoaDonDien", txtMaHDD.Text);
                            cmd.Parameters.AddWithValue("@MaPhong", txtPhongDien.Text);
                            cmd.Parameters.AddWithValue("@ChiSoCu", chiSoCu);
                            cmd.Parameters.AddWithValue("@CSM", chiSoMoi);
                            cmd.Parameters.AddWithValue("@Thoigian", dateTimePickerDien.Value);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Cập nhật giao diện
                                dgvHDD.Rows[selectedIndex].Cells[1].Value = txtPhongDien.Text; // Sửa cột nếu cần
                                dgvHDD.Rows[selectedIndex].Cells[2].Value = chiSoCu;
                                dgvHDD.Rows[selectedIndex].Cells[3].Value = chiSoMoi;
                                dgvHDD.Rows[selectedIndex].Cells["ThanhTien"].Value = thanhTien;

                                dgvHDD.Rows[selectedIndex].DefaultCellStyle.BackColor = Color.White; // Màu nền tạm thời

                                MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadData();

                                txtMaHDD.Text = "";
                                txtPhongDien.Text = "";
                                dateTimePickerDien.Text = "";
                                txtCSCDien.Text = "";
                                txtCSMDien.Text = "";
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
                    txtMaHDD.Enabled = true;
                    txtPhongDien.Enabled = true;
                    dateTimePickerDien.Enabled = true;
                    txtCSCDien.Enabled = true;
                    txtCSMDien.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            try
            {
                int vitri = dgvHDD.CurrentCell.RowIndex;
                string MaHoaDonDien = dgvHDD.Rows[vitri].Cells[0].Value.ToString();
                string MaPhong = dgvHDD.Rows[vitri].Cells[1].Value.ToString();
                string CSC = dgvHDD.Rows[vitri].Cells[2].Value.ToString();
                string CSM = dgvHDD.Rows[vitri].Cells[3].Value.ToString();
                string ThanhTien = dgvHDD.Rows[vitri].Cells[4].Value.ToString();
                string ThoiGian = dgvHDD.Rows[vitri].Cells[5].Value.ToString();

                data.ExcuteNonquery("delete from hoadondien where MaHoaDonDien = '" + MaHoaDonDien + "'");
                MessageBox.Show("Xóa Hóa đơn " + MaHoaDonDien + " thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvHDD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvHDD.Rows[e.RowIndex];

                txtMaHDD.Text = selectedRow.Cells[0].Value.ToString();
                txtPhongDien.Text = selectedRow.Cells[1].Value.ToString();
                txtCSCDien.Text = selectedRow.Cells[2].Value.ToString();
                txtCSMDien.Text = selectedRow.Cells[3].Value.ToString();
                dateTimePickerDien.Text = selectedRow.Cells[5].Value.ToString();
            }
        }

        private void btnThem2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source= LAPTOP-EK26VL1R\SQLEXPRESS; Initial Catalog = QLPhongTro; Integrated Security =True "))
                {
                    conn.Open();

                    string query = "INSERT INTO HoaDonNuoc (MaHoaDonNuoc, MaPhong, ChiSoCu, ChiSoMoi, ThoiGian) VALUES (@MaHoaDonNuoc, @MaPhong, @ChiSoCu, @ChiSoMoi, @ThoiGian)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaHoaDonNuoc", txtMaHDN.Text);
                        cmd.Parameters.AddWithValue("@MaPhong", txtPhongNuoc.Text);

                        cmd.Parameters.AddWithValue("@ChiSoCu", Convert.ToInt32(txtCSCN.Text));
                        cmd.Parameters.AddWithValue("@ChiSoMoi", Convert.ToInt32(txtCSMN.Text));
                        cmd.Parameters.AddWithValue("@ThoiGian", dateTimePickerNuoc.Value);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Thêm Hóa đơn nước mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();

                        txtMaHDN.Text = "";
                        txtPhongNuoc.Text = "";
                        dateTimePickerNuoc.Text = "";
                        txtCSCN.Text = "";
                        txtCSMN.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua2_Click(object sender, EventArgs e)
        {
            if (dgvHDD.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn muốn sửa!");
                return;
            }

            try
            {
                int selectedIndex = dgvHDN.CurrentCell.RowIndex;
                string MaHoaDonNuoc = dgvHDN.Rows[selectedIndex].Cells[0].Value.ToString();

                if (txtMaHDN.Enabled) // Kiểm tra xem có đang sửa hay không
                {
                    // Cập nhật dữ liệu
                    using (SqlConnection conn = new SqlConnection(@"Data Source= LAPTOP-EK26VL1R\SQLEXPRESS; Initial Catalog = QLPhongTro; Integrated Security =True "))
                    {
                        conn.Open();

                        // Tính toán thành tiền (nếu cần thiết, có thể bỏ qua nếu đã tính toán trong SQL)
                        int chiSoCu = Convert.ToInt32(txtCSCN.Text);
                        int chiSoMoi = Convert.ToInt32(txtCSMN.Text);
                        decimal giaNuoc = 20000;

                        decimal thanhTien = (chiSoMoi - chiSoCu) * giaNuoc;
                        // Loại bỏ cột ThanhTien khỏi câu lệnh UPDATE
                        string query = "UPDATE HoaDonNuoc SET MaPhong = @MaPhong, ChiSoCu = @ChiSoCu, ChiSoMoi = @CSM, Thoigian = @Thoigian WHERE MaHoaDonNuoc = @MaHoaDonNuoc";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaHoaDonNuoc", txtMaHDN.Text);
                            cmd.Parameters.AddWithValue("@MaPhong", txtPhongNuoc.Text);
                            cmd.Parameters.AddWithValue("@ChiSoCu", chiSoCu);
                            cmd.Parameters.AddWithValue("@CSM", chiSoMoi);
                            cmd.Parameters.AddWithValue("@Thoigian", dateTimePickerNuoc.Value);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Cập nhật giao diện
                                dgvHDN.Rows[selectedIndex].Cells[1].Value = txtPhongNuoc.Text; 
                                dgvHDN.Rows[selectedIndex].Cells[2].Value = chiSoCu;
                                dgvHDN.Rows[selectedIndex].Cells[3].Value = chiSoMoi;
                                dgvHDN.Rows[selectedIndex].Cells["ThanhTien"].Value = thanhTien;

                                dgvHDN.Rows[selectedIndex].DefaultCellStyle.BackColor = Color.White; 

                                MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadData();

                                txtMaHDN.Text = "";
                                txtPhongNuoc.Text = "";
                                dateTimePickerNuoc.Text = "";
                                txtCSCN.Text = "";
                                txtCSMN.Text = "";
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
                    txtMaHDD.Enabled = true;
                    txtPhongDien.Enabled = true;
                    dateTimePickerDien.Enabled = true;
                    txtCSCDien.Enabled = true;
                    txtCSMDien.Enabled = true;
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
                int vitri = dgvHDN.CurrentCell.RowIndex;
                string MaHoaDonNuoc = dgvHDN.Rows[vitri].Cells[0].Value.ToString();
                string MaPhong = dgvHDN.Rows[vitri].Cells[1].Value.ToString();
                string CSC = dgvHDN.Rows[vitri].Cells[2].Value.ToString();
                string CSM = dgvHDN.Rows[vitri].Cells[3].Value.ToString();
                string ThanhTien = dgvHDN.Rows[vitri].Cells[4].Value.ToString();
                string ThoiGian = dgvHDN.Rows[vitri].Cells[5].Value.ToString();

                data.ExcuteNonquery("delete from hoadonnuoc where MaHoaDonNuoc = '" + MaHoaDonNuoc + "'");
                MessageBox.Show("Xóa Hóa đơn " + MaHoaDonNuoc + " thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvHDN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvHDN.Rows[e.RowIndex];

                txtMaHDN.Text = selectedRow.Cells[0].Value.ToString();
                txtPhongNuoc.Text = selectedRow.Cells[1].Value.ToString();
                txtCSCN.Text = selectedRow.Cells[2].Value.ToString();
                txtCSMN.Text = selectedRow.Cells[3].Value.ToString();
                dateTimePickerNuoc.Text = selectedRow.Cells[5].Value.ToString();
            }
        }
        private void dgvHDDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvHDDV.Rows[e.RowIndex];

                txtMaHDDV.Text = selectedRow.Cells[0].Value.ToString();
                txtMaDV.Text = selectedRow.Cells[1].Value.ToString();
                txtSoLuong.Text = selectedRow.Cells[2].Value.ToString();

            }
        }
        private void btnThemDV_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source= LAPTOP-EK26VL1R\SQLEXPRESS; Initial Catalog = QLPhongTro; Integrated Security =True "))
                {
                    conn.Open();

                    string query = "INSERT INTO HoaDonDichVu (MaHoaDon, MaDichVu, SoLuong) VALUES (@MaHoaDon, @MaDichVu, @SoLuong)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaHoaDon", txtMaHDN.Text);
                        cmd.Parameters.AddWithValue("@MaDichVu", txtPhongNuoc.Text);

                        cmd.Parameters.AddWithValue("@SoLuong", Convert.ToInt32(txtSoLuong.Text));


                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Tạo Hóa đơn dịch vụ mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();

                        txtMaHDDV.Text = "";
                        txtMaDV.Text = "";
                        txtSoLuong.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            try
            {
                int vitri = dgvHDDV.CurrentCell.RowIndex;
                string MaHoaDon = dgvHDDV.Rows[vitri].Cells[0].Value.ToString();
                string MaDichVu = dgvHDDV.Rows[vitri].Cells[1].Value.ToString();
                string SoLuong = dgvHDDV.Rows[vitri].Cells[2].Value.ToString();
                string ThanhTien = dgvHDDV.Rows[vitri].Cells[3].Value.ToString();


                data.ExcuteNonquery("delete from hoadondichvu where MaHoaDon = '" + MaHoaDon + "'");
                MessageBox.Show("Xóa Hóa đơn " + MaHoaDon + " thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            if (dgvHDDV.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn muốn sửa!");
                return;
            }

            try
            {
                int selectedIndex = dgvHDDV.CurrentCell.RowIndex;
                string MaHoaDon = dgvHDDV.Rows[selectedIndex].Cells[0].Value.ToString();

                if (txtMaHDDV.Enabled) // Kiểm tra xem có đang sửa hay không
                {
                    // Cập nhật dữ liệu
                    using (SqlConnection conn = new SqlConnection(@"Data Source= LAPTOP-EK26VL1R\SQLEXPRESS; Initial Catalog = QLPhongTro; Integrated Security =True "))
                    {
                        conn.Open();

                        // Tính toán thành tiền (nếu cần thiết, có thể bỏ qua nếu đã tính toán trong SQL)
                        int SoLuong = Convert.ToInt32(txtSoLuong.Text);

                        string query = "UPDATE HoaDonDichVu SET MaDichVu = @MaDichVu, SoLuong = @SoLuong WHERE MaHoaDon = @MaHoaDon";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaHoaDon", txtMaHDDV.Text);
                            cmd.Parameters.AddWithValue("@MaDichVu", txtMaDV.Text);
                            cmd.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);


                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Cập nhật giao diện
                                dgvHDDV.Rows[selectedIndex].Cells[1].Value = txtMaDV.Text;
                                dgvHDDV.Rows[selectedIndex].Cells[2].Value = txtSoLuong.Text;
  

                                dgvHDN.Rows[selectedIndex].DefaultCellStyle.BackColor = Color.White;

                                MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadData();

                                txtMaHDDV.Text = "";
                                txtMaDV.Text = "";
                                txtSoLuong.Text = "";
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
                    txtMaHDDV.Enabled = true;
                    txtMaDV.Enabled = true;
                    txtSoLuong.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }


        
        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            frmReport BaoCao = new frmReport();
            BaoCao.ShowDialog();
        }
    }
}
