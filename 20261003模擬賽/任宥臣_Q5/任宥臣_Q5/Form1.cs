using System.Diagnostics;

namespace 任宥臣_Q5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> raw = new List<string>();
        List<int> count = "0,0,0,0".Split(',').Select(int.Parse).ToList();

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (count.Sum() == 0) return; 
            int width = 800 - 20; float height = 530 - 100;
            var g = e.Graphics;
            var pen = Brushes.Black;
            var type = "DEBUG INFO WARNING ERROR".Split();
            var colors = new List<Color>{ Color.Gray, Color.Blue, Color.Orange, Color.Red};
            g.DrawString("筆數", DefaultFont, pen, 27, 10);
            g.DrawLine(new Pen(pen), new PointF(40, 30), new PointF(40, height));
            g.DrawLine(new Pen(pen), new PointF(40, height), new PointF(width, height));
            for (int i = 0; i < 5; i++)
            {
                int num = count.Max() / 4 * (4 - i);
                //float textHeight = height - 8 - height * i/5;
                float textHeight = height - height * (float)num / count.Max() * 0.9f;
                //float textHeight = height * .1f + (height + 45) * i / 5;
                g.DrawString(num.ToString(), DefaultFont, pen, new PointF(20, textHeight));
                if (num == 0) continue;
                g.DrawLine(new Pen(Brushes.LightGray), new PointF(40, textHeight + 8), new PointF(width, textHeight + 8));
            }
            var maxHeight = count.Max();
            var newHeight = height * .1f + (height + 45);
            for (int i = 0; i < count.Count; i++)
            {
                float boxHeight = (float)count[i] / maxHeight * 0.9f;
                //if (count[i] > count.Max() / 4 * (4 - i)) boxHeight += 0.05f;
                Debug.WriteLine("Height "+boxHeight);

                g.DrawString(type[i], DefaultFont, pen, i*width/4+100, height+10);
                var outline = new RectangleF(i * width / 4 + 75, height - height * boxHeight+9, 100, height * boxHeight-9);
                outline.Inflate(1.1f, 1.1f);
                g.FillRectangle(new SolidBrush(Color.Black), outline);
                g.FillRectangle(new SolidBrush(colors[i]), new RectangleF(i * width / 4 + 75, height - height*boxHeight+9, 100, height*boxHeight-9));
                g.DrawString(count[i].ToString(), DefaultFont, pen, i * width / 4 + 100 + 17, height - height * boxHeight - 20);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd =  new OpenFileDialog())
            {
                ofd.Filter = "logFile|*.log";
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    raw = File.ReadAllLines(ofd.FileName).ToList();
                    label1.Text = $"{ofd.SafeFileName}（共{raw.Count()}筆）";
                }
            }
            count[0] = raw.Where(x => x.Contains("DEBUG")).Count();
            count[1] = raw.Where(x => x.Contains("INFO")).Count();
            count[2] = raw.Where(x => x.Contains("WARNING")).Count();
            count[3] = raw.Where(x => x.Contains("ERROR")).Count();
            Debug.WriteLine(string.Join(' ', count));
            panel1.Refresh();
        }
    }
}
