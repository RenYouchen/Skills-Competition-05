namespace BrianRen_107_Q4_Data_Analyze {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> raw = new List<string>();

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 選取資料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text File *.txt|*.txt";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    raw = File.ReadAllLines(ofd.FileName).ToList();
                    string s = "";
                    for (int i = 0; i < raw.Count; i++)
                    {
                        s += $"麵[{i + 1}]:\t{string.Join(' ', raw[i].Split().Select(int.Parse).Select(x => $"{x:F2}"))}\n";
                    }
                    richTextBox1.Text = s;
                }
            }
        }

        private void 求F統計值和自由度dfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<List<int>> data = raw.Select(x=>x.Split(' ').Select(int.Parse).ToList()).ToList();

            var UT = data.SelectMany(row => row).Average();
            var utList = data.Select(x=>x.Average()).ToList();
            double SSb = 0;
            for(int i = 0; i < data.Count; i++)
            {
                SSb+=data[i].Count * Math.Pow(utList[i] - UT ,2);
            }
            double SSw = 0;
            for(int i = 0; i < data.Count; i++)
                for(int j = 0; j < data[i].Count; j++)
                {
                    SSw += Math.Pow(data[i][j] - utList[i], 2);
                }
            var dfb = data.Count - 1;
            var dfw = data.Select(x=>x.Count).Sum() - data.Count;

            var MSb = SSb / dfb;
            var MSw = SSw / dfw;
            var F = MSb / MSw;
            string result = "F統計值計算:\n";
            result += $"F={F:F3}\n自由度df:{dfb},{dfw}";
            richTextBox2.Text = result;
        }
    }
}
