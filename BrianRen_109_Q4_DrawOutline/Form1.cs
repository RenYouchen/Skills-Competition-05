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

            for (int i = 0; i < points.Count; i++)
            {
                g.FillRectangle(new SolidBrush(Color.Red), points[i].X, points[i].Y, 10, 10);
            }
        }
        List<(Point, Point)> lines = new List<(Point, Point)>();

        private void findLines()
        {
            var x = rects
                .SelectMany(r => new[] { r.Left, r.Right })
                .Distinct()
                .Order().ToList();
            var y = rects
                .SelectMany(r => new[] { r.Top, r.Bottom })
                .Distinct()
                .Order().ToList();

            bool[,] covered = new bool[x.Count, y.Count ];
            points.Clear();
            
            //foreach(var ix in x)
            //{
            //    foreach(var iy in y)
            //    {
            //        foreach(var rect in rects)
            //        {
            //            if(rect.Left > ix || rect.Right < ix || rect.Top > iy || rect.Bottom < iy)
            //            {
            //                covered[ix, iy] = true;
            //                } 
            //        }
            //    }
            //}

            for(int i = 0; i < x.Count; i++)
            {
                for(int j  = 0; j < y.Count; j++)
                {
                    foreach(var rect in rects)
                    {
                        if (rect.Left > x[i] || rect.Right < x[i] || rect.Top > y[j] || rect.Bottom < y[j])
                        {
                            covered[i, j] = true;
                            points.Add(new Point(x[i], y[j]));
                        }
                    }
                }
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
