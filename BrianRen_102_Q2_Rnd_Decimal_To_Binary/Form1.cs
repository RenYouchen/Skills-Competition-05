namespace BrianRen_102_Q2_Rnd_Decimal_To_Binary {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Random.Shared.Next();
        }
    }
}
