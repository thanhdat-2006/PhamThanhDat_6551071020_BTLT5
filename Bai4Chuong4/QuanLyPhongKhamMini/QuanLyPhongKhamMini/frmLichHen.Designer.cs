namespace QuanLyPhongKhamMini
{
    partial class frmLichHen
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
            dtpNgayGioHen = new DateTimePicker();
            lblTenBenhNhan = new Label();
            lblNgayGioHen = new Label();
            lstLichHen = new ListBox();
            txtTenBenhNhan = new TextBox();
            btnDatLich = new Button();
            SuspendLayout();
            // 
            // dtpNgayGioHen
            // 
            dtpNgayGioHen.Location = new Point(459, 154);
            dtpNgayGioHen.Margin = new Padding(4, 4, 4, 4);
            dtpNgayGioHen.Name = "dtpNgayGioHen";
            dtpNgayGioHen.Size = new Size(266, 31);
            dtpNgayGioHen.TabIndex = 0;
            // 
            // lblTenBenhNhan
            // 
            lblTenBenhNhan.AutoSize = true;
            lblTenBenhNhan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTenBenhNhan.Location = new Point(162, 80);
            lblTenBenhNhan.Margin = new Padding(4, 0, 4, 0);
            lblTenBenhNhan.Name = "lblTenBenhNhan";
            lblTenBenhNhan.Size = new Size(147, 25);
            lblTenBenhNhan.TabIndex = 1;
            lblTenBenhNhan.Text = "Tên Bệnh Nhân:";
            // 
            // lblNgayGioHen
            // 
            lblNgayGioHen.AutoSize = true;
            lblNgayGioHen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNgayGioHen.Location = new Point(162, 162);
            lblNgayGioHen.Margin = new Padding(4, 0, 4, 0);
            lblNgayGioHen.Name = "lblNgayGioHen";
            lblNgayGioHen.Size = new Size(136, 25);
            lblNgayGioHen.TabIndex = 2;
            lblNgayGioHen.Text = "Ngày Giờ Hẹn:";
            // 
            // lstLichHen
            // 
            lstLichHen.FormattingEnabled = true;
            lstLichHen.Location = new Point(162, 246);
            lstLichHen.Margin = new Padding(4, 4, 4, 4);
            lstLichHen.Name = "lstLichHen";
            lstLichHen.Size = new Size(589, 154);
            lstLichHen.TabIndex = 3;
            // 
            // txtTenBenhNhan
            // 
            txtTenBenhNhan.Location = new Point(459, 76);
            txtTenBenhNhan.Margin = new Padding(4, 4, 4, 4);
            txtTenBenhNhan.Name = "txtTenBenhNhan";
            txtTenBenhNhan.Size = new Size(293, 31);
            txtTenBenhNhan.TabIndex = 4;
            // 
            // btnDatLich
            // 
            btnDatLich.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDatLich.Location = new Point(405, 450);
            btnDatLich.Margin = new Padding(4, 4, 4, 4);
            btnDatLich.Name = "btnDatLich";
            btnDatLich.Size = new Size(120, 60);
            btnDatLich.TabIndex = 5;
            btnDatLich.Text = "Đặt Lịch:";
            btnDatLich.UseVisualStyleBackColor = true;
            btnDatLich.Click += btnDatLich_Click;
            // 
            // frmLichHen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(btnDatLich);
            Controls.Add(txtTenBenhNhan);
            Controls.Add(lstLichHen);
            Controls.Add(lblNgayGioHen);
            Controls.Add(lblTenBenhNhan);
            Controls.Add(dtpNgayGioHen);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmLichHen";
            Text = "Lịch Hẹn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpNgayGioHen;
        private Label lblTenBenhNhan;
        private Label lblNgayGioHen;
        private ListBox lstLichHen;
        private TextBox txtTenBenhNhan;
        private Button btnDatLich;
    }
}