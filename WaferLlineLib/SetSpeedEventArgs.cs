using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaferLlineLib
{
    public delegate void SetSpeedEventHandler(object sender, SetSpeedEventArgs e);

    public class SetSpeedEventArgs
    {
        public int No { get; }
        public int Speed { get; }
        public SetSpeedEventArgs(int no, int speed)
        {
            No = no;
            Speed = speed;
        }
    }
}
