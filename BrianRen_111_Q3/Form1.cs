namespace BrianRen_111_Q3
{
    public partial class Form1 : Form
    {
        Color[,] colors = new Color[4, 4];
        Color[,] oldColors;
        public Form1()
        {
            InitializeComponent();
            create();
            pictureBox2.Image = draw(colors);
            swap_old_color();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            create();
            swap_old_color();
        }

        private void swap_old_color()
        {
            if (oldColors != null) pictureBox1.Image = draw(oldColors);
            oldColors = (Color[,])colors.Clone();
            pictureBox2.Image = draw(colors);
        }
        private void create()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    colors[i, j] = Color.FromArgb(
                        Random.Shared.Next(255),
                        Random.Shared.Next(255),
                        Random.Shared.Next(255)
                        );
                }
            }
        }

        private Bitmap draw(Color[,] colors)
        {
            Bitmap img = new Bitmap(240, 240);
            Graphics g = Graphics.FromImage(img);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    g.FillRectangle(new SolidBrush(colors[i, j]), i * 60, j * 60, 60, 60);
                }
            }
            //pictureBox2.Image = img;
            return img;
        }

        //HoriFlip
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    (colors[i, j], colors[3 - i, j]) = (colors[3 - i, j], colors[i, j]);
                }
            }
            swap_old_color();
        }

        //VerFlip
        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    (colors[j, i], colors[j, 3 - i]) = (colors[j, 3 - i], colors[i, j]);
                }
            }
            swap_old_color();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Color[,] newArray = new Color[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    newArray[i, j] = colors[j, i];
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    (newArray[i, j], newArray[3 - i, j]) = (newArray[3 - i, j], newArray[i, j]);
                }
            }
            colors = newArray;
            swap_old_color();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Color[,] newArray = new Color[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    newArray[i, j] = colors[j, i];
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    (newArray[j, i], newArray[j, 3 - i]) = (newArray[j, 3 - i], newArray[i, j]);
                }
            }
            colors = newArray;
            swap_old_color();
        }
    }
}
