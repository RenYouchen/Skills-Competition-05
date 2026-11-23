using System.Diagnostics;

namespace BrianRen_097_Q1_Sinc_Draw {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        float Sinc(float x)
        {
            if (x == 0)
                return 1;
            else
                return (float)Math.Sin(x) / x;
        }
        List<PointF> points = new List<PointF>();
        private void button1_Click(object sender, EventArgs e)
        {
            float x, y;
            points.Clear();
            int a = int.Parse(textBox1.Text), b = int.Parse(textBox2.Text);
            for(float i = a; i<=b; i+=0.1f)
            {
                x = (float)i * panel1.Width/(b-a) + panel1.Width/2;
                y = -Sinc(i) * panel1.Height * 0.5f + panel1.Height*3/4;
                Debug.WriteLine((x,y));
                points.Add(new PointF(x, y));
            }
            panel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            if (points.Count > 0)
            {
                int a = int.Parse(textBox1.Text), b = int.Parse(textBox2.Text);

                g.DrawLine(Pens.Black, panel1.Width/2, 0, panel1.Width/2, panel1.Height);
                g.DrawLine(Pens.Black, 0, panel1.Height * 3 / 4, panel1.Width, panel1.Height * 3 / 4);

                g.DrawLines(Pens.Red, points.ToArray());

            }
        }
    }
}
