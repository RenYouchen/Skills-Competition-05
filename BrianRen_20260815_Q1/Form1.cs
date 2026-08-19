using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrianRen_20260815_dotNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedIndex = -1;
            textBox4.Text = "";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
            {
                MessageBox.Show("請輸入姓名");  
                textBox1.Focus();
                return;
            } else if (textBox2.Text == "")
            {
                MessageBox.Show("請輸入學校");
                textBox2.Focus();
                return;
            } else if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("請選擇興趣");
                comboBox1.Focus();
                return;
            }
            textBox4.Text = $"大家好，我是{textBox1.Text.Trim()}\r\n" +
                $"來自{textBox2.Text.Trim()}\r\n" +
                $"我的興趣是{comboBox1.Text}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new object[]
            {
                "程式設計",
                "電腦游戲",
                "閲讀",
                "唱歌",
                "繪畫",
                "攝影",
                "運動",
                "旅游",
                "做飯",
                "看電影"
            });
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = -1;
        }
    }
}