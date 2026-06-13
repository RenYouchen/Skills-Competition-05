namespace BrianRen_114_Q4_Round2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var (a, b) = textBox1.Text.Split('/').Select(int.Parse).ToList() switch {var x => (x[0], x[1]) };

            string output = "";

            int c = a / b;
            output += $"{c};";
            a = a % b;
            (a, b) = (b, a); 
            while (true)
            {
                c = a / b;
                a = a % b;
                output += $"{c},";
                (a,b) = (b, a);
                if(a==0 || b==0) break; 
            }
            output = output.Remove(output.Length-1);
            textBox2.Text = output;
        }
    }
}
