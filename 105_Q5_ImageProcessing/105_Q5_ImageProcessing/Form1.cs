namespace _105_Q5_ImageProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    raw.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var bmp = (Bitmap)raw.Image;
            for(int i = 0; i < bmp.Width; i++)
            {
                for(int j = 0; j < bmp.Height; j++)
                {
                    var pixel = bmp.GetPixel(i, j);
                    var g = (int)(pixel.R * .3 + .59 * pixel.G + .11 * pixel.B);
                    if (g >= 255) g = 255;
                    bmp.SetPixel(i, j, Color.FromArgb(g,g,g));
                }
            }
            gray.Image = bmp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var bmp = (Bitmap)raw.Image;
            var rBmp = (Bitmap)bmp.Clone();
            var gBmp = (Bitmap)bmp.Clone();
            var bBmp = (Bitmap)bmp.Clone();
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    var pixel = bmp.GetPixel(i, j);
                    rBmp.SetPixel(i, j, Color.FromArgb(pixel.R, 0, 0));
                    gBmp.SetPixel(i, j, Color.FromArgb(0, pixel.G, 0));
                    bBmp.SetPixel(i, j, Color.FromArgb(0, 0, pixel.B));
                }
            }
            r.Image = rBmp;
            g.Image = gBmp;
            b.Image = bBmp;
        }
    }
}