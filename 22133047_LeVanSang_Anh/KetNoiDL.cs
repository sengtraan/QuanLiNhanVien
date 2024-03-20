using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace _22133047_LeVanSang_Anh
{
    internal class KetNoiDL
    {
        public SqlConnection cnn = new SqlConnection("Data Source=.;Initial Catalog=QuanLiNhanVien;Persist Security Info=True;User ID=sa;Password=123456");
        public void myConnect()
        {
            cnn.Open();
        }
        public void myClass()
        {
            cnn.Close();
        }
        public DataTable taobang(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter ds = new SqlDataAdapter(sql, cnn);
            ds.Fill(dt);
            return dt;
        }
        public void Luu(string manv, string tennv, Image anh)
        {
            string sql = "insert into QuanLiNV(MaNV, TenNV, Anh) values('" + manv + "','" + tennv + "', '" + anh + "')";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
    }
}
