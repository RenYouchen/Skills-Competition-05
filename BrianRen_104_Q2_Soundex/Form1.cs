/*
LEE
KUHNE
EBELL
EBELSON
SCHAEFER
SCHAAK
*/
namespace BrianRen_104_Q2_Soundex {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nameList = richTextBox1.Lines;

            foreach(var line in nameList)
            {
                string result = "";
                for (int i = 0; i < line.Length; i++)
                {
                    if (i == 0)
                    {
                        result += line[0];
                        continue;
                    }
                    if ("AEIOUYWH".Contains(line[i])) continue;

                    if (result.Length == 4) break;

                    int r = GetNum(line[i]);
                    if ($"{result.Last()}" != $"{r}")
                        result += GetNum(line[i]);
                }
                while (result.Length < 4)
                    result += "0";
                richTextBox2.Text += result + '\n';
            }
        }

        int GetNum(char c)
        {
            if ("BPFV".Contains(c)) return 1;
            if ("CSKGJQXZ".Contains(c)) return 2;
            if ("DT".Contains(c)) return 3;
            if ("L".Contains(c)) return 4;
            if ("MN".Contains(c)) return 5;
            if ("R".Contains(c)) return 6;
            return -1;
        }
    }
}
