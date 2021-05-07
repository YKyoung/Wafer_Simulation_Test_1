using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaferLineCommLib;
using WaferLlineLib;

namespace WaferLine_공장_시뮬레이젼
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        int next_lineno = 1;
        Dictionary<int, WaferLineForm> wdic = new Dictionary<int, WaferLineForm>();

        private void btn_add_Click(object sender, EventArgs e)
        {
            int no = next_lineno;
            next_lineno++;
            WaferLine wl = new WaferLine(no);
            string[] sitems = new string[] { no.ToString(), "0", "0" };
            ListViewItem lvi = new ListViewItem(sitems);
            lvi.Tag = wl;
            lv_line.Items.Add(lvi);
            cb_line.Items.Add(wl);
            lb_next_no.Text = next_lineno.ToString();
            WaferLineForm wlf = new WaferLineForm(wl);
            wlf.EndedCoating += Wlf_EndedCoating;
            wlf.AddedWafer += Wlf_AddedWafer;
            wlf.AddedPR += Wlf_AddedPR;
            wlf.SettedSpeed += Wlf_SettedSpeed;
            wlf.SettedDrop += Wlf_SettedDrop;
            wlf.EndedPR += Wlf_EndedPR;
            wdic.Add(no, wlf);
        }

        private void Wlf_EndedPR(object sender, EndPREventArgs e)
        {
            ListViewItem lvi = lv_line.Items[e.No - 1];
            if (lvi.Selected)
            {
                WaferLine wl = lvi.Tag as WaferLine;
                lb_pr.Text = wl.PCnt.ToString();

            }
        }

        private void Wlf_SettedDrop(object sender, SetDropEventArgs e)
        {
            ChangeStatusSelectedWaferLine(e.No);
        }

        private void ChangeStatusSelectedWaferLine(int no)
        {
            ListViewItem lvi = lv_line.Items[no - 1];
            if (lvi.Selected)
            {
                WaferLine wl = lvi.Tag as WaferLine;
                lb_spin.Text = wl.Spin.ToString();
                lb_drop.Text = wl.Drop.ToString();
                lb_pr.Text = wl.PCnt.ToString();
            }
        }

        private void Wlf_SettedSpeed(object sender, SetSpeedEventArgs e)
        {
            ChangeStatusSelectedWaferLine(e.No);
        }

        private void Wlf_AddedPR(object sender, AddPREventArgs e)
        {
            ChangeStatusSelectedWaferLine(e.No);
        }

        private void Wlf_AddedWafer(object sender, AddWaferEventArgs e)
        {
            ChangeStatusWaferLine(e.No);
        }

        private void ChangeStatusWaferLine(int no)
        {
            ListViewItem lvi = lv_line.Items[no - 1];
            WaferLine wl = lvi.Tag as WaferLine;
            lvi.SubItems[1].Text = wl.BWCnt.ToString();
            lvi.SubItems[2].Text = wl.AWCnt.ToString();
            cb_line.Items[no - 1] = wl;
        }

        private void Wlf_EndedCoating(object sender, EndCoatingEventArgs e)
        {
            ChangeStatusWaferLine(e.No);
            ListViewItem lvi = lv_line.Items[e.No - 1];
            if(lvi.Selected)
            {
                WaferLine wl = lvi.Tag as WaferLine;
                cb_awafer.Items.Add(wl.LastWafer);
                lb_pr.Text = wl.PCnt.ToString();
            }
            

        }

        private void btn_manage_Click(object sender, EventArgs e)
        {
            if(cb_line.SelectedIndex == -1)
            {
                return;
            }
            WaferLine wl = cb_line.SelectedItem as WaferLine;
            if (wdic[wl.No].Visible == false)
            {
                wdic[wl.No].Show();
            }
        }

        private void cb_awafer_SelectedIndexChanged(object sender, EventArgs e)
        {
            pn_awafer.Wafer = cb_awafer.SelectedItem as Wafer;
            pn_awafer.Invalidate();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbox_ip.DataSource = MyNetwork.Addresses;
        }
    }
}
