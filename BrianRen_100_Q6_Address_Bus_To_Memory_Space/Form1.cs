namespace BrianRen_100_Q6_Address_Bus_To_Memory_Space {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Random.Shared.Next(16, 53).ToString();
            textBox2.Text = $"{Random.Shared.Next(1, 9)}B";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int addressBus = int.Parse(textBox1.Text);
            int bpa = int.Parse(textBox2.Text.Replace("B", ""));

            int prefix = (1 << (addressBus % 10)) * bpa;
            if (addressBus > 40)
            {
                prefix = (1 << (addressBus - 40)) * bpa;
            }
            string postfix = (addressBus / 10) switch
            {
                1 => "KB",
                2 => "MB",
                3 => "GB",
                >= 4 => "TB"
            };
            textBox3.Text = prefix + postfix;
        }
        List<string> types = new List<string> { "KB", "MB", "GB", "TB" };
        private void button4_Click(object sender, EventArgs e)
        {
            int type = Random.Shared.Next(0, 4);
            int x = type switch
            {
                0 => Random.Shared.Next(512, 1024),
                3 => Random.Shared.Next(1, 32768),
                _ => Random.Shared.Next(1, 1024)
            };
            textBox6.Text = x + types[type];
            textBox5.Text = Random.Shared.Next(1, 9) + "B";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = textBox6.Text;
            int typeIdx = types.IndexOf(s[^2..]);
            int a = int.Parse(s[..^2]);
            int bpa = int.Parse(textBox5.Text[..^1]);

            long x = a * typeIdx switch
            {
                0 => 1L << 10,
                1 => 1L << 20,
                2 => 1L << 30,
                3 => 1L << 40,
            } / bpa;
            int cnt = 0;
            while ((1L << cnt) < x) cnt++;
            textBox4.Text = (cnt).ToString();
        }
    }
}
