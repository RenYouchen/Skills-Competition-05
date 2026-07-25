using System.Drawing.Drawing2D;

namespace BrianRen_112_Q5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < blocks.Count; i++)
            {
                Rectangle block = blocks[i];
                using Pen pen = new Pen(
                        i switch
                        {
                            0 => Brushes.Red,
                            1 => Brushes.Blue,
                            2 => Brushes.Green,
                            _ => Brushes.Orange
                        }
                    );
                pen.DashStyle = i switch
                {
                    0 => DashStyle.Dot,
                    1 => DashStyle.Dash,
                    2 => DashStyle.DashDotDot,
                    _ => DashStyle.DashDot,
                };
                e.Graphics.DrawRectangle(pen, block);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            if (!show) return;
            for (int i = 0; i < blocks.Count; i++)
            {
                Rectangle block = blocks[i];
                using Pen pen = new Pen(
                        i switch
                        {

                            0 => Brushes.Red,
                            1 => Brushes.Blue,
                            2 => Brushes.Green,
                            _ => Brushes.Orange
                        }
                    );
                pen.DashStyle = i switch
                {
                    0 => DashStyle.Dot,
                    1 => DashStyle.Dash,
                    2 => DashStyle.DashDotDot,
                    _ => DashStyle.DashDot,
                };
                e.Graphics.DrawRectangle(pen, block);
            }
   
            foreach(var block in blocks)
            {
               foreach(var block2 in blocks)
                {
                    if (block == block2) continue;
                    if(block.IntersectsWith(block2))
                    {
                        var t = block;
                        t.Intersect(block2);
                        e.Graphics.FillRectangle(Brushes.Red, t);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }


        List<Rectangle> blocks = new List<Rectangle>();
        bool show = false;
        private void button1_Click(object sender, EventArgs e)
        {
            blocks.Clear();
            show = false;
            for (int i = 0; i < Random.Shared.Next(3) + 2; i++)
            {
                blocks.Add(new Rectangle(
                    Random.Shared.Next(20, 81),
                    Random.Shared.Next(20, 81),
                    Random.Shared.Next(40, 201),
                    Random.Shared.Next(40, 201)
                    ));
            }
            panel1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            show = true;
            panel2.Refresh();
        }
    }
}
