using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCoffee
{
    public class NguyenLieuController
    {
        private readonly DBConnect _database;

        public NguyenLieuController()
        {
            _database = new DBConnect();
        }

        public List<NguyenLieu> LayDanhSachNguyenLieu()
        {
            var nguyenLieus = new List<NguyenLieu>();

            string query = "select * from NguyenLieu";

            try
            {
                DataTable dataTable = _database.ExecuteQuery(query, CommandType.Text);

                foreach (DataRow row in dataTable.Rows)
                {
                    NguyenLieu nguyenLieu = new NguyenLieu()
                    {
                        MaNguyenLieu = Convert.ToInt32(row["MaNguyenLieu"]),
                        TenNguyenLieu = row["TenNguyenLieu"].ToString(),
                        MoTa = row["MoTa"].ToString(),
                        DonViChuan = row["DonViChuan"].ToString(),
                        SoLuongTonKho = Convert.ToDouble(row["SoLuongTonKho"]),
                        TonkhoToiThieu = Convert.ToDouble(row["TonKhoToiThieu"]),
                        TinhTrang = Convert.ToInt32(row["TinhTrang"]),
                        MaNhaCungCap = Convert.ToInt32(row["MaNhaCungCap"])
                    };

                    nguyenLieus.Add(nguyenLieu);
                }
            }
            catch (Exception ex)
            {

            }

            return nguyenLieus;
        }

        public NguyenLieu LayNguyenLieuTheoMa(int maNguyenLieu)
        {
            string query = "select * from NguyenLieu where MaNguyenLieu = @ma";

            try
            {
                DataTable dataTable = _database.ExecuteQuery(query, CommandType.Text, new SqlParameter("@ma", maNguyenLieu));

                NguyenLieu nguyenLieu = new NguyenLieu();

                foreach (DataRow row in dataTable.Rows)
                {
                    nguyenLieu.MaNguyenLieu = Convert.ToInt32(row["MaNguyenLieu"]);
                    nguyenLieu.TenNguyenLieu = row["TenNguyenLieu"].ToString();
                    nguyenLieu.MoTa = row["MoTa"].ToString();
                    nguyenLieu.DonViChuan = row["DonViChuan"].ToString();
                    nguyenLieu.SoLuongTonKho = Convert.ToDouble(row["SoLuongTonKho"]);
                    nguyenLieu.TonkhoToiThieu = Convert.ToDouble(row["TonKhoToiThieu"]);
                    nguyenLieu.TinhTrang = Convert.ToInt32(row["TinhTrang"]);
                }

                return nguyenLieu;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool ThemMoiNguyenLieu(NguyenLieu nguyenLieu)
        {
            string query = "insert into NguyenLieu (TenNguyenLieu, DonViChuan, MoTa, TonKhoToiThieu, MaNhaCungCap) values (@ten, @donVi, @moTa, @tonKhoToiThieu, @maNhaCungCap)";
            try
            {
                int rowAffected = _database.ExecuteNonQuery(query, CommandType.Text, new SqlParameter("@ten", nguyenLieu.TenNguyenLieu), new SqlParameter("@donVi", nguyenLieu.DonViChuan), new SqlParameter("@moTa", nguyenLieu.MoTa), new SqlParameter("@tonKhoToiThieu", nguyenLieu.TonkhoToiThieu), new SqlParameter("@maNhaCungCap", nguyenLieu.MaNhaCungCap));
                return rowAffected > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool CapNhatThongTinNguyenLieu(NguyenLieu nguyenLieu)
        {
            string query = "update NguyenLieu set TenNguyenLieu = @ten, MoTa = @moTa, TonKhoToiThieu = @tonKhoToiThieu, SoLuongTonKho = @tonKho where MaNguyenLieu = @ma";

            try
            {
                int rowAffected = _database.ExecuteNonQuery(query, CommandType.Text, new SqlParameter("@ten", nguyenLieu.TenNguyenLieu), new SqlParameter("@moTa", nguyenLieu.MoTa), new SqlParameter("@tonKhoToiThieu", nguyenLieu.TonkhoToiThieu), new SqlParameter("@ma", nguyenLieu.MaNguyenLieu), new SqlParameter("@tonKho", nguyenLieu.SoLuongTonKho));
                return rowAffected > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool XoaNguyenLieu(int maNguyenLieu)
        {
            return false;
        }
    }
}
