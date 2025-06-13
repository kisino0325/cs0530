namespace cs0530
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -10;
        int vx2 = -10;
        int vy2 = -10;
        int vx3 = -10;
        int vy3 = -10;
        int counter = 0;
        static Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            vx = random.Next(-10, 11);
            vy = random.Next(-10, 11);
            vx2 = random.Next(-10, 11);
            vy2 = random.Next(-10, 11);
            vx3 = random.Next(-10, 11);
            vy3 = random.Next(-10, 11);

            label1.Left = random.Next(ClientSize.Width - label1.Width);
            label1.Top = random.Next(ClientSize.Height - label1.Height);
            label4.Left = random.Next(ClientSize.Width - label4.Width);
            label4.Top = random.Next(ClientSize.Height - label4.Height);
            label5.Left = random.Next(ClientSize.Width - label5.Width);
            label5.Top = random.Next(ClientSize.Height - label5.Height);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            label3.Text = $"{counter}";
            var mpos = MousePosition;
            var fpos = PointToClient(mpos);

            Text = $"{mpos.X},{mpos.Y} /{fpos.X},{fpos.Y}";

            label4.Left += vx;
            label4.Top += vy;
            label5.Left += vx;
            label5.Top += vy;
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
            if (label4.Left < 0)
            {
                vx2 = Math.Abs(vx2);
            }
            else if (label4.Right > ClientSize.Width)
            {
                vx2 = -Math.Abs(vx2);
            }
            if (label4.Top < 0)
            {
                vy2 = Math.Abs(vy2);
            }
            else if (label4.Bottom > ClientSize.Height)
            {
                vy2 = -Math.Abs(vy2);
            }
            if (label4.Left < label2.Right && label4.Right > label2.Left && label4.Top < label2.Bottom && label4.Bottom > label2.Top)
            {
                timer1.Enabled = false;
            }
            if (fpos.X > label4.Left
                && fpos.X < label4.Top
                && fpos.Y > label4.Right
                && fpos.Y < label4.Bottom) ;
            if (label5.Left < 0)
            {
                vx3 = Math.Abs(vx3);
            }
            else if (label5.Right > ClientSize.Width)
            {
                vx3 = -Math.Abs(vx3);
            }
            if (label5.Top < 0)
            {
                vy3 = Math.Abs(vy3);
            }
            else if (label5.Bottom > ClientSize.Height)
            {
                vy3 = -Math.Abs(vy3);
            }
            if (label5.Left < label2.Right && label5.Right > label2.Left && label5.Top < label2.Bottom && label5.Bottom > label2.Top)
            {
                timer1.Enabled = false;
            }
            if (fpos.X > label5.Left
                && fpos.X < label5.Top
                && fpos.Y > label5.Right
                && fpos.Y < label5.Bottom) ;

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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
