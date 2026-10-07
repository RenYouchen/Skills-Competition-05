namespace 任宥臣_Q3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            richTextBox1 = new RichTextBox();
            panel1 = new Panel();
            totalCount = new Label();
            label6 = new Label();
            panel2 = new Panel();
            infoCount = new Label();
            label9 = new Label();
            panel3 = new Panel();
            warnCount = new Label();
            label11 = new Label();
            panel4 = new Panel();
            errorCount = new Label();
            label13 = new Label();
            panel5 = new Panel();
            totalCount1 = new Label();
            label15 = new Label();
            panel6 = new Panel();
            vaildCount = new Label();
            label17 = new Label();
            panel7 = new Panel();
            invaildCount = new Label();
            label19 = new Label();
            panel8 = new Panel();
            matchedCount = new Label();
            label21 = new Label();
            textBox3 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            checkBox1 = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(169, 20);
            label1.TabIndex = 0;
            label1.Text = "日誌檔案載入原始內容";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 44);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 1;
            label2.Text = "檔案路徑：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 78);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 2;
            label3.Text = "統計範圍：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 112);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 3;
            label4.Text = "輸入關鍵字：";
            // 
            // button1
            // 
            button1.Location = new Point(311, 41);
            button1.Name = "button1";
            button1.Size = new Size(118, 51);
            button1.TabIndex = 4;
            button1.Text = "開啟檔案";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 186);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 5;
            label5.Text = "日誌內容";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(113, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 28);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(113, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(192, 28);
            textBox2.TabIndex = 7;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(17, 209);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            richTextBox1.ShortcutsEnabled = false;
            richTextBox1.Size = new Size(1134, 328);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            richTextBox1.WordWrap = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(totalCount);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(745, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 37);
            panel1.TabIndex = 9;
            // 
            // totalCount
            // 
            totalCount.AutoSize = true;
            totalCount.Location = new Point(126, 8);
            totalCount.Name = "totalCount";
            totalCount.Size = new Size(55, 20);
            totalCount.TabIndex = 1;
            totalCount.Text = "label7";
            totalCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 8);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 0;
            label6.Text = "TOTAL";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lime;
            panel2.Controls.Add(infoCount);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(745, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 37);
            panel2.TabIndex = 10;
            // 
            // infoCount
            // 
            infoCount.AutoSize = true;
            infoCount.Location = new Point(126, 8);
            infoCount.Name = "infoCount";
            infoCount.Size = new Size(55, 20);
            infoCount.TabIndex = 1;
            infoCount.Text = "label8";
            infoCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 8);
            label9.Name = "label9";
            label9.Size = new Size(49, 20);
            label9.TabIndex = 0;
            label9.Text = "INFO";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gold;
            panel3.Controls.Add(warnCount);
            panel3.Controls.Add(label11);
            panel3.Location = new Point(745, 98);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 37);
            panel3.TabIndex = 10;
            // 
            // warnCount
            // 
            warnCount.AutoSize = true;
            warnCount.Location = new Point(126, 8);
            warnCount.Name = "warnCount";
            warnCount.Size = new Size(65, 20);
            warnCount.TabIndex = 1;
            warnCount.Text = "label10";
            warnCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 8);
            label11.Name = "label11";
            label11.Size = new Size(62, 20);
            label11.TabIndex = 0;
            label11.Text = "WARN";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Red;
            panel4.Controls.Add(errorCount);
            panel4.Controls.Add(label13);
            panel4.Location = new Point(745, 141);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 37);
            panel4.TabIndex = 10;
            // 
            // errorCount
            // 
            errorCount.AutoSize = true;
            errorCount.Location = new Point(126, 8);
            errorCount.Name = "errorCount";
            errorCount.Size = new Size(65, 20);
            errorCount.TabIndex = 1;
            errorCount.Text = "label12";
            errorCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(3, 8);
            label13.Name = "label13";
            label13.Size = new Size(64, 20);
            label13.TabIndex = 0;
            label13.Text = "ERROR";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.InactiveCaption;
            panel5.Controls.Add(totalCount1);
            panel5.Controls.Add(label15);
            panel5.Location = new Point(984, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(167, 37);
            panel5.TabIndex = 10;
            // 
            // totalCount1
            // 
            totalCount1.AutoSize = true;
            totalCount1.Location = new Point(99, 8);
            totalCount1.Name = "totalCount1";
            totalCount1.Size = new Size(65, 20);
            totalCount1.TabIndex = 1;
            totalCount1.Text = "label14";
            totalCount1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(3, 8);
            label15.Name = "label15";
            label15.Size = new Size(60, 20);
            label15.TabIndex = 0;
            label15.Text = "TOTAL";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.InactiveCaption;
            panel6.Controls.Add(vaildCount);
            panel6.Controls.Add(label17);
            panel6.Location = new Point(984, 55);
            panel6.Name = "panel6";
            panel6.Size = new Size(167, 37);
            panel6.TabIndex = 11;
            // 
            // vaildCount
            // 
            vaildCount.AutoSize = true;
            vaildCount.Location = new Point(99, 8);
            vaildCount.Name = "vaildCount";
            vaildCount.Size = new Size(65, 20);
            vaildCount.TabIndex = 1;
            vaildCount.Text = "label16";
            vaildCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(3, 8);
            label17.Name = "label17";
            label17.Size = new Size(57, 20);
            label17.TabIndex = 0;
            label17.Text = "VAILD";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.InactiveCaption;
            panel7.Controls.Add(invaildCount);
            panel7.Controls.Add(label19);
            panel7.Location = new Point(984, 98);
            panel7.Name = "panel7";
            panel7.Size = new Size(167, 37);
            panel7.TabIndex = 11;
            // 
            // invaildCount
            // 
            invaildCount.AutoSize = true;
            invaildCount.Location = new Point(99, 8);
            invaildCount.Name = "invaildCount";
            invaildCount.Size = new Size(65, 20);
            invaildCount.TabIndex = 1;
            invaildCount.Text = "label18";
            invaildCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(3, 8);
            label19.Name = "label19";
            label19.Size = new Size(75, 20);
            label19.TabIndex = 0;
            label19.Text = "INVAILD";
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.InactiveCaption;
            panel8.Controls.Add(matchedCount);
            panel8.Controls.Add(label21);
            panel8.Location = new Point(984, 141);
            panel8.Name = "panel8";
            panel8.Size = new Size(167, 37);
            panel8.TabIndex = 11;
            // 
            // matchedCount
            // 
            matchedCount.AutoSize = true;
            matchedCount.Location = new Point(99, 8);
            matchedCount.Name = "matchedCount";
            matchedCount.Size = new Size(65, 20);
            matchedCount.TabIndex = 1;
            matchedCount.Text = "label20";
            matchedCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(3, 8);
            label21.Name = "label21";
            label21.Size = new Size(91, 20);
            label21.TabIndex = 0;
            label21.Text = "MATCHED";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(134, 109);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(171, 28);
            textBox3.TabIndex = 12;
            // 
            // button2
            // 
            button2.Location = new Point(311, 109);
            button2.Name = "button2";
            button2.Size = new Size(118, 51);
            button2.TabIndex = 13;
            button2.Text = "分析／搜尋";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(435, 110);
            button3.Name = "button3";
            button3.Size = new Size(118, 51);
            button3.TabIndex = 14;
            button3.Text = "清除";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(134, 143);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(124, 24);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "不區分大小寫";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 549);
            Controls.Add(checkBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(richTextBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private RichTextBox richTextBox1;
        private Panel panel1;
        private Label totalCount;
        private Label label6;
        private Panel panel2;
        private Label infoCount;
        private Label label9;
        private Panel panel3;
        private Label warnCount;
        private Label label11;
        private Panel panel4;
        private Label errorCount;
        private Label label13;
        private Panel panel5;
        private Label totalCount1;
        private Label label15;
        private Panel panel6;
        private Label vaildCount;
        private Label label17;
        private Panel panel7;
        private Label invaildCount;
        private Label label19;
        private Panel panel8;
        private Label matchedCount;
        private Label label21;
        private TextBox textBox3;
        private Button button2;
        private Button button3;
        private CheckBox checkBox1;
    }
}
