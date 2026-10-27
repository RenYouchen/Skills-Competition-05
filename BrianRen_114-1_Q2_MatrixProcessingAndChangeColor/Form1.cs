using System.Drawing.Printing;

namespace BrianRen_114_1_Q2_MatrixProcessingAndChangeColor {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        Panel[,] cells = new Panel[4, 4];

        private void Form1_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.RowCount = 4;
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
                    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
                    cells[i, j] = new Panel
                    {
                        Dock = DockStyle.Fill,
                        Margin = Padding.Empty,
                        BackColor = Color.FromArgb(
                                255,
                                Random.Shared.Next(255),
                                Random.Shared.Next(255),
                                Random.Shared.Next(255)
                            ),
                        Tag = (j, i),
                    };
                    cells[i, j].Click += Color_On_Click;
                    tableLayoutPanel1.Controls.Add(cells[i, j], j, i);
                }
            toolStripStatusLabel1.Text = "就緒";
        }

        private void Color_On_Click(object? sender, EventArgs e)
        {
            if (sender is not Panel p) return;
            using var dlg = new ColorDialog { Color = p.BackColor };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                p.BackColor = dlg.Color;
            }
        }


        static int N = 4;
        void Transform(Func<int, int, (int r, int c)> target, string msg)
        {
            var oldColor = new Color[4, 4];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    oldColor[i, j] = cells[i, j].BackColor;
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    var (newI, newJ) = target(i, j);
                    cells[newI, newJ].BackColor = oldColor[i, j];
                }
            toolStripStatusLabel1.Text = msg;
        }

        private void btnRotateCW(object? sender, EventArgs e) => Transform((r, c) => (c, N - 1 - r), "已順時針旋轉");
        private void btnRotateCCW(object? sender, EventArgs e) => Transform((r, c) => (N - 1 - c, r), "已逆時針旋轉");
        private void btnFlipH(object? sender, EventArgs e) => Transform((r, c) => (r, N - c - 1), "已水平翻轉");
        private void btnFlipV(object? sender, EventArgs e) => Transform((r, c) => (N - 1 - r, c), "已垂直翻轉");

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    cells[i, j].BackColor = Color.FromArgb(
                            255,
                            Random.Shared.Next(256),
                            Random.Shared.Next(256),
                            Random.Shared.Next(256)
                        );
            toolStripStatusLabel1.Text = "已隨機填充";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    var color = cells[i, j].BackColor;
                    cells[i, j].BackColor = Color.FromArgb(
                        255,
                        255 - color.R,
                        255 - color.G,
                        255 - color.B);
                }
            toolStripStatusLabel1.Text = "已顔色反轉";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
