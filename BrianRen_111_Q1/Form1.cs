using System.Diagnostics;

namespace BrianRen_111_Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label4.Text = textBox1.Text;
            if (textBox1.Text == "") return;
            long[] result = new long[] { 1, 1, 1, 0 };
            for (int i = 0; i < int.Parse(textBox1.Text) -1; i++)
            {
                result = calc(result, new long[] { 1, 1, 1, 0 });
            }
            label5.Text = result[0].ToString();
            label6.Text = result[1].ToString();
            label7.Text = result[2].ToString();
            label8.Text = result[3].ToString();

        }
        long[] calc(long[] a, long[] b)
        {
            return new[]
            {
                a[0]*b[0] + a[1]*b[2], a[0]*b[1] + a[1]*b[3],
                a[2]*b[0] + a[3]*b[2],  a[2]*b[1] + a[3]*b[3]
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
