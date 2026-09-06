using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrianRen_110_Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Refresh();
        }

        List<(int,int)> points = new List<(int,int)> ();
        List<(Point, Point)> lines = new List<(Point, Point)> ();
        private void button1_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            points.Clear();
            lines.Clear();
            List<int> x = Enumerable
                .Range(1, 8)
                .OrderBy(_=>rnd.Next())
                .ToList();
            List<int> y = Enumerable
                .Range(1, 8)
                .OrderBy(_=>rnd.Next())
                .ToList();
            for(int i = 0; i < x.Count; i++)
            {
                points.Add((x[i], y[i]));
            }
            points.RemoveAt(rnd.Next(0, 7));
            points = points.OrderBy(i => i.Item1).ToList();
            panel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 9; i++) {
                for (int j = 0; j < 9; j++) {
                    e.Graphics.DrawRectangle(
                        new Pen(color: Color.Black),
                        new Rectangle(i * 60,j * 60, 60,60)
                    );
                }
            }
            if (lines.Count > 0)
            {
                for (int i = 0; i < lines.Count; i++)
                {
                    e.Graphics.DrawLine(
                        new Pen(Color.Red, 4),
                        lines[i].Item1, lines[i].Item2
                        );
                }
            }
            if (points.Count > 0)
            { 
                for (int i = 0; i < points.Count; i++) {
                    e.Graphics.FillEllipse(
                        new SolidBrush(Color.Black),
                        points[i].Item1 * 60 - 5,
                        points[i].Item2 * 60 - 5,
                        10,10
                        );
                }
            }

                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lines.Clear();
            if (points.Count == 0) return;
            int count = 0;
            var y = (int)points.Average(x=>x.Item2);
            var x1 = points.First().Item1;
            var x2 = points.Last().Item1;
            count += x2-x1;
            lines.Add((new Point(x1*60, y*60), new Point(x2*60, y*60)));
            foreach (var p in points) {
                count += Math.Abs(p.Item2 - y);
                lines.Add((new Point(p.Item1 * 60, y * 60), new Point(p.Item1 * 60, p.Item2 * 60)));
            }

            textBox1.Text = count.ToString();
            panel1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
