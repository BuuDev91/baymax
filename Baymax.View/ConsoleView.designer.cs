namespace Baymax.View
{
    partial class ConsoleView
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
            this.ledView4 = new Baymax.View.LedView();
            this.ledView3 = new Baymax.View.LedView();
            this.ledView2 = new Baymax.View.LedView();
            this.ledView1 = new Baymax.View.LedView();
            this.SuspendLayout();
            // 
            // ledView4
            // 
            this.ledView4.Location = new System.Drawing.Point(113, 0);
            this.ledView4.Name = "ledView4";
            this.ledView4.Size = new System.Drawing.Size(20, 20);
            this.ledView4.State = false;
            this.ledView4.TabIndex = 4;
            // 
            // ledView3
            // 
            this.ledView3.Location = new System.Drawing.Point(73, 0);
            this.ledView3.Name = "ledView3";
            this.ledView3.Size = new System.Drawing.Size(20, 20);
            this.ledView3.State = false;
            this.ledView3.TabIndex = 3;
            // 
            // ledView2
            // 
            this.ledView2.Location = new System.Drawing.Point(35, 0);
            this.ledView2.Name = "ledView2";
            this.ledView2.Size = new System.Drawing.Size(20, 20);
            this.ledView2.State = false;
            this.ledView2.TabIndex = 2;
            // 
            // ledView1
            // 
            this.ledView1.Location = new System.Drawing.Point(0, 0);
            this.ledView1.Name = "ledView1";
            this.ledView1.Size = new System.Drawing.Size(20, 20);
            this.ledView1.State = false;
            this.ledView1.TabIndex = 1;
            // 
            // ConsoleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.ledView4);
            this.Controls.Add(this.ledView3);
            this.Controls.Add(this.ledView2);
            this.Controls.Add(this.ledView1);
            this.Name = "ConsoleView";
            this.Size = new System.Drawing.Size(750, 192);
            this.ResumeLayout(false);

        }

        #endregion

        private LedView ledView1;
        private LedView ledView2;
        private LedView ledView3;
        private LedView ledView4;
    }
}
