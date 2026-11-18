using System.Numerics;

namespace BrianRen_102_Q5_Calc {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = string.Empty;
            int a = int.Parse(textBox1.Text), b = int.Parse(textBox2.Text), c = int.Parse(textBox3.Text);
            if(a*b == c) Switch(correct);
            else
            {
                Switch(wrong);
                label6.Text += $"(1) {a}+{b%10}={a+=b%10}\n";
                label6.Text += $"(2) {a}X{(b/10) * 10}={a*=(b/10)*10}\n";
                label6.Text += $"(3) {int.Parse(textBox1.Text) % 10}X{b % 10}={(int.Parse(textBox1.Text) % 10) * (b % 10)}\n";
                label6.Text += $"(4) {a}+{(int.Parse(textBox1.Text) % 10) * (b % 10)}={a += (int.Parse(textBox1.Text) % 10) * (b % 10)}";
            }

        }

        void Switch(Label lbl)
        {
            wrong.Visible = lbl == wrong;
            correct.Visible = lbl == correct;

        }
    }
}
