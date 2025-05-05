using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_Án
{
    internal class KetNoi
    {
        string strcon = @"Data Source= LAPTOP-EK26VL1R\SQLEXPRESS; Initial Catalog = QLPhongTro; Integrated Security =True ";
        public SqlConnection GetConnect()
        {
            SqlConnection conn = new SqlConnection(strcon);
            conn.Open();
            return conn;
        }

        public int ExcuteNonquery(string query)
        {
            int data = 0;
            using (SqlConnection ketnoi = new SqlConnection(strcon))
            {
                ketnoi.Open();
                SqlCommand thucthi = new SqlCommand(query, ketnoi);
                data = thucthi.ExecuteNonQuery();
                ketnoi.Close();
            }
            return data;
        }
    }
}
