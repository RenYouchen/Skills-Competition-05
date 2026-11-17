namespace BrianRen_100_Q3_CountDown {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            label2.ForeColor = Color.Red;
            label5.ForeColor = Color.Red;
        }
        int remainSecond = 0 * 60 + 5;
        private void timer1_Tick(object sender, EventArgs e)
        {
            remainSecond--;
            label2.Text = (remainSecond/60).ToString();
            label5.Text = (remainSecond%60).ToString();
            if(remainSecond == 0)
            {
                timer1.Stop();
                label2.ForeColor = Color.White;
                label2.BackColor = Color.Red;
                label5.ForeColor = Color.White;
                label5.BackColor = Color.Red;
                MessageBox.Show("•régµ½");
            }
        }
    }
}
