using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaferLlineLib
{
    public delegate void EndCoatingEvntHandler(object sender, EndCoatingEventArgs e);
    public class EndCoatingEventArgs
    {
        public int No { get; }
        public int BWCnt { get; }
        public int AWCnt { get; }
        public EndCoatingEventArgs(int no, int bwcnt, int awcnt)
        {
            No = no;
            BWCnt = bwcnt;
            AWCnt = awcnt;
        }
    }
}
