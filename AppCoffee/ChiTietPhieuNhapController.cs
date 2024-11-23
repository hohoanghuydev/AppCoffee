using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCoffee
{
    public class ChiTietPhieuNhapController
    {
        private readonly DBConnect _database;
        public ChiTietPhieuNhapController()
        {
            _database = new DBConnect();
        }

        public int LayPhieuNhapMoiNhat()
        {
            string query = "select top 1 MaPhieuNhap from PhieuNhap order by MaPhieuNhap desc";

            return (int)_database.ExecuteScalar(query, CommandType.Text);
        }

        public DataTable LayDanhSachChiTietNhap(int maPhieuNhap)
        {
            string query = "select * from ChiTietPhieuNhap where MaPhieuNhap = @maPhieu";

            return _database.ExecuteQuery(query, CommandType.Text, new System.Data.SqlClient.SqlParameter("@maPhieu", maPhieuNhap));
        }

        public bool TaoMoiPhieuNhap(PhieuNhap phieuNhap)
        {
            string query = "insert into PhieuNhap (NgayNhap, GhiChu) values (@ngayNhap, @ghiChu)";

            try
            {
                int rowAffected = _database.ExecuteNonQuery(query, CommandType.Text, new System.Data.SqlClient.SqlParameter("@ngayNhap", phieuNhap.NgayNhap), new SqlParameter("@ghiChu", phieuNhap.GhiChu));
                return rowAffected > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ThemNguyenLieuVaoPhieuNhap(ChiTietPhieuNhap chiTietPhieuNhap)
        {
            string query = "insert into ChiTietPhieuNhap (MaPhieuNhap, MaNguyenLieu, DonViNhap, SoLuongNhap, DonGiaNhap) values (@maPhieu, @maNguyenLieu, @donVi, @soLuong, @donGia)";

            try
            {
                int rowAffected = _database.ExecuteNonQuery(query, CommandType.Text, new SqlParameter("@maPhieu", chiTietPhieuNhap.MaPhieuNhap), new SqlParameter("@maNguyenLieu", chiTietPhieuNhap.MaNguyenLieu), new SqlParameter("@donVi", chiTietPhieuNhap.DonVi), new SqlParameter("@soLuong", chiTietPhieuNhap.SoLuongNhap), new SqlParameter("@donGia", chiTietPhieuNhap.DonGiaNhap));
                return rowAffected > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
