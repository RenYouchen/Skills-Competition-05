namespace BrianRen_114_Q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            (a, b) = richTextBox1.Text.Split("/").Select(x => int.Parse(x)).ToList() switch { var x => (x[0], x[1]) };

            string output = "";
            output += $"{a / b};";
            while (true)
            {
                var tmp = b;
                b = a % b;
                a = tmp;
                if (a == 0 || b == 0) break;
                output += $"{a / b},";
            }
            output = output.Remove(output.Length - 1);
            richTextBox2.Text = output;
        }
    }
}
