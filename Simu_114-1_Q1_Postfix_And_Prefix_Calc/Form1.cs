namespace Simu_114_1_Q1_Postfix_And_Prefix_Calc {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Evaluate Postfix");
            comboBox1.Items.Add("Evaluate Prefix");
            comboBox1.SelectedIndex = 0;
            textBox1.Text = "5.2 3.1 + 2 4 / *";
        }
        
        List<string> steps = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                calcStack.Clear();
                steps.Clear();
                if (comboBox1.SelectedIndex == 0)
                {
                    calcPostfix(textBox1.Text);
                }
                else
                {
                    calcPrefix(textBox1.Text);
                }
                textBox2.Text = calcStack.Peek().ToString();
                textBox3.Text = string.Join(Environment.NewLine, steps);
            } catch(Exception _)
            {
                MessageBox.Show("表達式錯誤");
            }
            
        }
        Stack<decimal> calcStack = new Stack<decimal>();

        void calcPostfix(string exp)
        {
            calcStack.Clear();
            var data = exp.Split(' ').ToList();
            int count = 1;
            foreach(var i in data)
            {
                decimal num;
                if(decimal.TryParse(i, out num))
                {
                    calcStack.Push(num);
                    steps.Add($"[{count++}] push {num}\t stack=[{string.Join(',', calcStack)}]");
                } 
                else 
                {
                    decimal lop = calcStack.Pop();
                    decimal rop = calcStack.Pop();
                    if (i == "+")
                    {
                        calcStack.Push(lop + rop);
                    }
                    else if (i == "-")
                    {
                        calcStack.Push(lop - rop);
                    }
                    else if (i == "*")
                    {
                        calcStack.Push(lop * rop);
                    }
                    else if (i == "/")
                    {
                        calcStack.Push(lop / rop);
                    }
                    string result = i == data.Last().ToString() ? "結果" : $"push\t[{string.Join(',', calcStack)}]";
                    steps.Add($"[{count++}] {lop} {i} {rop} = {calcStack.Peek()} --> {result}");

                }

            }
        }

        void calcPrefix(string exp)
        {
            calcStack.Clear();
            var data = exp.Split(' ').Reverse().ToList();
            int count = 1;
            for(int idx = 0;  idx < data.Count; idx++) {
                {
                    var i = data[idx];
                    decimal num;
                    if (decimal.TryParse(i, out num))
                    {
                        calcStack.Push(num);
                        steps.Add($"[{count++}] push {num}\t stack=[{string.Join(',', calcStack)}]");
                    }
                    else
                    {
                        decimal lop = calcStack.Pop();
                        decimal rop = calcStack.Pop();
                        if (i == "+")
                        {
                            calcStack.Push(lop + rop);
                        }
                        else if (i == "-")
                        {
                            calcStack.Push(lop - rop);
                        }
                        else if (i == "*")
                        {
                            calcStack.Push(lop * rop);
                        }
                        else if (i == "/")
                        {
                            calcStack.Push(lop / rop);
                        }
                        string result = idx == data.Count() - 1 ? "結果" : $"push\t[{string.Join(',', calcStack)}]";
                        steps.Add($"[{count++}] {lop} {i} {rop} = {calcStack.Peek()} --> {result}");

                    }
                }
            }
        }
    }
}
