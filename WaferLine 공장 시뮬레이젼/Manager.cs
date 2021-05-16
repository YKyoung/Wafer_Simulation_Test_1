using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WaferLineCommLib;

namespace WaferLine_공장_시뮬레이젼
{
    public class Manager
    {
        public event RecvStsEndPtEventHandler RecvStsEndPoint;
        private Manager()
        {

        }
        static Manager manager = new Manager();
        public static Manager Singleton 
        { 
            get
            {
                return manager;
            } 
        }
        public void StartServer(string ip, int port)
        {
            FactoryServer fs = new FactoryServer(ip, port);
            fs.RecvStsEndPoint += Fs_RecvStsEndPoint;
            fs.AsyncStart();
        }

        ControlClient cc;
        private void Fs_RecvStsEndPoint(object sender, RecvStsEndPtEventArgs e)
        {
            IPAddress cip = e.IPAddress;
            int cport = e.Port;
            cc = new ControlClient(cip, cport);
            if (RecvStsEndPoint != null)
            {
                RecvStsEndPoint(this, e);
            }
        }

        public void AddLine(int no)
        {
            if (cc == null)
            {
                return;
            }
            if (cc.SendAddLine(no) == false)
            {
                cc = null;
            }
        }

        public void AddWafer(int no, int bwcnt)
        {
            if (cc == null)
            {
                return;
            }
            if (cc.SendAddWafer(no, bwcnt) == false)
            {
                cc = null;
            }
        }

        public void AddPR(int no, int pcnt)
        {
            if (cc == null)
            {
                return;
            }
            if (cc.SendAddPR(no, pcnt) == false)
            {
                cc = null;
            }
        }

        public void SetSpeed(int no, int spin)
        {
            if (cc == null)
            {
                return;
            }
            if (cc.SendSetSpeed(no, spin) == false)
            {
                cc = null;
            }
        }

        public void SetDrop(int no, int drop)
        {
            if (cc == null)
            {
                return;
            }
            if (cc.SendSetDrop(no, drop) == false)
            {
                cc = null;
            };
        }

        public void EndedPR(int no)
        {
            if (cc == null)
            {
                return;
            }
            if (cc.SendEndPR(no) == false)
            {
                cc = null;
            }
        }

        public void EndedCoarting(int no, int bwcnt, int awcnt)
        {
            if (cc == null)
            {
                return;
            }
            if (cc.SendEndCoating(no, bwcnt, awcnt) == false)
            {
                cc = null;
            }
        }
    }
}
