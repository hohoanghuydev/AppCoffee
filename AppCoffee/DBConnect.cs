using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace AppCoffee
{
    public class DBConnect
    {
        private SqlConnection con;
        public string strConn = "Data Source=DESKTOP-D3EMUEJ\\SQLEXPRESS;Initial Catalog=QLCaPhe_Official;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True;";
        private readonly string _connectionString = "Data Source=.;Initial Catalog=QLCaPhe_Official;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True;";

        public SqlConnection Con { get => con; set => con = value; }
        public DBConnect()
        {
            Con = new SqlConnection(_connectionString);
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
            catch (Exception)
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
            catch (Exception)
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

        public DataTable ExecuteQuery(string query, CommandType commandType, params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection connection = OpenConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = commandType;

                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            return dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //Loi gi do
                return null;
            }
        }

        public int ExecuteNonQuery(string query, CommandType commandType, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = OpenConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = commandType;

                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    return command.ExecuteNonQuery();
                }
            }
        }

        public object ExecuteScalar(string query, CommandType commandType, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = OpenConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = commandType;

                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    return command.ExecuteScalar();
                }
            }
        }

        private SqlConnection OpenConnection()
        {
            SqlConnection connection = new SqlConnection(_connectionString);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }
    }
}
