namespace QuanLyPhongKhamMini
{
    partial class frmBenhNhan
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
            lblHoTen = new Label();
            lblTrieuChung = new Label();
            lblTuoi = new Label();
            txtTenBenhNhan = new TextBox();
            nudTuoi = new NumericUpDown();
            txtTrieuChung = new TextBox();
            btnLuuTam = new Button();
            lstBenhNhan = new ListBox();
            ((System.ComponentModel.ISupportInitialize)nudTuoi).BeginInit();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHoTen.Location = new Point(164, 60);
            lblHoTen.Margin = new Padding(4, 0, 4, 0);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(77, 25);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ Tên:";
            // 
            // lblTrieuChung
            // 
            lblTrieuChung.AutoSize = true;
            lblTrieuChung.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTrieuChung.Location = new Point(164, 130);
            lblTrieuChung.Margin = new Padding(4, 0, 4, 0);
            lblTrieuChung.Name = "lblTrieuChung";
            lblTrieuChung.Size = new Size(121, 25);
            lblTrieuChung.TabIndex = 1;
            lblTrieuChung.Text = "Triệu Chứng:";
            // 
            // lblTuoi
            // 
            lblTuoi.AutoSize = true;
            lblTuoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTuoi.Location = new Point(164, 222);
            lblTuoi.Margin = new Padding(4, 0, 4, 0);
            lblTuoi.Name = "lblTuoi";
            lblTuoi.Size = new Size(54, 25);
            lblTuoi.TabIndex = 2;
            lblTuoi.Text = "Tuổi:";
            // 
            // txtTenBenhNhan
            // 
            txtTenBenhNhan.Location = new Point(554, 56);
            txtTenBenhNhan.Margin = new Padding(4, 4, 4, 4);
            txtTenBenhNhan.Name = "txtTenBenhNhan";
            txtTenBenhNhan.Size = new Size(265, 31);
            txtTenBenhNhan.TabIndex = 3;
            // 
            // nudTuoi
            // 
            nudTuoi.Location = new Point(632, 220);
            nudTuoi.Margin = new Padding(4, 4, 4, 4);
            nudTuoi.Name = "nudTuoi";
            nudTuoi.Size = new Size(188, 31);
            nudTuoi.TabIndex = 4;
            // 
            // txtTrieuChung
            // 
            txtTrieuChung.Location = new Point(554, 126);
            txtTrieuChung.Margin = new Padding(4, 4, 4, 4);
            txtTrieuChung.Name = "txtTrieuChung";
            txtTrieuChung.Size = new Size(265, 31);
            txtTrieuChung.TabIndex = 5;
            // 
            // btnLuuTam
            // 
            btnLuuTam.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLuuTam.Location = new Point(429, 482);
            btnLuuTam.Margin = new Padding(4, 4, 4, 4);
            btnLuuTam.Name = "btnLuuTam";
            btnLuuTam.Size = new Size(134, 49);
            btnLuuTam.TabIndex = 6;
            btnLuuTam.Text = "Lưu Tạm";
            btnLuuTam.UseVisualStyleBackColor = true;
            btnLuuTam.Click += btnLuuTam_Click;
            // 
            // lstBenhNhan
            // 
            lstBenhNhan.FormattingEnabled = true;
            lstBenhNhan.Location = new Point(164, 281);
            lstBenhNhan.Margin = new Padding(4, 4, 4, 4);
            lstBenhNhan.Name = "lstBenhNhan";
            lstBenhNhan.Size = new Size(713, 154);
            lstBenhNhan.TabIndex = 7;
            // 
            // frmBenhNhan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(lstBenhNhan);
            Controls.Add(btnLuuTam);
            Controls.Add(txtTrieuChung);
            Controls.Add(nudTuoi);
            Controls.Add(txtTenBenhNhan);
            Controls.Add(lblTuoi);
            Controls.Add(lblTrieuChung);
            Controls.Add(lblHoTen);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmBenhNhan";
            Text = "Bệnh Nhân";
            ((System.ComponentModel.ISupportInitialize)nudTuoi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoTen;
        private Label lblTrieuChung;
        private Label lblTuoi;
        private TextBox txtTenBenhNhan;
        private NumericUpDown nudTuoi;
        private TextBox txtTrieuChung;
        private Button btnLuuTam;
        private ListBox lstBenhNhan;
    }
}