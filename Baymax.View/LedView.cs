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
    public partial class LedView : UserControl
    {
        private bool state;

        public LedView()
        {
            InitializeComponent();
        }

        public bool State
        {
            get
            {
                return this.state;
            }
            set
            {
                this.state = value;
                this.ledImage.Image = value ? Resource.LedOn : Resource.LedOff;
            }
        }

        public Led Led { get; set; }
    }
}