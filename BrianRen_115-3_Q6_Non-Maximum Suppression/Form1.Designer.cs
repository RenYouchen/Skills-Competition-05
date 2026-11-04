namespace BrianRen_115_3_Q6_Non_Maximum_Suppression {
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
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            textBox2 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(870, 45);
            label1.TabIndex = 0;
            label1.Text = "輸入候選框（第一行N，接下來N行[x1 y1 x2 y2 score]）:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 57);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(351, 415);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 490);
            label2.Name = "label2";
            label2.Size = new Size(203, 45);
            label2.TabIndex = 2;
            label2.Text = "IoU門檻值T:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(233, 485);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(130, 50);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(12, 538);
            button1.Name = "button1";
            button1.Size = new Size(240, 60);
            button1.TabIndex = 4;
            button1.Text = "繪製候選框";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(258, 538);
            button2.Name = "button2";
            button2.Size = new Size(105, 60);
            button2.TabIndex = 5;
            button2.Text = "執行";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(369, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(788, 466);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(369, 571);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(788, 50);
            textBox2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(369, 526);
            label3.Name = "label3";
            label3.Size = new Size(292, 45);
            label3.TabIndex = 8;
            label3.Text = "保留原始框編號：";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(19F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 633);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBox1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private TextBox textBox2;
        private Label label3;
    }
}
