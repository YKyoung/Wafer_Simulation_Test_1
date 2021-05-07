using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaferLlineLib
{
    public delegate void AddPREventHandler(object sender, AddPREventArgs e);
    public class AddPREventArgs:EventArgs
    {
        public int No { get; }
        public int PCnt { get; }
        public AddPREventArgs(int no, int pcnt)
        {
            No = no;
            PCnt = pcnt;
        }

    }
}
