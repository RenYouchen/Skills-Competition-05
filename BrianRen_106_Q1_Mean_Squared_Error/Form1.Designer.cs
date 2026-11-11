namespace BrianRen_106_Q1_Mean_Squared_Error {
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(68, 45);
            label1.TabIndex = 0;
            label1.Text = "N=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 9);
            label2.Name = "label2";
            label2.Size = new Size(67, 45);
            label2.TabIndex = 1;
            label2.Text = "Q=";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(86, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(94, 50);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(259, 6);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(94, 50);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(384, 4);
            button1.Name = "button1";
            button1.Size = new Size(171, 52);
            button1.TabIndex = 4;
            button1.Text = "產生分數";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(561, 2);
            button2.Name = "button2";
            button2.Size = new Size(171, 52);
            button2.TabIndex = 5;
            button2.Text = "分群";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(738, 2);
            button3.Name = "button3";
            button3.Size = new Size(171, 52);
            button3.TabIndex = 6;
            button3.Text = "畫圖";
            button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 134);
            label3.Name = "label3";
            label3.Size = new Size(88, 45);
            label3.TabIndex = 7;
            label3.Text = "數學";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(106, 81);
            label6.Name = "label6";
            label6.Size = new Size(110, 45);
            label6.TabIndex = 10;
            label6.Text = "label6";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(106, 129);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(917, 50);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(106, 185);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(917, 50);
            textBox4.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 190);
            label4.Name = "label4";
            label4.Size = new Size(88, 45);
            label4.TabIndex = 12;
            label4.Text = "英文";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(106, 241);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(917, 50);
            textBox5.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 246);
            label5.Name = "label5";
            label5.Size = new Size(88, 45);
            label5.TabIndex = 14;
            label5.Text = "分群";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(19F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 633);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Kmeans分群法";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label3;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
