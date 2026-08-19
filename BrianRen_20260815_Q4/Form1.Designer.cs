namespace BrianRen_20260815_Q4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.start = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(17, 34);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(200, 26);
            this.numericUpDown1.TabIndex = 0;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(227, 30);
            this.start.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(81, 34);
            this.start.TabIndex = 1;
            this.start.Text = "開始";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(318, 30);
            this.pause.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(81, 34);
            this.pause.TabIndex = 2;
            this.pause.Text = "暫停";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.button2_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(409, 30);
            this.reset.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(81, 34);
            this.reset.TabIndex = 3;
            this.reset.Text = "重設";
            this.reset.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(148, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 73);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 303);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(473, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 372);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.start);
            this.Controls.Add(this.numericUpDown1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}

