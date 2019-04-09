
namespace Baymax.TestDrive
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
            this.driveView = new Baymax.View.DriveView();
            this.commonRunParameters = new Baymax.View.CommonRunParameters();
            this.runLineView = new Baymax.View.RunLineView();
            this.runTurnView = new Baymax.View.RunTurnView();
            this.runArcView = new Baymax.View.RunArcView();
            this.SuspendLayout();
            // 
            // driveView
            // 
            this.driveView.Drive = null;
            this.driveView.Location = new System.Drawing.Point(0, 8);
            this.driveView.Name = "driveView";
            this.driveView.Size = new System.Drawing.Size(453, 714);
            this.driveView.TabIndex = 1;
            // 
            // commonRunParameters
            // 
            this.commonRunParameters.Acceleration = 0.3F;
            this.commonRunParameters.Location = new System.Drawing.Point(435, 3);
            this.commonRunParameters.Name = "commonRunParameters";
            this.commonRunParameters.Size = new System.Drawing.Size(673, 103);
            this.commonRunParameters.Speed = 0.5F;
            this.commonRunParameters.TabIndex = 2;
            // 
            // runLineView
            // 
            this.runLineView.Distance = 0.3F;
            this.runLineView.Location = new System.Drawing.Point(435, 89);
            this.runLineView.Name = "runLineView";
            this.runLineView.Size = new System.Drawing.Size(861, 110);
            this.runLineView.TabIndex = 3;
            this.runLineView.StartClicked += new System.EventHandler<System.EventArgs>(this.runLineView_StartClicked);
            // 
            // runTurnView
            // 
            this.runTurnView.Angle = 0F;
            this.runTurnView.Location = new System.Drawing.Point(435, 185);
            this.runTurnView.Name = "runTurnView";
            this.runTurnView.Size = new System.Drawing.Size(773, 121);
            this.runTurnView.TabIndex = 0;
            this.runTurnView.StartClicked += new System.EventHandler<System.EventArgs>(this.runTurnView_StartClicked);
            // 
            // runArcView
            // 
            this.runArcView.Angle = 0F;
            this.runArcView.Location = new System.Drawing.Point(435, 300);
            this.runArcView.Name = "runArcView";
            this.runArcView.Radius = 0F;
            this.runArcView.Size = new System.Drawing.Size(811, 184);
            this.runArcView.TabIndex = 4;
            this.runArcView.StartClicked += new System.EventHandler<System.EventArgs>(this.runArcView_StartClicked);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1330, 734);
            this.Controls.Add(this.driveView);
            this.Controls.Add(this.commonRunParameters);
            this.Controls.Add(this.runLineView);
            this.Controls.Add(this.runTurnView);
            this.Controls.Add(this.runArcView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private View.DriveView driveView;
        private View.CommonRunParameters commonRunParameters;
        private View.RunLineView runLineView;
        private View.RunTurnView runTurnView;
        private View.RunArcView runArcView;
    }
}

