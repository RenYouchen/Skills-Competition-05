namespace BrainRen_112_3_Q2_Roulette {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> items = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            items.Add("肯德基");
            items.Add("麥當勞");
            items.Add("必勝客");
            items.Add("漢堡王");
            items.Add("達美樂");
            UpdateListBox();
            button3.Hide();
        }

        void UpdateListBox()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < items.Count; i++)
                listBox1.Items.Add($"{i + 1} {items[i]}");
            pictureBox1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Cannot be empty");
                return;
            }
            items.Add((string)textBox1.Text);
            UpdateListBox();
        }
        float speed = 1.0f;
        private void button2_Click(object sender, EventArgs e)
        {
            speed = Random.Shared.Next(25, 40);
            button2.Enabled = false;
            timer1.Interval = 20;
            timer1.Start();
        }

        float rotation = 0;

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (items.Count == 0) { return; }
            var g = e.Graphics;

            int size = 500 - 40;
            var rect = new Rectangle((pictureBox1.Width - size) / 2, (pictureBox1.Height - size) / 2, size, size);
            float cx = rect.X + size / 2f, cy = rect.Y + size / 2f;
            float sweep = 360f / items.Count;

            for (int i = 0; i < items.Count; i++)
            {
                float start = rotation + i * sweep;
                g.FillPie(
                    new SolidBrush(Color.FromArgb(
                            Random.Shared.Next(256),
                            Random.Shared.Next(256),
                            Random.Shared.Next(256)
                        )),
                    rect, start, sweep
                    );

                var state = g.Save();
                g.TranslateTransform(cx, cy);
                g.RotateTransform(start + sweep / 2);
                g.DrawString(items[i], DefaultFont, Brushes.Black, size / 4f, -DefaultFont.Height / 2f);
                g.Restore(state);
            }
            g.FillPie(Brushes.Red, new Rectangle(500 - 50, 250, 50, 20), 15, -30);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rotation = (rotation + speed) % 360;
            speed *= 0.8f;
            pictureBox1.Invalidate();
            if (speed <= 0.2f)
            {
                timer1.Stop();
                button2.Enabled = true;
                MessageBox.Show($"Winner Is {items[GetWinner()]}");
            }
        }

        public int GetWinner()
        {
            float sweep = 360f / items.Count;
            float angle = ((0 - rotation) % 360 + 360) % 360;
            return (int)(angle / sweep);
        }

        int selectIdx = -1;
        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            button3.Show();
            selectIdx = listBox1.SelectedIndex;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectIdx == -1) return;
            items.RemoveAt(selectIdx);
            UpdateListBox();
            selectIdx = -1;
            button3.Hide();
        }
    }
}
