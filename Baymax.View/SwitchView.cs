using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Baymax.View
{
    public partial class SwitchView : UserControl
    {
        private bool switchState;

        public SwitchView()
        {
            InitializeComponent();
        }

        public bool State
        {
            get
            {
                return this.switchState;
            }
            set
            {
                this.switchState = value;
                this.switchImage.Image = value ? Resource.SwitchOn: Resource.SwitchOff;
            }
        }
    }
    
}