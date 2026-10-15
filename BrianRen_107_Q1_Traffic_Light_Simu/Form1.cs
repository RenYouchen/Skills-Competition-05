namespace BrianRen_107_Q1_Traffic_Light_Simu {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }
        int state = 0;
        bool start = false;
        List<List<int>> stateMap = "1 0 0 0 0 1,1 0 0 0 1 0,1 0 0 1 0 0,0 0 1 1 0 0,0 1 0 1 0 0,1 0 0 1 0 0"
            .Split(',').Select(x => x.Split().Select(int.Parse).ToList()).ToList();

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var currentState = stateMap[state];

            Graphics g = e.Graphics;
            g.DrawLine(Pens.Black, 200, 50, 200, 550);
            g.DrawLine(Pens.Black, 300, 50, 300, 550);
            g.DrawLine(Pens.Black, 50, 350, 600, 350);
            g.DrawLine(Pens.Black, 50, 450, 600, 450);
            var colors = new[] { Color.Red, Color.Yellow, Color.Green };
            var signs = new[] { "R", "A", "G" };
            for (int i = 0; i < 3; i++)
            {
                if (currentState[i] == 1 && start)
                {
                    g.FillEllipse(new SolidBrush(colors[i]), 100, i * 100 + 50, 80, 80);
                    g.DrawEllipse(Pens.Black, 100, i * 100 + 50, 80, 80);
                }
                if (currentState[i + 3] == 1 && start)
                {
                    g.FillEllipse(new SolidBrush(colors[i]), 100 * i + 325, 475, 80, 80);
                    g.DrawEllipse(Pens.Black, 100 * i + 325, 475, 80, 80);
                }
                g.DrawString($"{signs[i]}1", DefaultFont, Brushes.Black, 50, i * 100 + 75);
                g.DrawString($"{signs[i]}2", DefaultFont, Brushes.Black, 100 * i + 350, 475 + 80);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            start = true;
            panel1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!start) return;
            state = (state + 1) % 6;
            panel1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            start = false;
            state = 0;
            panel1.Refresh();
        }
    }
}
