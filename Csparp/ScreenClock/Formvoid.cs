using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ScreenClock
{
    public partial class Formvoid : Form
    {
        public delegate void UDPEventHandler(object sender, udpEventArgs e);
        public UDPEventHandler udpEvent = new UDPEventHandler(UDPhandler);
        public Random ra;
        public Formvoid()
        {
            InitializeComponent();
            udpevent udp = new udpevent(this);
            //this.Visible = false;
            this.Hide();
            ra = new Random(); 
        }

        static public void UDPhandler(object sender, udpEventArgs e)
        {
            
            FormClock bb = new FormClock(800, Encoding.UTF8.GetString(e.data, 0, e.recv));
            bb.Show();
        }
    }
}
