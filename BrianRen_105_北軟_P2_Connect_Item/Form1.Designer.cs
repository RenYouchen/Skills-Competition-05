namespace BrianRen_105_北軟_P2_Connect_Item {
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
            button1 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            button2 = new Button();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(147, 32);
            label1.TabIndex = 0;
            label1.Text = "影像高度H=";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(165, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(108, 39);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(437, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(108, 39);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(279, 6);
            label2.Name = "label2";
            label2.Size = new Size(152, 32);
            label2.TabIndex = 2;
            label2.Text = "影像高度W=";
            // 
            // button1
            // 
            button1.Location = new Point(9, 41);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 4;
            button1.Text = "讀檔";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(165, 48);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(623, 39);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 90);
            label3.Name = "label3";
            label3.Size = new Size(114, 32);
            label3.TabIndex = 6;
            label3.Text = "影像資料";
            // 
            // button2
            // 
            button2.Location = new Point(12, 569);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 7;
            button2.Text = "物件聯通";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(235, 576);
            label4.Name = "label4";
            label4.Size = new Size(130, 32);
            label4.TabIndex = 8;
            label4.Text = "物件個數=";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 125);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            richTextBox1.Size = new Size(770, 430);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(12, 621);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            richTextBox2.Size = new Size(770, 430);
            richTextBox2.TabIndex = 10;
            richTextBox2.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(362, 576);
            label5.Name = "label5";
            label5.Size = new Size(78, 32);
            label5.TabIndex = 11;
            label5.Text = "label5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 1060);
            Controls.Add(label5);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(button1);
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
        private Button button1;
        private TextBox textBox3;
        private Label label3;
        private Button button2;
        private Label label4;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Label label5;
    }
}
