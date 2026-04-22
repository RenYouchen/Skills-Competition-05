using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrianRen_114_Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var output = "一號\t二號\t三號\t四號" + Environment.NewLine;
            List<string> pattern = "黑桃,紅心,黑梅,紅磚".Split(',').ToList();

            List<string> outputPattern = new List<string>();
            Random rnd = new Random();
            for (int i = 0; i < pattern.Count; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    outputPattern.Add(pattern[i] + $",{(j == 6 ? 13 : (j + 1))}");
                }
            }
            List<string> a = pattern.Select(x => x = x + ",7").OrderBy(_=> rnd.Next()).ToList();
            outputPattern = outputPattern.OrderBy(x => rnd.Next()).ToList();
            outputPattern.InsertRange(0, a.ToList());
            for (int i = 0; i < pattern.Count*13; i+=4)
            {
                output += $"{outputPattern[i]}\t{outputPattern[i + 1]}\t{outputPattern[i + 2]}\t{outputPattern[i + 3]} {Environment.NewLine}";
            }
            textBox1.Text = output;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
