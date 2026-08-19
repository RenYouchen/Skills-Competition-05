using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrianRen_20260815
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            InitializeComponent();
        }     

        private void calc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(calc.Text)) {
                errorProvider1.SetError(name, "請輸入姓名");
                name.Focus();
                return;
            }
            if (!TryGetScore(chinese, "", out int chineseScore)) return;
            if (!TryGetScore(math, "", out int mathScore)) return;
            if (!TryGetScore(english, "", out int englishScore)) return;


        }

        //private void name_Validating(object sender, CancelEventArgs e)
        //{
        //    TextBox txb = sender as TextBox;
        //    if(string.IsNullOrWhiteSpace(txb.Text))
        //    {
        //        errorProvider1.SetError(txb, "不得爲空");
        //    }
        //}

        private bool TryGetScore(TextBox txt, string subject, out int score)
        {
            score = 0;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                errorProvider1.SetError(txt, $"{subject} 成績不得爲空");
                return false;
            }
            if(!int.TryParse(txt.Text.Trim(), out score))
            {
                errorProvider1.SetError(txt, $"{subject} 成績必須為數字");
                txt.SelectAll();
                return false;
            }
            if (score<0 || score > 100)
            {
                errorProvider1.SetError(txt, $"{subject} 成績必須介於0-100");
                txt.SelectAll(); 
                return false;
            }
            return true;
        }
    }
}
