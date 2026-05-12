using System.Diagnostics;

namespace BrianRen_113_Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> cfList = new List<int>();
            cfList = textBox1.Text.Split(',').Select(x => int.Parse(x)).ToList();
            var a = calc(cfList[0], cfList[1..]);
            textBox2.Text = $"{a.Item2} / {a.Item1}";
            Debug.WriteLine(a);
        }

        private (int, int) calc(int a, List<int> b)
        {
            if (b.Count != 1)
            {
                (int, int) rt = calc(b[0], b[1..]);
                int up = rt.Item2 * a + rt.Item1;
                int down = rt.Item2;
                Debug.WriteLine($"Recursive case: {(up, down)}");
                return (down, up);
            }
            else
            {
                int down, up;
                down = b[0];
                up = a * b[0] + 1;
                Debug.WriteLine($"Base case: {(up, down)}");
                return (down, up);
            }
            Debug.WriteLine($"{a} {string.Join(',', b)}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
