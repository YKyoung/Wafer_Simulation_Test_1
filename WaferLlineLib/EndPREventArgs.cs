using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaferLlineLib
{
    public delegate void EndPREventHandler(object sender, EndPREventArgs e);
    public class EndPREventArgs
    {
        public int No { get; }
        public EndPREventArgs(int no)
        {
            No = no;
        }

    }
}
