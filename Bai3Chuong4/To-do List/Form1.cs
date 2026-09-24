namespace To_do_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCongViecMoi.Text))
            {
                lstCongViec.Items.Add(txtCongViecMoi.Text);
                txtCongViecMoi.Clear();
            }
        }

        private void mnuDanhDauHoanThanh_Click(object sender, EventArgs e)
        {
            if (lstCongViec.SelectedItem != null)
            {
                int index = lstCongViec.SelectedIndex;
                string currentItem = lstCongViec.SelectedItem.ToString();

                if (!currentItem.StartsWith("[Hoàn thành] "))
                {
                    lstCongViec.Items[index] = "[Hoàn thành] " + currentItem;
                }
            }
        }

        private void mnuXoaCongViecNay_Click(object sender, EventArgs e)
        {
            if (lstCongViec.SelectedItem != null)
            {
                lstCongViec.Items.Remove(lstCongViec.SelectedItem);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một công việc trước khi xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mnuXoaTatCa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tất cả công việc?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lstCongViec.Items.Clear();
            }
        }
    }
}
