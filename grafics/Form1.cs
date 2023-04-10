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
    }
}