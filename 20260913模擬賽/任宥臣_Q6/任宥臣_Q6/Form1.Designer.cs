namespace 任宥臣_Q6
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(279, 20);
            label1.TabIndex = 0;
            label1.Text = "輸入原始方格（4行，每行４個字元）:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 32);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 150);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 244);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 150);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 221);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 3;
            label2.Text = "操作後的結果：";
            // 
            // button1
            // 
            button1.Location = new Point(168, 32);
            button1.Name = "button1";
            button1.Size = new Size(150, 50);
            button1.TabIndex = 4;
            button1.Text = "水平翻轉";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(168, 88);
            button2.Name = "button2";
            button2.Size = new Size(150, 50);
            button2.TabIndex = 5;
            button2.Text = "垂直翻轉";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(168, 144);
            button3.Name = "button3";
            button3.Size = new Size(150, 50);
            button3.TabIndex = 6;
            button3.Text = "順時針旋轉";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(168, 200);
            button4.Name = "button4";
            button4.Size = new Size(150, 50);
            button4.TabIndex = 7;
            button4.Text = "逆時針旋轉";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 406);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "方格圖案翻轉與旋轉";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
