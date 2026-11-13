using System.Diagnostics.Eventing.Reader;
using System.
    Windows.Forms.VisualStyles;

namespace BrianRen_104_Q1_Sudoku {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }


        Label currentLabel = new Label();
        Label[,] map = new Label[4, 4];
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    var lbl = new Label();
                    lbl.Text = i == j ? $"{i + 1}" : "";
                    lbl.BorderStyle = BorderStyle.FixedSingle;
                    lbl.Size = new Size(300 / 5, 300 / 5);
                    lbl.Click += i == j ? (_, _) => { } : (_, _) => currentLabel = lbl;
                    map[i, j] = lbl;
                    flowLayoutPanel1.Controls.Add(lbl);
                }
            }
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == j) continue;
                    if (map[i, j].Text != ""&&!map[i, j].Text.Contains(',')) continue;
                    map[i, j].Text = string.Join(", ",
                        Enumerable.Range(1, 4).Where(x => Used(i, j, $"{x}") != true));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool flag = true;
            for (int i = 0; i < 4 && flag; i++)
                for (int j = 0; j < 4; j++)
                    if (map[i, j].Text == "" || map[i, j].Text.Contains(','))
                        flag = false;

            List<(int, int)> points = [(0, 0), (2, 0), (0, 2), (2, 2)];
            for(int i = 0; i < 4 && flag; i++)
            {
                int rowSum = 0, colSum = 0, blockSum = 0;
                int l = i / 2 * 2, r = i / 2 * 2;

                for (int j = 0;j < 4; j++)
                {
                    rowSum += int.Parse(map[i, j].Text);
                    colSum += int.Parse(map[j, i].Text);
                    blockSum += int.Parse(map[l + j / 2, r + j % 2].Text);
                }
                if (rowSum != 10 || colSum != 10 || blockSum != 10) flag = false;
            }

            if(flag)
            {
                label1.Text = "Õý´_";
            }
            else
            {
                label1.Text = "åeÕ`";
            }
        }
        bool Used(int x, int y, string v)
        {
            for (int i = 0; i < 4; i++)
            {
                if (map[i, y].Text == v) return true;
                if (map[x, i].Text == v) return true;
            }

            int l = x / 2 * 2, r = y / 2 * 2;
            for (int i = l; i < l + 2; i++)
            {
                for (int j = r; j < r + 2; j++)
                {
                    if (map[i, j].Text == v) return true;
                }
            }
            return false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentLabel.Text = "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentLabel.Text = "2";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentLabel.Text = "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentLabel.Text = "4";
        }

        
    }
}