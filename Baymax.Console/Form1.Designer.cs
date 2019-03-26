using Baymax.View;

namespace Baymax.Console
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
            this.consoleView1 = new Baymax.View.ConsoleView();
            this.SuspendLayout();
            // 
            // consoleView1
            // 
            this.consoleView1.Console = null;
            this.consoleView1.Location = new System.Drawing.Point(40, 54);
            this.consoleView1.Name = "consoleView1";
            this.consoleView1.Size = new System.Drawing.Size(472, 109);
            this.consoleView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(827, 358);
            this.Controls.Add(this.consoleView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Baymax.View.ConsoleView consoleView1;
    }
}

