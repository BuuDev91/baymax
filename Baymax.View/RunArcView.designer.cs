namespace Baymax.View
{
    partial class RunArcView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonEditRadius = new System.Windows.Forms.Button();
            this.buttonEditAngle = new System.Windows.Forms.Button();
            this.upDownRadius = new System.Windows.Forms.NumericUpDown();
            this.upDownAngle = new System.Windows.Forms.NumericUpDown();
            this.radioLeft = new System.Windows.Forms.RadioButton();
            this.radioRight = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 38);
            this.label1.Text = "RunArc";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 49);
            this.label2.Text = "Radius (+/- mm)";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 39);
            this.label3.Text = "Angle (+/- degrees)";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(680, 58);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(128, 117);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            // 
            // buttonEditRadius
            // 
            this.buttonEditRadius.Location = new System.Drawing.Point(587, 57);
            this.buttonEditRadius.Name = "buttonEditRadius";
            this.buttonEditRadius.Size = new System.Drawing.Size(72, 49);
            this.buttonEditRadius.TabIndex = 4;
            this.buttonEditRadius.Text = "...";
            this.buttonEditRadius.Click += new System.EventHandler(this.buttonEditRadius_Click);
            // 
            // buttonEditAngle
            // 
            this.buttonEditAngle.Location = new System.Drawing.Point(587, 126);
            this.buttonEditAngle.Name = "buttonEditAngle";
            this.buttonEditAngle.Size = new System.Drawing.Size(72, 49);
            this.buttonEditAngle.TabIndex = 5;
            this.buttonEditAngle.Text = "...";
            this.buttonEditAngle.Click += new System.EventHandler(this.buttonEditAngle_Click);
            // 
            // upDownRadius
            // 
            this.upDownRadius.Location = new System.Drawing.Point(454, 57);
            this.upDownRadius.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.upDownRadius.Minimum = new decimal(new int[] {
            8000,
            0,
            0,
            -2147483648});
            this.upDownRadius.Name = "upDownRadius";
            this.upDownRadius.Size = new System.Drawing.Size(118, 48);
            this.upDownRadius.TabIndex = 6;
            this.upDownRadius.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // upDownAngle
            // 
            this.upDownAngle.Location = new System.Drawing.Point(454, 126);
            this.upDownAngle.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.upDownAngle.Name = "upDownAngle";
            this.upDownAngle.Size = new System.Drawing.Size(118, 48);
            this.upDownAngle.TabIndex = 7;
            this.upDownAngle.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // radioLeft
            // 
            this.radioLeft.Location = new System.Drawing.Point(404, 5);
            this.radioLeft.Name = "radioLeft";
            this.radioLeft.Size = new System.Drawing.Size(168, 33);
            this.radioLeft.TabIndex = 11;
            this.radioLeft.Text = "Left";
            // 
            // radioRight
            // 
            this.radioRight.Location = new System.Drawing.Point(587, 5);
            this.radioRight.Name = "radioRight";
            this.radioRight.Size = new System.Drawing.Size(175, 33);
            this.radioRight.TabIndex = 12;
            this.radioRight.Text = "Right";
            // 
            // RunArcView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.radioRight);
            this.Controls.Add(this.radioLeft);
            this.Controls.Add(this.upDownAngle);
            this.Controls.Add(this.upDownRadius);
            this.Controls.Add(this.buttonEditAngle);
            this.Controls.Add(this.buttonEditRadius);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RunArcView";
            this.Size = new System.Drawing.Size(811, 184);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonEditRadius;
        private System.Windows.Forms.Button buttonEditAngle;
        private System.Windows.Forms.NumericUpDown upDownRadius;
        private System.Windows.Forms.NumericUpDown upDownAngle;
        private System.Windows.Forms.RadioButton radioLeft;
        private System.Windows.Forms.RadioButton radioRight;
    }
}
