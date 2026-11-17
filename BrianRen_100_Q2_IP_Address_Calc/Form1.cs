using System.Diagnostics;

namespace BrianRen_100_Q2_IP_Address_Calc {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "10.168.100.253/30";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var currentIP = textBox1.Text;
            var part = currentIP.Split('/');

            uint ip = part[0].Split(".").Select(uint.Parse).Aggregate(0u, (acc, p) => (acc << 8) | p);

            uint mask = part[1] == "0" ? 0 : uint.MaxValue << (32 - int.Parse(part[1]));

            var address = ip & mask;
            var boardcast = address | ~mask;
            textBox2.Text = $"{address >> 24}.{(address >> 16) & 255}.{(address >> 8) & 255}.{address & 255}";
            textBox3.Text = $"{boardcast >> 24}.{(boardcast >> 16) & 255}.{(boardcast >> 8) & 255}.{boardcast & 255}";
            textBox4.Text = (Math.Pow(2,32 - int.Parse(part[1])) - 2).ToString();
            Debug.WriteLine("");
        }
    }
}
