namespace BrianRen_104_北軟_P4_Img_Quality {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog odf = new OpenFileDialog())
            {
                odf.Filter = "JPG File *.jpg|*.jpg";
                if (odf.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(odf.FileName);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;
            double sigmaAsqr = 0,
                   sigmaBsqr = 0,
                   microA = 0,
                   microB = 0;
            
            var img = (Bitmap)pictureBox1.Image;
            int w = img.Width,
                h = img.Height;
            for (int i = 0; i < w; i++)
            {
                for(int j = 0; j < h; j++)
                {
                    var p = img.GetPixel(i, j);
                    int r = p.R, g = p.G, b = p.B;
                    var a = r - g;
                    var beta = (r + g) * 0.5 - b;
                    microA += a;
                    microB += beta;
                }
            }

            microA /= (w * h);
            microB /= (w * h);
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    var p = img.GetPixel(i, j);
                    int r = p.R, g = p.G, b = p.B;
                    var a = r - g;
                    var beta = (r + g) * 0.5 - b;
                    sigmaAsqr += a * a - microA * microA;
                    sigmaBsqr += beta * beta - microB * microB;
                }
            }
            sigmaAsqr /= (w * h);
            sigmaBsqr /= (w * h);

            var QM1 = (Math.Sqrt(sigmaAsqr + sigmaBsqr) + 0.3 * Math.Sqrt(microA * microA + microB * microB)) / 85.59;
            var QM2 = 0.02 * Math.Log(sigmaAsqr / Math.Pow(Math.Abs(microA), 0.2)) * Math.Log(sigmaBsqr / Math.Pow(Math.Abs(microB), 0.2));
            textBox1.Text = QM1.ToString();
            textBox2.Text = QM2.ToString();
        }
    }
}
