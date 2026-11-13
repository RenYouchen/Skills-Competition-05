using System.Diagnostics;

namespace BrianRen_104_Q3_Float_To_Decimal {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }
        string rndFloat = "";

        private void button1_Click(object sender, EventArgs e)
        {
            rndFloat = "";
            textBox4.Clear();
            for (int i = 0; i < 32; i++)
            {
                rndFloat += $"{Random.Shared.Next(0, 2)}";
            }
            textBox1.Text = rndFloat.Substring(0, 1);
            textBox2.Text = rndFloat.Substring(1, 8);
            textBox3.Text = rndFloat.Substring(9, 23);

            //textBox1.Text = "1";
            //textBox2.Text = "10000110";
            //textBox3.Text = "01000011110000000000000";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rndFloat = textBox1.Text + textBox2.Text + textBox3.Text;
            //int raw = Convert.ToInt32(rndFloat, 2);
            //float result = BitConverter.ToSingle(BitConverter.GetBytes(raw));
            //textBox4.Text = result.ToString();

            double sign = rndFloat[0] - '0';

            double exponent = Convert.ToInt32(textBox2.Text, 2);

            double mantissa = textBox3.Text.Select((x,i)=>(x-'0') * Math.Pow(2, -(i+1))).Sum();

            mantissa = (mantissa + 1) * Math.Pow(2, (exponent - 127)) * Math.Pow(-1, sign);
            textBox4.Text = mantissa.ToString("0.##########");

        }
    }
}
