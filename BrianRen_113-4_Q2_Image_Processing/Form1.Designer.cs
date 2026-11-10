namespace BrianRen_113_4_Q2_Image_Processing {
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "5px", "10px", "20px" });
            comboBox1.Location = new Point(12, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 53);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.ImeMode = ImeMode.NoControl;
            comboBox2.Items.AddRange(new object[] { "40px", "80px", "120px" });
            comboBox2.Location = new Point(640, 12);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(242, 53);
            comboBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(260, 12);
            button1.Name = "button1";
            button1.Size = new Size(195, 53);
            button1.TabIndex = 2;
            button1.Text = "馬賽克";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 71);
            button2.Name = "button2";
            button2.Size = new Size(195, 53);
            button2.TabIndex = 3;
            button2.Text = "加亮";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(213, 71);
            button3.Name = "button3";
            button3.Size = new Size(195, 53);
            button3.TabIndex = 4;
            button3.Text = "加深";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 130);
            button4.Name = "button4";
            button4.Size = new Size(195, 53);
            button4.TabIndex = 5;
            button4.Text = "局部加亮";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(213, 130);
            button5.Name = "button5";
            button5.Size = new Size(195, 53);
            button5.TabIndex = 6;
            button5.Text = "局部加深";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 189);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1145, 862);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(888, 16);
            label1.Name = "label1";
            label1.Size = new Size(156, 45);
            label1.TabIndex = 8;
            label1.Text = "效果大小";
            // 
            // button6
            // 
            button6.Location = new Point(962, 130);
            button6.Name = "button6";
            button6.Size = new Size(195, 53);
            button6.TabIndex = 9;
            button6.Text = "載入圖片";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(19F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 1063);
            Controls.Add(button6);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button6;
    }
}
