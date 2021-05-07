using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaferLlineLib
{
    public delegate void AddWaferEventHandler(object sender, AddWaferEventArgs e);
    public class AddWaferEventArgs : EventArgs
    {
        public int No { get; }
        public int BWCnt { get; }

        public AddWaferEventArgs(int no, int bwcnt)
        {
            No = no;
            BWCnt = bwcnt;
        }      
    }
}
