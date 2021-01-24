
namespace WindowsGUI
{
    partial class MenuStripGUI
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
            this.huyhuyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.k6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.huy1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.huy1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mntsCombo = new System.Windows.Forms.ToolStripComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.huyhuyToolStripMenuItem,
            this.k6ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // huyhuyToolStripMenuItem
            // 
            this.huyhuyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.huy1ToolStripMenuItem,
            this.huy1ToolStripMenuItem1});
            this.huyhuyToolStripMenuItem.Name = "huyhuyToolStripMenuItem";
            this.huyhuyToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.huyhuyToolStripMenuItem.Text = "huyhuy";
            // 
            // k6ToolStripMenuItem
            // 
            this.k6ToolStripMenuItem.Name = "k6ToolStripMenuItem";
            this.k6ToolStripMenuItem.Size = new System.Drawing.Size(31, 20);
            this.k6ToolStripMenuItem.Text = "k6";
            // 
            // huy1ToolStripMenuItem
            // 
            this.huy1ToolStripMenuItem.Name = "huy1ToolStripMenuItem";
            this.huy1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.huy1ToolStripMenuItem.Text = "huy1";
            this.huy1ToolStripMenuItem.Click += new System.EventHandler(this.huy1ToolStripMenuItem_Click);
            // 
            // huy1ToolStripMenuItem1
            // 
            this.huy1ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripSeparator1,
            this.mntsCombo});
            this.huy1ToolStripMenuItem1.Name = "huy1ToolStripMenuItem1";
            this.huy1ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.huy1ToolStripMenuItem1.Text = "huyhuyhnf";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // mntsCombo
            // 
            this.mntsCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.mntsCombo.Name = "mntsCombo";
            this.mntsCombo.Size = new System.Drawing.Size(121, 23);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // MenuStripGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuStripGUI";
            this.Text = "MenuStripGUI";
            this.Load += new System.EventHandler(this.MenuStripGUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem huyhuyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem k6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem huy1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem huy1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox mntsCombo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}