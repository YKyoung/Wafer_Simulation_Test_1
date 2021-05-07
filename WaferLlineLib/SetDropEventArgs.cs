using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaferLlineLib
{
    public delegate void SetDropEventHandler(object sender, SetDropEventArgs e);
    public class SetDropEventArgs
    {
        public int No { get; }
        public int Drop { get; }
        public SetDropEventArgs(int no, int drop)
        {
            No = no;
            Drop = drop;
        }
    }
}
