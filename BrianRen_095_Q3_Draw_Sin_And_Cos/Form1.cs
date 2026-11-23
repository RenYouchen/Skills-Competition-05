namespace BrianRen_095_Q3_Draw_Sin_And_Cos {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        bool clear = true;
        bool selectSin = true;

        private void button1_Click(object sender, EventArgs e)
        {
            clear = false;


            panel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (clear) return;
            var g = e.Graphics;
            int x = panel1.Height / 2;

            List<PointF> points = new List<PointF>();
            g.DrawLine(Pens.Red, 0, x, panel1.Width, x);
            g.DrawLine(Pens.Red, 1, 1, 1, panel1.Height);

            for (int i = 0; i < 52/2; i++)
            {
                if(selectSin)
                    points.Add(new PointF(i * 10, (float)Math.Sin(i * Math.PI / -25.5) * x + x));
                else
                    points.Add(new PointF(i * 10, ((float)Math.Tan(i * Math.PI / -25.5) * x + x)));

            }
            g.DrawLines(Pens.Black, points.ToArray());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            selectSin = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            selectSin = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear = true;
            panel1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
