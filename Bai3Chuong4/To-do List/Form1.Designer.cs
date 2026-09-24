namespace To_do_List
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
            lblCongViecMoi = new Label();
            txtCongViecMoi = new TextBox();
            btnThem = new Button();
            lstCongViec = new ListBox();
            cmsCongViec = new ContextMenuStrip(components);
            mnuDanhDauHoanThanh = new ToolStripMenuItem();
            mnuXoaCongViecNay = new ToolStripMenuItem();
            mnuXoaTatCa = new ToolStripMenuItem();
            cmsCongViec.SuspendLayout();
            SuspendLayout();
            // 
            // lblCongViecMoi
            // 
            lblCongViecMoi.AutoSize = true;
            lblCongViecMoi.Location = new Point(100, 31);
            lblCongViecMoi.Name = "lblCongViecMoi";
            lblCongViecMoi.Size = new Size(130, 25);
            lblCongViecMoi.TabIndex = 0;
            lblCongViecMoi.Text = "Công việc mới:";
            // 
            // txtCongViecMoi
            // 
            txtCongViecMoi.Location = new Point(275, 25);
            txtCongViecMoi.Name = "txtCongViecMoi";
            txtCongViecMoi.Size = new Size(261, 31);
            txtCongViecMoi.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(581, 22);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // lstCongViec
            // 
            lstCongViec.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstCongViec.ContextMenuStrip = cmsCongViec;
            lstCongViec.FormattingEnabled = true;
            lstCongViec.Location = new Point(-1, 94);
            lstCongViec.Name = "lstCongViec";
            lstCongViec.Size = new Size(798, 354);
            lstCongViec.TabIndex = 3;
            // 
            // cmsCongViec
            // 
            cmsCongViec.ImageScalingSize = new Size(24, 24);
            cmsCongViec.Items.AddRange(new ToolStripItem[] { mnuDanhDauHoanThanh, mnuXoaCongViecNay, mnuXoaTatCa });
            cmsCongViec.Name = "cmsCongViec";
            cmsCongViec.Size = new Size(257, 100);
            // 
            // mnuDanhDauHoanThanh
            // 
            mnuDanhDauHoanThanh.Name = "mnuDanhDauHoanThanh";
            mnuDanhDauHoanThanh.Size = new Size(256, 32);
            mnuDanhDauHoanThanh.Text = "Đánh dấu hoàn thành";
            mnuDanhDauHoanThanh.Click += mnuDanhDauHoanThanh_Click;
            // 
            // mnuXoaCongViecNay
            // 
            mnuXoaCongViecNay.Name = "mnuXoaCongViecNay";
            mnuXoaCongViecNay.Size = new Size(256, 32);
            mnuXoaCongViecNay.Text = "Xóa công việc này";
            mnuXoaCongViecNay.Click += mnuXoaCongViecNay_Click;
            // 
            // mnuXoaTatCa
            // 
            mnuXoaTatCa.Name = "mnuXoaTatCa";
            mnuXoaTatCa.Size = new Size(256, 32);
            mnuXoaTatCa.Text = "Xóa tất cả";
            mnuXoaTatCa.Click += mnuXoaTatCa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstCongViec);
            Controls.Add(btnThem);
            Controls.Add(txtCongViecMoi);
            Controls.Add(lblCongViecMoi);
            Name = "Form1";
            Text = "Form1";
            cmsCongViec.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCongViecMoi;
        private TextBox txtCongViecMoi;
        private Button btnThem;
        private ListBox lstCongViec;
        private ContextMenuStrip cmsCongViec;
        private ToolStripMenuItem mnuDanhDauHoanThanh;
        private ToolStripMenuItem mnuXoaCongViecNay;
        private ToolStripMenuItem mnuXoaTatCa;
    }
}
