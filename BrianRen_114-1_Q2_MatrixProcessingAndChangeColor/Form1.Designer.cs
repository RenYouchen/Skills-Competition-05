namespace BrianRen_114_1_Q2_MatrixProcessingAndChangeColor {
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
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(400, 400);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(418, 12);
            button1.Name = "button1";
            button1.Size = new Size(333, 92);
            button1.TabIndex = 1;
            button1.Text = "隨機顔色填充 (&R)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(418, 110);
            button2.Name = "button2";
            button2.Size = new Size(333, 92);
            button2.TabIndex = 2;
            button2.Text = "水平翻轉 (&H)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnFlipH;
            // 
            // button3
            // 
            button3.Location = new Point(418, 208);
            button3.Name = "button3";
            button3.Size = new Size(333, 92);
            button3.TabIndex = 3;
            button3.Text = "垂直翻轉 (&Y)";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnFlipV;
            // 
            // button4
            // 
            button4.Location = new Point(418, 306);
            button4.Name = "button4";
            button4.Size = new Size(333, 92);
            button4.TabIndex = 4;
            button4.Text = "順時針旋轉90° (&C)";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnRotateCW;
            // 
            // button5
            // 
            button5.Location = new Point(418, 404);
            button5.Name = "button5";
            button5.Size = new Size(333, 92);
            button5.TabIndex = 5;
            button5.Text = "逆時針旋轉90° (&Z)";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnRotateCCW;
            // 
            // button6
            // 
            button6.Location = new Point(418, 502);
            button6.Name = "button6";
            button6.Size = new Size(333, 92);
            button6.TabIndex = 6;
            button6.Text = "顔色反轉 (&I)";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(418, 899);
            button7.Name = "button7";
            button7.Size = new Size(333, 92);
            button7.TabIndex = 7;
            button7.Text = "退出(Esc)";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(32, 32);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 994);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(763, 42);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(237, 32);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(19F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button7;
            ClientSize = new Size(763, 1036);
            Controls.Add(statusStrip1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}
