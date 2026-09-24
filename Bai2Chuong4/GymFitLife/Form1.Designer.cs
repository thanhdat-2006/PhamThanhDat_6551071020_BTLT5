namespace GymFitLife
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            lblHoTen = new Label();
            lblSDT = new Label();
            lblEmail = new Label();
            lblNgaySinh = new Label();
            lblGoiTap = new Label();
            label6 = new Label();
            txtHoTen = new TextBox();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            cboGoiTap = new ComboBox();
            nudSoBuoi1Tuan = new NumericUpDown();
            btnDangKy = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)nudSoBuoi1Tuan).BeginInit();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(149, 34);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(70, 25);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ tên:";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(149, 80);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(47, 25);
            lblSDT.TabIndex = 1;
            lblSDT.Text = "SDT:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(149, 129);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 25);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(149, 184);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(95, 25);
            lblNgaySinh.TabIndex = 3;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblGoiTap
            // 
            lblGoiTap.AutoSize = true;
            lblGoiTap.Location = new Point(149, 251);
            lblGoiTap.Name = "lblGoiTap";
            lblGoiTap.Size = new Size(74, 25);
            lblGoiTap.TabIndex = 4;
            lblGoiTap.Text = "Gói tập:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(149, 323);
            label6.Name = "label6";
            label6.Size = new Size(133, 25);
            label6.TabIndex = 5;
            label6.Text = "Số buổi 1 tuần:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(316, 28);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(300, 31);
            txtHoTen.TabIndex = 6;
            toolTip1.SetToolTip(txtHoTen, "Chỉ nhập chữ cái, không bao gồm số và ký tự đặc biệt");
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(316, 74);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(300, 31);
            txtSDT.TabIndex = 7;
            toolTip1.SetToolTip(txtSDT, "Nhập đúng 10 chữ số, không chứa khoảng trắng hay ký tự đặc biệt");
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(316, 123);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 31);
            txtEmail.TabIndex = 8;
            toolTip1.SetToolTip(txtEmail, "Email dùng để nhận thông báo lịch tập và khuyến mãi");
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(316, 184);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(300, 31);
            dtpNgaySinh.TabIndex = 9;
            toolTip1.SetToolTip(dtpNgaySinh, "Chọn ngày sinh");
            // 
            // cboGoiTap
            // 
            cboGoiTap.FormattingEnabled = true;
            cboGoiTap.Items.AddRange(new object[] { "Basic", "VIP", "Premium" });
            cboGoiTap.Location = new Point(316, 243);
            cboGoiTap.Name = "cboGoiTap";
            cboGoiTap.Size = new Size(300, 33);
            cboGoiTap.TabIndex = 10;
            toolTip1.SetToolTip(cboGoiTap, "Gói VIP và Premium có kèm huấn luyện viên");
            // 
            // nudSoBuoi1Tuan
            // 
            nudSoBuoi1Tuan.Location = new Point(316, 317);
            nudSoBuoi1Tuan.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            nudSoBuoi1Tuan.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoBuoi1Tuan.Name = "nudSoBuoi1Tuan";
            nudSoBuoi1Tuan.Size = new Size(300, 31);
            nudSoBuoi1Tuan.TabIndex = 11;
            toolTip1.SetToolTip(nudSoBuoi1Tuan, "Chọn số buổi tập trong 1 tuần mà bạn có thể tham gia");
            nudSoBuoi1Tuan.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(367, 407);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(158, 58);
            btnDangKy.TabIndex = 12;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 100;
            toolTip1.ShowAlways = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 510);
            Controls.Add(btnDangKy);
            Controls.Add(nudSoBuoi1Tuan);
            Controls.Add(cboGoiTap);
            Controls.Add(dtpNgaySinh);
            Controls.Add(txtEmail);
            Controls.Add(txtSDT);
            Controls.Add(txtHoTen);
            Controls.Add(label6);
            Controls.Add(lblGoiTap);
            Controls.Add(lblNgaySinh);
            Controls.Add(lblEmail);
            Controls.Add(lblSDT);
            Controls.Add(lblHoTen);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudSoBuoi1Tuan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoTen;
        private Label lblSDT;
        private Label lblEmail;
        private Label lblNgaySinh;
        private Label lblGoiTap;
        private Label label6;
        private TextBox txtHoTen;
        private TextBox txtSDT;
        private TextBox txtEmail;
        private DateTimePicker dtpNgaySinh;
        private ComboBox cboGoiTap;
        private NumericUpDown nudSoBuoi1Tuan;
        private Button btnDangKy;
        private ToolTip toolTip1;
    }
}
