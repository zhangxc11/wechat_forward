using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScreenClock
{
    public partial class Transparency : Form
    {
        private bool mouseIsIn = false;

        public Transparency()
        {
            InitializeComponent();
        }
        
        private void trackBarTransparent_ValueChanged(object sender, EventArgs e)
        {
            Owner.Opacity = trackBarTransparent.Value / 100.0;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            trackBarTransparent.Value = (int)(Owner.Opacity * 100.0);
            Point pt = new Point(Control.MousePosition.X, Control.MousePosition.Y);
            pt.Offset(-(trackBarTransparent.Value - 10) * 2 - 10, -10);
            this.Location = pt;
            mouseIsIn = false;
            timerHide.Start();
        }

        private void trackBarTransparent_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Hide();
                timerHide.Stop();
            }
        }

        private void timerHide_Tick(object sender, EventArgs e)
        {
            if (!this.trackBarTransparent.RectangleToScreen(this.DisplayRectangle).
                Contains(Control.MousePosition))
            {
                if (mouseIsIn == false)
                {
                    mouseIsIn = true;
                }
                else
                {
                    timerHide.Stop();
                    this.Hide();
                }
            }
        }
    }
}
