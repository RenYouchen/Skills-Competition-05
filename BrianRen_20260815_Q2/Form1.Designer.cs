namespace BrianRen_20260815
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.chinese = new System.Windows.Forms.TextBox();
            this.math = new System.Windows.Forms.TextBox();
            this.english = new System.Windows.Forms.TextBox();
            this.calc = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "國文";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "數學";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 253);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "英文";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(270, 25);
            this.name.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(164, 44);
            this.name.TabIndex = 4;

            // 
            // chinese
            // 
            this.chinese.Location = new System.Drawing.Point(270, 104);
            this.chinese.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chinese.Name = "chinese";
            this.chinese.Size = new System.Drawing.Size(164, 44);
            this.chinese.TabIndex = 5;
            
            // 
            // math
            // 
            this.math.Location = new System.Drawing.Point(270, 170);
            this.math.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.math.Name = "math";
            this.math.Size = new System.Drawing.Size(164, 44);
            this.math.TabIndex = 6;
            
            // 
            // english
            // 
            this.english.Location = new System.Drawing.Point(270, 244);
            this.english.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.english.Name = "english";
            this.english.Size = new System.Drawing.Size(164, 44);
            this.english.TabIndex = 7;
           
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(588, 25);
            this.calc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(125, 34);
            this.calc.TabIndex = 8;
            this.calc.Text = "計算";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(725, 25);
            this.clear.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(125, 34);
            this.clear.TabIndex = 9;
            this.clear.Text = "清除";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(588, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 37);
            this.label5.TabIndex = 10;
            this.label5.Text = "總分";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(588, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 37);
            this.label6.TabIndex = 11;
            this.label6.Text = "平均";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(588, 244);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 37);
            this.label7.TabIndex = 12;
            this.label7.Text = "結果";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 666);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.english);
            this.Controls.Add(this.math);
            this.Controls.Add(this.chinese);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox chinese;
        private System.Windows.Forms.TextBox math;
        private System.Windows.Forms.TextBox english;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

