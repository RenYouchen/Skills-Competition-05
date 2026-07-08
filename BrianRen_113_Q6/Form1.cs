namespace BrianRen_113_Q6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "All File|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "JPEG Image|*.jpg|PNG Image|*.png|Bitmap Image|*.bmp|TIFF Image|*.tif";
                if (sfd.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var image = (Bitmap)pictureBox1.Image;
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    var p = image.GetPixel(i, j);
                    int color = (int)(0.3 * p.R + 0.59 * p.G + 0.11 * p.B);
                    image.SetPixel(i, j, Color.FromArgb(color, color, color));
                }
            }
            pictureBox2.Image = image;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap result = new Bitmap(pictureBox2.Image.Width, pictureBox2.Image.Height);
            for(int i = 1; i < pictureBox2.Image.Width - 1; i++)
            {
                for(int j = 1;j < pictureBox2.Image.Height - 1; j++)
                {
                    int[,] pixels = new int[3, 3];
                    for (int x = -1; x < 2; x++)
                        for (int y = -1; y < 2; y++)
                            pixels[x+1,y+1] = ((Bitmap)pictureBox2.Image).GetPixel(i + x, j + y).R;
                    var gx = -pixels[0, 0] - 2 * pixels[1, 0] - pixels[2, 0] 
                        + pixels[0,2] + 2 * pixels[1,2] + pixels[2,2];
                    var gy = -pixels[0, 0] - 2 * pixels[0, 1] - pixels[0, 2]
                        + pixels[2, 0] + 2 * pixels[2, 1] + pixels[2, 2];
                    var g = (int)(Math.Sqrt(Math.Pow(gx, 2) + Math.Pow(gy, 2)));
                    if (g > 255) g = 255;
                    result.SetPixel(i, j, Color.FromArgb(g, g, g));
                }
            }
            pictureBox2.Image = result;
        }
    }
}
