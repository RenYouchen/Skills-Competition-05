using System.Diagnostics;

namespace BrianRen_Simu_1st_Q5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int n;
        List<Rectangle> rects = new List<Rectangle>();
        bool flag = false;
        private void button1_Click(object sender, EventArgs e)
        {
            var rawText = richTextBox1.Text.Split('\n');
            rects.Clear();
            n = int.Parse(rawText[0]);
            for (int i = 1; i < n + 1; i++)
            {
                var rawPos = rawText[i].Split(' ').Select(int.Parse).ToList();
                int w = rawPos[2] - rawPos[0];
                int h = rawPos[3] - rawPos[1];
                rects.Add(new Rectangle(rawPos[0] * 10, rawPos[1] * 10, w * 10, h * 10));
            }
            panel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.ScaleTransform(10,10);
            foreach (var rect in rects)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.Red), rect);
            }
            if(!flag)
            {
                foreach (var rect in rects)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.Black, 1), rect);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var img = new Bitmap(200, 200);
            flag = true;
            panel1.Refresh();
            panel1.DrawToBitmap(img, new Rectangle(0, 0, 200, 200));
            int count = 0;
            //var pixel = img.GetPixel(0, 0);
            //Debug.WriteLine($"a:{pixel}");
            for (int i = 0; i < 200; i++)
            {
                for (int j = 0; j < 200; j++)
                {
                    var pixel = img.GetPixel(i, j);
                    if (pixel.R != 240 || pixel.G!=240) count++;
                    //Debug.WriteLine(pixel);
                }
            }
            flag = false; panel1.Refresh();
            textBox1.Text = (count/100).ToString();
        }
    }
}
/*
 4
0 0 4 4
2 2 6 6
5 0 9 3
3 3 7 7
 */