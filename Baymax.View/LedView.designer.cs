namespace Baymax.View
{
    partial class LedView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ledImage = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // ledImage
            // 
            this.ledImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ledImage.Location = new System.Drawing.Point(0, 0);
            this.ledImage.Name = "ledImage";
            this.ledImage.Size = new System.Drawing.Size(20, 20);
            // 
            // LedView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.ledImage);
            this.Name = "LedView";
            this.Size = new System.Drawing.Size(20, 20);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ledImage;
    }
}
