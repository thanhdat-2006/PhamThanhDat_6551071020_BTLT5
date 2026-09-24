namespace SieuThi
{
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string dongMoi = $"{txtMaSP.Text} | {txtSoLuong.Text} | {txtDonGia.Text}";

            lstKetQua.Items.Add(dongMoi);
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtMaSP.Focus();
        }

        private void frmBanHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnThem.PerformClick();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnXoaTrang.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                DialogResult traLoi = MessageBox.Show(
                    "Bạn có muốn thoát?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (traLoi == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
    }
}
