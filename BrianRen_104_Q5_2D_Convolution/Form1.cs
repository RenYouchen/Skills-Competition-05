namespace BrianRen_104_Q5_2D_Convolution {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        TextBox[,] inputData = new TextBox[7, 7];
        TextBox[,] kSettings = new TextBox[3, 3];
        TextBox[,] outputData = new TextBox[7, 7];
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        var lbl = new Label();
                        lbl.Size = new Size(600 / 9, 600 / 9);
                        if (i == 0 && j == 0) lbl.Text = "";
                        else lbl.Text = i == 0 ? $"{j - 1}" : $"{i - 1}";
                        lbl.TextAlign = ContentAlignment.MiddleCenter;
                        var lbl2 = new Label();
                        lbl2.Size = new Size(600 / 9, 600 / 9);
                        if (i == 0 && j == 0) lbl2.Text = "";
                        else lbl2.Text = i == 0 ? $"{j - 1}" : $"{i - 1}";
                        lbl2.TextAlign = ContentAlignment.MiddleCenter;
                        flowLayoutPanel1.Controls.Add(lbl);
                        flowLayoutPanel3.Controls.Add(lbl2);
                    }
                    else
                    {
                        var txb1 = new TextBox();
                        var txb2 = new TextBox();
                        txb1.Size = new Size(600 / 9, 600 / 9);
                        txb2.Size = new Size(600 / 9, 600 / 9);
                        txb1.Text = "0";
                        txb2.Text = "0";
                        txb1.TextAlign = HorizontalAlignment.Center;
                        txb2.TextAlign = HorizontalAlignment.Center;

                        inputData[i - 1, j - 1] = txb1;
                        outputData[i - 1, j - 1] = txb2;
                        flowLayoutPanel1.Controls.Add(txb1);
                        flowLayoutPanel3.Controls.Add(txb2);
                    }
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        var lbl = new Label();
                        lbl.Size = new Size(368 / 5, 368 / 5);
                        lbl.TextAlign = ContentAlignment.MiddleCenter;
                        if (i == j)
                        {
                            lbl.Text = "";
                        }
                        else
                        {
                            lbl.Text = i == 0 ? $"{j - 2}" : $"{i - 2}";
                        }
                        flowLayoutPanel2.Controls.Add(lbl);
                    }
                    else
                    {
                        var txb = new TextBox();
                        txb.Size = new Size(368 / 5, 368 / 5);
                        txb.Text = "0";
                        txb.TextAlign = HorizontalAlignment.Center;
                        kSettings[i - 1, j - 1] = txb;
                        flowLayoutPanel2.Controls.Add(txb);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] I = new int[7,7], K = new int[3,3], O = new int[7, 7];
            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 7; j++)
                    I[i, j] = int.Parse(inputData[i, j].Text);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    K[i,j] = int.Parse(kSettings[2-i, 2-j].Text);

            for(int i = 1; i < 6; i++)
            {
                for(int j = 1; j < 6; j++)
                {
                    for(int x = -1; x < 2; x++)
                    {
                        for(int y = -1; y < 2; y++)
                        {
                            O[i,j] += I[i+x,j+y] * K[x+1, y+1];
                        }
                    }
                }
            }

            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 7; j++)
                    outputData[i,j].Text = $"{O[i,j]}";

            //MSE
            double MSE = I.Cast<int>().ToList()
                .Zip(O.Cast<int>().ToList(), (x,y) => Math.Pow(x-y, 2))
                .Average();
            //MAE
            double MAE = I.Cast<int>().ToList()
                .Zip(O.Cast<int>().ToList(), (x, y) => Math.Abs(x-y))
                .Average();
            //PSNR 
            double PSNR = 10 * Math.Log10(255 * 255 / MSE);

            textBox1.Text = MSE.ToString();
            textBox2.Text = MAE.ToString();
            textBox3.Text = PSNR.ToString();
        }
    }
}
