using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaferLlineLib;

namespace WaferLine_공장_시뮬레이젼
{
    public partial class WaferLineForm : Form
    {

        public event AddWaferEventHandler AddedWafer;
        public event AddPREventHandler AddedPR;
        public event SetSpeedEventHandler SettedSpeed;
        public event SetDropEventHandler SettedDrop;
        public event EndPREventHandler EndedPR;
        public event EndCoatingEvntHandler EndedCoating;
        public WaferLine WLine { get; }
        public int No { get { return WLine.No; } }
        public WaferLineForm(WaferLine wl)
        {
            InitializeComponent();
            WLine = wl;
            WLine.AddedWafer += WLine_AddedWafer;
            WLine.AddedPR += WLine_AddedPR;
            WLine.EndedCoating += WLine_EndedCoating;
            WLine.EndedPR += WLine_EndedPR;
            WLine.SettedSpeed += WLine_SettedSpeed;
            WLine.SettedDrop += WLine_SettedDrop;

        }

        private void WLine_SettedDrop(object sender, SetDropEventArgs e)
        {
            if (SettedDrop != null)
            {
                SettedDrop(this, e);
            }
        }

        private void WLine_SettedSpeed(object sender, SetSpeedEventArgs e)
        {
            if(SettedSpeed != null)
            {
                SettedSpeed(this, e);
            }

        }

        private void WLine_EndedPR(object sender, EndPREventArgs e)
        {
            if (EndedPR != null)
            {
                EndedPR(this, e);
            }
        }

        private void WLine_EndedCoating(object sender, EndCoatingEventArgs e)
        {
            if (EndedCoating != null)
            {
                EndedCoating(this, e);
            }
        }

        private void WLine_AddedPR(object sender, AddPREventArgs e)
        {
            if (AddedPR != null)
            {
                AddedPR(this, e);
            }
        }

        private void WLine_AddedWafer(object sender, AddWaferEventArgs e)
        {
            if (AddedWafer != null)
            {
                AddedWafer(this, e);
            }
        }

        private void WaferLineForm_Load(object sender, EventArgs e)
        {
            lb_no.Text = No.ToString();
            wlc.Line = WLine;
        }

        private void WaferLineForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
