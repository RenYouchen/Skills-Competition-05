namespace BrianRen_103_Q3_Random_8bit_Adder {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Random.Shared.Next(256), 2).PadLeft(8, '0');
            textBox2.Text = Convert.ToString(Random.Shared.Next(256), 2).PadLeft(8, '0');
            //textBox1.Text = "01001010";
            //textBox2.Text = "11001010";
            for (int i = 3; i <= 8; i++)
                Controls[$"textBox{i}"].Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToSByte(textBox1.Text, 2), b = Convert.ToSByte(textBox2.Text, 2);
            textBox3.Text = Convert.ToString(a + b, 2).PadLeft(8, '0');
            int sum = a + b;
            textBox3.Text = Convert.ToString(sum & 0xFF,2).PadLeft(8, '0');
            if (sum > 127) textBox4.Text = "overflow";
            else if (sum < -128) textBox4.Text = "underflow";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sbyte a = Convert.ToSByte(textBox1.Text, 2), b = Convert.ToSByte(textBox2.Text, 2);
            textBox8.Text = a.ToString();
            textBox7.Text = b.ToString();
            textBox6.Text = Convert.ToSByte(textBox3.Text, 2).ToString();
            if (textBox4.Text == "overflow") textBox5.Text = "ÒçÎ»";
            else if (textBox4.Text == "underflow") textBox5.Text = "²»×ãÎ»";
        }
    }
}
