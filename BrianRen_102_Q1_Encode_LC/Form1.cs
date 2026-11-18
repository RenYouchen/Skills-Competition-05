using System.Diagnostics;

namespace BrianRen_102_Q1_Encode_LC {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }
        TextBox[,] inputData = new TextBox[6, 6];
        TextBox[,] mask = new TextBox[3, 3];
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    var size = new Size(400 / 8, 400 / 8);
                    if (i == 0 || j == 0)
                    {
                        Label label = new Label();
                        label.Size = size;
                        label.TextAlign = ContentAlignment.MiddleCenter;
                        if (i == j)
                        {
                            label.Text = "";
                        }
                        else
                        {
                            label.Text = $"{(i == 0 ? j - 1 : i - 1)}";
                        }
                        flowLayoutPanel1.Controls.Add(label);
                    }
                    else
                    {
                        TextBox textBox = new TextBox();
                        textBox.Size = size;
                        textBox.Text = "100";

                        inputData[i - 1, j - 1] = textBox;
                        flowLayoutPanel1.Controls.Add(textBox);
                    }
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    var size = new Size(300 / 5, 300 / 5);
                    if (i == 0 || j == 0)
                    {
                        Label label = new Label();
                        label.Size = size;
                        label.TextAlign = ContentAlignment.MiddleCenter;
                        if (i == j)
                        {
                            label.Text = "";
                        }
                        else
                        {
                            label.Text = $"{(i == 0 ? j - 1 : i - 1)}";
                        }
                        flowLayoutPanel2.Controls.Add(label);
                    }
                    else
                    {
                        TextBox textBox = new TextBox();
                        textBox.Size = size;
                        mask[i - 1, j - 1] = textBox;
                        flowLayoutPanel2.Controls.Add(textBox);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox2.Text), y = int.Parse(textBox3.Text);

            List<List<int>> input = Enumerable.Range(x, 3)
                .Select(r => Enumerable.Range(y, 3).Select(c => int.Parse(inputData[r, c].Text)).ToList())
                .ToList();
            List<List<int>> msk = Enumerable.Range(0,3)
                .Select(i => Enumerable.Range(0,3).Select(j => int.Parse(mask[i,j].Text)).ToList())
                .ToList();

            //var sum = input.Cast<int>().Zip(msk.Cast<int>(), (i, m) => (i - input[1][1] >= 0 ? m : 0)).Sum();
            var sum = input.SelectMany(x => x).Zip(msk.SelectMany(x => x).ToList(), (i, m) => (i - input[1][1] >= 0 ? m : 0)).Sum();
            textBox1.Text = sum.ToString();
        }

        int T(int n) => n >= 0 ? 1 : 0;
    }
}
