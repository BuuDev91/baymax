using Baymax.View;

namespace Baymax.TestMotor
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
            this.driveCtrlView = new Baymax.View.DriveCtrlView();
            this.motorCtrlView1 = new Baymax.View.MotorCtrlView();
            this.motorCtrlView2 = new Baymax.View.MotorCtrlView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // driveCtrlView
            // 
            this.driveCtrlView.DriveCtrl = null;
            this.driveCtrlView.Location = new System.Drawing.Point(0, 0);
            this.driveCtrlView.Name = "driveCtrlView";
            this.driveCtrlView.Size = new System.Drawing.Size(1200, 188);
            this.driveCtrlView.TabIndex = 0;
            // 
            // motorCtrlView1
            // 
            this.motorCtrlView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.motorCtrlView1.Location = new System.Drawing.Point(0, 0);
            this.motorCtrlView1.MotorCtrl = null;
            this.motorCtrlView1.Name = "motorCtrlView1";
            this.motorCtrlView1.Size = new System.Drawing.Size(1416, 780);
            this.motorCtrlView1.TabIndex = 1;
            // 
            // motorCtrlView2
            // 
            this.motorCtrlView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.motorCtrlView2.Location = new System.Drawing.Point(0, 0);
            this.motorCtrlView2.MotorCtrl = null;
            this.motorCtrlView2.Name = "motorCtrlView2";
            this.motorCtrlView2.Size = new System.Drawing.Size(1416, 582);
            this.motorCtrlView2.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 74);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1436, 847);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.motorCtrlView1);
            this.tabPage1.Location = new System.Drawing.Point(10, 57);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1416, 780);
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.motorCtrlView2);
            this.tabPage2.Location = new System.Drawing.Point(10, 57);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1416, 582);
            this.tabPage2.Text = "tabPage2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1446, 931);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.driveCtrlView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DriveCtrlView driveCtrlView;
        private MotorCtrlView motorCtrlView1;
        private MotorCtrlView motorCtrlView2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

