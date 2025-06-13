namespace cs0530
{
    public partial class Form1 : Form
    {
        int[] vx = new int[3];
        int[] vy = new int[3];

        int counter = 0;
        static Random random = new Random();
        public Form1()
        {
            InitializeComponent();

            vx[0] = random.Next(-10, 11);
            vy[0] = random.Next(-10, 11);
            vx[1] = random.Next(-69, 83);
            vy[1] = random.Next(-69, 83);
            vx[2] = random.Next(-77, 91);
            vy[2] = random.Next(-77, 91);

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

            label4.Left += vx[1];
            label4.Top += vy[1];
            label5.Left += vx[2];
            label5.Top += vy[2];
            label2.Left = fpos.X - label2.Width / 2;
            label2.Top = fpos.Y - label2.Height / 2;

            label1.Left += vx[0];
            label1.Top += vy[0];
            if (label1.Left < 0)
            {
                vx[0] = Math.Abs(vx[0]);
            }
            else if (label1.Right > ClientSize.Width)
            {
                vx[0] = -Math.Abs(vx[0]);
            }
            if (label1.Top < 0)
            {
                vy[0] = Math.Abs(vy[0]);
            }
            else if (label1.Bottom > ClientSize.Height)
            {
                vy[0] = -Math.Abs(vy[0]);
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
                vx[1] = Math.Abs(vx[1]);
            }
            else if (label4.Right > ClientSize.Width)
            {
                vx[1] = -Math.Abs(vx[1]);
            }
            if (label4.Top < 0)
            {
                vy[1] = Math.Abs(vy[1]);
            }
            else if (label4.Bottom > ClientSize.Height)
            {
                vy[1] = -Math.Abs(vy[1]);
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
                vx[2] = Math.Abs(vx[2]);
            }
            else if (label5.Right > ClientSize.Width)
            {
                vx[2] = -Math.Abs(vx[2]);
            }
            if (label5.Top < 0)
            {
                vy[2] = Math.Abs(vy[2]);
            }
            else if (label5.Bottom > ClientSize.Height)
            {
                vy[2] = -Math.Abs(vy[2]);
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

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i=0; i<10;i++)
            {
                MessageBox.Show($"{i}");
            }
        }
    }
}
