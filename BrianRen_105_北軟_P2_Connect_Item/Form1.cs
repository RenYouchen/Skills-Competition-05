using System.Runtime.CompilerServices;

namespace BrianRen_105_北軟_P2_Connect_Item {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }
        string[] raw;
        List<List<int>> grid = new List<List<int>>();
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog odf = new OpenFileDialog())
            {
                odf.Filter = "Text File *.txt|*.txt";
                if (odf.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.Clear();
                    richTextBox2.Clear();
                    grid.Clear();
                    textBox3.Text = odf.FileName;
                    raw = File.ReadAllLines(odf.FileName);
                    foreach (string line in raw)
                        grid.Add(line.Split().Select(int.Parse).ToList());
                    richTextBox1.Lines = raw;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (raw == null) return;
            List<int> ofsX = [-1, -1, -1, 0, 0, 1, 1, 1];
            List<int> ofsY = [-1, 0, 1, -1, 1, -1, 0, 1];

            Queue<(int,int)> q = new Queue<(int,int)>();

            int count = 0;
            int n = grid.Count;
            int m = grid[0].Count;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if (grid[i][j] != 255) continue;
                    count++;
                    var cur = (i: i, j: j);
                    q.Enqueue(cur);
                    while(q.Count > 0)
                    {
                        var (ai,aj) = q.Dequeue();
                        var a = (i: ai, j: aj);
                        for (int k = 0; k < 8; k++)
                        {
                            var nCur = (i: a.i + ofsX[k], j: a.j + ofsY[k]);
                            if (nCur.i < 0 || nCur.i >= n || nCur.j < 0 || nCur.j >= m) continue;
                            if (grid[nCur.i][nCur.j] != 255) continue;
                            q.Enqueue(nCur);
                            grid[nCur.i][nCur.j] = count;
                        }
                    }
                }
            }
            richTextBox2.Text = string.Join('\n', grid.Select(x => string.Join(' ', x)));
        }
    }
}
