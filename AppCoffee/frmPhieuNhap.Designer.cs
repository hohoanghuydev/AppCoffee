namespace AppCoffee
{
    partial class frmPhieuNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewPhieuNhap = new System.Windows.Forms.DataGridView();
            this.buttonTaoPhieuNhap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.buttonXemChiTiet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPhieuNhap
            // 
            this.dataGridViewPhieuNhap.AllowUserToAddRows = false;
            this.dataGridViewPhieuNhap.AllowUserToDeleteRows = false;
            this.dataGridViewPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhieuNhap.Location = new System.Drawing.Point(13, 63);
            this.dataGridViewPhieuNhap.MultiSelect = false;
            this.dataGridViewPhieuNhap.Name = "dataGridViewPhieuNhap";
            this.dataGridViewPhieuNhap.ReadOnly = true;
            this.dataGridViewPhieuNhap.RowHeadersWidth = 62;
            this.dataGridViewPhieuNhap.RowTemplate.Height = 28;
            this.dataGridViewPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPhieuNhap.Size = new System.Drawing.Size(1195, 532);
            this.dataGridViewPhieuNhap.TabIndex = 0;
            // 
            // buttonTaoPhieuNhap
            // 
            this.buttonTaoPhieuNhap.Location = new System.Drawing.Point(1055, 12);
            this.buttonTaoPhieuNhap.Name = "buttonTaoPhieuNhap";
            this.buttonTaoPhieuNhap.Size = new System.Drawing.Size(153, 45);
            this.buttonTaoPhieuNhap.TabIndex = 1;
            this.buttonTaoPhieuNhap.Text = "Tạo phiếu nhập";
            this.buttonTaoPhieuNhap.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phiếu nhập";
            // 
            // textBoxMaPhieuNhap
            // 
            this.textBoxMaPhieuNhap.Enabled = false;
            this.textBoxMaPhieuNhap.Location = new System.Drawing.Point(122, 21);
            this.textBoxMaPhieuNhap.Name = "textBoxMaPhieuNhap";
            this.textBoxMaPhieuNhap.Size = new System.Drawing.Size(208, 26);
            this.textBoxMaPhieuNhap.TabIndex = 3;
            // 
            // buttonXemChiTiet
            // 
            this.buttonXemChiTiet.Location = new System.Drawing.Point(896, 12);
            this.buttonXemChiTiet.Name = "buttonXemChiTiet";
            this.buttonXemChiTiet.Size = new System.Drawing.Size(153, 45);
            this.buttonXemChiTiet.TabIndex = 1;
            this.buttonXemChiTiet.Text = "Xem chi tiết";
            this.buttonXemChiTiet.UseVisualStyleBackColor = true;
            // 
            // frmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 607);
            this.Controls.Add(this.textBoxMaPhieuNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonXemChiTiet);
            this.Controls.Add(this.buttonTaoPhieuNhap);
            this.Controls.Add(this.dataGridViewPhieuNhap);
            this.Name = "frmPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhieuNhap";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPhieuNhap;
        private System.Windows.Forms.Button buttonTaoPhieuNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMaPhieuNhap;
        private System.Windows.Forms.Button buttonXemChiTiet;
    }
}