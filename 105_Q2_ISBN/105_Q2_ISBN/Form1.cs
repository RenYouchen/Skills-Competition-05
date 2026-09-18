using System.Diagnostics;

namespace _105_Q2_ISBN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "957-442-355";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var input = new List<char>();
            for (int i = 0; i < textBox1.Text.Length; i++)
                if (char.IsDigit(textBox1.Text[i])) input.Add(textBox1.Text[i]);
            
            if(input.Count == 9)
            {
                int s = 0;
                var isbn13 = new List<char>(input);
                for (int i = 0; i < input.Count; i++)
                    s += (input[i] - '0') * (10 - i);

                int M = s % 11;
                int N = 11 - M;
                input.Add(N switch
                {
                    10 => 'X',
                    11 => '0',
                    _ => (char)(N + '0')
                });
                textBox2.Clear();
                textBox2.Text = parseISBN(input);

                Debug.WriteLine(string.Join(' ', input));


                isbn13.Insert(0, '8');
                isbn13.Insert(0, '7');
                isbn13.Insert(0, '9');

                int sum13 = 0;
                for (int i = 0; i < isbn13.Count; i++)
                {
                    sum13 += (isbn13[i] - '0') * (i % 2 == 0 ? 1 : 3);
                }
                int chkNum = 10 - (sum13 % 10);
                isbn13.Add((char)(chkNum + '0'));
                Debug.WriteLine(string.Join(' ', chkNum));
                textBox3.Clear();
                textBox3.Text = parseISBN(isbn13);
            }
            else
            {
                MessageBox.Show("Wrong Value");
            }

        }
        private string parseISBN(List<char> input)
        {
            var code = "157,204,421,442,7198,7323,8573".Split(',');
            string s = "";
            for (int i = 0; i < input.Count; i++)
            {
                s += input[i];
                //if (i % 3 == 2 && i != input.Count - 1) s += '-';
            }
            foreach(var i in code)
            {
                if(s.Contains(i))
                {
                    Debug.WriteLine(i);
                    var replace = input.Count > 10 ? $"-{i}-" : $"{i}-";
                    s = s.Replace(i, replace);
                    break;
                }
            }
            s = s.Insert(3, "-");
            s = s.Insert(s.Length-1, "-");
            return s;
        }
    }
}