namespace BrianRen_114_1_Q5_RectOverlapDetection {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        List<Rectangle> rects = new List<Rectangle>();

        private void button1_Click(object sender, EventArgs e)
        {
            overlaps.Clear();
            groups.Clear();
            union.Clear();
            rects.Clear();
            for (int i = 0; i < Random.Shared.Next(5, 11); i++)
            {
                rects.Add(new Rectangle(
                        Random.Shared.Next(0, panel1.Size.Width - 200),
                        Random.Shared.Next(0, panel1.Size.Height - 200),
                        Random.Shared.Next(40, 200),
                        Random.Shared.Next(40, 200)
                    ));
            }
            panel1.Refresh();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (Rectangle rect in rects)
            {
                g.DrawRectangle(Pens.Black, rect);
            }
            foreach(var r in overlaps)
            {
                g.FillRectangle(Brushes.Red, r);
            }
            foreach(var r in union)
            {
                g.DrawRectangle(Pens.Blue, r);
            }
        }
        List<Rectangle> overlaps = new();
        List<Rectangle> union = new();
        List<int> groups = new();
        private void button2_Click(object sender, EventArgs e)
        {
            overlaps.Clear();
            groups.Clear();
            groups = Enumerable.Range(0, rects.Count).ToList();

            for(int i = 0; i < rects.Count; i++)
            {
                for(int j = i+1; j < rects.Count; j++)
                {
                    if (rects[i].IntersectsWith(rects[j]))
                    {
                        overlaps.Add(Rectangle.Intersect(rects[i], rects[j]));
                    }
                }
            }

            for(int i = 0; i < rects.Count;i++)
            {
                for(int j = i+1; j < rects.Count;j++)
                {
                    if (rects[i].IntersectsWith(rects[j]) && groups[i] != groups[j])
                    {
                        int oldGroup = groups[j];
                        int newGroup = groups[i];   
                        for(int k = 0; k < rects.Count; k++)
                        {
                            if (groups[k] == oldGroup)
                            {
                                groups[k] = newGroup;
                            }
                        }
                    }
                }
            }
            var a = Enumerable.Range(0,groups.Count)
                .GroupBy(x => groups[x])
                .Where(x=>x.Count()>1)
                .Select(x => x.Select(y => rects[y]).Aggregate(Rectangle.Union)).ToList();
            union = a;
            panel1.Refresh();
        }
    }
}
