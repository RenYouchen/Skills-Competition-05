namespace BrianRen_107_Q6_Huffman_Decoding {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, char> map = new()
        {
            ["10"] = 'A',
            ["01"] = 'B',
            ["11"] = 'C',
            ["001"] = 'D',
            ["000"] = 'E'
        };
        private void button1_Click(object sender, EventArgs e)
        {
            var length = Random.Shared.Next(26, 48); //26~47 because if ==47 -> ([47] + "001").Lenght == 50
            var keys = map.Keys.ToArray();
            var result = "";
            while (result.Length < length)
                result += (keys[Random.Shared.Next(keys.Length)]);
            textBox1.Text = result;
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var length = Random.Shared.Next(26, 50);
            var result = "";
            while (result.Length < length) result += Random.Shared.Next(2);
            textBox4.Text = result;
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var rt = Decoder(textBox1.Text);
            if(rt == "error") textBox2.Text = "不合理";
            else
            {
                textBox2.Clear();
                textBox3.Text = rt;
            }
            rt = Decoder(textBox4.Text);
            if (rt == "error") textBox5.Text = "不合理";
            else
            {
                textBox5.Clear();
                textBox6.Text = rt;
            }
        }

        string Decoder(string input)
        {
            var result = "";
            var temp = "";
            foreach(var c in input)
            {
                temp += c;
                if(map.TryGetValue(temp, out char ch))
                {
                    result += ch;
                    temp = "";
                }
            }
            if (temp != "") return "error";
            return result;
        }
    }
}
