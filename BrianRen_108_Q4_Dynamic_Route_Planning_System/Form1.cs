using System.Diagnostics;

namespace BrianRen_108_Q4_Dynamic_Route_Planning_System {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        bool[,] map = new bool[11, 11];
        (int, int)? start, end;
        bool draw = false;

        private void button1_Click(object sender, EventArgs e)
        {
            
            //for (int i = 0; i < 11; i++)
            //    for (int j = 0; j < 11; j++) map[i, j] = false;
            map = new bool[11, 11]; //直接初始化
            draw = true;
            var cells = Enumerable.Range(0, 11 * 11)
                .Select(x => (x / 11, x % 11))
                .OrderBy(_ => Random.Shared.Next()).ToList();
            foreach (var (x, y) in cells.Take(32)) map[x, y] = true;
            start = cells[32];
            end = cells[33];
            //for(int i = 0; i < 32; i++)
            //{
            //    var x = Random.Shared.Next(0, 11);
            //    var y = Random.Shared.Next(0, 11);
            //    if (!map[x, y])
            //    {
            //        map[x, y] = true;
            //    }
            //    else i--;
            //}
            //while(start != (-1,-1))
            //{
            //    var x = Random.Shared.Next(0, 11);
            //    var y = Random.Shared.Next(0, 11);
            //    if (map[x, y]) continue;
            //    start = (x, y);
            //}

            panel1.Refresh();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillEllipse(Brushes.Black, 0, 0, 30, 30);
            g.DrawString("路障點O", DefaultFont, Brushes.Black, 30, 0);
            g.DrawEllipse(new Pen(Color.Blue, 3), 0, 35, 30, 30);
            g.DrawString("起點S", DefaultFont, Brushes.Black, 30, 35);
            g.DrawRectangle(new Pen(Color.Red, 3), 0, 70, 30, 30);
            g.DrawString("終點T", DefaultFont, Brushes.Black, 30, 70);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            var p = Pens.Black;
            for (int i = 1; i <= 11; i++)
            {
                g.DrawLine(p, 55, i * 55, 55 * 11, i * 55);
                g.DrawLine(p, i * 55, 55, i * 55, 55 * 11);
            }

            if (draw)
            {
                for (int i = 0; i < 11; i++)
                    for (int j = 0; j < 11; j++)
                    {
                        var c = new Rectangle((i + 1) * 55 - 15, (j + 1) * 55 - 15, 30, 30);
                        if (map[i, j])
                        {
                            g.FillEllipse(Brushes.Black, c);
                        }
                    }

                if(start is (int sx, int sy))
                {
                    var rectStart = new Rectangle((sx + 1) * 55 - 15, (sy + 1) * 55 - 15, 30, 30);
                    g.FillEllipse(Brushes.White, rectStart);
                    g.DrawEllipse(new Pen(Color.Blue, 3), rectStart);
                }

                if (end is (int ex, int ey))
                {
                    var rectStart = new Rectangle((ex + 1) * 55 - 15, (ey + 1) * 55 - 15, 30, 30);
                    g.FillRectangle(Brushes.White, rectStart);
                    g.DrawRectangle(new Pen(Color.Blue, 3), rectStart);
                }
                if (start != null && end != null)
                {
                    bfs();
                    if(result.Count > 0)
                    {
                        g.DrawLines(new Pen(Color.Blue, 3), result.Select(p => new Point((p.Item1 + 1) * 55, (p.Item2 + 1) * 55)).ToArray());
                    }
                }
            }
        }

        int state = -1; //-1: null, 0: O, 1:S, 2:T
        List<(int, int)> result = new List<(int, int)> ();
        void bfs()
        {
            int[] dx = { -1, 1, 0, 0 }, dy = { 0, 0, 1, -1 };
            var prev = new (int, int)?[11, 11];
            var visited = new bool[11, 11];
            var queue = new Queue<(int,int)>();

            queue.Enqueue(start!.Value);
            visited[start.Value.Item1, start.Value.Item2] = true;

            while(queue.Count > 0)
            {
                var (x,y) = queue.Dequeue();
                if (end == (x, y)) break;

                for(int i = 0; i < 4; i++)
                {
                    var currentX = x + dx[i];
                    var currentY = y + dy[i];

                    if (currentX < 0 || currentY < 0 || currentX > 10 || currentY > 10) continue;
                    if(visited[currentX, currentY] || map[currentX, currentY]) continue;
                    visited[currentX, currentY] = true;
                    prev[currentX, currentY] = (x, y);
                    queue.Enqueue((currentX, currentY));
                }      
            }
            if (!visited[end.Value.Item1, end.Value.Item2])
            {
                system.Text = "No Path Found";
                result.Clear();
                return;
            }
            result.Clear();
            system.Text = "";

            for ((int, int)? p = end; p != null; p = prev[p.Value.Item1, p.Value.Item2])
            {
                result.Add(p.Value);
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            var x = (int)Math.Round((e.X - 55) / (double)55);
            var y = (int)Math.Round((e.Y - 55) / (double)55);

            if (x < 0 || x > 10 || y < 0 || y > 10) return;

            if (state == -1)
            {
                //state = map[x, y] == true ? 0
                //: start == (x, y) ? 1
                //: end == (x, y) ? 2
                //: -1;
                if (map[x, y])
                {
                    state = 0;
                    map[x, y] = false;
                }
                else if (start == (x, y))
                {
                    state = 1;
                    start = null;
                }
                else if(end == (x, y))
                {
                    state = 2; 
                    end = null;
                }
            }
            else
            {
                var hasItem = map[x, y] == true || start == (x,y) || end == (x,y);
                if (hasItem) return;
                if (state == 0) map[x, y] = true;
                else if (state == 1) start = (x, y);
                else if (state == 2) end = (x, y);
                state = -1;
            }
            panel1.Refresh();
        }
    }
}
