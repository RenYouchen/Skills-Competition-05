using System.Windows.Forms;

namespace BrianRen_105_Q6_Hidden_Image {
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
                    button2.Enabled = true;
                    button2.Text = "Reveal The Image Behind";
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
                    //if((r & 1) == 1) r = 16 
                    r = (r & 1) == 1 ? 16 : 235;
                    g = (g & 1) == 1 ? 16 : 235;
                    b = (b & 1) == 1 ? 16 : 235;
                    nBmp.SetPixel(j, i, Color.FromArgb(r, g, b));
                }
            }
            pictureBox1.Image = nBmp;
        }
    }
}
