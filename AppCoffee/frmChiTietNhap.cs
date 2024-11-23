using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCoffee
{
    public partial class frmChiTietNhap : Form
    {
        private readonly ChiTietPhieuNhapController _controller = new ChiTietPhieuNhapController();
        private readonly PhieuNhapController _controllerPhieuNhap = new PhieuNhapController();
        private readonly NguyenLieuController _controllerNguyenLieu = new NguyenLieuController();
        private readonly DonViController _controllerDonVi = new DonViController();
        private int maPhieuNhap;
        public frmChiTietNhap(int? maPhieuNhap)
        {
            InitializeComponent();
            this.maPhieuNhap = maPhieuNhap ?? 0;
            this.Load += FrmChiTietNhap_Load;
        }

        private void FrmChiTietNhap_Load(object sender, EventArgs e)
        {
            this.buttonTaoPhieuNhapMoi.Click += ButtonTaoPhieuNhapMoi_Click;
            this.buttonThemVaoPhieuNhap.Click += ButtonThemVaoPhieuNhap_Click;
            LoadDanhSachNguyenLieuNhap();
            if (maPhieuNhap != 0)
            {
                LoadThongTinPhieuNhap(maPhieuNhap);
                buttonTaoPhieuNhapMoi.Text = "Cập nhật";
            }
            LoadDanhSachNguyenLieu();
            LoadDanhSachDonVi();
        }

        private void LoadDanhSachNguyenLieu()
        {
            List<NguyenLieu> nguyenLieus = _controllerNguyenLieu.LayDanhSachNguyenLieu();

            comboBoxNguyenLieu.DataSource = nguyenLieus;
            comboBoxNguyenLieu.DisplayMember = "TenNguyenLieu";
            comboBoxNguyenLieu.ValueMember = "MaNguyenLieu";
        }

        private void LoadDanhSachDonVi()
        {
            DataTable dataTable = _controllerDonVi.LayDanhSachDonVi();

            comboBoxDonVi.DataSource = dataTable;
            comboBoxDonVi.DisplayMember = "TenDonVi";
            comboBoxDonVi.ValueMember = "MaDonVi";
        }

        private void LoadThongTinPhieuNhap(int maPhieuNhap)
        {
            DataTable dataTable = _controllerPhieuNhap.LayPhieuNhap(maPhieuNhap);

            foreach (DataRow row in dataTable.Rows)
            {
                textBoxMaPhieuNhap.Text = row["MaPhieuNhap"].ToString();
                textBoxNgayNhap.Text = row["NgayNhap"].ToString();
                textBoxGhiChu.Text = row["GhiChu"].ToString();
                textBoxTongTien.Text = row["TongTien"].ToString();
            }
        }

        private void LoadDanhSachNguyenLieuNhap()
        {
            if (maPhieuNhap == 0)
            {
                return;
            }

            DataTable dataTable = _controller.LayDanhSachChiTietNhap(maPhieuNhap);

            dataGridView1.DataSource = dataTable;
        }

        private void ButtonThemVaoPhieuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                int maPhieuNhap = Convert.ToInt32(textBoxMaPhieuNhap.Text);
                int maNguyenLieu = Convert.ToInt32(comboBoxNguyenLieu.SelectedValue);
                int maDonVi = Convert.ToInt32(comboBoxDonVi.SelectedValue);
                double soLuong = Convert.ToDouble(numericUpDownSoLuong.Value);
                int donGia = Convert.ToInt32(textBoxDonGia.Text);

                var chiTietPhieuNhap = new ChiTietPhieuNhap()
                {
                    MaPhieuNhap = maPhieuNhap,
                    MaNguyenLieu = maNguyenLieu,
                    DonVi = maDonVi,
                    SoLuongNhap = soLuong,
                    DonGiaNhap = donGia
                };

                if (!_controller.ThemNguyenLieuVaoPhieuNhap(chiTietPhieuNhap))
                {
                    MessageBox.Show("Nhập nguyên liệu thất bại");
                    return;
                }

                MessageBox.Show("Nhập nguyên liệu thành công");
                LoadDanhSachNguyenLieuNhap();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
            }
        }

        private void ButtonTaoPhieuNhapMoi_Click(object sender, EventArgs e)
        {
            try
            {
                var phieuNhap = new PhieuNhap()
                {
                    NgayNhap = DateTime.Now,
                    GhiChu = textBoxGhiChu.Text
                };

                if (!_controller.TaoMoiPhieuNhap(phieuNhap))
                {
                    MessageBox.Show("Tạo phiếu nhập thất bại");
                    return;
                }

                MessageBox.Show("Tạo thành công");

                maPhieuNhap = _controller.LayPhieuNhapMoiNhat();
                LoadThongTinPhieuNhap(maPhieuNhap);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
            }
        }
    }
}
