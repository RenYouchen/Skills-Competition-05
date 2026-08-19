namespace BrianRen_20260815_Q3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.drinks = new System.Windows.Forms.ComboBox();
            this.middle = new System.Windows.Forms.RadioButton();
            this.large = new System.Windows.Forms.RadioButton();
            this.bobble = new System.Windows.Forms.CheckBox();
            this.cream = new System.Windows.Forms.CheckBox();
            this.numOfDrinks = new System.Windows.Forms.NumericUpDown();
            this.AddOrder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DelOrder = new System.Windows.Forms.Button();
            this.ClearOrder = new System.Windows.Forms.Button();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.SendOrder = new System.Windows.Forms.Button();
            this.orderList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numOfDrinks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "飲料";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "杯型";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "加料";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "數量";
            // 
            // drinks
            // 
            this.drinks.FormattingEnabled = true;
            this.drinks.Location = new System.Drawing.Point(158, 33);
            this.drinks.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.drinks.Name = "drinks";
            this.drinks.Size = new System.Drawing.Size(199, 45);
            this.drinks.TabIndex = 4;
            // 
            // middle
            // 
            this.middle.AutoSize = true;
            this.middle.Location = new System.Drawing.Point(158, 98);
            this.middle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.middle.Name = "middle";
            this.middle.Size = new System.Drawing.Size(114, 41);
            this.middle.TabIndex = 5;
            this.middle.TabStop = true;
            this.middle.Text = "中杯";
            this.middle.UseVisualStyleBackColor = true;
            // 
            // large
            // 
            this.large.AutoSize = true;
            this.large.Location = new System.Drawing.Point(282, 96);
            this.large.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.large.Name = "large";
            this.large.Size = new System.Drawing.Size(114, 41);
            this.large.TabIndex = 6;
            this.large.TabStop = true;
            this.large.Text = "大杯";
            this.large.UseVisualStyleBackColor = true;
            // 
            // bobble
            // 
            this.bobble.AutoSize = true;
            this.bobble.Location = new System.Drawing.Point(158, 151);
            this.bobble.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bobble.Name = "bobble";
            this.bobble.Size = new System.Drawing.Size(115, 41);
            this.bobble.TabIndex = 7;
            this.bobble.Text = "珍珠";
            this.bobble.UseVisualStyleBackColor = true;
            // 
            // cream
            // 
            this.cream.AutoSize = true;
            this.cream.Location = new System.Drawing.Point(282, 151);
            this.cream.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cream.Name = "cream";
            this.cream.Size = new System.Drawing.Size(148, 41);
            this.cream.TabIndex = 8;
            this.cream.Text = "奶油球";
            this.cream.UseVisualStyleBackColor = true;
            // 
            // numOfDrinks
            // 
            this.numOfDrinks.Location = new System.Drawing.Point(158, 214);
            this.numOfDrinks.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.numOfDrinks.Name = "numOfDrinks";
            this.numOfDrinks.Size = new System.Drawing.Size(200, 44);
            this.numOfDrinks.TabIndex = 9;
            // 
            // AddOrder
            // 
            this.AddOrder.Location = new System.Drawing.Point(74, 266);
            this.AddOrder.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(312, 65);
            this.AddOrder.TabIndex = 10;
            this.AddOrder.Text = "加入訂單";
            this.AddOrder.UseVisualStyleBackColor = true;
            this.AddOrder.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 37);
            this.label5.TabIndex = 11;
            this.label5.Text = "訂單明細";
            // 
            // DelOrder
            // 
            this.DelOrder.Location = new System.Drawing.Point(974, 65);
            this.DelOrder.Name = "DelOrder";
            this.DelOrder.Size = new System.Drawing.Size(218, 72);
            this.DelOrder.TabIndex = 13;
            this.DelOrder.Text = "刪除選取項目";
            this.DelOrder.UseVisualStyleBackColor = true;
            // 
            // ClearOrder
            // 
            this.ClearOrder.Location = new System.Drawing.Point(974, 155);
            this.ClearOrder.Name = "ClearOrder";
            this.ClearOrder.Size = new System.Drawing.Size(218, 72);
            this.ClearOrder.TabIndex = 14;
            this.ClearOrder.Text = "清空訂單";
            this.ClearOrder.UseVisualStyleBackColor = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.Location = new System.Drawing.Point(974, 247);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(149, 37);
            this.TotalPrice.TabIndex = 15;
            this.TotalPrice.Text = "總金額：";
            // 
            // SendOrder
            // 
            this.SendOrder.Location = new System.Drawing.Point(981, 311);
            this.SendOrder.Name = "SendOrder";
            this.SendOrder.Size = new System.Drawing.Size(218, 72);
            this.SendOrder.TabIndex = 16;
            this.SendOrder.Text = "送出訂單";
            this.SendOrder.UseVisualStyleBackColor = true;
            // 
            // orderList
            // 
            this.orderList.FormattingEnabled = true;
            this.orderList.ItemHeight = 37;
            this.orderList.Location = new System.Drawing.Point(438, 96);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(447, 300);
            this.orderList.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 439);
            this.Controls.Add(this.orderList);
            this.Controls.Add(this.SendOrder);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.ClearOrder);
            this.Controls.Add(this.DelOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddOrder);
            this.Controls.Add(this.numOfDrinks);
            this.Controls.Add(this.cream);
            this.Controls.Add(this.bobble);
            this.Controls.Add(this.large);
            this.Controls.Add(this.middle);
            this.Controls.Add(this.drinks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numOfDrinks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox drinks;
        private System.Windows.Forms.RadioButton middle;
        private System.Windows.Forms.RadioButton large;
        private System.Windows.Forms.CheckBox bobble;
        private System.Windows.Forms.CheckBox cream;
        private System.Windows.Forms.NumericUpDown numOfDrinks;
        private System.Windows.Forms.Button AddOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DelOrder;
        private System.Windows.Forms.Button ClearOrder;
        private System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.Button SendOrder;
        private System.Windows.Forms.ListBox orderList;
    }
}

