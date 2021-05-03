using System.Windows.Forms;

namespace WaferLineControlLib
{
    public class DPanel : Panel
    {
        public DPanel()
        {
            SetStyle(System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer |
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();
        }
    }
}
