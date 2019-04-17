using Baymax.Control;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Baymax.Testat
{
    public partial class Form1 : Form
    {
        private Robot robot;
        private RobotConsole robotConsole;
        private float oldDistance;
        private int count;
        private Thread blink;
        private Thread objectCount;
        private delegate void Counter();

        public Form1()
        {
            InitializeComponent();

            this.robot = new Robot();
            this.driveView.Drive = robot.Drive;
            this.robot.Drive.Power = true;
            this.robot.Drive.tracksCompleted += Drive_tracksCompleted;

            this.radarView.Radar = this.robot.Radar;

            this.robotConsole = new Control.RobotConsole();
            this.robotConsole[Switches.Switch1].SwitchStateChanged += start;
        }

        private void Drive_tracksCompleted(object sender, TrackCompletedEventArgs e)
        {
            blink.Abort();
            objectCount.Abort();
            blink = null;
            objectCount = null;
            this.robotConsole[Leds.Led1].LedEnabled = true;
            this.robotConsole[Leds.Led2].LedEnabled = true;
            this.robotConsole[Leds.Led3].LedEnabled = true;
            this.robotConsole[Leds.Led4].LedEnabled = true;
        }

        private void start(object sender, EventArgs e)
        {
            
            count = 0;
            if (blink != null)
                blink.Abort();
            blink = null;
            blink = new Thread(blinking);
            blink.Start();

            if (objectCount != null)
                objectCount.Abort();
            objectCount = null;
            objectCount = new Thread(objectCounting);
            objectCount.Start();

            Drive drive = this.robot.Drive;
            //first line
            drive.RunLine(2.5f, 0.5f, 0.2f);
            drive.RunTurn(-90, 0.5f, 0.5f);
            //second line
            drive.RunLine(1f, 2, 1);
            drive.RunTurn(-90, 0.5f, 0.5f);
            drive.RunLine(1.5f, 2, 1);
            //arc right near the end
            drive.RunArcRight(1, 90, 0.5f, 0.5f);
            //line to finish
            drive.RunTurn(-90, 0.5f, 0.5f);
            //drive.RunLine(0.f, 2, 1);
        }

        private void blinking()
        {
            this.robotConsole[Leds.Led1].LedEnabled = false;
            this.robotConsole[Leds.Led2].LedEnabled = true;
            this.robotConsole[Leds.Led3].LedEnabled = false;
            this.robotConsole[Leds.Led4].LedEnabled = true;

            while (true)
            {
                this.robotConsole[Leds.Led1].LedEnabled = !this.robotConsole[Leds.Led1].LedEnabled;
                this.robotConsole[Leds.Led2].LedEnabled = !this.robotConsole[Leds.Led2].LedEnabled;
                this.robotConsole[Leds.Led3].LedEnabled = !this.robotConsole[Leds.Led3].LedEnabled;
                this.robotConsole[Leds.Led4].LedEnabled = !this.robotConsole[Leds.Led4].LedEnabled;
                Thread.Sleep(100);
            }
        }

        private void objectCounting()
        {
            while (true)
            {
                if (this.robot.Drive.tracks.Count > 6)
                {
                    float distance = this.radarView.Radar.Distance;
                    Thread.Sleep(10);
                    float distance2 = this.radarView.Radar.Distance;
                    if (Math.Abs(distance - distance2) < 0.1)
                    {
                        if (oldDistance == 0)
                            this.oldDistance = distance;
                        float difference = this.oldDistance - distance;

                        if (difference > 1)
                        {
                            count++;
                            Counter c = counter;
                            this.Invoke(c);
                        }

                        this.oldDistance = distance;
                    }
                }
                Thread.Sleep(90);
            }
        }

        private void counter()
        {
            labelCount.Text = count.ToString();
        }
    }
}
