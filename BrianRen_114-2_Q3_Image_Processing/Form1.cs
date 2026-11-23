namespace BrianRen_114_2_Q3_Image_Processing {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog d = new OpenFileDialog())
            {
                if (d.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(d.FileName);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            int h = bmp.Height, w = bmp.Width;
            Bitmap nBmp = new Bitmap(w, h);

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    var color = bmp.GetPixel(j, i);
                    int r = color.R, g = color.G, b = color.B;
                    int l = Math.Min(255, (int)(0.299 * r) + (int)(0.587 * g) + (int)(0.114 * b));
                    nBmp.SetPixel(j, i, Color.FromArgb(l, l, l));
                }
            }
            pictureBox2.Image = nBmp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            int h = bmp.Height, w = bmp.Width;
            Bitmap nBmp = new Bitmap(w, h);

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    var color = bmp.GetPixel(j, i);
                    int r = color.R, g = color.G, b = color.B;
                    nBmp.SetPixel(j, i, Color.FromArgb(255 - r, 255 - g, 255 - b));
                }
            }
            pictureBox3.Image = nBmp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == null) return;
            Bitmap bmp = (Bitmap)pictureBox2.Image;
            int h = bmp.Height, w = bmp.Width;
            Bitmap nBmp = new Bitmap(w, h);

            double min = double.MaxValue, max = double.MinValue;

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    var color = bmp.GetPixel(j, i);
                    int r = color.R, g = color.G, b = color.B;
                    double l = Math.Min(255, (0.299 * r) + (0.587 * g) + (0.114 * b));
                    min = Math.Min(min, l);
                    max = Math.Max(max, l);
                }
            }

            label4.Text = max.ToString();
            label3.Text = min.ToString();

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    var color = bmp.GetPixel(j, i);
                    int l = color.R;
                    int G = Math.Min(255, (int)((l - min) / (max - min) * 255));
                    nBmp.SetPixel(j, i, Color.FromArgb(G,G,G));
                }
            }
            pictureBox4.Image = nBmp;
        }
    }
}
