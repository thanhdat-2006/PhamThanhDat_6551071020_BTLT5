namespace CafeStatusDemo
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
            menuStrip1 = new MenuStrip();
            mnuHeThong = new ToolStripMenuItem();
            mnuItemDoiMauNen = new ToolStripMenuItem();
            mnuItemThoat = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblGioHienTai = new ToolStripStatusLabel();
            lblTenQuan = new ToolStripStatusLabel();
            lblTrangThai = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuHeThong });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuItemDoiMauNen, mnuItemThoat });
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(103, 29);
            mnuHeThong.Text = "Hệ thống";
            // 
            // mnuItemDoiMauNen
            // 
            mnuItemDoiMauNen.Name = "mnuItemDoiMauNen";
            mnuItemDoiMauNen.Size = new Size(216, 34);
            mnuItemDoiMauNen.Text = "Đổi màu nền";
            mnuItemDoiMauNen.Click += mnuItemDoiMauNen_Click;
            // 
            // mnuItemThoat
            // 
            mnuItemThoat.Name = "mnuItemThoat";
            mnuItemThoat.Size = new Size(216, 34);
            mnuItemThoat.Text = "Thoát";
            mnuItemThoat.Click += mnuItemThoat_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblGioHienTai, lblTenQuan, lblTrangThai });
            statusStrip1.Location = new Point(0, 418);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 32);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblGioHienTai
            // 
            lblGioHienTai.Name = "lblGioHienTai";
            lblGioHienTai.Size = new Size(107, 25);
            lblGioHienTai.Text = "Giờ Hiện Tại";
            lblGioHienTai.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTenQuan
            // 
            lblTenQuan.Name = "lblTenQuan";
            lblTenQuan.Size = new Size(532, 25);
            lblTenQuan.Spring = true;
            lblTenQuan.Text = "CAFE ÁNH DƯƠNG";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = false;
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Overflow = ToolStripItemOverflow.Never;
            lblTrangThai.Size = new Size(100, 25);
            lblTrangThai.Text = "Trạng Thái";
            lblTrangThai.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuItemDoiMauNen;
        private ToolStripMenuItem mnuItemThoat;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblGioHienTai;
        private ToolStripStatusLabel lblTenQuan;
        private System.Windows.Forms.Timer timer1;
        private ToolStripStatusLabel lblTrangThai;
        private ToolStripStatusLabel spacer1;
        private ToolStripStatusLabel spacer2;
    }
}
