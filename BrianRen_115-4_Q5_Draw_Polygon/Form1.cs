namespace BrianRen_115_4_Q5_Draw_Polygon {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            int n = (int)numericUpDown1.Value;
            double center = panel1.Width / 2;
            double r = panel1.Width * 0.5;
            List<PointF> points = new List<PointF>();
            for (int i = 0; i < n; i++)
            {
                double offset = (360f / n * i - 90f) * Math.PI / 180;
                double x = center + r * Math.Cos(offset);
                double y = center + r * Math.Sin(offset);
                points.Add(new PointF((float)x, (float)y));
            }

            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    g.DrawLine(Pens.Black,points[i], points[j]);
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            panel1.Refresh();
        }
    }
}
