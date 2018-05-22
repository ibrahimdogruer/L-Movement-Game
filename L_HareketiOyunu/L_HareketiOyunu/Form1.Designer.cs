namespace L_HareketiOyunu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yeniOyunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniOyunToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(379, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yeniOyunToolStripMenuItem
            // 
            this.yeniOyunToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x7ToolStripMenuItem,
            this.x8ToolStripMenuItem,
            this.x9ToolStripMenuItem});
            this.yeniOyunToolStripMenuItem.Name = "yeniOyunToolStripMenuItem";
            this.yeniOyunToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.yeniOyunToolStripMenuItem.Text = "Yeni Oyun";
            // 
            // x7ToolStripMenuItem
            // 
            this.x7ToolStripMenuItem.Name = "x7ToolStripMenuItem";
            this.x7ToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.x7ToolStripMenuItem.Text = "7x7";
            this.x7ToolStripMenuItem.Click += new System.EventHandler(this.x7ToolStripMenuItem_Click);
            // 
            // x8ToolStripMenuItem
            // 
            this.x8ToolStripMenuItem.Name = "x8ToolStripMenuItem";
            this.x8ToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.x8ToolStripMenuItem.Text = "8x8";
            this.x8ToolStripMenuItem.Click += new System.EventHandler(this.x8ToolStripMenuItem_Click);
            // 
            // x9ToolStripMenuItem
            // 
            this.x9ToolStripMenuItem.Name = "x9ToolStripMenuItem";
            this.x9ToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.x9ToolStripMenuItem.Text = "9x9";
            this.x9ToolStripMenuItem.Click += new System.EventHandler(this.x9ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(45, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 230);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(42, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(172, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 57);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(379, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yeniOyunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x9ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

