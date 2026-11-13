namespace BrianRen_104_Q6_RichTextBox_String_Search {
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
            button1 = new Button();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(358, 46);
            button1.TabIndex = 0;
            button1.Text = "開啓文字檔顯示在下面方塊中";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(638, 392);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 1;
            button2.Text = "搜尋";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 64);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 294);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 361);
            label1.Name = "label1";
            label1.Size = new Size(239, 32);
            label1.TabIndex = 3;
            label1.Text = "請輸入欲搜尋的字串";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(352, 361);
            label2.Name = "label2";
            label2.Size = new Size(139, 32);
            label2.TabIndex = 4;
            label2.Text = "找到的個數";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(352, 403);
            label3.Name = "label3";
            label3.Size = new Size(27, 32);
            label3.TabIndex = 5;
            label3.Text = "0";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 396);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "題目：搜尋字串并標示黃色背景顔色";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
    }
}
