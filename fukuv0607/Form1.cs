namespace fukuv0607
{
    public partial class Form1 : Form
    {
        int vx = -4;
        int vy = -4;
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Text = "ngan";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            label3.Text =$"{counter}";

            var fpos = PointToClient(MousePosition);
            //label1.Text = $"{fpos.X},{fpos.Y}";
            label2.Left = fpos.X;
            label2.Top = fpos.Y;
            if ((fpos.X > label1.Left)
                && (fpos.X < label1.Right)
                && (fpos.Y > label1.Top)
                && (fpos.Y < label1.Bottom))
            {
                timer1.Enabled = false;
            }
            if (label2.Left < ClientSize.Width)
            {
                vx = Math.Abs(vx);
            }


            label1.Left += vx;
            label1.Top += vy;
            if (label1.Left < 0)
            {

                vx = Math.Abs(vx);
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy);

            }
            if (label1.Left + label1.Width > ClientSize.Width)
            {
                vx = -Math.Abs(vx);
            }
            if (label1.Top + label1.Height > ClientSize.Height)
            {
                vy = -Math.Abs(vy);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
