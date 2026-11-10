using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace BrianRen_113_4_Q2_Image_Processing {
    public partial class Form1 : Form {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "10px";
            comboBox2.SelectedItem = "40px";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Load(ofd.FileName);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;
            var result = new Bitmap(pictureBox1.Image);
            var size = int.Parse(comboBox1.SelectedItem.ToString().Replace("px", ""));

            for (int i = 0; i < pictureBox1.Image.Width; i += size)
            {
                for (int j = 0; j < pictureBox1.Image.Height; j += size)
                {
                    var c = Average((Bitmap)pictureBox1.Image, i, j, size);
                    var g = Graphics.FromImage(result);
                    g.FillRectangle(new SolidBrush(c), i, j, size, size);
                }
            }
            pictureBox1.Image = result;
        }

        public Color Average(Bitmap src, int x0, int y0, int block)
        {
            int r = 0, g = 0, b = 0, n = 0;
            for (int i = x0; i < Math.Min(x0 + block, src.Width); i++)
            {
                for (int j = y0; j < Math.Min(y0 + block, src.Height); j++)
                {
                    Color c = src.GetPixel(i, j);
                    r += c.R; g += c.G; b += c.B;
                    n++;
                }
            }

            return Color.FromArgb(r / n, g / n, b / n);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    bmp.SetPixel(i, j, Brighter(bmp, i, j));
                }
            }
            pictureBox1.Image = bmp;
        }

        Color Brighter(Bitmap src, int x, int y)
        {
            var c = src.GetPixel(x, y);
            int r = c.R, g = c.G, b = c.B;
            return Color.FromArgb(Math.Min(255, r + 50), Math.Min(255, g + 50), Math.Min(255, b + 50));
        }

        Color Darker(Bitmap src, int x, int y)
        {
            var c = src.GetPixel(x, y);
            int r = c.R, g = c.G, b = c.B;
            return Color.FromArgb(Math.Max(0, r - 50), Math.Max(0, g - 50), Math.Max(0, b - 50));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    bmp.SetPixel(i, j, Darker(bmp, i, j));
                }
            }
            pictureBox1.Image = bmp;
        }
        int clickX = 0;
        int clickY = 0;


        private void button4_Click(object sender, EventArgs e)
        {
            int size = int.Parse(comboBox2.Text.Replace("px", ""));

            int lX = Math.Max(0, clickX - size / 2);
            int lY = Math.Max(0, clickY - size / 2);
            int rX = Math.Min(pictureBox1.Image.Width, clickX + size / 2);
            int rY = Math.Min(pictureBox1.Image.Height, clickY + size / 2);

            Bitmap bmp = new Bitmap(pictureBox1.Image);
            for (int i = lX; i < rX; i++)
            {
                for (int j = lY; j < rY; j++)
                {
                    bmp.SetPixel(i, j, Brighter(bmp, i, j));
                }
            }
            pictureBox1.Image = bmp;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            var bmp = new Bitmap(pictureBox1.Image);
            clickX = e.X * bmp.Width / pictureBox1.Width;
            clickY = e.Y * bmp.Height / pictureBox1.Height;
            Debug.WriteLine((clickX, clickY));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int size = int.Parse(comboBox2.Text.Replace("px", ""));

            int lX = Math.Max(0, clickX - size / 2);
            int lY = Math.Max(0, clickY - size / 2);
            int rX = Math.Min(pictureBox1.Image.Width, clickX + size / 2);
            int rY = Math.Min(pictureBox1.Image.Height, clickY + size / 2);

            Bitmap bmp = new Bitmap(pictureBox1.Image);
            for (int i = lX; i < rX; i++)
            {
                for (int j = lY; j < rY; j++)
                {
                    bmp.SetPixel(i, j, Darker(bmp, i, j));
                }
            }
            pictureBox1.Image = bmp;
        }
    }
}
