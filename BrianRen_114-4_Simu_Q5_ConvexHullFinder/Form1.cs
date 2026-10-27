namespace BrianRen_114_4_Simu_Q5_ConvexHullFinder {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        List<Point> points = new List<Point>();
        List<Point> lines = new List<Point>();
        private void button1_Click(object sender, EventArgs e)
        {
            //1145 766
            points.Clear();
            lines.Clear();
            for (int i = 0; i < 20; i++)
                points.Add(new Point(
                        Random.Shared.Next(0, 1140),
                        Random.Shared.Next(0, 766)
                    ));
            panel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (Point p in points)
            {
                g.FillEllipse(Brushes.Blue, new Rectangle(p, new Size(10, 10)));
            }

            if(lines.Count > 0)
            {
                g.DrawLines(Pens.Black, lines.ToArray());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var p = points.OrderBy(a => a.X).ThenBy(a => a.Y).ToList();
            var h = new List<Point>();

            foreach(var q in p)
            {
                while(h.Count >= 2 && cross(h[^2], h[^1], q) <= 0) h.RemoveAt(h.Count - 1);
                h.Add(q);
            }
            int lower = h.Count + 1;

            for(int i = p.Count-2; i>=0; i--)
            {
                while (h.Count >= lower && cross(h[^2], h[^1], p[i]) <= 0) h.RemoveAt(h.Count - 1);
                h.Add(p[i]);
            }
            //h.RemoveAt(h.Count - 1);
            lines = h;
            panel1.Refresh();
        }

        double cross(Point o, Point a, Point b) =>
            (a.X -  o.X) * (b.Y - o.Y) - (a.Y - o.Y) * (b.X - o.X);


    }
}
