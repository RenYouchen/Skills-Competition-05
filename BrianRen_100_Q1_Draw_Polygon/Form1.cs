namespace BrianRen_100_Q1_Draw_Polygon {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "B";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var center = 200;
            var r = 200 * 0.5;
            List<PointF> points = new List<PointF>();
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                double angle = 2 * Math.PI / (int)numericUpDown1.Value;
                double a = -Math.PI / 2 + angle * i;
                float x = (float)(r * Math.Cos(a) + 200);
                float y = (float)(r * Math.Sin(a) + 200);
                points.Add(new PointF(x, y));
            }
            var g = e.Graphics;
            var pen = textBox1.Text switch
            {
                "B" => Pens.Black,
                "R" => Pens.Red,
                "G" => Pens.Green,
                "L" => Pens.Blue,
                _ => Pens.Black
            };
            for (int i = 0; i < points.Count; i++)
            {
                for (int j = i; j < points.Count; j++)
                {
                    g.DrawLine(pen, points[i], points[j]);
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            panel1.Refresh();
        }
    }
}
