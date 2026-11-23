namespace BrianRen_103_Q6_Calc {
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 0;
            label1.Text = "輸入X";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(78, 39);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(96, 44);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(78, 39);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 9);
            label2.Name = "label2";
            label2.Size = new Size(77, 32);
            label2.TabIndex = 2;
            label2.Text = "輸入P";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(180, 44);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(78, 39);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(180, 9);
            label3.Name = "label3";
            label3.Size = new Size(82, 32);
            label3.TabIndex = 4;
            label3.Text = "輸入N";
            // 
            // button1
            // 
            button1.Location = new Point(12, 89);
            button1.Name = "button1";
            button1.Size = new Size(78, 46);
            button1.TabIndex = 6;
            button1.Text = "計算";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 96);
            label4.Name = "label4";
            label4.Size = new Size(80, 32);
            label4.TabIndex = 7;
            label4.Text = "餘數=";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(180, 96);
            label5.Name = "label5";
            label5.Size = new Size(0, 32);
            label5.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(12, 141);
            button2.Name = "button2";
            button2.Size = new Size(78, 46);
            button2.TabIndex = 9;
            button2.Text = "清除";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(95, 141);
            button3.Name = "button3";
            button3.Size = new Size(78, 46);
            button3.TabIndex = 10;
            button3.Text = "結束";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private Button button1;
        private Label label4;
        private Label label5;
        private Button button2;
        private Button button3;
    }
}
