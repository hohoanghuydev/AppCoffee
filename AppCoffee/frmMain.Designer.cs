using System.Windows.Forms;
namespace AppCoffee
{
    partial class mainApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainApp));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_thanhToan = new System.Windows.Forms.Button();
            this.panelTaoHoaDon = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_countTable = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_nameGuest = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_nameStaff = new System.Windows.Forms.TextBox();
            this.panelDanhSachDatMon = new System.Windows.Forms.Panel();
            this.btn_themMon = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_timKiemMon = new System.Windows.Forms.TextBox();
            this.dgv_tenMon = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.đổiMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cob_loaiMon = new System.Windows.Forms.ComboBox();
            this.nud_soLuong = new System.Windows.Forms.NumericUpDown();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaTri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.pnl_3 = new System.Windows.Forms.Panel();
            this.flp_Ban = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_doiban = new System.Windows.Forms.ToolStripMenuItem();
            this.hủyBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelThongTinHoaDon = new System.Windows.Forms.Panel();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.dgv_thongTinHoaDon = new System.Windows.Forms.DataGridView();
            this.txt_TongTienHoaDon = new System.Windows.Forms.TextBox();
            this.txt_GiamGia = new System.Windows.Forms.TextBox();
            this.txt_thanhTien = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSoBan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.errBaoLoi = new System.Windows.Forms.ErrorProvider(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.quảnLýKhoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panelTaoHoaDon.SuspendLayout();
            this.panelDanhSachDatMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tenMon)).BeginInit();
            this.contextMenuStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_soLuong)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.pnl_3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panelThongTinHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongTinHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errBaoLoi)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.quảnLýToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1748, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(256, 34);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(256, 34);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýKhoToolStripMenuItem,
            this.quảnLýKhoToolStripMenuItem1,
            this.nhậpKhoToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // quảnLýKhoToolStripMenuItem
            // 
            this.quảnLýKhoToolStripMenuItem.Name = "quảnLýKhoToolStripMenuItem";
            this.quảnLýKhoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.quảnLýKhoToolStripMenuItem.Text = "Quản lý danh mục";
            this.quảnLýKhoToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKhoToolStripMenuItem_Click);
            // 
            // btn_thanhToan
            // 
            this.btn_thanhToan.Location = new System.Drawing.Point(21, 716);
            this.btn_thanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_thanhToan.Name = "btn_thanhToan";
            this.btn_thanhToan.Size = new System.Drawing.Size(253, 82);
            this.btn_thanhToan.TabIndex = 4;
            this.btn_thanhToan.Text = "Thanh toán";
            this.btn_thanhToan.UseVisualStyleBackColor = true;
            this.btn_thanhToan.Click += new System.EventHandler(this.button5_Click);
            // 
            // panelTaoHoaDon
            // 
            this.panelTaoHoaDon.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelTaoHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTaoHoaDon.Controls.Add(this.dateTimePicker1);
            this.panelTaoHoaDon.Controls.Add(this.btnXacNhan);
            this.panelTaoHoaDon.Controls.Add(this.label10);
            this.panelTaoHoaDon.Controls.Add(this.txt_countTable);
            this.panelTaoHoaDon.Controls.Add(this.label7);
            this.panelTaoHoaDon.Controls.Add(this.txt_nameGuest);
            this.panelTaoHoaDon.Controls.Add(this.label8);
            this.panelTaoHoaDon.Controls.Add(this.label9);
            this.panelTaoHoaDon.Controls.Add(this.txt_nameStaff);
            this.panelTaoHoaDon.Location = new System.Drawing.Point(12, 129);
            this.panelTaoHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTaoHoaDon.Name = "panelTaoHoaDon";
            this.panelTaoHoaDon.Size = new System.Drawing.Size(570, 330);
            this.panelTaoHoaDon.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(168, 18);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(378, 26);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnXacNhan.Enabled = false;
            this.btnXacNhan.Location = new System.Drawing.Point(36, 245);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(513, 65);
            this.btnXacNhan.TabIndex = 5;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Ngày nhập";
            // 
            // txt_countTable
            // 
            this.txt_countTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_countTable.Location = new System.Drawing.Point(168, 126);
            this.txt_countTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_countTable.Name = "txt_countTable";
            this.txt_countTable.Size = new System.Drawing.Size(379, 26);
            this.txt_countTable.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tên nhân viên";
            // 
            // txt_nameGuest
            // 
            this.txt_nameGuest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nameGuest.Location = new System.Drawing.Point(168, 71);
            this.txt_nameGuest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nameGuest.Name = "txt_nameGuest";
            this.txt_nameGuest.Size = new System.Drawing.Size(379, 26);
            this.txt_nameGuest.TabIndex = 18;
            this.txt_nameGuest.TextChanged += new System.EventHandler(this.txt_nameGuest_TextChanged);
            this.txt_nameGuest.Leave += new System.EventHandler(this.txt_nameGuest_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Số bàn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Tên khách hàng";
            // 
            // txt_nameStaff
            // 
            this.txt_nameStaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nameStaff.Enabled = false;
            this.txt_nameStaff.Location = new System.Drawing.Point(168, 181);
            this.txt_nameStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nameStaff.Name = "txt_nameStaff";
            this.txt_nameStaff.Size = new System.Drawing.Size(379, 26);
            this.txt_nameStaff.TabIndex = 17;
            // 
            // panelDanhSachDatMon
            // 
            this.panelDanhSachDatMon.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelDanhSachDatMon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDanhSachDatMon.Controls.Add(this.btn_themMon);
            this.panelDanhSachDatMon.Controls.Add(this.label16);
            this.panelDanhSachDatMon.Controls.Add(this.txt_timKiemMon);
            this.panelDanhSachDatMon.Controls.Add(this.dgv_tenMon);
            this.panelDanhSachDatMon.Controls.Add(this.cob_loaiMon);
            this.panelDanhSachDatMon.Controls.Add(this.nud_soLuong);
            this.panelDanhSachDatMon.Controls.Add(this.txtTongTien);
            this.panelDanhSachDatMon.Controls.Add(this.label5);
            this.panelDanhSachDatMon.Controls.Add(this.label1);
            this.panelDanhSachDatMon.Controls.Add(this.label4);
            this.panelDanhSachDatMon.Controls.Add(this.txtGiaTri);
            this.panelDanhSachDatMon.Controls.Add(this.label2);
            this.panelDanhSachDatMon.Location = new System.Drawing.Point(1167, 129);
            this.panelDanhSachDatMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDanhSachDatMon.Name = "panelDanhSachDatMon";
            this.panelDanhSachDatMon.Size = new System.Drawing.Size(570, 816);
            this.panelDanhSachDatMon.TabIndex = 3;
            // 
            // btn_themMon
            // 
            this.btn_themMon.Location = new System.Drawing.Point(181, 734);
            this.btn_themMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_themMon.Name = "btn_themMon";
            this.btn_themMon.Size = new System.Drawing.Size(226, 65);
            this.btn_themMon.TabIndex = 5;
            this.btn_themMon.Text = "Thêm món";
            this.btn_themMon.UseVisualStyleBackColor = true;
            this.btn_themMon.Click += new System.EventHandler(this.btn_themMon_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(30, 74);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 20);
            this.label16.TabIndex = 17;
            this.label16.Text = "Tìm kiếm";
            // 
            // txt_timKiemMon
            // 
            this.txt_timKiemMon.Location = new System.Drawing.Point(127, 70);
            this.txt_timKiemMon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_timKiemMon.Name = "txt_timKiemMon";
            this.txt_timKiemMon.Size = new System.Drawing.Size(406, 26);
            this.txt_timKiemMon.TabIndex = 16;
            this.txt_timKiemMon.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgv_tenMon
            // 
            this.dgv_tenMon.AllowUserToAddRows = false;
            this.dgv_tenMon.AllowUserToDeleteRows = false;
            this.dgv_tenMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tenMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tenMon.ContextMenuStrip = this.contextMenuStrip3;
            this.dgv_tenMon.Location = new System.Drawing.Point(32, 126);
            this.dgv_tenMon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_tenMon.Name = "dgv_tenMon";
            this.dgv_tenMon.ReadOnly = true;
            this.dgv_tenMon.RowHeadersWidth = 51;
            this.dgv_tenMon.RowTemplate.Height = 24;
            this.dgv_tenMon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tenMon.Size = new System.Drawing.Size(502, 382);
            this.dgv_tenMon.TabIndex = 15;
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMónToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(155, 36);
            // 
            // đổiMónToolStripMenuItem
            // 
            this.đổiMónToolStripMenuItem.Name = "đổiMónToolStripMenuItem";
            this.đổiMónToolStripMenuItem.Size = new System.Drawing.Size(154, 32);
            this.đổiMónToolStripMenuItem.Text = "Đổi món";
            this.đổiMónToolStripMenuItem.Click += new System.EventHandler(this.đổiMónToolStripMenuItem_Click_1);
            // 
            // cob_loaiMon
            // 
            this.cob_loaiMon.FormattingEnabled = true;
            this.cob_loaiMon.Location = new System.Drawing.Point(127, 16);
            this.cob_loaiMon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cob_loaiMon.Name = "cob_loaiMon";
            this.cob_loaiMon.Size = new System.Drawing.Size(406, 28);
            this.cob_loaiMon.TabIndex = 12;
            this.cob_loaiMon.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // nud_soLuong
            // 
            this.nud_soLuong.Location = new System.Drawing.Point(142, 600);
            this.nud_soLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud_soLuong.Name = "nud_soLuong";
            this.nud_soLuong.Size = new System.Drawing.Size(154, 26);
            this.nud_soLuong.TabIndex = 11;
            this.nud_soLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_soLuong.ValueChanged += new System.EventHandler(this.nud_soLuong_ValueChanged);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(141, 665);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(392, 26);
            this.txtTongTien.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 606);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại món";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 670);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tổng tiền";
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.Location = new System.Drawing.Point(142, 546);
            this.txtGiaTri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Size = new System.Drawing.Size(391, 26);
            this.txtGiaTri.TabIndex = 8;
            this.txtGiaTri.TextChanged += new System.EventHandler(this.txtGiaTri_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 550);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giá trị";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaMónToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(158, 36);
            // 
            // xóaMónToolStripMenuItem
            // 
            this.xóaMónToolStripMenuItem.Name = "xóaMónToolStripMenuItem";
            this.xóaMónToolStripMenuItem.Size = new System.Drawing.Size(157, 32);
            this.xóaMónToolStripMenuItem.Text = "Xóa món";
            this.xóaMónToolStripMenuItem.Click += new System.EventHandler(this.xóaMónToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(220, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 38);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hóa đơn";
            // 
            // pnl_3
            // 
            this.pnl_3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnl_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_3.Controls.Add(this.flp_Ban);
            this.pnl_3.Location = new System.Drawing.Point(12, 465);
            this.pnl_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_3.Name = "pnl_3";
            this.pnl_3.Size = new System.Drawing.Size(570, 480);
            this.pnl_3.TabIndex = 2;
            // 
            // flp_Ban
            // 
            this.flp_Ban.AutoScroll = true;
            this.flp_Ban.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flp_Ban.Location = new System.Drawing.Point(3, 2);
            this.flp_Ban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flp_Ban.Name = "flp_Ban";
            this.flp_Ban.Size = new System.Drawing.Size(565, 472);
            this.flp_Ban.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_doiban,
            this.hủyBànToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 68);
            // 
            // tsmi_doiban
            // 
            this.tsmi_doiban.Name = "tsmi_doiban";
            this.tsmi_doiban.Size = new System.Drawing.Size(151, 32);
            this.tsmi_doiban.Text = "Đổi bàn";
            this.tsmi_doiban.Click += new System.EventHandler(this.đổiBànToolStripMenuItem_Click);
            // 
            // hủyBànToolStripMenuItem
            // 
            this.hủyBànToolStripMenuItem.Name = "hủyBànToolStripMenuItem";
            this.hủyBànToolStripMenuItem.Size = new System.Drawing.Size(151, 32);
            this.hủyBànToolStripMenuItem.Text = "Hủy bàn";
            this.hủyBànToolStripMenuItem.Click += new System.EventHandler(this.hủyBànToolStripMenuItem_Click);
            // 
            // panelThongTinHoaDon
            // 
            this.panelThongTinHoaDon.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelThongTinHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelThongTinHoaDon.Controls.Add(this.btnInHoaDon);
            this.panelThongTinHoaDon.Controls.Add(this.btn_thanhToan);
            this.panelThongTinHoaDon.Controls.Add(this.dgv_thongTinHoaDon);
            this.panelThongTinHoaDon.Controls.Add(this.txt_TongTienHoaDon);
            this.panelThongTinHoaDon.Controls.Add(this.txt_GiamGia);
            this.panelThongTinHoaDon.Controls.Add(this.txt_thanhTien);
            this.panelThongTinHoaDon.Controls.Add(this.label14);
            this.panelThongTinHoaDon.Controls.Add(this.label13);
            this.panelThongTinHoaDon.Controls.Add(this.label12);
            this.panelThongTinHoaDon.Controls.Add(this.txtSoBan);
            this.panelThongTinHoaDon.Controls.Add(this.label11);
            this.panelThongTinHoaDon.Controls.Add(this.label6);
            this.panelThongTinHoaDon.Location = new System.Drawing.Point(590, 129);
            this.panelThongTinHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelThongTinHoaDon.Name = "panelThongTinHoaDon";
            this.panelThongTinHoaDon.Size = new System.Drawing.Size(570, 816);
            this.panelThongTinHoaDon.TabIndex = 4;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Location = new System.Drawing.Point(309, 716);
            this.btnInHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(233, 82);
            this.btnInHoaDon.TabIndex = 17;
            this.btnInHoaDon.Text = "In Hóa Đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // dgv_thongTinHoaDon
            // 
            this.dgv_thongTinHoaDon.AllowUserToAddRows = false;
            this.dgv_thongTinHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_thongTinHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongTinHoaDon.ContextMenuStrip = this.contextMenuStrip2;
            this.dgv_thongTinHoaDon.Location = new System.Drawing.Point(34, 102);
            this.dgv_thongTinHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_thongTinHoaDon.Name = "dgv_thongTinHoaDon";
            this.dgv_thongTinHoaDon.RowHeadersWidth = 51;
            this.dgv_thongTinHoaDon.RowTemplate.Height = 24;
            this.dgv_thongTinHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_thongTinHoaDon.Size = new System.Drawing.Size(511, 468);
            this.dgv_thongTinHoaDon.TabIndex = 16;
            // 
            // txt_TongTienHoaDon
            // 
            this.txt_TongTienHoaDon.Location = new System.Drawing.Point(136, 589);
            this.txt_TongTienHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TongTienHoaDon.Name = "txt_TongTienHoaDon";
            this.txt_TongTienHoaDon.Size = new System.Drawing.Size(406, 26);
            this.txt_TongTienHoaDon.TabIndex = 12;
            // 
            // txt_GiamGia
            // 
            this.txt_GiamGia.Location = new System.Drawing.Point(136, 629);
            this.txt_GiamGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_GiamGia.Name = "txt_GiamGia";
            this.txt_GiamGia.Size = new System.Drawing.Size(406, 26);
            this.txt_GiamGia.TabIndex = 13;
            // 
            // txt_thanhTien
            // 
            this.txt_thanhTien.Location = new System.Drawing.Point(136, 666);
            this.txt_thanhTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_thanhTien.Name = "txt_thanhTien";
            this.txt_thanhTien.Size = new System.Drawing.Size(406, 26);
            this.txt_thanhTien.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 670);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 20);
            this.label14.TabIndex = 15;
            this.label14.Text = "Thành tiền:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 632);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "Giảm giá:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 592);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Tổng tiền:";
            // 
            // txtSoBan
            // 
            this.txtSoBan.Location = new System.Drawing.Point(75, 58);
            this.txtSoBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoBan.Name = "txtSoBan";
            this.txtSoBan.Size = new System.Drawing.Size(39, 26);
            this.txtSoBan.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Bàn: ";
            // 
            // errBaoLoi
            // 
            this.errBaoLoi.ContainerControl = this;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "100-1000536_coffee-cup-icon-cup-of-coffee-icon-png.png");
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label15.ImageIndex = 0;
            this.label15.Location = new System.Drawing.Point(541, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(778, 49);
            this.label15.TabIndex = 5;
            this.label15.Text = "PHẦN MỀM QUẢN LÝ QUÁN CAFE";
            // 
            // quảnLýKhoToolStripMenuItem1
            // 
            this.quảnLýKhoToolStripMenuItem1.Name = "quảnLýKhoToolStripMenuItem1";
            this.quảnLýKhoToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.quảnLýKhoToolStripMenuItem1.Text = "Quản lý kho";
            this.quảnLýKhoToolStripMenuItem1.Click += new System.EventHandler(this.quảnLýKhoToolStripMenuItem1_Click);
            // 
            // nhậpKhoToolStripMenuItem
            // 
            this.nhậpKhoToolStripMenuItem.Name = "nhậpKhoToolStripMenuItem";
            this.nhậpKhoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.nhậpKhoToolStripMenuItem.Text = "Nhập kho";
            this.nhậpKhoToolStripMenuItem.Click += new System.EventHandler(this.nhậpKhoToolStripMenuItem_Click);
            // 
            // mainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1748, 949);
            this.Controls.Add(this.panelTaoHoaDon);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panelThongTinHoaDon);
            this.Controls.Add(this.pnl_3);
            this.Controls.Add(this.panelDanhSachDatMon);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Giao diện chính";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form_quanlyquancafe_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelTaoHoaDon.ResumeLayout(false);
            this.panelTaoHoaDon.PerformLayout();
            this.panelDanhSachDatMon.ResumeLayout(false);
            this.panelDanhSachDatMon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tenMon)).EndInit();
            this.contextMenuStrip3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_soLuong)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.pnl_3.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelThongTinHoaDon.ResumeLayout(false);
            this.panelThongTinHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongTinHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errBaoLoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private Button btn_thanhToan;
        private Panel panelTaoHoaDon;
        private Panel panelDanhSachDatMon;
        private Label label5;
        private TextBox txtGiaTri;
        private TextBox txtTongTien;
        private Label label4;
        private Label label2;
        private Label label1;
        private Panel pnl_3;
        private Panel panelThongTinHoaDon;
        private FlowLayoutPanel flp_Ban;
        private Label label10;
        private TextBox txt_countTable;
        private Label label7;
        private TextBox txt_nameGuest;
        private Label label8;
        private Label label9;
        private TextBox txt_nameStaff;
        private DateTimePicker dateTimePicker1;
        private Button btnXacNhan;
        private Label label6;
        private NumericUpDown nud_soLuong;
        private TextBox txtSoBan;
        private Label label11;
        private Label label14;
        private Label label13;
        private Label label12;
        private TextBox txt_thanhTien;
        private TextBox txt_GiamGia;
        private TextBox txt_TongTienHoaDon;
        private ErrorProvider errBaoLoi;
        private Label label15;
        private ImageList imageList1;
        private DataGridView dgv_thongTinHoaDon;
        private ComboBox cob_loaiMon;
        private DataGridView dgv_tenMon;
        private Label label16;
        private TextBox txt_timKiemMon;
        private Button btn_themMon;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem tsmi_doiban;
        private ToolStripMenuItem hủyBànToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem xóaMónToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip3;
        private ToolStripMenuItem đổiMónToolStripMenuItem;
        private Button btnInHoaDon;
        private ToolStripMenuItem quảnLýKhoToolStripMenuItem;
        private ToolStripMenuItem quảnLýKhoToolStripMenuItem1;
        private ToolStripMenuItem nhậpKhoToolStripMenuItem;
    }
}