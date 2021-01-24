
namespace WindowsGUI
{
    partial class CheckboxGUI
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
            this.ckbKter = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ckbKter
            // 
            this.ckbKter.AutoSize = true;
            this.ckbKter.Location = new System.Drawing.Point(125, 91);
            this.ckbKter.Name = "ckbKter";
            this.ckbKter.Size = new System.Drawing.Size(116, 17);
            this.ckbKter.TabIndex = 0;
            this.ckbKter.Text = "Ban co phai la Kter";
            this.ckbKter.ThreeState = true;
            this.ckbKter.UseVisualStyleBackColor = true;
            this.ckbKter.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.ckbKter.CheckStateChanged += new System.EventHandler(this.ckbKter_CheckStateChanged);
            this.ckbKter.Click += new System.EventHandler(this.ckbKter_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 131);
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
            this.label1.Location = new System.Drawing.Point(190, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(125, 133);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 20);
            this.txbName.TabIndex = 3;
            // 
            // CheckboxGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ckbKter);
            this.Name = "CheckboxGUI";
            this.Text = "CheckboxGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbKter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbName;
    }
}