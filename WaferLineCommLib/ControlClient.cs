using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WaferLineCommLib
{
    public class ControlClient
    {
        IPAddress cip;
        int cport;
        public ControlClient(IPAddress cip, int cport)
        {
            this.cip = cip;
            this.cport = cport;
        }
        public bool SendAddWafer(int no, int bwcnt)
        {
            byte[] packet = new byte[128];
            MemoryStream ms = new MemoryStream(packet);
            BinaryWriter bw = new BinaryWriter(ms);
            bw.Write((int)MsgType.MSG_FC_ADDWF);
            bw.Write(no);
            bw.Write(bwcnt);
            bw.Close();
            ms.Close();
            return SendPacket(packet);

        }
        public bool SendAddLine(int no)
        {
            byte[] packet = new byte[128];
            MemoryStream ms = new MemoryStream(packet);
            BinaryWriter bw = new BinaryWriter(ms);
            bw.Write((int)MsgType.MSG_FC_ADDLN);
            bw.Write(no);
            bw.Close();
            ms.Close();
            return SendPacket(packet);
        }
        bool SendPacket(byte[] packet)
        {
            try
            {
                Socket sock = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ep = new IPEndPoint(cip, cport);
                sock.Connect(ep);
                sock.Send(packet);
                sock.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
