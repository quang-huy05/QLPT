using Microsoft.Reporting.WinForms;
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
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();

        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            Report_HoaDon report = new Report_HoaDon();
            string connection_string = @"Data Source=LAPTOP-EK26VL1R\SQLEXPRESS;Initial Catalog=QLPhongTro;Integrated Security=True";

            string query = @"SELECT HoaDonTong.MaHoaDon, HoaDonTong.MaPhong, HoaDonTong.NgayLapHoaDon, HoaDonTong.TienPhong, HoaDonDien.ThanhTien, HoaDonNuoc.ThanhTien AS Expr1, HoaDonTong.TongTien
                FROM HoaDonTong INNER JOIN
                  HoaDonDien ON HoaDonTong.MaHoaDonDien = HoaDonDien.MaHoaDonDien INNER JOIN
                  HoaDonNuoc ON HoaDonTong.MaHoaDonNuoc = HoaDonNuoc.MaHoaDonNuoc";

            SqlConnection conn = new SqlConnection(connection_string);
            SqlDataAdapter adptr = new SqlDataAdapter(query, conn);
            adptr.Fill(report, report.Tables[0].TableName);

            ReportDataSource rds = new ReportDataSource("Report_HoaDon", report.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();

            this.reportViewer1.RefreshReport();


            DateTime ngayHienTai = DateTime.Now;

            lblTime.Text = ngayHienTai.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
