namespace BrianRen_100_Q6_Address_Bus_To_Memory_Space {
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(62, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(447, 19);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox1_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(823, 19);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 39);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(62, 167);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 39);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(447, 167);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(200, 39);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(823, 167);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(200, 39);
            textBox6.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(320, 15);
            button1.Name = "button1";
            button1.Size = new Size(108, 46);
            button1.TabIndex = 6;
            button1.Text = "F-rand";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(697, 15);
            button2.Name = "button2";
            button2.Size = new Size(108, 46);
            button2.TabIndex = 7;
            button2.Text = "F-conv";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(320, 206);
            button3.Name = "button3";
            button3.Size = new Size(108, 46);
            button3.TabIndex = 8;
            button3.Text = "R-conv";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(695, 206);
            button4.Name = "button4";
            button4.Size = new Size(108, 46);
            button4.TabIndex = 9;
            button4.Text = "R-rand";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 81);
            label1.Name = "label1";
            label1.Size = new Size(148, 64);
            label1.TabIndex = 10;
            label1.Text = "Address bus:\r\n# 16 ~ 52\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(447, 81);
            label2.Name = "label2";
            label2.Size = new Size(206, 64);
            label2.TabIndex = 11;
            label2.Text = "Bytes per address:\r\n# 1B ~ 8B\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(823, 81);
            label3.Name = "label3";
            label3.Size = new Size(224, 64);
            label3.TabIndex = 12;
            label3.Text = "Memory space:\r\n# 512KB ~ 32768TB\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(318, 64);
            label4.Name = "label4";
            label4.Size = new Size(110, 32);
            label4.TabIndex = 13;
            label4.Text = "===>>>";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(695, 64);
            label5.Name = "label5";
            label5.Size = new Size(110, 32);
            label5.TabIndex = 14;
            label5.Text = "===>>>";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(320, 167);
            label6.Name = "label6";
            label6.Size = new Size(110, 32);
            label6.TabIndex = 15;
            label6.Text = "<<<===";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(693, 167);
            label7.Name = "label7";
            label7.Size = new Size(110, 32);
            label7.TabIndex = 16;
            label7.Text = "<<<===";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 264);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "The System of Address Bus Corresponding to Menory Space";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
