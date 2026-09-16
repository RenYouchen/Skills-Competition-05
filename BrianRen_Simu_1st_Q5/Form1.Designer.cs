namespace BrianRen_Simu_1st_Q5
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
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(613, 45);
            label1.TabIndex = 0;
            label1.Text = "輸入N及N個矩形坐標（x1 y1 x2 y2）：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 406);
            label2.Name = "label2";
            label2.Size = new Size(224, 45);
            label2.TabIndex = 1;
            label2.Text = "連集總面積：";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 57);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            richTextBox1.Size = new Size(339, 270);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(12, 333);
            button1.Name = "button1";
            button1.Size = new Size(165, 70);
            button1.TabIndex = 3;
            button1.Text = "繪製矩形";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(183, 333);
            button2.Name = "button2";
            button2.Size = new Size(168, 70);
            button2.TabIndex = 4;
            button2.Text = "計算聯集";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 454);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(339, 50);
            textBox1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Location = new Point(357, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 400);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(19F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 525);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "試題五：矩形聯集面積計算器";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Panel panel1;
    }
}
