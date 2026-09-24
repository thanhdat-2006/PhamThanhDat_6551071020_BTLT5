namespace BangVe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool isDrawing = false;
        Point previousPoint;

        private void pnlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                previousPoint = e.Location;
                lblViTri.Text = $"X: {e.X}, Y: {e.Y} - Đang vẽ...";
            }
        }

        private void pnlCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                lblViTri.Text = $"X: {e.X}, Y: {e.Y} - Đang vẽ...";

                using (Graphics g = pnlCanvas.CreateGraphics())
                {
                    g.DrawLine(Pens.Black, previousPoint, e.Location);
                }
                previousPoint = e.Location;
            }
            else
            {
                lblViTri.Text = $"X: {e.X}, Y: {e.Y} - Sẵn sàng";
            }
        }

        private void pnlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
                lblViTri.Text = $"X: {e.X}, Y: {e.Y} - Sẵn sàng";
            }
        }

        private void pnlCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pnlCanvas.Invalidate();
            }
        }
    }
}
