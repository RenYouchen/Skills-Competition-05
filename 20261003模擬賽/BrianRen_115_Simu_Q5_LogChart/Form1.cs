using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrianRen_115_Simu_Q5_LogChart {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> strings;

        private void button1_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Log File *.log|*.log";
                if(ofd.ShowDialog()  == DialogResult.OK)
                {
                    strings = File.ReadAllLines(ofd.FileName)
                        .Select(x => x.Split('|')[1])
                        .ToList();

                    label1.Text = ofd.SafeFileName + $"(共{strings.Count}筆)";
                }
                    
                chart1.Legends.Clear();
                chart1.Series.Clear();
                chart1.ChartAreas.Clear();
                chart1.Titles.Clear();
                
                var s = chart1.Series.Add("筆數");
                s.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

                Color[] c = new[] { Color.Gray, Color.Blue, Color.Orange, Color.Red };
                string[] type = new[] { "DEBUG", "INFO", "WARNING", "ERROR" }; 

                s.IsValueShownAsLabel = true;
                s.BorderColor = Color.Black;
                s.BorderWidth = 1;
                int[] counts = type.Select(x => strings.Count(i=>i==x)).ToArray();
                for (int i = 0; i < 4; i++)
                {
                    int idx = s.Points.AddXY(type[i], counts[i]);
                    s.Points[idx].Color = c[i];
                }

                var area = chart1.ChartAreas.Add("main");
                //area.AxisY.Title = "筆數";
                area.AxisX.MajorGrid.Enabled = false;
                area.AxisY.MajorGrid.LineColor = Color.Silver;
                //area.AxisY.Maximum = counts.Max();
                var t = chart1.Titles.Add("筆數");
                t.Alignment = ContentAlignment.TopLeft;
                t.DockedToChartArea = chart1.ChartAreas[0].Name;
                t.IsDockedInsideChartArea = false;
            }
        }
    }
}
