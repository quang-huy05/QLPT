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

namespace Đồ_Án
{

    public partial class frmQuanLyDichVu : Form
    {
        
        public frmQuanLyDichVu()
        {
            InitializeComponent();

        }
        KetNoi data = new KetNoi();

        private void loadData()
        {
            string str = "Select* from DichVu";
            SqlDataAdapter da = new SqlDataAdapter(str, data.GetConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDichVu.DataSource = dt;

        }
        private void frmQuanLyDichVu_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void RoomButton_Click(object sender, EventArgs e)
        {
            // Đặt lại màu viền của tất cả các nút phòng
            foreach (Button btn in flowLayoutPanel1.Controls)
            {
                btn.FlatStyle = FlatStyle.Standard;
            }

            // Thiết lập viền nổi bật cho nút phòng được chọn
            Button selectedButton = (Button)sender;
            selectedButton.FlatStyle = FlatStyle.Popup;
            selectedButton.FlatAppearance.BorderColor = Color.Red;
            selectedButton.FlatAppearance.BorderSize = 2;


        }
        

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTrangChu trangChu = new frmTrangChu();
            trangChu.Show();
        }

        private void mnuThongTinPhong_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyPhong ThongTinPhong = new frmQuanLyPhong();
            ThongTinPhong.Show();
        }

        private void mnuQuanLyDichVu_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void mnuQuanLyTienDien_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyKhachHang QLKH = new frmQuanLyKhachHang();
            QLKH.Show();
        }

        private void mnuQuanLyTienNuoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyHopDong QuanLyTienNuoc = new frmQuanLyHopDong();
            QuanLyTienNuoc.Show();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắn chắn muốn đăng xuất ?",
               "Thông báo",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if ( result == DialogResult.Yes)
            {
                this.Hide();
                frmLogin DangNhap = new frmLogin();
                DangNhap.Show();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {

        }


        private void txtSoNguoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTextRun.Text = lblTextRun.Text.Substring(1, int.Parse(lblTextRun.Text.Length.ToString()) - 1) + lblTextRun.Text.Substring(0, 1);

        }

        private void dgvDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvDichVu.Rows[e.RowIndex];

                txtMaDV.Text = selectedRow.Cells[0].Value.ToString();
                txtTenDV.Text = selectedRow.Cells[1].Value.ToString();
                txtGiaDV.Text = selectedRow.Cells[2].Value.ToString();
                richTextboxMota.Text = selectedRow.Cells[3].Value.ToString();

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int vitri = dgvDichVu.CurrentCell.RowIndex;
                string MaDV = txtMaDV.Text;
                string TenDV = txtTenDV.Text;
                string GiaDV = txtGiaDV.Text;
                string MoTa = richTextboxMota.Text;
                data.ExcuteNonquery("insert into DichVu values ('" + MaDV + "', N'" + TenDV + "','" + GiaDV + "',N'" + MoTa + "')");
                MessageBox.Show("Thêm dịch vụ mới thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();

                txtMaDV.Text = "";
                txtTenDV.Text = "";
                txtGiaDV.Text = "";
                richTextboxMota.Text = "";
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
                int vitri = dgvDichVu.CurrentCell.RowIndex;
                string MaDV = dgvDichVu.Rows[vitri].Cells[0].Value.ToString();
                string TenDV = dgvDichVu.Rows[vitri].Cells[1].Value.ToString();
                string GiaDV = dgvDichVu.Rows[vitri].Cells[2].Value.ToString();
                string MoTa = dgvDichVu.Rows[vitri].Cells[3].Value.ToString();

                data.ExcuteNonquery("delete from DichVu where MaDichVu = '" + MaDV + "'");
                MessageBox.Show("Xóa dịch vụ " + MaDV + " thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (dgvDichVu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng dữ liệu để sửa!");
                return;
            }


            try
            {
                int vitri = dgvDichVu.CurrentCell.RowIndex;
                string MaDV = dgvDichVu.Rows[vitri].Cells[0].Value.ToString();
                string TenDV = dgvDichVu.Rows[vitri].Cells[1].Value.ToString();
                string GiaDV = dgvDichVu.Rows[vitri].Cells[2].Value.ToString();
                string MoTa = dgvDichVu.Rows[vitri].Cells[3].Value.ToString();


                txtMaDV.Text = MaDV;
                txtTenDV.Text = TenDV;
                txtGiaDV.Text = GiaDV;
                richTextboxMota.Text = MoTa;


                txtMaDV.Enabled = true;
                txtTenDV.Enabled = true;
                txtGiaDV.Enabled = true;
                richTextboxMota.Enabled = true;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            string MaDV = txtMaDV.Text;
            string TenDV = txtTenDV.Text;
            string GiaDV = txtGiaDV.Text;
            string MoTa = richTextboxMota.Text;


            // Câu lệnh SQL để cập nhật dữ liệu
            string query = "UPDATE dichvu SET  TenDichVu = @TenDV, GiaDichVu = @GiaDV, MoTa =@MoTa WHERE MaDichVu = @MaDV";

            // Thực hiện câu lệnh SQL
            using (SqlConnection conn = new SqlConnection(@"Data Source= LAPTOP-EK26VL1R\SQLEXPRESS; Initial Catalog = QLPhongTro; Integrated Security =True "))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaDV", MaDV);
                    cmd.Parameters.AddWithValue("@TenDV", TenDV);
                    cmd.Parameters.AddWithValue("@GiaDV", GiaDV);
                    cmd.Parameters.AddWithValue("@MoTa", MoTa);
                    cmd.ExecuteNonQuery();
                }

            }
            MessageBox.Show("Sửa thông tin thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Cập nhật lại DataGridView
            loadData();


            txtMaDV.Text = "";
            txtTenDV.Text = "";
            txtGiaDV.Text = "";
            richTextboxMota.Text = "";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string TimDV = txtDichVu.Text;

            string query = "SELECT * FROM DichVu WHERE 1=1"; // Use 1=1 to simplify adding conditions

            if (!string.IsNullOrEmpty(TimDV))
            {
                query += " AND TenDichVu LIKE '%' + @TenDV + '%'";
            }



            if (!string.IsNullOrEmpty(TimDV))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, data.GetConnect());

                if (!string.IsNullOrEmpty(TimDV))
                {
                    da.SelectCommand.Parameters.AddWithValue("@TenDV", TimDV);
                }

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvDichVu.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên dịch vụ muốn tìm kiếm");
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            txtMaDV.Text = "";
            txtTenDV.Text = "";
            txtGiaDV.Text = "";
            richTextboxMota.Text = "";
        }


        private void btnTrangChu_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmTrangChu TrangChu = new frmTrangChu();
            TrangChu.Show();
        }

        private void btnQLP_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyPhong ThongTinPhong = new frmQuanLyPhong();
            ThongTinPhong.Show();
        }

        private void btnQLDV_Click_1(object sender, EventArgs e)
        {
            this.Show();
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

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
