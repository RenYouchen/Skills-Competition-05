namespace BrianRen_115_4_Q1_Flights_Query_System {
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
            Button button1;
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            button2 = new Button();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            Route = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Class = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Minutes = new DataGridViewTextBoxColumn();
            Transfers = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1779, 12);
            button1.Name = "button1";
            button1.Size = new Size(128, 54);
            button1.TabIndex = 14;
            button1.Text = "搜尋";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(122, 45);
            label1.TabIndex = 0;
            label1.Text = "出發地";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(346, 17);
            label2.Name = "label2";
            label2.Size = new Size(122, 45);
            label2.TabIndex = 2;
            label2.Text = "目的地";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(680, 17);
            label3.Name = "label3";
            label3.Size = new Size(88, 45);
            label3.TabIndex = 4;
            label3.Text = "艙等";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1014, 17);
            label4.Name = "label4";
            label4.Size = new Size(156, 45);
            label4.TabIndex = 6;
            label4.Text = "排序欄位";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1400, 17);
            label5.Name = "label5";
            label5.Size = new Size(156, 45);
            label5.TabIndex = 8;
            label5.Text = "排序方向";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(129, 13);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(211, 53);
            comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(463, 13);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(211, 53);
            comboBox2.TabIndex = 10;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(774, 13);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(211, 53);
            comboBox3.TabIndex = 11;
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(1176, 13);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(211, 53);
            comboBox4.TabIndex = 12;
            // 
            // comboBox5
            // 
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(1562, 13);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(211, 53);
            comboBox5.TabIndex = 13;
            // 
            // button2
            // 
            button2.Location = new Point(1913, 12);
            button2.Name = "button2";
            button2.Size = new Size(128, 54);
            button2.TabIndex = 15;
            button2.Text = "清除";
            button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 574);
            label6.Name = "label6";
            label6.Size = new Size(110, 45);
            label6.TabIndex = 17;
            label6.Text = "label6";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Route, Column1, Class, Price, Minutes, Transfers });
            dataGridView1.Location = new Point(12, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(2042, 499);
            dataGridView1.TabIndex = 18;
            // 
            // Route
            // 
            Route.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Route.DataPropertyName = "Route";
            Route.FillWeight = 38.46153F;
            Route.HeaderText = "完整航綫";
            Route.MinimumWidth = 10;
            Route.Name = "Route";
            Route.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.DataPropertyName = "Flights";
            Column1.HeaderText = "航空公司與航班編號";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Class
            // 
            Class.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Class.DataPropertyName = "Class";
            Class.FillWeight = 38.46153F;
            Class.HeaderText = "各航段艙等";
            Class.MinimumWidth = 10;
            Class.Name = "Class";
            Class.ReadOnly = true;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Price.DataPropertyName = "Price";
            Price.FillWeight = 38.46153F;
            Price.HeaderText = "總票價";
            Price.MinimumWidth = 10;
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Minutes
            // 
            Minutes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Minutes.DataPropertyName = "TimeText";
            Minutes.FillWeight = 38.46153F;
            Minutes.HeaderText = "總時間";
            Minutes.MinimumWidth = 10;
            Minutes.Name = "Minutes";
            Minutes.ReadOnly = true;
            // 
            // Transfers
            // 
            Transfers.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Transfers.DataPropertyName = "Transfers";
            Transfers.FillWeight = 38.46153F;
            Transfers.HeaderText = "轉機次數";
            Transfers.MinimumWidth = 10;
            Transfers.Name = "Transfers";
            Transfers.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(19F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2083, 633);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox5);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "國際機票查詢系統";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private Button button1;
        private Button button2;
        private Label label6;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Route;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Class;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Minutes;
        private DataGridViewTextBoxColumn Transfers;
    }
}
