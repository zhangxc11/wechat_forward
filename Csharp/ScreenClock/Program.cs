using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Text;


namespace ScreenClock
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Formvoid());
            //FormClock bb = new FormClock(800, "hello world, long text, long text, long text, long text, long text, long text, long text, long text, long text");
            //bb.Show();
            //Application.Run(new FormClock(600, "hello world"));
            //new FormClock(500, "hello world, long text, long text, long text, long text, long text, long text, long text, long text, long text");
            //new FormClock(1000, "one");
            //Application.Run(new StartForm());
        }
    }
}
