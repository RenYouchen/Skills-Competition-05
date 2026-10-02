namespace Simu_114_1_Q1_Postfix_And_Prefix_Calc {
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
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(209, 45);
            label1.TabIndex = 0;
            label1.Text = "模式 (Mode)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(282, 45);
            label2.TabIndex = 1;
            label2.Text = "輸入 (Expression)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 223);
            label3.Name = "label3";
            label3.Size = new Size(212, 45);
            label3.TabIndex = 2;
            label3.Text = "結果 (Result)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 288);
            label4.Name = "label4";
            label4.Size = new Size(192, 45);
            label4.TabIndex = 3;
            label4.Text = "步驟(Steps)";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(300, 1);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(426, 53);
            comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(300, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1124, 50);
            textBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(300, 140);
            button1.Name = "button1";
            button1.Size = new Size(271, 65);
            button1.TabIndex = 6;
            button1.Text = "Run";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(300, 218);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(1124, 50);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(300, 288);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(1124, 529);
            textBox3.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(19F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1495, 829);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "前序 / 後序 計算機";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
