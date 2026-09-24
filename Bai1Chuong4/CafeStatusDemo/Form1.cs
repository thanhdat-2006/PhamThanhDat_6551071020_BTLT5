namespace CafeStatusDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblGioHienTai.Text = DateTime.Now.ToString("HH:mm:ss");

            int hour = DateTime.Now.Hour;

            if (hour >= 6 && hour < 22)
            {
                lblTrangThai.Text = "Đang mở cửa";
                lblTrangThai.ForeColor = Color.Green;
            }
            else
            {
                lblTrangThai.Text = "Đã đóng cửa";
                lblTrangThai.ForeColor = Color.Red;
            }

        }

        private void mnuItemDoiMauNen_Click(object sender, EventArgs e)
        {
            ColorDialog colordialog = new ColorDialog();

            if (colordialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colordialog.Color;
            }
        }

        private void mnuItemThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
