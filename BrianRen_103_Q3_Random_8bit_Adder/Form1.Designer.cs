namespace BrianRen_103_Q3_Random_8bit_Adder {
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 24);
            label1.Name = "label1";
            label1.Size = new Size(139, 32);
            label1.TabIndex = 0;
            label1.Text = "二進制加法";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(471, 24);
            label2.Name = "label2";
            label2.Size = new Size(139, 32);
            label2.TabIndex = 1;
            label2.Text = "十進制驗證";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 87);
            label3.Name = "label3";
            label3.Size = new Size(54, 32);
            label3.TabIndex = 2;
            label3.Text = "A：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 152);
            label4.Name = "label4";
            label4.Size = new Size(53, 32);
            label4.TabIndex = 3;
            label4.Text = "B：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 220);
            label5.Name = "label5";
            label5.Size = new Size(87, 32);
            label5.TabIndex = 4;
            label5.Text = "Sum：";
            // 
            // button1
            // 
            button1.Location = new Point(706, 73);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 13;
            button1.Text = "Random";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(706, 138);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 14;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(706, 206);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 15;
            button3.Text = "Verify";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(706, 276);
            button4.Name = "button4";
            button4.Size = new Size(150, 46);
            button4.TabIndex = 16;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(169, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 39);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(169, 149);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(267, 39);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(169, 217);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(267, 39);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(169, 283);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(267, 39);
            textBox4.TabIndex = 8;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(442, 80);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(200, 39);
            textBox8.TabIndex = 9;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(442, 149);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(200, 39);
            textBox7.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(442, 217);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(200, 39);
            textBox6.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(442, 283);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(200, 39);
            textBox5.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(textBox7);
            Controls.Add(textBox8);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "隨機八位元2的補數之整數相加與驗證系統";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
    }
}
