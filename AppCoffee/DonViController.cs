using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCoffee
{
    public class DonViController
    {
        private readonly DBConnect _database;

        public DonViController()
        {
            _database = new DBConnect();
        }

        public DataTable LayDanhSachDonVi()
        {
            string query = "select * from DonViTinh";

            return _database.ExecuteQuery(query, System.Data.CommandType.Text);
        }
    }
}
