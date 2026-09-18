using System.ComponentModel;
using System.Diagnostics;

namespace _105_Q3_Run_Length_Encoding_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0000001000000010000000001100000000000000";
            //textBox2.Text = textBox1.Text.Length.ToString();
            //1000000000000001100000000000000000000001
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            var rndSet = Enumerable.Repeat(0, 40).ToList();
            for(int i =0;i <4;i++)
            {
                rndSet[i] = 1;
            }
            rndSet = rndSet.OrderBy(x => Random.Shared.Next()).ToList();
            rndSet.ForEach(x => textBox1.Text += x);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var raw = textBox1.Text;
            var t = raw.Split('1');
            textBox2.Clear();
            var output = t.Select(x => convByte(x.Count())).ToList();
            if (t.Last() == "")
                output.RemoveAt(output.Count-1);
            textBox2.Text = string.Join(' ', output);
            textBox3.Text = $"{((double)textBox2.Text.Length / 40) * 100}%";
        }

        private int convByte(int count)
        {
            string a = "";
            if (count == 0) return 0; 
            while(count > 0)
            {
                a += count % 2;
                count /= 2;
            }
            var rev = a.Reverse().ToList();
            a = "";
            rev.ForEach(x => a += x);
            return int.Parse(a);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}