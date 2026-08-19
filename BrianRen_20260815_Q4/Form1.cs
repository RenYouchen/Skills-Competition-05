using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrianRen_20260815_Q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 3600;
            label1.Text = "";
        }
        int second;
        bool paused = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (second > 0) {
                second--;
                UpdateDisplay();
            } 
            if(second == 0) {
                timer1.Stop();
                MessageBox.Show("倒數結束！");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(paused)
            {
                pause.Text = "暫停";
                timer1.Start();
            } else
            {
                pause.Text = "繼續";
                timer1.Stop();
            }
            paused = !paused;
        }

        private void start_Click(object sender, EventArgs e)
        {
            second = int.Parse(numericUpDown1.Text);
            timer1.Start(); 
            progressBar1.Maximum = second;
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            label1.Text = $"{second} 秒";
            int progress = int.Parse(numericUpDown1.Text) - second;
            if (progress <= 0) { progress = 0; }
            progressBar1.Value = progress;
        }
    }
}
