using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrianRen_20260822_Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Point penPoint;
        private bool drawing;
        private Color color;
        private Graphics g;

        private void Form1_Load(object sender, EventArgs e)
        {
            drawing = false;
            g = pictureBox1.CreateGraphics();

            Color[] colors = new Color[] {
                Color.Black, Color.White, Color.Gray,
                Color.DarkRed, Color.Red, Color.Orange
            };
            foreach (Color color in colors) {
                Button btn = new Button
                {
                    Size = new Size(20, 20),
                    BackColor = color,
                    FlatStyle = FlatStyle.Flat,
                    Margin = new Padding(3),
                    UseVisualStyleBackColor = false
                };
                btn.Click += (_,eve) => this.color = color;

                flowLayoutPanel1.Controls.Add(btn);
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            this.drawing = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.penPoint = new Point(e.X, e.Y);
            this.drawing = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(this.drawing)
            {
                Point mousePoint = new Point(e.X, e.Y);
                using (Pen pen = new Pen(color, trackBar1.Value))
                {
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;   
                    pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round; 
                    this.g.DrawLine(pen, this.penPoint, mousePoint);
                }
                this.penPoint = mousePoint;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = $"筆刷粗細: {trackBar1.Value}";
        }
    }
}
