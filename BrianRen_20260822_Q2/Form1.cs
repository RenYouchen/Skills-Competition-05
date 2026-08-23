using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrianRen_20260822_Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog()) {
                if (dlg.ShowDialog() == DialogResult.OK) { 
                    richTextBox1.Text = File.ReadAllText(dlg.FileName);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = 0;
            int searchCount = 0;
            var search = textBox1.Text;
            richTextBox1.SelectAll(); 
            richTextBox1.SelectionBackColor = Color.White;
            while((index = richTextBox1.Find(search.ToCharArray(), index)) != -1)
            {
                richTextBox1.Select(index, search.Length);
                richTextBox1.SelectionBackColor = Color.Yellow;
                index += search.Length;
                searchCount++;
            }
            count.Text = $"找到的個數： {searchCount}";
        }
    }
}
