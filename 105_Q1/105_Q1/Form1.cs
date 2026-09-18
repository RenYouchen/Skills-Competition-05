using System.Diagnostics;
using System.Numerics;

namespace _105_Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "123,456,789,123,456,789*80000";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var stringInput = "";
            for(int a = 0; a < textBox1.Text.Length; a++)
            {
                if (textBox1.Text[a] != ',') stringInput += textBox1.Text[a];
            }
            List<BigInteger> calcNum = new List<BigInteger>();
            List<char> calcChar = new List<char>();
            int index = 0;
            int oldIndex = 0;
            while (index < stringInput.Length)
            {
                bool isDigital = true;
                do
                {
                    index++;
                    if (index >= stringInput.Length) break;
                    isDigital = (char.IsDigit(stringInput[index]));
                    if(!isDigital) calcChar.Add(stringInput[index]);
                } while (isDigital);
                calcNum.Add(BigInteger.Parse(stringInput[oldIndex..index]));
                oldIndex = index+1;
                index++;
            }
            Debug.WriteLine(string.Join(' ', calcNum));
            Debug.WriteLine(string.Join(' ', calcChar));

            while(calcChar.Count > 0)
            {
                for(int i = 0; i < calcChar.Count; i++) 
                {
                    if (calcChar[i] == '*') {
                        BigInteger a = calcNum[i];
                        BigInteger b = calcNum[i + 1];
                        calcNum.RemoveAt(i + 1);
                        calcNum[i] = a * b;
                    }
                }
                calcChar.RemoveAll(x => x == '*');
                for (int i = 0; i < calcChar.Count; i++)
                {
                    if (calcChar[i] == '/')
                    {
                        BigInteger a = calcNum[i];
                        BigInteger b = calcNum[i + 1];
                        calcNum.RemoveAt(i + 1);
                        calcNum[i] = a / b;
                    }
                }
                calcChar.RemoveAll(x => x == '/');
                for (int i = 0; i < calcChar.Count; i++)
                {
                    if (calcChar[i] == '+')
                    {
                        BigInteger a = calcNum[i];
                        BigInteger b = calcNum[i + 1];
                        calcNum.RemoveAt(i + 1);
                        calcNum[i] = a + b;
                    }
                }
                calcChar.RemoveAll(x => x == '+');
                for (int i = 0; i < calcChar.Count; i++)
                {
                    if (calcChar[i] == '-')
                    {
                        BigInteger a = calcNum[i];
                        BigInteger b = calcNum[i + 1];
                        calcNum.RemoveAt(i + 1);
                        calcNum[i] = a - b;
                    }
                }
                calcChar.RemoveAll(x => x == '-');
            }
            Debug.WriteLine(string.Join(' ', calcNum));
            Debug.WriteLine(string.Join(' ', calcChar));
            string outputNum = calcNum.First().ToString();
            Debug.WriteLine(outputNum);
            textBox2.Clear();
            int j = outputNum.Length;
            for (int i = 0; i < outputNum.Length; i++)
            {
                textBox2.Text += outputNum[i];
                if ((j-i) % 3 == 1&&i!=outputNum.Length-1) textBox2.Text += ',';       
            }
        }
    }
}