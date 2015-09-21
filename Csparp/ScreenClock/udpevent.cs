using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ScreenClock
{
    public class udpEventArgs : EventArgs
    {
        public int recv;
        public byte[] data;
    }

    

    class udpevent
    {
        public Formvoid owner;

        public udpevent(Formvoid ow)
        {
            owner = ow;
            Thread t = new Thread(recvData);
            t.Start();
        }

        public void recvData()
        {
            

            IPEndPoint ip = new IPEndPoint(IPAddress.Any, 5068);
            Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            newsock.Bind(ip);

            IPEndPoint sender_s = new IPEndPoint(IPAddress.Any, 0);

            while (true)
            {
                udpEventArgs e = new udpEventArgs();
                e.data = new byte[1024];
                EndPoint Remote = (EndPoint)(sender_s);
                e.data = new byte[4096];
                //发送接受信息
                e.recv = newsock.ReceiveFrom(e.data, ref Remote);
                if (owner != null)
                {
                    owner.BeginInvoke(owner.udpEvent, this, e);
                    
                }
            }
        }

    }
}
