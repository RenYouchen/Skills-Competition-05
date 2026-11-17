using System.Diagnostics;

namespace BrianRen_100_Q5_Encode_OR_Decode {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "-1";
            textBox2.Text = "2";
            textBox3.Text = "6";
            textBox4.Text = "0.637197";
        }
        //1000101110110101000111
        private void button1_Click(object sender, EventArgs e)
        {
            int lx = int.Parse(textBox1.Text),
                rx = int.Parse(textBox2.Text),
                acc = int.Parse(textBox3.Text);

            int split = (rx - lx) * (int)Math.Pow(10, acc);
            int m = 0;
            while(Math.Pow(2,m) < split) m++;

            if (textBox4.Text.Contains("."))
            {
                double x = double.Parse(textBox4.Text);
                long scale = 1L << m;
                long result = (long)Math.Round((x - lx) / (rx - lx) * ((1 << m) - 1));
                label5.Text = $"Ans = {Convert.ToString(result, 2)}";
            }
            else
            {
                double x = Convert.ToInt32(textBox4.Text,2);
                label5.Text = $"Ans = {Math.Round(lx + x * (rx - lx) / ((1 << m) - 1), acc)}";
            }

        }
    }
}

