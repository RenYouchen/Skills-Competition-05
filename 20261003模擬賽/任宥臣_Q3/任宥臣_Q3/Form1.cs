using System.Diagnostics;

namespace 任宥臣_Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            totalCount.Text = 0.ToString();
            totalCount1.Text = 0.ToString();
            infoCount.Text = 0.ToString();
            warnCount.Text = 0.ToString();
            errorCount.Text = 0.ToString();
            vaildCount.Text = 0.ToString();
            invaildCount.Text = 0.ToString();
            matchedCount.Text = 0.ToString();
        }

        string[] raw;
        List<LogData> logFileData = new List<LogData>();
        int invaildDataCount = 0;
        int matchedDataCount = 0;
        List<string> levelType = new List<string> { "INFO", "WARN", "ERROR" };

        private void button1_Click(object sender, EventArgs e)
        {
            logFileData.Clear();
            invaildDataCount = 0;
            matchedDataCount = 0;
            textBox2.Text = "全部有效資料";
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "TextFile|*.txt|log File|*.log";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    raw = File.ReadAllLines(ofd.FileName);
                    textBox1.Text = ofd.FileName;
                }
            }
            if (raw == null) return;

            foreach (var log in raw)
            {
                try
                {
                    if (log == "") continue;
                    var data = log.Split('|');

                    var dateTime = DateTime.Parse(data[0]);
                    //DateTime.TryParse(data[0], out dateTime);
                    var level = data[1];
                    if (!levelType.Contains(level))
                    {
                        Invaild("Contain unknown level");
                        continue;
                    }
                    var name = data[2];
                    var msg = data[3];
                    if (data.Count() > 4)
                    {
                        Invaild("Contains | in name or msg");
                        continue;
                    }
                    logFileData.Add(new LogData(dateTime, level, name, msg));
                }
                catch (Exception ex)
                {
                    Invaild(ex.Message);
                }
            }
            Debug.WriteLine(string.Join("\n", logFileData));

            totalCount.Text = (logFileData.Count + invaildDataCount).ToString();
            totalCount1.Text = (logFileData.Count + invaildDataCount).ToString();
            infoCount.Text = logFileData.Where(x => x.Level == "INFO").Count().ToString();
            warnCount.Text = logFileData.Where(x => x.Level == "WARN").Count().ToString();
            errorCount.Text = logFileData.Where(x => x.Level == "ERROR").Count().ToString();
            vaildCount.Text = logFileData.Count().ToString();
            invaildCount.Text = invaildDataCount.ToString();
            matchedCount.Text = matchedDataCount.ToString();

            richTextBox1.Text = string.Join('\n', logFileData);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var aA = checkBox1.Checked;
            var searchText = textBox3.Text;
            textBox2.Text = $"搜尋'{searchText}'";
            var searchData = logFileData.Where(x =>
            {
                if (aA)
                {
                    return x.ToString().ToLower().Contains(searchText.ToLower());
                }
                else
                {
                    return x.ToString().Contains(searchText);
                }
            }).ToList();
            matchedCount.Text = searchData.Count().ToString();  
            richTextBox1.Text = string.Join('\n', searchData);
        }

        record LogData(DateTime Time, string Level, string Name, string Msg)
        {
            public override string ToString()
            {
                return $"{Time.ToString("yyyy-MM-dd HH:mm:ss")}|{Level}|{Name}|{Msg}";
            }
        }

        void Invaild(string err)
        {
            Debug.WriteLine($"-----------{err}");
            invaildDataCount++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            logFileData.Clear();
            invaildDataCount = 0;
            matchedDataCount = 0;
            richTextBox1.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            totalCount.Text = 0.ToString();
            totalCount1.Text = 0.ToString();
            infoCount.Text = 0.ToString();
            warnCount.Text = 0.ToString();
            errorCount.Text = 0.ToString();
            vaildCount.Text = 0.ToString();
            invaildCount.Text = 0.ToString();
            matchedCount.Text = 0.ToString();
        }
    }
}
