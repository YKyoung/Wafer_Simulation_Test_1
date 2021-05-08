using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaferLineCommLib
{
    public delegate void AddLineEventHandler(object sender, AddLineEventArgs e);
    public class AddLineEventArgs:EventArgs
    {
        public int No { get; }
        public AddLineEventArgs(int no)
        {
            No = no;
        } 
        
    }
}
