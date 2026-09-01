using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrianRen_110_Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var text = textBox1.Text;
            if (!(8 <= text.Count()) || !(text.Count() <= 20))
            {
                MessageBox.Show("超出範圍");
                textBox1.Clear();
            }
            else
            {
                var output = text
                    .GroupBy(f => char.IsLetter(f))
                    .Select(g => g.Count()).ToList();
                if (output.Count() != 2) output.Add(0);
                label2.Text = string.Join(", ", output);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var text = textBox1.Text;
            int[] letterAndNum = label2.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int level = 0;
            if (text.Count() > 12) level += 1;
            if (letterAndNum[0] > 0 && letterAndNum[1] > 0) level += 1;
            if (letterAndNum[0] > letterAndNum[1]) level += 1;
            label3.Text = level == 3 ? "strong" : "weak";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label2.Text = "";
            label3.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}