namespace BezierSpline
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
            ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
        }
        int realSize = 3;
        bool canDraw = false;
        bool newDraw = false;
        Graphics g;
        Bitmap bmp;

        PointF[] pointsBezier = new PointF[10];


        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "N/A";
            label2.Text = "N/A";
            checkBox1.Enabled = false;
            Print_System();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Print_System()
        {
            if (newDraw)
            {
                realSize = 3;
                canDraw = false;
                PointF[] pointsBezier = new PointF[10];
                newDraw = false;
                pictureBox1.Invalidate();
            }
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            int w = pictureBox1.ClientSize.Width / 2;
            int h = pictureBox1.ClientSize.Height / 2;
            g.TranslateTransform(w, h);

            g.DrawLine(Pens.Black, new Point(-w, 0), new Point(w, 0));
            g.DrawLine(Pens.Black, new Point(0, h), new Point(0, -h));
            g.DrawLine(Pens.Black, new Point(w - 1, h), new Point(w - 1, -h));
            g.DrawLine(Pens.Black, new Point(-w, h), new Point(-w, -h));
            g.DrawLine(Pens.Black, new Point(-w, -h), new Point(w, -h));
            g.DrawLine(Pens.Black, new Point(-w, h), new Point(w, h));
            pictureBox1.Image = bmp;
            pointsBezier[0].X = w + 1;
            pointsBezier[0].Y = h + 1;
            pointsBezier[1].X = w + 1;
            pointsBezier[1].Y = h + 1;
            pointsBezier[2].X = w + 1;
            pointsBezier[2].Y = h + 1;
            pointsBezier[3].X = w + 1;
            pointsBezier[3].Y = h + 1;
            pointsBezier[4].X = w + 1;
            pointsBezier[4].Y = h + 1;
            pointsBezier[5].X = w + 1;
            pointsBezier[5].Y = h + 1;
            pointsBezier[6].X = w + 1;
            pointsBezier[6].Y = h + 1;
            pointsBezier[7].X = w + 1;
            pointsBezier[7].Y = h + 1;
            pointsBezier[8].X = w + 1;
            pointsBezier[8].Y = h + 1;
            pointsBezier[9].X = w + 1;
            pointsBezier[9].Y = h + 1;

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int w = pictureBox1.ClientSize.Width / 2;
            int h = pictureBox1.ClientSize.Height / 2;
            int x = Convert.ToInt32(e.X); // координата по оси X
            int y = Convert.ToInt32(e.Y); // координата по оси Y
            label1.Text = (x - w).ToString();
            label2.Text = (-(y - h)).ToString();
        }

        private void clearText()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Enabled == true)
            {
                clearText();
                realSize = 3;
                canDraw = false;
                PointF[] pointsBezier = new PointF[10];
                newDraw = false;
                checkBox1.Enabled = false;
                Print_System();
            }
            label15.Text = "";
            g = Graphics.FromImage(bmp);
            int w = pictureBox1.ClientSize.Width / 2;
            int h = pictureBox1.ClientSize.Height / 2;
            g.TranslateTransform(w, h);

            int x = Convert.ToInt32(label1.Text);
            int y = Convert.ToInt32(label2.Text);

            for (int i = 0; i < pointsBezier.Length; i++)
            {
                if (pointsBezier[i].X == w + 1 && pointsBezier[i].Y == h + 1)
                {
                    pointsBezier[i].X = x;
                    pointsBezier[i].Y = y;
                    if (i != 0)
                    {
                        PointF start = new PointF(pointsBezier[i - 1].X, -pointsBezier[i - 1].Y);
                        PointF end = new PointF(pointsBezier[i].X, -pointsBezier[i].Y);
                        g.DrawLine(new Pen(Color.DarkOrchid), start, end);
                    }
                    switch (++i)
                    {
                        case 1:
                            g.FillRectangle(Brushes.DarkRed, x, -y, 5, 5);
                            textBox1.Text = label1.Text;
                            textBox2.Text = label2.Text; break;
                        case 2:
                            g.FillRectangle(Brushes.Crimson, x, -y, 5, 5);
                            textBox3.Text = label1.Text;
                            textBox4.Text = label2.Text; break;
                        case 3:
                            g.FillRectangle(Brushes.Green, x, -y, 5, 5);
                            textBox5.Text = label1.Text;
                            textBox6.Text = label2.Text;
                            canDraw = true;
                            break;
                        case 4:
                            g.FillRectangle(Brushes.RoyalBlue, x, -y, 5, 5);
                            textBox7.Text = label1.Text;
                            textBox8.Text = label2.Text; realSize = 4; break;
                        case 5:
                            g.FillRectangle(Brushes.DarkCyan, x, -y, 5, 5);
                            textBox9.Text = label1.Text;
                            textBox10.Text = label2.Text; realSize = 5; break;
                        case 6:
                            g.FillRectangle(Brushes.Orange, x, -y, 5, 5);
                            textBox11.Text = label1.Text;
                            textBox12.Text = label2.Text; realSize = 6; break;
                        case 7:
                            g.FillRectangle(Brushes.Olive, x, -y, 5, 5);
                            textBox13.Text = label1.Text;
                            textBox14.Text = label2.Text; realSize = 7; break;
                        case 8:
                            g.FillRectangle(Brushes.MediumTurquoise, x, -y, 5, 5);
                            textBox15.Text = label1.Text;
                            textBox16.Text = label2.Text; realSize = 8; break;
                        case 9:
                            g.FillRectangle(Brushes.SandyBrown, x, -y, 5, 5);
                            textBox17.Text = label1.Text;
                            textBox18.Text = label2.Text; realSize = 9; break;
                        case 10:
                            g.FillRectangle(Brushes.DarkGoldenrod, x, -y, 5, 5);
                            textBox19.Text = label1.Text;
                            textBox20.Text = label2.Text; realSize = 10; break;
                        default: break;
                    }
                    break;
                }
            }
            pictureBox1.Image = bmp;
        }

        private int Fuctorial(int n) // Функция вычисления факториала
        {
            int res = 1;
            for (int i = 1; i <= n; i++)
                res *= i;
            return res;
        }

        private float polinom(int i, int n, float t)// Функция вычисления полинома Бернштейна
        {
            return (Fuctorial(n) / (Fuctorial(i) * Fuctorial(n - i))) * (float)Math.Pow(t, i) * (float)Math.Pow(1 - t, n - i);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (canDraw)
            {
                g = Graphics.FromImage(bmp);
                int w = pictureBox1.ClientSize.Width / 2;
                int h = pictureBox1.ClientSize.Height / 2;
                g.TranslateTransform(w, h);
                int j = 0;
                float step = 0.01f;
                PointF[] result = new PointF[101];//Конечный массив точек кривой
                for (float t = 0; t < 1; t += step)
                {
                    float ytmp = 0;
                    float xtmp = 0;
                    for (int i = 0; i < realSize; i++)
                    { // проходим по каждой точке
                        float b = polinom(i, realSize - 1, t); // вычисляем наш полином Бернштейна
                        xtmp += pointsBezier[i].X * b; // записываем и прибавляем результат
                        ytmp += pointsBezier[i].Y * b;
                    }
                    result[j] = new PointF(xtmp, -ytmp);
                    j++;
                }
                g.DrawLines(new Pen(Color.SteelBlue), result);
                checkBox1.Enabled = true;
                pictureBox1.Image = bmp;
                label15.Text = "Нажмите Refresh,\nчтобы продолжить";
            }
            else
            {
                label15.Text = "Введите координаты\nхотя бы\nтрёх точек";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            newDraw = true;
            checkBox1.Enabled = false;
            clearText();
            Print_System();
        }
    }
}