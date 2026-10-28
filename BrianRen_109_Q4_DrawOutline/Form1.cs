using System.Drawing.Drawing2D;

namespace BrianRen_109_Q4_DrawOutline {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        List<Rectangle> rects = new List<Rectangle>();
        List<Point> points = new List<Point>();

        private void button1_Click(object sender, EventArgs e)
        {
            rects.Clear();

            int i = Random.Shared.Next(3, 5);
            while (i-- > 0)
            {
                rects.Add(new Rectangle(

                    Random.Shared.Next(20, 80),
                    Random.Shared.Next(20, 80),
                    Random.Shared.Next(40, 200),
                    Random.Shared.Next(40, 200)
                ));
            }

            //rects.Add(new Rectangle(0, 0, 100, 100));
            //rects.Add(new Rectangle(50, 50, 100, 100));
            panel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var pens = Enumerable.Range(0, 4).Select(_ => new Pen(Color.Black)).ToList();
            pens[0].DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            pens[1].DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            pens[2].DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            pens[3].DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            for (int i = 0; i < rects.Count; i++)
            {
                g.DrawRectangle(pens[i], rects[i]);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var pens = Enumerable.Range(0, 4).Select(_ => new Pen(Color.Black)).ToList();
            pens[0].DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            pens[1].DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            pens[2].DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            pens[3].DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            for (int i = 0; i < rects.Count; i++)
            {
                g.DrawRectangle(pens[i], rects[i]);
            }

            //for (int i = 0; i < points.Count; i++)
            //{
            //    g.FillRectangle(new SolidBrush(Color.Red), points[i].X, points[i].Y, 3, 3);
            //}
            var rPen = new Pen(Color.Red); rPen.Width = 5;
            for (int i = 0; i < lines.Count; i++)
            {
                g.DrawLine(rPen, lines[i].Item1, lines[i].Item2);
            }
        }
        List<(Point, Point)> lines = new List<(Point, Point)>();

        private void findLines()
        {
            var xs = rects
                .SelectMany(r => new[] { r.Left, r.Right })
                .Distinct()
                .Order().ToList();
            var ys = rects
                .SelectMany(r => new[] { r.Top, r.Bottom })
                .Distinct()
                .Order().ToList();

            int nx = xs.Count() - 1, ny = ys.Count() - 1;

            bool[,] covered = new bool[nx, ny];
            points.Clear();
            lines.Clear();

            for (int i = 0; i < nx; i++)
                for (int j = 0; j < ny; j++)
                    covered[i, j] = rects.Any(r => r.Left <= xs[i] && r.Right >= xs[i + 1]
                                                && r.Top <= ys[j] && r.Bottom >= ys[j + 1]);
            ////DEBUG
            //for (int i = 0; i < nx; i++)
            //    for (int j = 0; j < ny; j++)
            //        if (covered[i, j] == true) points.Add(new Point(xs[i], ys[j]));

            for (int i = 0; i < nx; i++)
                for (int j = 0; j < ny; j++)
                {
                    if (!covered[i, j]) continue;
                    if (i == 0 || !covered[i - 1, j] /*最左邊或是左邊空的*/) lines.Add((new Point(xs[i], ys[j]), new Point(xs[i], ys[j + 1])));//LEFT
                    if (i == nx-1 || !covered[i + 1, j]) lines.Add((new Point(xs[i+1], ys[j]), new Point(xs[i + 1], ys[j + 1])));//RIGHT
                    if (j == 0 || !covered[i, j - 1]) lines.Add((new Point(xs[i], ys[j]), new Point(xs[i + 1], ys[j])));//TOP
                    if (j == ny-1 || !covered[i, j + 1]) lines.Add((new Point(xs[i], ys[j + 1]), new Point(xs[i+1], ys[j + 1])));//BOTTOM
                }

            Console.WriteLine();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            findLines();

            panel2.Refresh();
        }
    }
}
