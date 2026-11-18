namespace BrianRen_102_Q4_Picture_Inflate {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image, bitmap = new Bitmap(bmp);
            if (bmp == null) return;
            int[] offfsetX = [-1, -1, -1, 0, 0, 0, 1, 1, 1];
            int[] offfsetY = [-1, 0, 1, -1, 0, 1, -1, 0, 1];

            for (int i = 1; i < bmp.Width - 1; i++)
            {
                for(int j = 1; j < bmp.Height - 1; j++)
                {
                    Color c = bmp.GetPixel(i, j);
                    int r = c.R, g = c.G, b = c.B;
                    if (r + g + b < 240)
                    {
                        for (int k = 0; k < 9; k++)
                        {
                            bitmap.SetPixel(i + offfsetX[k], j + offfsetY[k], Color.Black);
                        }
                    }
                }
            } 
            pictureBox1.Image = bitmap;
        }
    }
}
