using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baymax.Control
{
    public class TrackCompletedEventArgs : EventArgs
    {
        public float Distance { get; set; }

        public TrackCompletedEventArgs(float distance)
        {
            Distance = distance;
        }
    }
}
