namespace BrianRen_107_Q6_Huffman_Decoding {
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            button3 = new Button();
            button4 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(496, 45);
            label1.TabIndex = 0;
            label1.Text = "簡易霍夫曼解碼資料解壓縮系統";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 129);
            label2.Name = "label2";
            label2.Size = new Size(88, 90);
            label2.TabIndex = 1;
            label2.Text = "解碼\r\n文字\r\n";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(label12, 4, 1);
            tableLayoutPanel1.Controls.Add(label11, 3, 1);
            tableLayoutPanel1.Controls.Add(label10, 2, 1);
            tableLayoutPanel1.Controls.Add(label9, 1, 1);
            tableLayoutPanel1.Controls.Add(label8, 0, 1);
            tableLayoutPanel1.Controls.Add(label7, 4, 0);
            tableLayoutPanel1.Controls.Add(label6, 3, 0);
            tableLayoutPanel1.Controls.Add(label5, 2, 0);
            tableLayoutPanel1.Controls.Add(label4, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Location = new Point(373, 117);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.5F));
            tableLayoutPanel1.Size = new Size(676, 114);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Location = new Point(541, 57);
            label12.Name = "label12";
            label12.Size = new Size(130, 55);
            label12.TabIndex = 9;
            label12.Text = "E";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Location = new Point(407, 57);
            label11.Name = "label11";
            label11.Size = new Size(126, 55);
            label11.TabIndex = 8;
            label11.Text = "D";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point(273, 57);
            label10.Name = "label10";
            label10.Size = new Size(126, 55);
            label10.TabIndex = 7;
            label10.Text = "C";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(139, 57);
            label9.Name = "label9";
            label9.Size = new Size(126, 55);
            label9.TabIndex = 6;
            label9.Text = "B";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(5, 57);
            label8.Name = "label8";
            label8.Size = new Size(126, 55);
            label8.TabIndex = 5;
            label8.Text = "A";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(541, 2);
            label7.Name = "label7";
            label7.Size = new Size(130, 53);
            label7.TabIndex = 4;
            label7.Text = "000";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(407, 2);
            label6.Name = "label6";
            label6.Size = new Size(126, 53);
            label6.TabIndex = 3;
            label6.Text = "001";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(273, 2);
            label5.Name = "label5";
            label5.Size = new Size(126, 53);
            label5.TabIndex = 2;
            label5.Text = "11";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(139, 2);
            label4.Name = "label4";
            label4.Size = new Size(126, 53);
            label4.TabIndex = 1;
            label4.Text = "01";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(5, 2);
            label3.Name = "label3";
            label3.Size = new Size(126, 53);
            label3.TabIndex = 0;
            label3.Text = "10";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 273);
            label13.Name = "label13";
            label13.Size = new Size(174, 45);
            label13.TabIndex = 3;
            label13.Text = "霍夫曼碼1";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(12, 330);
            label14.Name = "label14";
            label14.Size = new Size(174, 45);
            label14.TabIndex = 4;
            label14.Text = "合理驗證1";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(407, 330);
            label15.Name = "label15";
            label15.Size = new Size(208, 45);
            label15.TabIndex = 5;
            label15.Text = "霍夫曼解碼1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(192, 273);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(921, 50);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(192, 327);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 50);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(621, 327);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(492, 50);
            textBox3.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(1146, 267);
            button1.Name = "button1";
            button1.Size = new Size(264, 62);
            button1.TabIndex = 9;
            button1.Text = "Random Set1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1146, 398);
            button2.Name = "button2";
            button2.Size = new Size(264, 62);
            button2.TabIndex = 16;
            button2.Text = "Random Set2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(621, 458);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(492, 50);
            textBox6.TabIndex = 15;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(192, 458);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(200, 50);
            textBox5.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(192, 404);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(921, 50);
            textBox4.TabIndex = 13;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(407, 461);
            label16.Name = "label16";
            label16.Size = new Size(208, 45);
            label16.TabIndex = 12;
            label16.Text = "霍夫曼解碼2";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(12, 461);
            label17.Name = "label17";
            label17.Size = new Size(174, 45);
            label17.TabIndex = 11;
            label17.Text = "合理驗證2";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(12, 404);
            label18.Name = "label18";
            label18.Size = new Size(174, 45);
            label18.TabIndex = 10;
            label18.Text = "霍夫曼碼2";
            // 
            // button3
            // 
            button3.Location = new Point(407, 541);
            button3.Name = "button3";
            button3.Size = new Size(264, 62);
            button3.TabIndex = 17;
            button3.Text = "Decoding";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1146, 541);
            button4.Name = "button4";
            button4.Size = new Size(264, 62);
            button4.TabIndex = 18;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(19F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1470, 623);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label16;
        private Label label17;
        private Label label18;
        private Button button3;
        private Button button4;
    }
}
