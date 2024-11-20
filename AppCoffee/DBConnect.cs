using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace AppCoffee
{
  public  class DBConnect
    {
        private SqlConnection con;
        public string strConn = "Data Source=DESKTOP-D3EMUEJ\\SQLEXPRESS;Initial Catalog=QLCaPhe_Official;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True;";
        public string connectionString = "Data Source=.;Initial Catalog=QLCaPhe_Official;Integrated Security=True;";

        public SqlConnection Con { get => con; set => con = value; }
        public DBConnect()
        {
            Con = new SqlConnection(connectionString);
        }
        public void Open()
        {
            if (Con.State == ConnectionState.Closed)
                Con.Open();
        }
        public void Close()
        {
            if (Con.State == ConnectionState.Open)
                Con.Close();
        }
        public int GetNonQuery(string sql)
        {
            int kq = 0;
            try
            {
                Open();
                SqlCommand cmd = new SqlCommand(sql, Con);
                kq = cmd.ExecuteNonQuery();
                Close();
                return kq;
            }
            catch(Exception)
            {
                return kq;
            }
        }
        public DataTable GetDataTable(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(sql, Con);
            adap.Fill(dt);
            return dt;
        }
        public object Getscalar(string sql)
        {
            try
            {
                Open();
                SqlCommand cmd = new SqlCommand(sql, Con);
                object kq = cmd.ExecuteScalar();
                Close();
                return kq;
            }
            catch(Exception)
            {
                return 0;
            }
            
        }

        public SqlDataReader GetReader(string sql)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                return rdr;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
