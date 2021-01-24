
namespace WindowsGUI
{
    partial class ImageGUI
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
            this.pcbImage = new System.Windows.Forms.PictureBox();
            this.cbImage = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbImage
            // 
            this.pcbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbImage.Location = new System.Drawing.Point(139, 12);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(223, 226);
            this.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImage.TabIndex = 0;
            this.pcbImage.TabStop = false;
            // 
            // cbImage
            // 
            this.cbImage.FormattingEnabled = true;
            this.cbImage.Location = new System.Drawing.Point(12, 12);
            this.cbImage.Name = "cbImage";
            this.cbImage.Size = new System.Drawing.Size(121, 21);
            this.cbImage.TabIndex = 1;
            this.cbImage.SelectedValueChanged += new System.EventHandler(this.cbImage_SelectedValueChanged);
            // 
            // ImageGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbImage);
            this.Controls.Add(this.pcbImage);
            this.Name = "ImageGUI";
            this.Text = "ImageGUI";
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pcbImage;
        private System.Windows.Forms.ComboBox cbImage;
    }
}