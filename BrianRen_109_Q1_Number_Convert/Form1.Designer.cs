namespace BrianRen_109_Q1_Number_Convert {
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
            numOutput = new Label();
            label4 = new Label();
            chineseOutput = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(190, 45);
            label1.TabIndex = 0;
            label1.Text = "輸入數目：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 92);
            label2.Name = "label2";
            label2.Size = new Size(224, 45);
            label2.TabIndex = 1;
            label2.Text = "三位分隔數：";
            // 
            // numOutput
            // 
            numOutput.AutoSize = true;
            numOutput.Location = new Point(271, 92);
            numOutput.Name = "numOutput";
            numOutput.Size = new Size(0, 45);
            numOutput.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 169);
            label4.Name = "label4";
            label4.Size = new Size(190, 45);
            label4.TabIndex = 3;
            label4.Text = "輸出大寫：";
            // 
            // chineseOutput
            // 
            chineseOutput.AutoSize = true;
            chineseOutput.Location = new Point(242, 169);
            chineseOutput.Name = "chineseOutput";
            chineseOutput.Size = new Size(0, 45);
            chineseOutput.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(18, 239);
            button1.Name = "button1";
            button1.Size = new Size(150, 68);
            button1.TabIndex = 5;
            button1.Text = "轉換";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(214, 239);
            button2.Name = "button2";
            button2.Size = new Size(150, 68);
            button2.TabIndex = 6;
            button2.Text = "清除";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(214, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 50);
            textBox1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(19F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 329);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(chineseOutput);
            Controls.Add(label4);
            Controls.Add(numOutput);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "數目轉換國字大寫";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label numOutput;
        private Label label4;
        private Label chineseOutput;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
    }
}
