namespace _105_Q4_LightSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //(int, int) center = e.Graphics.
            e.Graphics.DrawEllipse(new Pen(new SolidBrush(Color.Black)), );
        }
    }
}