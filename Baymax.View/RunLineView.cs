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
    public partial class RunLineView : UserControl
    {
        public event EventHandler<EventArgs> StartClicked;

        public float Distance
        {
            get
            {
                return (float)upDownDistance.Value / 1000f;
            }

            set
            {
                upDownDistance.Value = (decimal)value * 1000;
            }
        }

        public RunLineView()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
           StartClicked(this, e);
        }

        private void buttonEditAcceleration_Click(object sender, EventArgs e)
        {
            NumberKeyboard nk = new NumberKeyboard();
            nk.Number = (float)upDownDistance.Value;
            if (nk.ShowDialog() == DialogResult.OK)
            {
                upDownDistance.Value = (int)nk.Number;
            }
        }
    }
}