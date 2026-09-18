namespace 任宥臣_Q6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //textBox1.Text = $"ABCD{Environment.NewLine}EFGH{Environment.NewLine}IJKL{Environment.NewLine}MNOP";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var output = HoriFlip(textBox1.Text.Split(Environment.NewLine).ToList());
            textBox2.Text = string.Join($"{Environment.NewLine}", output);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            var output = VecFlip(textBox1.Text.Split(Environment.NewLine).ToList());
            textBox2.Text = string.Join($"{Environment.NewLine}", output);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var output = HoriFlip(Transform(textBox1.Text.Split(Environment.NewLine).ToList()));
            textBox2.Text = string.Join($"{Environment.NewLine}", output);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var output = VecFlip(Transform(textBox1.Text.Split(Environment.NewLine).ToList()));
            textBox2.Text = string.Join($"{Environment.NewLine}", output);
        }
        private List<string> HoriFlip(List<string> raw)
        {
            //List<string> a = raw;
            //foreach (var c in a)
            //{
            //    c.Reverse();
            //}
            var a = raw.Select(x => x.Reverse()).ToList();
            List<string> output = new List<string>();
            foreach (var i in a)
            {
                string s = "";
                foreach (var j in i)
                {
                    s += j;
                }
                output.Add(s);
            }
            return output;
        }

        private List<string> VecFlip(List<string> raw)
        {
            //List<string> a = raw;
            //foreach (var c in a)
            //{
            //    c.Reverse();
            //}
            var a = raw;
            a.Reverse();
            return a;
        }

        private List<string> Transform(List<string> raw)
        {
            var a = raw;
            char[,] trans = new char[4, 4];
            for (int i = 0; i < a.Count; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    trans[i, j] = a[j][i];
                }
            }

            List<string> output = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                string s = "";
                for (int j = 0; j < 4; j++)
                {
                    s += trans[i, j];
                }
                output.Add(s);
            }
            return output;
        }

        
    }
}
