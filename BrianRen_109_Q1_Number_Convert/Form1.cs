using System;
using System.Diagnostics;
using System.Numerics;

namespace BrianRen_109_Q1_Number_Convert {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "406000";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numOutput.Text = BigInteger.Parse(textBox1.Text).ToString("N0");
            BigInteger num = BigInteger.Parse(textBox1.Text);
            string[] numMap = "Áã,Ò¼,ÙE,Èþ,ËÁ,Îé,ê‘,Æâ,°Æ,¾Á".Split(',');
            string[] unit1 = ",Ê°,°Û,Çª".Split(',');
            string[] unit2 = ",Èf,ƒ|,Õ×".Split(',');
            bool needAppendZero = false;
            string ans = "";
            string raw = textBox1.Text;
            List<string> selections = new List<string>();
            for(int i = raw.Length; i > 0; i-=4)
            {
                selections.Add(raw[Math.Max(0, i - 4)..i]);
            }
            
            Debug.Write(string.Join(' ', selections));

            for(int i = selections.Count - 1; i >= 0; i--)
            {
                for (int j = 0; j < selections[i].Length; j++)
                {
                    int c = selections[i][j] - '0';
                    int unitIdx = selections[i].Length - j - 1;
                    if (c != 0)
                    {
                        ans += numMap[c] + unit1[unitIdx];
                    } else
                    {
                        ans += numMap[0];
                    }
                }
                if (int.Parse(selections[i]) != 0) ans += unit2[i];
            }
            while (ans.Contains("ÁãÁã")) ans = ans.Replace("ÁãÁã", "Áã");
            ans = ans.Replace("Ê°Áã", "Ê°");
            ans = ans.Trim('Áã');
            if (num == 0) ans = "Áã";
            chineseOutput.Text = ans;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            numOutput.Text = "";
            chineseOutput.Text = "";
        }
    }
}
