namespace WinFrom矩陣旋轉 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
            int n = (int)numericUpDown1.Value, m = (int)numericUpDown2.Value;
            int k = 1;
            var grid = Enumerable.Range(0, n).Select((_, i) => Enumerable.Range(0, m).Select((_, j) => k++));
            richTextBox1.Text = string.Join('\n', grid.Select(x => string.Join(' ', x)));

            Transform();
            Transform();
        }

        int max;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var grid = richTextBox1.Lines.Select(x => x.Split().ToList()).ToList();

            int n = (int)numericUpDown1.Value, m = (int)numericUpDown2.Value;
            max = Math.Max(n, m);

            float size = 400 / max;

            var a = Enumerable.Range(0, max).Select((_, i) => Enumerable.Range(0, max).Select((_, j) => grid[i][j]).ToList()).ToList();
            for (int i = 0; i < max; i++)
                for (int j = 0; j < max; j++)
                    a[i][j] = grid[j][i];
            for (int i = 0; i < max; i++)
            {
                for (int j = 0; j < max; j++)
                {
                    if (a[i][j] == "") continue;
                    g.FillRectangle(Brushes.AliceBlue, i * size, j * size, size, size);
                    g.DrawRectangle(Pens.Black, i * size, j * size, size, size);
                    g.DrawString(a[i][j], DefaultFont, Brushes.Black, i * size + size / 2 - 12, j * size + size / 2 - 12);
                }
            }
        }

        void Transform()
        {
            var grid = richTextBox1.Lines.Select(x => x.Split().ToList()).ToList();
            int n = (int)numericUpDown1.Value, m = (int)numericUpDown2.Value;
            max = Math.Max(n, m);

            if (n < max)
            {
                while(n++<max)
                grid.Add(Enumerable.Repeat("", max).ToList());
            }
            else if (m < max)
            {
                while(m++<max)
                for (int i = 0; i < max; i++)
                    grid[i].Add("");
            }
            var a = Enumerable.Range(0, max).Select((_, i) => Enumerable.Range(0, max).Select((_, j) => grid[i][j]).ToList()).ToList();
            for (int i = 0; i < max; i++)
                for (int j = 0; j < max; j++)
                    a[i][j] = grid[j][i];
            richTextBox1.Text = string.Join('\n', a.Select(x => string.Join(' ', x)));
        }

        void VerFlip()
        {
            var grid = richTextBox1.Lines.Select(x => x.Split().ToList()).ToList();
            var a = Enumerable.Range(0, max).Select((_, i) => Enumerable.Range(0, max).Select((_, j) => grid[i][j]).ToList()).ToList();

            for (int i = 0; i < max; i++)
                for (int j = 0; j < max; j++)
                    a[i][j] = grid[max - i - 1][j];
            richTextBox1.Text = string.Join('\n', a.Select(x => string.Join(' ', x)));

        }

        void HorFlip()
        {
            var grid = richTextBox1.Lines.Select(x => x.Split().ToList()).ToList();
            var a = Enumerable.Range(0, max).Select((_, i) => Enumerable.Range(0, max).Select((_, j) => grid[i][j]).ToList()).ToList();

            for (int i = 0; i < max; i++)
                for (int j = 0; j < max; j++)
                    a[i][j] = grid[i][max - j - 1];
            richTextBox1.Text = string.Join('\n', a.Select(x => string.Join(' ', x)));

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int n = (int)numericUpDown1.Value, m = (int)numericUpDown2.Value;
            int k = 1;
            var grid = Enumerable.Range(0, n).Select((_, i) => Enumerable.Range(0, m).Select((_, j) => k++));
            richTextBox1.Text = string.Join('\n', grid.Select(x => string.Join(' ', x)));
            Transform();
            Transform();
            panel1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transform();
            VerFlip();
            panel1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Transform();
            HorFlip();
            panel1.Refresh();
        }
    }
}
