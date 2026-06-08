namespace BrianRen_114_Q1_Round2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> pattern = "黑桃,紅心,紅磚,黑莓".Split(',').ToList(); 
            List<string> cards = pattern.SelectMany(x=>Enumerable.Range(1,13), (x,y) => $"{x},{y}").ToList();
            Random rnd = new Random();
            cards = cards.OrderBy(x => rnd.Next()).OrderByDescending(x => x[3] == '7').ToList();

            string output = "一號\t二號\t三號\t四號" + Environment.NewLine;
            for (int i = 0; i < cards.Count; i+=4) {
                output += $"{cards[i]}\t{cards[i+1]}\t{cards[i+2]}\t{cards[i+3]}{Environment.NewLine}";
            }

            textBox1.Text = output;
        }
    }
}
