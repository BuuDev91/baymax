using Baymax.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Baymax.TestDrive
{
    public partial class Form1 : Form
    {
        private Drive drive;
        public Form1()
        {
            InitializeComponent();

            drive = new Drive();
            this.driveView.Drive = drive;
            drive.Power = true;
        }

        private void runLineView_StartClicked(object sender, EventArgs e)
        {
            drive.RunLine(this.runLineView.Distance, this.commonRunParameters.Speed, this.commonRunParameters.Acceleration);
        }

        private void runTurnView_StartClicked(object sender, EventArgs e)
        {
            drive.RunTurn(this.runTurnView.Angle, this.commonRunParameters.Speed, this.commonRunParameters.Acceleration);
        }

        private void runArcView_StartClicked(object sender, EventArgs e)
        {
            float radius = this.runArcView.Radius;
            float angle = this.runArcView.Angle;
            float speed = this.commonRunParameters.Speed;
            float acceleration = this.commonRunParameters.Acceleration;
            if (this.runArcView.ArcLeft)
                drive.RunArcLeft(radius, angle, speed, acceleration);
            else
                drive.RunArcRight(radius, angle, speed, acceleration);
        }
    }
}
