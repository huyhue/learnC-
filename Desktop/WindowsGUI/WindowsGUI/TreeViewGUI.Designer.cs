
namespace WindowsGUI
{
    partial class TreeViewGUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeViewGUI));
            this.tvShow = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // tvShow
            // 
            this.tvShow.Cursor = System.Windows.Forms.Cursors.Default;
            this.tvShow.ImageIndex = 0;
            this.tvShow.ImageList = this.imageList1;
            this.tvShow.Location = new System.Drawing.Point(13, 13);
            this.tvShow.Name = "tvShow";
            this.tvShow.SelectedImageIndex = 0;
            this.tvShow.Size = new System.Drawing.Size(569, 425);
            this.tvShow.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.png");
            this.imageList1.Images.SetKeyName(1, "2.png");
            this.imageList1.Images.SetKeyName(2, "3.png");
            // 
            // TreeViewGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tvShow);
            this.Name = "TreeViewGUI";
            this.Text = "TreeViewGUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvShow;
        private System.Windows.Forms.ImageList imageList1;
    }
}