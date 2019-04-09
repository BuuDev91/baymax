namespace Baymax.View
{
    partial class RunLineView
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonEditAcceleration = new System.Windows.Forms.Button();
            this.upDownDistance = new System.Windows.Forms.NumericUpDown();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 46);
            this.label1.Text = "RunLine";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 44);
            this.label2.Text = "Length (+/- mm)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "+/-";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(681, 43);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(104, 54);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonEditAcceleration
            // 
            this.buttonEditAcceleration.Location = new System.Drawing.Point(545, 43);
            this.buttonEditAcceleration.Name = "buttonEditAcceleration";
            this.buttonEditAcceleration.Size = new System.Drawing.Size(107, 54);
            this.buttonEditAcceleration.TabIndex = 5;
            this.buttonEditAcceleration.Text = "...";
            this.buttonEditAcceleration.Click += new System.EventHandler(this.buttonEditAcceleration_Click);
            // 
            // upDownDistance
            // 
            this.upDownDistance.Location = new System.Drawing.Point(369, 49);
            this.upDownDistance.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.upDownDistance.Minimum = new decimal(new int[] {
            8000,
            0,
            0,
            -2147483648});
            this.upDownDistance.Name = "upDownDistance";
            this.upDownDistance.Size = new System.Drawing.Size(138, 48);
            this.upDownDistance.TabIndex = 9;
            this.upDownDistance.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // RunLineView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.upDownDistance);
            this.Controls.Add(this.buttonEditAcceleration);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RunLineView";
            this.Size = new System.Drawing.Size(810, 110);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonEditAcceleration;
        private System.Windows.Forms.NumericUpDown upDownDistance;
    }
}
