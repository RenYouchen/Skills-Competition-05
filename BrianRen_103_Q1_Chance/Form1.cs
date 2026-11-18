namespace BrianRen_103_Q1_Chance {
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
            decimal a = decimal.Parse(textBox1.Text) *
                decimal.Parse(textBox4.Text) +
                decimal.Parse(textBox2.Text) *
                decimal.Parse(textBox5.Text) +
                decimal.Parse(textBox3.Text) *
                decimal.Parse(textBox6.Text);
            richTextBox1.Text = $"在台北市的上班族遲到的機率為:{a}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal a = decimal.Parse(textBox1.Text) *
                decimal.Parse(textBox4.Text) +
                decimal.Parse(textBox2.Text) *
                decimal.Parse(textBox5.Text) +
                decimal.Parse(textBox3.Text) *
                decimal.Parse(textBox6.Text);
            richTextBox1.Text = $"如果已知有一個人上班遲到，那他是自己開車的機率爲何:{decimal.Parse(textBox6.Text) / a}";
        }
    }
}
