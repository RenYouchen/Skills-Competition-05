using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrianRen_106_Q1_Mean_Squared_Error_dotnet4._7._2 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Text = string.Concat(Enumerable.Range(1, N).Select(x => $"{x,4}"));
            textBox1.Text = "15";
            textBox2.Text = "11";
        }


        List<int> mathScores = new List<int>();
        List<int> englishScores = new List<int>();
        List<int> group = new List<int>();
        List<double> mseList = new List<double>();
        Random rnd = new Random();
        int N = 0;
        int K = 2;
        private void button1_Click(object sender, EventArgs e)
        {
            N = int.Parse(textBox1.Text);
            label6.Text = string.Concat(Enumerable.Range(1,N).Select(x=>$"{x,4}"));
            mathScores = Enumerable.Repeat(0, N).Select(x => rnd.Next(0, 101)).ToList();
            englishScores = Enumerable.Repeat(0, N).Select(x => rnd.Next(0, 101)).ToList();

            //mathScores = "28 67 66 12 41 28 72 28 90 83 39 50 69 83 61".Split().Select(int.Parse).ToList();
            //englishScores = "57 33 46 71 88 72 2 67 44 44 12 81 32 25 34".Split().Select(int.Parse).ToList();

            math.Text = string.Concat(mathScores.Select(x => $"{x,4}"));
            english.Text = string.Concat(englishScores.Select(x => $"{x,4}"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int P = 0;
            int Q = int.Parse(textBox2.Text);
            mseList.Clear();
            group.Clear();

            List<(double,double)> u = new List<(double,double)>();
            List<int> rndIdx = Enumerable.Range(0, N).OrderBy(_ => rnd.Next()).Take(K).ToList();
            foreach(int idx in rndIdx)
            {
                u.Add((mathScores[idx], englishScores[idx]));
            }
            u = u.OrderBy(x => x).ToList();

            for(int i = 0; i < N; i++)
            {
                group.Add(-1);
            }

            while (P++ < Q)
            {
                for (int i = 0; i < N; i++)
                {
                    double min = double.MaxValue;
                    (int, int) x = (mathScores[i], englishScores[i]);
                    for (int j = 0; j < u.Count; j++)
                    {
                        if (min > Dist(x, u[j]))
                        {
                            min = Dist(x, u[j]);
                            group[i] = j;
                        }
                    }
                }
                double sum = 0;
                for (int i = 0; i < K; i++)
                {
                    var member = Enumerable.Range(0, N).Where(x => group[x] == i).ToList();
                    if (member.Count == 0) continue;
                    u[i] = (member.Average(x => mathScores[x]), member.Average(x => englishScores[x]));
                }

                mseList.Add(Enumerable.Range(0, N).Average(x => Dist((mathScores[x], englishScores[x]), u[group[x]])));
            }
            textBox5.Text = string.Concat(group.Select(x => $"{x+1,4}"));
            Debug.WriteLine("");
        }

        double Dist((double,double) x, (double,double) u) =>
            Math.Sqrt(Math.Pow(x.Item1 - u.Item1, 2) + Math.Pow(x.Item2 - u.Item2, 2));

        private void button3_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Legends.Clear();

            var s = chart1.Series.Add("MSE");
            s.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            s.Color = Color.Blue;
            s.BorderWidth = 2;

            for(int i=0; i < mseList.Count;i ++)
            {
                s.Points.AddXY(i, mseList[i]);
            }

            var area = chart1.ChartAreas[0];
            area.AxisX.Title = "疊代次數";
            area.AxisY.Title = "MSE";
            area.AxisX.Minimum = 0;
            area.AxisX.Maximum = mseList.Count - 1;
            area.AxisX.Interval = 2;              // 橫軸每 2 標一個刻度，和範例一樣
            area.AxisY.Minimum = Math.Floor(mseList.Min()) - 1;   // 縱軸範圍貼近資料
            area.AxisY.Maximum = Math.Ceiling(mseList.Max()) + 1;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;
        }
    }
}
