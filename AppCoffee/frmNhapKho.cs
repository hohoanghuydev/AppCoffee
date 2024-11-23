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
    public partial class frmNhapKho : Form
    {
        NguyenLieuController _controller = new NguyenLieuController();
        public frmNhapKho()
        {
            InitializeComponent();
            this.Load += FrmNhapKho_Load;
            this.buttonThemNguyenLieu.Click += ButtonThemNguyenLieu_Click;
            this.buttonHuyThaoTac.Click += ButtonHuyThaoTac_Click;
            this.dataGridViewNguyenLieu.CellClick += DataGridViewNguyenLieu_CellClick;
            this.buttonSuaNguyenLieu.Click += ButtonSuaNguyenLieu_Click;
        }

        private void ButtonSuaNguyenLieu_Click(object sender, EventArgs e)
        {
            if (!IsInputValid(textBoxMaNguyenLieu.Text))
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu muốn sửa");
                return;
            }

            if (!IsInputValid(textBoxTenNguyenLieu.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                textBoxTenNguyenLieu.Focus();
                return;
            }

            if (!IsInputValid(textBoxDonViTinh.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                textBoxDonViTinh.Focus();
                return;
            }

            var nguyenLieu = new NguyenLieu()
            {
                MaNguyenLieu = Convert.ToInt32(textBoxMaNguyenLieu.Text),
                TenNguyenLieu = textBoxTenNguyenLieu.Text,
                MoTa = textBoxMoTa.Text,
                TonkhoToiThieu = Convert.ToDouble(numericUpDownSoLuongToiThieu.Value),
                SoLuongTonKho = Convert.ToDouble(numericUpDownTonKho.Value),
            };

            if (!_controller.CapNhatThongTinNguyenLieu(nguyenLieu))
            {
                MessageBox.Show("Cập nhật thất bại");
                return;
            }

            MessageBox.Show("Cập nhật thành công");
            ReloadDataGridView();
        }

        private void DataGridViewNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewNguyenLieu.CurrentRow.Cells.Count <= 0)
            {
                return;
            }

            int maNguyenLieu = Convert.ToInt32(dataGridViewNguyenLieu.CurrentRow.Cells[0].Value);

            NguyenLieu nguyenLieu = _controller.LayNguyenLieuTheoMa(maNguyenLieu);

            if (nguyenLieu == null)
            {
                return;
            }

            try
            {
                textBoxMaNguyenLieu.Text = nguyenLieu.MaNguyenLieu.ToString();
                textBoxTenNguyenLieu.Text = nguyenLieu.TenNguyenLieu;
                textBoxDonViTinh.Text = nguyenLieu.DonViChuan;
                textBoxMoTa.Text = nguyenLieu.MoTa;
                numericUpDownSoLuongToiThieu.Value = Convert.ToDecimal(nguyenLieu.TonkhoToiThieu);
                numericUpDownTonKho.Value = Convert.ToDecimal(nguyenLieu.SoLuongTonKho);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi định dạng trong quá trình hiển thị");
            }
        }

        private void ButtonHuyThaoTac_Click(object sender, EventArgs e)
        {
            ClearThongTin();
            ReloadDataGridView();
        }

        private void ClearThongTin()
        {
            foreach (Control control in this.groupBoxNguyenLieu.Controls)
            {
                if (control.GetType() == typeof(TextBox) || control.GetType() == typeof(NumericUpDown) || control.GetType() == typeof(RichTextBox))
                {
                    control.Text = string.Empty;
                }
            }
        }

        private void ButtonThemNguyenLieu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxMaNguyenLieu.Text))
            {
                MessageBox.Show("Hủy thao tác trước khi thực hiện thêm.");
                return;
            }

            if (!IsInputValid(textBoxTenNguyenLieu.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                textBoxTenNguyenLieu.Focus();
                return;
            }

            if (!IsInputValid(textBoxDonViTinh.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                textBoxDonViTinh.Focus();
                return;
            }

            if (numericUpDownSoLuongToiThieu.Value <= 0)
            {
                MessageBox.Show("Số lượng tồn tối thiểu phải lớn hơn 0");
                return;
            }

            var nguyenLieu = new NguyenLieu()
            {
                TenNguyenLieu = textBoxTenNguyenLieu.Text,
                MoTa = textBoxMoTa.Text,
                TonkhoToiThieu = Convert.ToDouble(numericUpDownSoLuongToiThieu.Value),
                DonViChuan = textBoxDonViTinh.Text
            };

            if (!_controller.ThemMoiNguyenLieu(nguyenLieu))
            {
                MessageBox.Show("Thêm thất bại");
                return;
            }

            MessageBox.Show("Thêm thành công");
            ReloadDataGridView();
        }

        private bool IsInputValid(string text)
        {
            return !string.IsNullOrWhiteSpace(text);
        }

        private void ReloadDataGridView()
        {
            dataGridViewNguyenLieu.DataSource = _controller.LayDanhSachNguyenLieu();
        }

        private void FrmNhapKho_Load(object sender, EventArgs e)
        {
            ReloadDataGridView();
        }
    }
}
