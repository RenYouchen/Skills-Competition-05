using System.Diagnostics;

namespace BrianRen_115_Simu_Q3_LogAnalyze {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] lblR1 = { "TOTAL", "INFO", "WARN", "ERROR" };
            string[] lblR2 = { "TOTAL", "VALID", "INVALID", "MATCHED" };
            for (int i = 0; i < 4; i++)
            {
                tableLayoutPanel1.GetControlFromPosition(0, i).Text = lblR1[i];
                tableLayoutPanel1.GetControlFromPosition(1, i).Text = "0";
                tableLayoutPanel1.GetControlFromPosition(3, i).Text = lblR2[i];
                tableLayoutPanel1.GetControlFromPosition(4, i).Text = "0";
            }
        }

        List<Data> datas = new List<Data>();
        int invalidCount = 0;
        int matchedCount = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            datas.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            richTextBox1.Clear();
            checkBox1.Checked = false;
            invalidCount = 0; 
            matchedCount = 0;
            updateData();

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text File *.txt|*.txt|Log File *.log|*.log";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = ofd.FileName;
                    textBox2.Text = "全部有效資料";
                    //datas = File.ReadAllText(ofd.FileName)
                    //    .Split('\n', StringSplitOptions.RemoveEmptyEntries)
                    //    .Select(x => x.Split('|'))
                    //    .Select(x => new Data(DateTime.Parse(x[0]), x[1], x[2], x[3]))
                    //    .ToList();

                    var raw = File.ReadAllLines(ofd.FileName);
                    var types = new[] { "INFO", "WARN", "ERROR" };
                    foreach(var log in raw)
                    {
                        if(string.IsNullOrEmpty(log)) continue;
                        var x = log.Split("|");

                        try
                        {
                            if (!types.Contains(x[1])) throw new FormatException("");
                            if (x.Length > 4) throw new FormatException("");
                            datas.Add(new Data(DateTime.Parse(x[0]), x[1], x[2], x[3]));
                        }
                        catch
                        {
                            invalidCount++;
                        }
                    }

                    richTextBox1.Text = string.Join('\n', datas);

                    updateData();
                }
            }
        }

        void updateData()
        {
            int[] data1 =
                    {
                        datas.Count + invalidCount,
                        datas.Count(x=>x.type == "INFO"),
                        datas.Count(x=>x.type == "WARN"),
                        datas.Count(x=>x.type == "ERROR")
                    };

            int[] data2 =
            {
                        datas.Count + invalidCount,
                        datas.Count,
                        invalidCount,
                        matchedCount
                    };

            for (int i = 0; i < data1.Length; i++)
                tableLayoutPanel1.GetControlFromPosition(1, i).Text = data1[i].ToString();
            for (int i = 0; i < data2.Length; i++)
                tableLayoutPanel1.GetControlFromPosition(4, i).Text = data2[i].ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            datas.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            richTextBox1.Clear();
            checkBox1.Checked = false;
            invalidCount = 0; 
            matchedCount = 0;
            updateData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var searchText = textBox3.Text;
            var aA = checkBox1.Checked;
            textBox2.Text = $"搜尋 {searchText}";

            var matchData = new List<Data>();
            if (aA)
            {
                matchData = datas.Where(x => x.ToString().Contains(searchText)).ToList();
            } 
            else
            {
                matchData = datas.Where(x=>x.ToString().ToLower().Contains(searchText.ToLower())).ToList();
            }
            matchedCount = matchData.Count;
            updateData();

            richTextBox1.Text = string.Join('\n', matchData);

        }

        record Data(DateTime time, string type, string name, string msg)
        {
            public override string ToString() => $"{time.ToString("yyyy-MM-dd HH-mm-ss")}|{type}|{name}|{msg}";
        };
    }
}
