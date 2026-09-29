using System.Diagnostics;

namespace BrianRen_108_Q1_Vending_Machine {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectButton = this.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            double addCash;
            double.TryParse(selectButton.Name.Trim('_'), out addCash);
            double cash = double.Parse(textBox1.Text);
            cash += addCash;
            textBox1.Text = cash.ToString("0.0");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            double cash = double.Parse(textBox1.Text);
            if (cash - 35 >= 0)
            {
                cash -= 35;
                status.Text += "送出Cola ";
            }
            textBox1.Text = cash.ToString("0.0");

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            double cash = double.Parse(textBox1.Text);
            if (cash - 30 >= 0)
            {
                cash -= 30;
                status.Text += "送出PEPSO ";
            }
            textBox1.Text = cash.ToString("0.0");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            double cash = double.Parse(textBox1.Text);
            if (cash - 25 >= 0)
            {
                cash -= 25;
                status.Text += "送出diet PEPSO ";
            }
            textBox1.Text = cash.ToString("0.0");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            double cash = double.Parse(textBox1.Text);
            if (cash - 30 >= 0)
            {
                cash -= 30;
                status.Text += "送出Diet Cola ";
            }
            textBox1.Text = cash.ToString("0.0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0.0")
            {
                status.Text = "";
            }
            else
            {
                status.Text += $"退還{textBox1.Text}";
                textBox1.Text = "0.0";
            }
        }
    }
}
