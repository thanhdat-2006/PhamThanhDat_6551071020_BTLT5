namespace SieuThi
{
    partial class frmBanHang
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
            txtMaSP = new TextBox();
            txtDonGia = new TextBox();
            txtSoLuong = new TextBox();
            lblMaSP = new Label();
            lblSoLuong = new Label();
            lblDonGia = new Label();
            btnThem = new Button();
            btnXoaTrang = new Button();
            lstKetQua = new ListBox();
            SuspendLayout();
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(356, 50);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(372, 31);
            txtMaSP.TabIndex = 0;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(356, 212);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(372, 31);
            txtDonGia.TabIndex = 1;
            txtDonGia.KeyPress += txtSoLuong_KeyPress;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(356, 126);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(372, 31);
            txtSoLuong.TabIndex = 2;
            txtSoLuong.KeyPress += txtSoLuong_KeyPress;
            // 
            // lblMaSP
            // 
            lblMaSP.AutoSize = true;
            lblMaSP.Location = new Point(200, 56);
            lblMaSP.Name = "lblMaSP";
            lblMaSP.Size = new Size(124, 25);
            lblMaSP.TabIndex = 3;
            lblMaSP.Text = "Mã sản phẩm:";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(200, 132);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(89, 25);
            lblSoLuong.TabIndex = 4;
            lblSoLuong.Text = "Số lượng:";
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(200, 218);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(79, 25);
            lblDonGia.TabIndex = 5;
            lblDonGia.Text = "Đơn giá:";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(810, 47);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.Location = new Point(810, 123);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(112, 34);
            btnXoaTrang.TabIndex = 7;
            btnXoaTrang.Text = "Xóa trắng";
            btnXoaTrang.UseVisualStyleBackColor = true;
            btnXoaTrang.Click += btnXoaTrang_Click;
            // 
            // lstKetQua
            // 
            lstKetQua.FormattingEnabled = true;
            lstKetQua.Location = new Point(203, 276);
            lstKetQua.Name = "lstKetQua";
            lstKetQua.Size = new Size(719, 254);
            lstKetQua.TabIndex = 8;
            // 
            // frmBanHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 620);
            Controls.Add(lstKetQua);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnThem);
            Controls.Add(lblDonGia);
            Controls.Add(lblSoLuong);
            Controls.Add(lblMaSP);
            Controls.Add(txtSoLuong);
            Controls.Add(txtDonGia);
            Controls.Add(txtMaSP);
            KeyPreview = true;
            Name = "frmBanHang";
            Text = "FormBanHangSieuThi";
            KeyDown += frmBanHang_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaSP;
        private TextBox txtDonGia;
        private TextBox txtSoLuong;
        private Label lblMaSP;
        private Label lblSoLuong;
        private Label lblDonGia;
        private Button btnThem;
        private Button btnXoaTrang;
        private ListBox lstKetQua;
    }
}
