using Baymax.View;

namespace Baymax.Testat
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
            this.labelCount = new System.Windows.Forms.Label();
            this.driveView = new Baymax.View.DriveView();
            this.radarView = new Baymax.View.RadarView();
            this.SuspendLayout();
            // 
            // labelCount
            // 
            this.labelCount.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.labelCount.Location = new System.Drawing.Point(563, 163);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(292, 119);
            this.labelCount.Text = "0";
            // 
            // driveView
            // 
            this.driveView.Drive = null;
            this.driveView.Location = new System.Drawing.Point(0, 0);
            this.driveView.Name = "driveView";
            this.driveView.Size = new System.Drawing.Size(498, 671);
            this.driveView.TabIndex = 1;
            // 
            // radarView
            // 
            this.radarView.Location = new System.Drawing.Point(528, 0);
            this.radarView.Name = "radarView";
            this.radarView.Radar = null;
            this.radarView.Size = new System.Drawing.Size(486, 139);
            this.radarView.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1267, 671);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.driveView);
            this.Controls.Add(this.radarView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private View.DriveView driveView;
        private RadarView radarView;
        private System.Windows.Forms.Label labelCount;
    }
}

