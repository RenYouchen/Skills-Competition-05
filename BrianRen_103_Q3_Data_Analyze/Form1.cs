using System.Security.Cryptography;

namespace BrianRen_103_Q3_Data_Analyze {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        int n, m;
        List<List<double>> data = new List<List<double>>();
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog odf = new OpenFileDialog())
            {
                if (odf.ShowDialog() == DialogResult.OK)
                {
                    var a = File.ReadAllLines(odf.FileName);
                    richTextBox1.Clear();
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (i == 0)
                        {
                            var x = a[i].Split().Select(int.Parse).ToList();
                            n = x[0]; m = x[1];
                            continue;
                        }
                        data.Add(a[i].Split().Select(double.Parse).ToList());
                        richTextBox1.Text += $"{i - 1,5} {data[i - 1][0],5} {data[i - 1][1],5}\n";
                    }

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var NH = new List<double>();
            var NW = new List<double>();

            var uH = data.Select(x => x[0]).Average();
            var uW = data.Select(x => x[1]).Average();
            var oH = data.Select(x => Math.Pow(x[0] - uH, 2)).Average();
            var oW = data.Select(x => Math.Pow(x[1] - uW,2)).Average();

            NH = data.Select(x => (x[0] - uH)/oH).ToList();
            NW = data.Select(x => (x[1] - uW)/oW).ToList();

            List<List<List<double>>> s = new List<List<List<double>>>();
            for (int i = 0; i < 3; i++)
                s.Add(new List<List<double>>());

            var NHW = NH.Zip(NW, (x,y) => new List<double>() {x,y}).ToList();

            s[0].Add(NHW[0]);
            s[1].Add(NHW[1]);
            s[2].Add(NHW[2]);

            for(int i = 3;i < NHW.Count;i++)
                s[Random.Shared.Next(0, 3)].Add(NHW[i]);
            
            for(int t = 0; t < 200; t++)
            {
                var uHj = new List<double>();
                var uWj = new List<double>();   
                for(int j = 0; j < s.Count; j++)
                {
                    var uHtj = s[j].Select(x => x[0]).Average();
                    var uWtj = s[j].Select(x => x[1]).Average();
                    uHj.Add(uHtj);
                    uWj.Add(uWtj);
                }

                var uHWj = uHj.Zip(uWj, (x, y) => new List<double>() { x, y }).ToList();

                s.Clear();
                for (int k = 0; k < 3; k++)
                    s.Add(new List<List<double>>());

                for (int i = 0; i < NHW.Count;i++)
                {
                    var dist = new List<(int, double)>();
                    for (int j = 0; j < s.Count; j++)
                        dist.Add((j, Dist(NHW[i], uHWj[j])));
                    
                    s[dist.MinBy(x => x.Item2).Item1].Add(NHW[i]);
                }
            }

            richTextBox3.Clear();
            richTextBox4.Clear();
            richTextBox5.Clear();

            List<(int, int)> result = new List<(int, int)>();

            for (int i = 0; i < s.Count; i++)
            {
                var rtb = (RichTextBox)Controls[$"richTextBox{i + 3}"];
                
                rtb.Text = string.Join('\n', s[i].Select(x =>
                {
                    result.Add((NHW.IndexOf(x), i));
                    return $"{NHW.IndexOf(x),5} {data[NHW.IndexOf(x)][0],5} {data[NHW.IndexOf(x)][1],5}";
                }));
            }
            result = result.OrderBy(x => x.Item1).ToList();
            richTextBox2.Text = string.Join('\n', result.Select((x => $"µÚ{x.Item1}¹PŒÙì¶µÚ{x.Item2}¶Ñ")));

        }

        double Dist(List<double> p1,  List<double> p2)
        {
            double sum = 0;
            for(int i = 0; i < p1.Count;i++)
            {
                sum+= Math.Pow(p1[i] - p2[i],2);
            }
            return Math.Sqrt(sum);
        }
    }
}
