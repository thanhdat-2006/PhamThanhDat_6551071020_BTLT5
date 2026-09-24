namespace GymFitLife
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ họ tên và số điện thoại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string goiTap = cboGoiTap.Text;
                string soBuoi = nudSoBuoi1Tuan.Text;

                string thongTin = $"Họ tên: {txtHoTen.Text}\n" +
                                  $"SĐT: {txtSDT.Text}\n" +
                                  $"Gói tập: {goiTap}\n" +
                                  $"Số buổi/tuần: {soBuoi}";
                MessageBox.Show(thongTin, "Thông tin đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
