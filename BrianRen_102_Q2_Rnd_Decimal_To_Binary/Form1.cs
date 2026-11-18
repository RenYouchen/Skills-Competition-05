namespace BrianRen_102_Q2_Rnd_Decimal_To_Binary {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Round(Random.Shared.NextDouble() * 10000, 6).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            string result = Convert.ToString((int)a,2) + '.';

            a -= (int)a;
            string s = ""; 
            while(s.Length < 10)
            {
                a *= 2;
                if (a == 0) break;
                s += (int)a;
                a -= (int)a;
            }

            textBox2.Text = result + s;
            textBox3.Text = textBox2.Text.TrimEnd('0');
        }
    }
}
