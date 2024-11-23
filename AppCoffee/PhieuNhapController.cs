using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCoffee
{
    public class PhieuNhapController
    {
        private readonly DBConnect _database;
        public PhieuNhapController()
        {
            _database = new DBConnect();
        }

        public DataTable LayDanhSachPhieuNhap()
        {
            string query = "select * from PhieuNhap";

            return _database.ExecuteQuery(query, CommandType.Text);
        }

        public DataTable LayPhieuNhap(int maPhieuNhap)
        {
            string query = "select * from PhieuNhap where MaPhieuNhap = @maPhieu";

            return _database.ExecuteQuery(query, CommandType.Text, new System.Data.SqlClient.SqlParameter("@maPhieu", maPhieuNhap));
        }
    }
}
