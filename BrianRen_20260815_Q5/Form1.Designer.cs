namespace BrianRen_20260815_Q5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.開啓圖片OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.儲存圖片SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.關閉ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(425, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開啓圖片OpenToolStripMenuItem,
            this.儲存圖片SaveToolStripMenuItem,
            this.清除ClearToolStripMenuItem,
            this.關閉ExitToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(72, 22);
            this.toolStripDropDownButton1.Text = "檔案(File)";
            // 
            // 開啓圖片OpenToolStripMenuItem
            // 
            this.開啓圖片OpenToolStripMenuItem.Name = "開啓圖片OpenToolStripMenuItem";
            this.開啓圖片OpenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.開啓圖片OpenToolStripMenuItem.Text = "開啓圖片(Open)";
            // 
            // 儲存圖片SaveToolStripMenuItem
            // 
            this.儲存圖片SaveToolStripMenuItem.Name = "儲存圖片SaveToolStripMenuItem";
            this.儲存圖片SaveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.儲存圖片SaveToolStripMenuItem.Text = "儲存圖片(Save)";
            // 
            // 清除ClearToolStripMenuItem
            // 
            this.清除ClearToolStripMenuItem.Name = "清除ClearToolStripMenuItem";
            this.清除ClearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.清除ClearToolStripMenuItem.Text = "清除(Clear)";
            // 
            // 關閉ExitToolStripMenuItem
            // 
            this.關閉ExitToolStripMenuItem.Name = "關閉ExitToolStripMenuItem";
            this.關閉ExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.關閉ExitToolStripMenuItem.Text = "關閉(Exit)";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(108, 22);
            this.toolStripDropDownButton2.Text = "檢視(Size Mode)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 439);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "簡易圖片瀏覽器";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem 開啓圖片OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 儲存圖片SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清除ClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 關閉ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
    }
}

