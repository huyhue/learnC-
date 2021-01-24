
namespace WindowsGUI
{
    partial class ProcessGUI
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
            this.txbLog = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHiden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbLog
            // 
            this.txbLog.Location = new System.Drawing.Point(12, 12);
            this.txbLog.Multiline = true;
            this.txbLog.Name = "txbLog";
            this.txbLog.Size = new System.Drawing.Size(206, 237);
            this.txbLog.TabIndex = 0;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(224, 12);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 1;
            this.btnProcess.Text = "Get Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(224, 41);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHiden
            // 
            this.btnHiden.Location = new System.Drawing.Point(224, 70);
            this.btnHiden.Name = "btnHiden";
            this.btnHiden.Size = new System.Drawing.Size(75, 23);
            this.btnHiden.TabIndex = 3;
            this.btnHiden.Text = "Hiden";
            this.btnHiden.UseVisualStyleBackColor = true;
            this.btnHiden.Click += new System.EventHandler(this.btnHiden_Click);
            // 
            // ProcessGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHiden);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txbLog);
            this.Name = "ProcessGUI";
            this.Text = "ProcessGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbLog;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHiden;
    }
}