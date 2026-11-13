using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace BrianRen_104_Q6_RichTextBox_String_Search {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        string s = "";
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog odf = new OpenFileDialog())
            {
                odf.Filter = "Text File *.txt|*.txt";
                if (odf.ShowDialog() == DialogResult.OK)
                {
                    s = File.ReadAllText(odf.FileName);
                    richTextBox1.Text = s;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string searchStr = textBox1.Text;
            label3.Text = "0";
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = Color.White;
            if(string.IsNullOrWhiteSpace(searchStr) || string.IsNullOrWhiteSpace(richTextBox1.Text)) return;
            s = richTextBox1.Text;
            var result = Regex.Matches(s,searchStr);
            for (int i = 0; i < result.Count; i++)
            {
                richTextBox1.Select(result[i].Index, result[i].Length);
                richTextBox1.SelectionBackColor = Color.Yellow;
            }
            label3.Text = result.Count.ToString();
        }
    }
}
