namespace cs0530
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -10;
        int counter = 0;
        static Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            vx = random.Next(-10, 11);
            vy = random.Next(-10, 11);

            label1.Left = random.Next(ClientSize.Width - label1.Width);
            label1.Top = random.Next(ClientSize.Height - label1. Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            label3.Text = $"{counter}";
            var mpos = MousePosition;
            var fpos = PointToClient(mpos);

            Text = $"{mpos.X},{mpos.Y} /{fpos.X},{fpos.Y}";


            label2.Left = fpos.X - label2.Width / 2;
            label2.Top = fpos.Y - label2.Height / 2;

            label1.Left += vx;
            label1.Top += vy;
            if (label1.Left < 0)
            {
                vx = Math.Abs(vx);
            }
            else if (label1.Right > ClientSize.Width)
            {
                vx = -Math.Abs(vx);
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy);
            }
            else if (label1.Bottom > ClientSize.Height)
            {
                vy = -Math.Abs(vy);
            }
            if (label1.Left < label2.Right && label1.Right > label2.Left && label1.Top < label2.Bottom && label1.Bottom > label2.Top)
            {
                timer1.Enabled = false;
            }
            if (fpos.X > label1.Left
                && fpos.X < label1.Top
                && fpos.Y > label1.Right
                && fpos.Y < label1.Bottom) ;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            counter = 0;
            button1.Visible = false;
        }
    }
}
