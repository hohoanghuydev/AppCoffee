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
    public partial class frmPhieuNhap : Form
    {
        private readonly PhieuNhapController _controller = new PhieuNhapController();
        public frmPhieuNhap()
        {
            InitializeComponent();
            this.Load += FrmPhieuNhap_Load;
            this.FormClosing += FrmPhieuNhap_FormClosing;
            this.Activated += FrmPhieuNhap_Activated;
        }

        private void FrmPhieuNhap_Activated(object sender, EventArgs e)
        {
            LoadDanhSachPhieuNhap();
        }

        private void FrmPhieuNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            //visible
        }

        private void FrmPhieuNhap_Load(object sender, EventArgs e)
        {
            this.dataGridViewPhieuNhap.CellClick += DataGridViewPhieuNhap_CellClick;
            this.buttonTaoPhieuNhap.Click += ButtonTaoPhieuNhap_Click;
            this.buttonXemChiTiet.Click += ButtonXemChiTiet_Click;
            this.buttonLamMoi.Click += ButtonLamMoi_Click;
        }

        private void ButtonLamMoi_Click(object sender, EventArgs e)
        {
            LoadDanhSachPhieuNhap();
        }

        private void LoadDanhSachPhieuNhap()
        {
            DataTable dataTable = _controller.LayDanhSachPhieuNhap();

            dataGridViewPhieuNhap.DataSource = dataTable;
        }

        private void ButtonXemChiTiet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxMaPhieuNhap.Text))
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập muốn xem");
                return;
            }

            int maPhieuNhap = Convert.ToInt32(textBoxMaPhieuNhap.Text);

            //Tao form moi co maPhieuNhap

            var frmChiTiet = new frmChiTietNhap(maPhieuNhap);
            frmChiTiet.Show();
        }

        private void ButtonTaoPhieuNhap_Click(object sender, EventArgs e)
        {
            var frmChiTiet = new frmChiTietNhap(null);
            frmChiTiet.Show();
        }

        private void DataGridViewPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPhieuNhap.SelectedRows.Count <= 0)
            {
                return;
            }

            textBoxMaPhieuNhap.Text = dataGridViewPhieuNhap.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
