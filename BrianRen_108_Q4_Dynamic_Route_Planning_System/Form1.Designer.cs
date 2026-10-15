namespace BrianRen_108_Q4_Dynamic_Route_Planning_System {
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
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            system = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 9);
            label1.Name = "label1";
            label1.Size = new Size(292, 45);
            label1.TabIndex = 0;
            label1.Text = "動態路綫規划系統";
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 661);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            panel1.MouseClick += panel1_MouseClick;
            // 
            // panel2
            // 
            panel2.Location = new Point(760, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 300);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(760, 446);
            button1.Name = "button1";
            button1.Size = new Size(250, 50);
            button1.TabIndex = 3;
            button1.Text = "Initialization";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(760, 557);
            button2.Name = "button2";
            button2.Size = new Size(250, 50);
            button2.TabIndex = 4;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            // 
            // system
            // 
            system.AutoSize = true;
            system.Location = new Point(760, 377);
            system.Name = "system";
            system.Size = new Size(0, 45);
            system.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(19F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 743);
            Controls.Add(system);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Label system;
    }
}
