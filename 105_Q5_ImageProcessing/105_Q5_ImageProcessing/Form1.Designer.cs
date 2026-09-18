namespace _105_Q5_ImageProcessing
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.raw = new System.Windows.Forms.PictureBox();
            this.gray = new System.Windows.Forms.PictureBox();
            this.g = new System.Windows.Forms.PictureBox();
            this.r = new System.Windows.Forms.PictureBox();
            this.b = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.raw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "載入影像1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 16);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "影像1灰階";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // raw
            // 
            this.raw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.raw.Location = new System.Drawing.Point(17, 51);
            this.raw.Name = "raw";
            this.raw.Size = new System.Drawing.Size(200, 200);
            this.raw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.raw.TabIndex = 2;
            this.raw.TabStop = false;
            // 
            // gray
            // 
            this.gray.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gray.Location = new System.Drawing.Point(223, 51);
            this.gray.Name = "gray";
            this.gray.Size = new System.Drawing.Size(200, 200);
            this.gray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gray.TabIndex = 3;
            this.gray.TabStop = false;
            // 
            // g
            // 
            this.g.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.g.Location = new System.Drawing.Point(219, 310);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(200, 200);
            this.g.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.g.TabIndex = 5;
            this.g.TabStop = false;
            // 
            // r
            // 
            this.r.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.r.Location = new System.Drawing.Point(13, 310);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(200, 200);
            this.r.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.r.TabIndex = 4;
            this.r.TabStop = false;
            // 
            // b
            // 
            this.b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.b.Location = new System.Drawing.Point(425, 310);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(200, 200);
            this.b.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.b.TabIndex = 6;
            this.b.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 275);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 31);
            this.button3.TabIndex = 7;
            this.button3.Text = "影像1三色分離";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "（ 圖一）";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "（ 圖二）";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "（ 圖三）";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 513);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "（ 圖四）";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(548, 513);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "（ 圖五）";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 543);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.b);
            this.Controls.Add(this.g);
            this.Controls.Add(this.r);
            this.Controls.Add(this.gray);
            this.Controls.Add(this.raw);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.raw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private PictureBox raw;
        private PictureBox gray;
        private PictureBox g;
        private PictureBox r;
        private PictureBox b;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}