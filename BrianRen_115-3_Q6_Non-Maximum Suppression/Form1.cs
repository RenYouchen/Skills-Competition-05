/*4
10 10 50 50 0.90
12 12 52 52 0.75
100 100 140 140 0.95
30 30 70 70 0.60
 */

using System.Drawing.Drawing2D;
namespace BrianRen_115_3_Q6_Non_Maximum_Suppression {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        List<Box> rects = new();
        private void button1_Click(object sender, EventArgs e)
        {
            string[] raw = richTextBox1.Text.Split('\n');
            rects.Clear();
            kepts = null;
            int n = int.Parse(raw[0]);
            for (int i = 0; i < n; i++)
            {
                var d = raw[i + 1].Split(' ').Select(double.Parse).ToArray();
                rects.Add(new Box(i+1, (int)d[0], (int)d[1], (int)d[2], (int)d[3], d[4]));
            }
            panel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            foreach (var rect in rects)
            {
                var p = new Pen(Color.Black) { DashStyle = DashStyle.Dash };
                g.DrawString($"{rect.id}", DefaultFont, Brushes.Black, rect.x1, rect.y1);
                g.DrawRectangle(p, rect.rect);
            }
            if(kepts!=null)
            foreach(var i in kepts)
            {
                g.DrawRectangle(Pens.Red, rects[i-1].rect);
            }
        }
        HashSet<int>? kepts = null;
        private void button2_Click(object sender, EventArgs e)
        {
            double t = double.Parse(textBox1.Text);
            var order = rects
                .OrderByDescending(x => x.score)
                .ThenBy(x=>x.id)
                .ToList();

            var suppressed = new HashSet<int>();
            kepts = new();

            foreach(var best in order)
            {
                if (suppressed.Contains(best.id)) continue;
                kepts.Add(best.id);
                foreach(var other in order)
                {
                    if(other.id == best.id || kepts.Contains(other.id) || suppressed.Contains(other.id)) continue;
                    if(IoU(best, other) > t) suppressed.Add(other.id);
                }
            }
            textBox2.Text = string.Join(' ', kepts.OrderBy(x=>x));
            panel1.Refresh();
        }
        record Box(int id, int x1, int y1, int x2, int y2, double score)
        {
            public Rectangle rect = new Rectangle(x1, y1, x2-x1,y2-y1);
            public double Area => rect.Width * rect.Height;
        };

        double IoU(Box a, Box b)
        {
            double interWidth = Math.Max(0, Math.Min(a.x2, b.x2) - Math.Max(a.x1, b.x1));
            double interHeight = Math.Max(0, Math.Min(a.y2, b.y2) - Math.Max(a.y1, b.y1));
            double intersection = interWidth * interHeight;
            return intersection / (a.Area + b.Area - intersection);
        }
    }
}
