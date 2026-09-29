namespace BrianRen_108_Q1_Vending_Machine {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            button2 = new Button();
            _5 = new RadioButton();
            _10 = new RadioButton();
            _50 = new RadioButton();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            status = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 56);
            label1.Name = "label1";
            label1.Size = new Size(90, 45);
            label1.TabIndex = 0;
            label1.Text = "35元";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 173);
            label2.Name = "label2";
            label2.Size = new Size(90, 45);
            label2.TabIndex = 1;
            label2.Text = "30元";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 283);
            label3.Name = "label3";
            label3.Size = new Size(90, 45);
            label3.TabIndex = 2;
            label3.Text = "25元";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(231, 395);
            label4.Name = "label4";
            label4.Size = new Size(90, 45);
            label4.TabIndex = 3;
            label4.Text = "30元";
            // 
            // button1
            // 
            button1.Location = new Point(101, 475);
            button1.Name = "button1";
            button1.Size = new Size(220, 73);
            button1.TabIndex = 4;
            button1.Text = "退款(refund)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(613, 28);
            label5.Name = "label5";
            label5.Size = new Size(244, 45);
            label5.TabIndex = 5;
            label5.Text = "存款(balance$)";
            // 
            // button2
            // 
            button2.Location = new Point(613, 395);
            button2.Name = "button2";
            button2.Size = new Size(200, 100);
            button2.TabIndex = 6;
            button2.Text = "投幣\r\n（diposit）";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // _5
            // 
            _5.AutoSize = true;
            _5.Location = new Point(613, 173);
            _5.Name = "_5";
            _5.Size = new Size(103, 49);
            _5.TabIndex = 7;
            _5.TabStop = true;
            _5.Text = "5元";
            _5.UseVisualStyleBackColor = true;
            // 
            // _10
            // 
            _10.AutoSize = true;
            _10.Location = new Point(613, 228);
            _10.Name = "_10";
            _10.Size = new Size(121, 49);
            _10.TabIndex = 8;
            _10.TabStop = true;
            _10.Text = "10元";
            _10.UseVisualStyleBackColor = true;
            // 
            // _50
            // 
            _50.AutoSize = true;
            _50.Location = new Point(613, 283);
            _50.Name = "_50";
            _50.Size = new Size(121, 49);
            _50.TabIndex = 9;
            _50.TabStop = true;
            _50.Text = "50元";
            _50.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(613, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 50);
            textBox1.TabIndex = 10;
            textBox1.Text = "0.0";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 100);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(12, 146);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 100);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(12, 252);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(200, 100);
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(12, 358);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(200, 100);
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // status
            // 
            status.AutoSize = true;
            status.Location = new Point(211, 561);
            status.Name = "status";
            status.Size = new Size(0, 45);
            status.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(19F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 637);
            Controls.Add(status);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(_50);
            Controls.Add(_10);
            Controls.Add(_5);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Vending Machine";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label label5;
        private Button button2;
        private RadioButton _5;
        private RadioButton _10;
        private RadioButton _50;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label status;
    }
}
