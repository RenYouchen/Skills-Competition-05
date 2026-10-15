namespace BrianRen_107_Q4_Data_Analyze {
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
            menuStrip1 = new MenuStrip();
            檔案ToolStripMenuItem = new ToolStripMenuItem();
            選取資料ToolStripMenuItem = new ToolStripMenuItem();
            結束ToolStripMenuItem = new ToolStripMenuItem();
            統計ToolStripMenuItem = new ToolStripMenuItem();
            求F統計值和自由度dfToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            groupBox1 = new GroupBox();
            richTextBox1 = new RichTextBox();
            groupBox2 = new GroupBox();
            richTextBox2 = new RichTextBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 檔案ToolStripMenuItem, 統計ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1169, 42);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            檔案ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 選取資料ToolStripMenuItem, 結束ToolStripMenuItem });
            檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            檔案ToolStripMenuItem.Size = new Size(84, 38);
            檔案ToolStripMenuItem.Text = "檔案";
            // 
            // 選取資料ToolStripMenuItem
            // 
            選取資料ToolStripMenuItem.Name = "選取資料ToolStripMenuItem";
            選取資料ToolStripMenuItem.Size = new Size(247, 44);
            選取資料ToolStripMenuItem.Text = "選取資料";
            選取資料ToolStripMenuItem.Click += 選取資料ToolStripMenuItem_Click;
            // 
            // 結束ToolStripMenuItem
            // 
            結束ToolStripMenuItem.Name = "結束ToolStripMenuItem";
            結束ToolStripMenuItem.Size = new Size(247, 44);
            結束ToolStripMenuItem.Text = "結束";
            結束ToolStripMenuItem.Click += 結束ToolStripMenuItem_Click;
            // 
            // 統計ToolStripMenuItem
            // 
            統計ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 求F統計值和自由度dfToolStripMenuItem });
            統計ToolStripMenuItem.Name = "統計ToolStripMenuItem";
            統計ToolStripMenuItem.Size = new Size(84, 38);
            統計ToolStripMenuItem.Text = "統計";
            // 
            // 求F統計值和自由度dfToolStripMenuItem
            // 
            求F統計值和自由度dfToolStripMenuItem.Name = "求F統計值和自由度dfToolStripMenuItem";
            求F統計值和自由度dfToolStripMenuItem.Size = new Size(381, 44);
            求F統計值和自由度dfToolStripMenuItem.Text = "求F統計值和自由度df";
            求F統計值和自由度dfToolStripMenuItem.Click += 求F統計值和自由度dfToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 53);
            label1.Name = "label1";
            label1.Size = new Size(480, 45);
            label1.TabIndex = 1;
            label1.Text = "工作桌編號 選手姓名 代表學校";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Location = new Point(22, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(677, 520);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "輸入資料";
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(3, 46);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(671, 471);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBox2);
            groupBox2.Location = new Point(705, 101);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(452, 520);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "F統計值和自由度df";
            // 
            // richTextBox2
            // 
            richTextBox2.BorderStyle = BorderStyle.FixedSingle;
            richTextBox2.Dock = DockStyle.Fill;
            richTextBox2.Location = new Point(3, 46);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(446, 471);
            richTextBox2.TabIndex = 0;
            richTextBox2.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(19F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 633);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "全國高級中等學校107學年工業類科學生技藝競賽";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 檔案ToolStripMenuItem;
        private ToolStripMenuItem 選取資料ToolStripMenuItem;
        private ToolStripMenuItem 結束ToolStripMenuItem;
        private ToolStripMenuItem 統計ToolStripMenuItem;
        private ToolStripMenuItem 求F統計值和自由度dfToolStripMenuItem;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
    }
}
