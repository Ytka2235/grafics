namespace grafics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen pen1 = new Pen(Color.Black);
            Pen pen2 = new Pen(Color.Red);
            Pen pen3 = new Pen(Color.Blue);
            Pen pen4 = new Pen(Color.Green);
            Point[] points = new Point[1600];
            Random rnd = new Random();
            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.Clear(Color.White);
            int x = rnd.Next(1, 800);
            for(int i = 0; i < 1600;i++)
            {
                points[i] = new Point(x,i);
            }
            graphics.DrawLines(pen1, points);
            x = rnd.Next(1, 400);
            for (int i = 0; i < 1600; i++)
            {
                points[i] = new Point(i, x);
            }
            graphics.DrawLines(pen2, points);
            x = rnd.Next(-700, 700);
            for (int i = 0; i < 1600; i++)
            {
                points[i] = new Point(x, i);
                x++;
            }
            graphics.DrawLines(pen3, points);
            x = rnd.Next(0, 1400);
            for (int i = 0; i < 1600; i++)
            {
                points[i] = new Point(x, i);
                x--;
            }
            graphics.DrawLines(pen4, points);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Graphics graphics = pictureBox1.CreateGraphics();
            Bitmap image = new Bitmap(800,400,graphics);
            graphics.Clear(Color.White);
            for(int i = 0;i < 10000;i++)
            {
                image.SetPixel(rnd.Next(1,800), rnd.Next(1, 400),Color.Yellow);
                image.SetPixel(rnd.Next(1, 800), rnd.Next(1, 400), Color.Red);
                image.SetPixel(rnd.Next(1, 800), rnd.Next(1, 400), Color.Green);
                image.SetPixel(rnd.Next(1, 800), rnd.Next(1, 400), Color.Blue);
            }
            pictureBox1.Image = image;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pen pen1 = new Pen(Color.Black);
            Pen pen2 = new Pen(Color.Red);
            Pen pen3 = new Pen(Color.Blue);
            Pen pen4 = new Pen(Color.Green);
            Random rnd = new Random();
            int x;
            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.Clear(Color.White);
            for(int i = 0; i<=20;i++)
            {
                x = rnd.Next(5, 100);
                graphics.DrawEllipse(pen1, rnd.Next(-100,800), rnd.Next(-100, 400), x, x);
                x = rnd.Next(5, 100);
                graphics.DrawEllipse(pen2, rnd.Next(-100, 800), rnd.Next(-100, 400), x, x);
                x = rnd.Next(5, 100);
                graphics.DrawEllipse(pen3, rnd.Next(-100, 800), rnd.Next(-100, 400), x, x);
                x = rnd.Next(5, 100);
                graphics.DrawEllipse(pen4, rnd.Next(-100, 800), rnd.Next(-100, 400), x, x);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen1 = new Pen(Color.Black);
            graphics.Clear(Color.White);
            Point[] pointy = new Point[2] { new Point(400,0) , new Point(400,400)};
            Point[] pointx = new Point[2] { new Point(0, 200), new Point(800, 200) };
            graphics.DrawLines(pen1,pointy);
            graphics.DrawLines(pen1, pointx);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen1 = new Pen(Color.Black);
            graphics.Clear(Color.White);
            Point[] points = new Point[800];
            int y;
            for (int x = -400, i = 0; x < 400; x++,i++)
            {
                y = -(int)(Math.Sin((double)x / 40 ) * 40 ) +200 ;
                points[i] = new Point(x + 400, y);
            }
            graphics.DrawLines(pen1, points);
            Point[] pointy = new Point[2] { new Point(400, 0), new Point(400, 400) };
            Point[] pointx = new Point[2] { new Point(0, 200), new Point(800, 200) };
            graphics.DrawLines(pen1, pointy);
            graphics.DrawLines(pen1, pointx);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.Clear(Color.White);
            Pen pen1 = new Pen(Color.Black, 1f);
            Point[] points = new Point[800];
            int y;
            for (int x = -400, i = 0; x < 400; x++, i++)
            {
                y = -(x*x/80) + 200;
                points[i] = new Point(x + 400, y);
            }
            graphics.DrawLines(pen1, points);
            Point[] pointy = new Point[2] { new Point(400, 0), new Point(400, 400) };
            Point[] pointx = new Point[2] { new Point(0, 200), new Point(800, 200) };
            graphics.DrawLines(pen1, pointy);
            graphics.DrawLines(pen1, pointx);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.Clear(Color.White);
            Pen pen1 = new Pen(Color.Black, 1f);
            Point[] points = new Point[800];
            int y;
            for (int x = -400, i = 0; x < 400; x++, i++)
            {
                y = -(x * x * x / 1200) + 200;
                points[i] = new Point(x + 400, y);
            }
            graphics.DrawLines(pen1, points);
            Point[] pointy = new Point[2] { new Point(400, 0), new Point(400, 400) };
            Point[] pointx = new Point[2] { new Point(0, 200), new Point(800, 200) };
            graphics.DrawLines(pen1, pointy);
            graphics.DrawLines(pen1, pointx);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.Clear(Color.White);
            Pen pen1 = new Pen(Color.Black, 1f);
            Point[] points = new Point[800];
            int y;
            for (int x = -400, i = 0; x < 401; x++, i++)
            {
                if (x == 0) x++;
                y = (int)(-(1/((double)x/400)) + 200);
                points[i] = new Point(x + 400, y);
            }
            graphics.DrawLines(pen1, points);
            Point[] pointy = new Point[2] { new Point(400, 0), new Point(400, 400) };
            Point[] pointx = new Point[2] { new Point(0, 200), new Point(800, 200) };
            graphics.DrawLines(pen1, pointy);
            graphics.DrawLines(pen1, pointx);
        }
    }
}