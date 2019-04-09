using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Baymax.Control;

namespace Baymax.View
{
    public partial class RunTurnView : UserControl
    {
        public event EventHandler<EventArgs> StartClicked;

        public float Angle
        {
            get
            {
                return (float)upDownAngle.Value;
            }

            set
            {
                upDownAngle.Value = (decimal)value;
            }
        }

        public RunTurnView()
        {
            InitializeComponent();
        }

        private void buttonEditAngle_Click(object sender, EventArgs e)
        {
            NumberKeyboard nk = new NumberKeyboard();
            nk.Number = (float)upDownAngle.Value;
            if (nk.ShowDialog() == DialogResult.OK)
            {
                upDownAngle.Value = (int)nk.Number;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            StartClicked(this, e);
        }
    }
}