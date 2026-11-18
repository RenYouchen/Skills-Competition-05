namespace BrianRen_102_Q5_Calc {
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
            button1 = new Button();
            button2 = new Button();
            wrong = new Label();
            correct = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 32);
            label1.TabIndex = 0;
            label1.Text = "被乘數m";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(176, 9);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 1;
            label2.Text = "乘數n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 57);
            label3.Name = "label3";
            label3.Size = new Size(28, 32);
            label3.TabIndex = 2;
            label3.Text = "X";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(278, 57);
            label4.Name = "label4";
            label4.Size = new Size(30, 32);
            label4.TabIndex = 6;
            label4.Text = "=";
            // 
            // button1
            // 
            button1.Location = new Point(12, 99);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 7;
            button1.Text = "驗證答案";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(168, 99);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 8;
            button2.Text = "清除";
            button2.UseVisualStyleBackColor = true;
            // 
            // wrong
            // 
            wrong.AutoSize = true;
            wrong.Location = new Point(430, 61);
            wrong.Name = "wrong";
            wrong.Size = new Size(104, 32);
            wrong.TabIndex = 9;
            wrong.Text = "is wrong";
            wrong.Visible = false;
            // 
            // correct
            // 
            correct.AutoSize = true;
            correct.Location = new Point(346, 113);
            correct.Name = "correct";
            correct.Size = new Size(132, 32);
            correct.TabIndex = 10;
            correct.Text = "Very Good!";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(346, 155);
            label6.Name = "label6";
            label6.Size = new Size(0, 32);
            label6.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(115, 39);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(157, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(115, 39);
            textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(309, 54);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(115, 39);
            textBox3.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 338);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(correct);
            Controls.Add(wrong);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Label wrong;
        private Label correct;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
