using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaferLlineLib;

namespace WaferLlineLib
{
    public class WaferLine : IEnumerable<Wafer>
    {

        public event AddWaferEventHandler AddedWafer;
        public event AddPREventHandler AddedPR;
        public event SetSpeedEventHandler SettedSpeed;
        public event SetDropEventHandler SettedDrop;
        public event EndPREventHandler EndedPR;
        public event EndCoatingEvntHandler EndedCoating;
        public int No { get; }
        public int Spin
        {
            get;
            set;
        }
        public int Drop
        {
            get;
            set;
        }
        public WaferLine(int no)
        {
            No = no;
            Spin = 1000;
            Drop = 20;
        }
        List<Wafer> bwafers = new List<Wafer>();
        List<Wafer> awafers = new List<Wafer>();
        public Wafer LastWafer
        {
            get
            {
                if (awafers.Count == 0)
                {
                    return null;
                }
                return awafers[awafers.Count - 1];
            }
        }
        public void EndCoating(int bwcnt, int awcnt)
        {
            while (bwafers.Count > bwcnt)
            {
                bwafers.RemoveAt(0);
            }
            while (awafers.Count < awcnt)
            {
                awafers.Add(null);
            }
        }
        Wafer nwafer;
        int nowp; // 1병은 1000 셀을 코팅할 수 있다,
        public Wafer Now
        {
            get
            {
                return nwafer;
            }
        }
        public int BWCnt
        {
            get { return bwafers.Count; }
        }
        public int InWafer(int wcnt)
        {
            int avail = 200 - BWCnt;
            if (wcnt > avail)
            {
                wcnt = avail;
            }
            for (int i = 0; i < wcnt; i++)
            {
                bwafers.Add(new Wafer());
            }
            if(AddedWafer != null)
            {
                AddedWafer(this, new AddWaferEventArgs(No, BWCnt));
            }
            
            return bwafers.Count;
        }
        public int AWCnt
        {
            get { return awafers.Count; }
        }
        public int PCnt { get; set; }
        public int NPcnt { get { return nowp; } }

        public int InPr(int pcnt)
        {
            int avail = 20 - PCnt;
            if (pcnt > avail)
            {
                pcnt = avail;
            }
            PCnt += pcnt;
            if(AddedPR != null)
            {
                AddedPR(this, new AddPREventArgs(No, PCnt));
            }
            return PCnt;
        }
        public void SetSpin(int spin)
        {
            Spin = spin;
            if(SettedSpeed != null)
            {
                SettedSpeed(this, new SetSpeedEventArgs(No, spin));
            }
        }
        public void SetDrop(int drop)
        {
            Drop = drop;
            if (SettedDrop != null)
            {
                SettedDrop(this, new SetDropEventArgs(No, drop));
            }
        }

        Random rand = new Random();
        public bool Coating()
        {
            if (nowp == 0)
            {
                if (EndedPR != null)
                {
                    EndedPR(this, new EndPREventArgs(No));
                }
                if (PCnt == 0)
                {
                    return false;
                }
                nowp = 1000;
                PCnt--;
            }
            if (nwafer == null)
            {
                if (bwafers.Count == 0)
                {
                    return false;
                }
                nwafer = bwafers[0];
                bwafers.RemoveAt(0);
            }
            nwafer.Coating(rand.Next(70, 100));
            nowp--;
            if (nwafer.Increment() == false)
            {
                awafers.Add(nwafer);
                nwafer = null;
                if (EndedCoating != null)
                {
                    EndedCoating(this, new EndCoatingEventArgs(No, BWCnt, AWCnt));
                }
            }
            return true;
        }
        public override string ToString()
        {
            return string.Format("WaferLine No:{0}", No);
        }

        public IEnumerator<Wafer> GetEnumerator()
        {
            return awafers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return awafers.GetEnumerator();
        }
    }
}
