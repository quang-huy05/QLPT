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
    public partial class frmDSDV : Form
    {
        public frmDSDV()
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
            dgvDSDV.DataSource = dt;

        }
        private void frmDSDV_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
