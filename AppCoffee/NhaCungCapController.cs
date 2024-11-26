using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCoffee
{
    public class NhaCungCapController
    {
        private readonly DBConnect _database;

        public NhaCungCapController()
        {
            _database = new DBConnect();
        }

        public DataTable LayDanhSachNhaCungCap()
        {
            string query = "select * from NhaCungCap";
            return _database.ExecuteQuery(query, CommandType.Text);
        }

        public NhaCungCap LayNhaCungCap(int maNhaCungCap)
        {
            string query = "select * from NhaCungCap where MaNhaCungCap = @ma";
            DataTable dataTable = _database.ExecuteQuery(query, CommandType.Text, new System.Data.SqlClient.SqlParameter("@ma", maNhaCungCap));
            NhaCungCap nhaCungCap = new NhaCungCap();

            foreach (DataRow row in dataTable.Rows)
            {
                nhaCungCap.MaNhaCungCap = Convert.ToInt32(row["MaNhaCungCap"]);
                nhaCungCap.TenNhaCungCap = row["TenNhaCungCap"].ToString();
                nhaCungCap.LienHe = row["LienHe"].ToString();
                nhaCungCap.DiaChi = row["DiaChi"].ToString();
            }

            return nhaCungCap;
        }

        public bool ThemNhaCungCap(NhaCungCap nhaCungCap)
        {
            string query = "insert into NhaCungCap (TenNhaCungCap, LienHe, DiaChi) values (@ten, @lienHe, @diaChi)";

            try
            {
                int rowAffected = _database.ExecuteNonQuery(query, CommandType.Text, new SqlParameter("@ten", nhaCungCap.TenNhaCungCap), new SqlParameter("@lienHe", nhaCungCap.LienHe), new SqlParameter("@diaChi", nhaCungCap.DiaChi));
                return rowAffected > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool SuaNhaCungCap(NhaCungCap nhaCungCap)
        {
            string query = "update NhaCungCap set TenNhaCungCap = @ten, LienHe = @lienHe, DiaChi = @diaChi where MaNhaCungCap = @ma";

            try
            {
                int rowAffected = _database.ExecuteNonQuery(query, CommandType.Text, new SqlParameter("@ma", nhaCungCap.MaNhaCungCap), new SqlParameter("@ten", nhaCungCap.TenNhaCungCap), new SqlParameter("@lienHe", nhaCungCap.LienHe), new SqlParameter("@diaChi", nhaCungCap.DiaChi));
                return rowAffected > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool XoaNhaCungCap(int maNhaCungCap)
        {
            string query = "delete NhaCungCap where MaNhaCungCap = @ma";

            try
            {
                int rowAffected = _database.ExecuteNonQuery(query, CommandType.Text, new SqlParameter("@ma", maNhaCungCap));
                return rowAffected > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
