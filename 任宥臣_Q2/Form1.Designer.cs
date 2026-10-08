namespace 任宥臣_Q2 {
    partial class Form1 {
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
            panel1 = new Panel();
            panel3 = new Panel();
            dtp2 = new DateTimePicker();
            dtp1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            dataGridView2 = new DataGridView();
            label9 = new Label();
            label8 = new Label();
            button7 = new Button();
            button4 = new Button();
            button5 = new Button();
            textBox5 = new TextBox();
            button6 = new Button();
            label7 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(18, 56);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(2612, 1340);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Controls.Add(dtp2);
            panel3.Controls.Add(dtp1);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(dataGridView2);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(1242, 26);
            panel3.Name = "panel3";
            panel3.Size = new Size(1324, 1271);
            panel3.TabIndex = 10;
            // 
            // dtp2
            // 
            dtp2.CustomFormat = "";
            dtp2.Format = DateTimePickerFormat.Time;
            dtp2.Location = new Point(750, 273);
            dtp2.Name = "dtp2";
            dtp2.Size = new Size(301, 50);
            dtp2.TabIndex = 23;
            // 
            // dtp1
            // 
            dtp1.CustomFormat = "";
            dtp1.Format = DateTimePickerFormat.Time;
            dtp1.Location = new Point(278, 273);
            dtp1.Name = "dtp1";
            dtp1.Size = new Size(301, 50);
            dtp1.TabIndex = 22;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(276, 138);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(646, 53);
            comboBox1.TabIndex = 21;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(31, 508);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 82;
            dataGridView2.Size = new Size(1263, 738);
            dataGridView2.TabIndex = 14;
            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(585, 273);
            label9.Name = "label9";
            label9.Size = new Size(190, 45);
            label9.TabIndex = 18;
            label9.Text = "結束時間：";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(46, 273);
            label8.Name = "label8";
            label8.Size = new Size(156, 45);
            label8.TabIndex = 17;
            label8.Text = "開始時間";
            // 
            // button7
            // 
            button7.Location = new Point(864, 396);
            button7.Name = "button7";
            button7.Size = new Size(248, 93);
            button7.TabIndex = 16;
            button7.Text = "清除";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button4
            // 
            button4.Location = new Point(585, 396);
            button4.Name = "button4";
            button4.Size = new Size(248, 93);
            button4.TabIndex = 15;
            button4.Text = "刪除預約";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(302, 396);
            button5.Name = "button5";
            button5.Size = new Size(248, 93);
            button5.TabIndex = 14;
            button5.Text = "修改預約";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(278, 203);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(644, 50);
            textBox5.TabIndex = 11;
            // 
            // button6
            // 
            button6.Location = new Point(31, 396);
            button6.Name = "button6";
            button6.Size = new Size(248, 93);
            button6.TabIndex = 13;
            button6.Text = "新增預約";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 203);
            label7.Name = "label7";
            label7.Size = new Size(156, 45);
            label7.TabIndex = 10;
            label7.Text = "預約人：";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(278, 75);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(200, 50);
            textBox4.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 138);
            label4.Name = "label4";
            label4.Size = new Size(190, 45);
            label4.TabIndex = 7;
            label4.Text = "選擇教室：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 75);
            label5.Name = "label5";
            label5.Size = new Size(190, 45);
            label5.TabIndex = 6;
            label5.Text = "預約編號：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 18);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(224, 45);
            label6.TabIndex = 5;
            label6.Text = "預約排程管理";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(18, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(1218, 1271);
            panel2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 443);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1136, 803);
            dataGridView1.TabIndex = 13;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // button3
            // 
            button3.Location = new Point(688, 335);
            button3.Name = "button3";
            button3.Size = new Size(248, 93);
            button3.TabIndex = 12;
            button3.Text = "刪除教室";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(405, 335);
            button2.Name = "button2";
            button2.Size = new Size(248, 93);
            button2.TabIndex = 11;
            button2.Text = "修改教室";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(134, 335);
            button1.Name = "button1";
            button1.Size = new Size(248, 93);
            button1.TabIndex = 10;
            button1.Text = "新增教室";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(292, 138);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(644, 50);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(292, 75);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(200, 50);
            textBox1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 138);
            label3.Name = "label3";
            label3.Size = new Size(190, 45);
            label3.TabIndex = 7;
            label3.Text = "教室名稱：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 75);
            label2.Name = "label2";
            label2.Size = new Size(190, 45);
            label2.TabIndex = 6;
            label2.Text = "教室編號：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 18);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(224, 45);
            label1.TabIndex = 5;
            label1.Text = "教室資料管理";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(19F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(2660, 1413);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "教室預約排程管理系統";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label9;
        private Label label8;
        private Button button7;
        private Button button4;
        private Button button5;
        private TextBox textBox5;
        private Button button6;
        private Label label7;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private ComboBox comboBox1;
        private DateTimePicker dtp1;
        private DateTimePicker dtp2;
    }
}
