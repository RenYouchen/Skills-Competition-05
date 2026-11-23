using System.Numerics;

namespace BrianRen_103_Q6_Calc {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text),
                p = int.Parse(textBox2.Text),
                n = int.Parse(textBox3.Text);

            BigInteger a = x;
            p--;
            while (p-- > 0) a *= x;
            a = a % n;
            label5.Text = a.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <= 3; i++)
            {
                var t = (TextBox)(Controls[$"textBox{i}"]);
                t.Clear();
            }
        }
    }
}
