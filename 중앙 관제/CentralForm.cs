using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaferLineCommLib;
using WaferLlineLib;

namespace 중앙_관제
{
    public partial class CentralForm : Form
    {
        public CentralForm()
        {
            InitializeComponent();       
        }

        private void CentralForm_Load(object sender, EventArgs e)
        {
            IPAddress defaddr = MyNetwork.Addresses[0];
            tbox_me_ip.Text = defaddr.ToString();
        }

        FactoryClient fc;
        private void btn_set_fa_Click(object sender, EventArgs e)
        {
            string fip = tbox_fa_ip.Text;
            int fport = int.Parse(tbox_fa_port.Text);
            fc = new FactoryClient(fip, fport);

        }       

        private void btn_set_me_Click(object sender, EventArgs e)
        {
            string ip = tbox_me_ip.Text;
            int port = int.Parse(tbox_me_port.Text);
            ControlServer cs = new ControlServer(ip, port);
            cs.AddedLine += Cs_AddedLine;
            cs.AddedWafer += Cs_AddedWafer;
            cs.AddedPR += Cs_AddedPR;
            cs.SettedSpeed += Cs_SettedSpeed;
            cs.SettedDrop += Cs_SettedDrop;
            cs.EndedPR += Cs_EndedPR;
            cs.EndedCoating += Cs_EndedCoating;
            cs.AsyncStart();
            fc.SendMyInfo(ip, port);
        }

        private void Cs_EndedCoating(object sender, EndCoatingEventArgs e)
        {
            if (this.InvokeRequired)
            {
                EndCoatingEvntHandler dele = Cs_EndedCoating;
                this.Invoke(dele, new object[] { sender, e });
            }
            else
            {
                ListViewItem lvi = lvi_dic[e.No];
                WaferLine wl = lvi.Tag as WaferLine;
                wl.EndCoating(e.BWCnt, e.AWCnt);
                lvi.SubItems[1].Text = e.BWCnt.ToString();
                if (lvi.Selected)
                {
                    //lvi.SubItems[1].Text = e.BWCnt.ToString();
                    lb_awafer.Text = e.AWCnt.ToString();
                }            
            }
        }

        private void Cs_EndedPR(object sender, EndPREventArgs e)
        {
            if (this.InvokeRequired)
            {
                EndPREventHandler dele = Cs_EndedPR;
                this.Invoke(dele, new object[] { sender, e });
            }
            else
            {
                ListViewItem lvi = lvi_dic[e.No];
                WaferLine wl = lvi.Tag as WaferLine;
                wl.PCnt--;
                if (lvi.Selected)
                {
                    lb_npr.Text = wl.PCnt.ToString();
                }
            }
        }

        private void Cs_SettedDrop(object sender, SetDropEventArgs e)
        {
            if (this.InvokeRequired)
            {
                SetDropEventHandler dele = Cs_SettedDrop;
                this.Invoke(dele, new object[] { sender, e });
            }
            else
            {
                ListViewItem lvi = lvi_dic[e.No];
                WaferLine wl = lvi.Tag as WaferLine;
                wl.Drop = e.Drop;
                if (lvi.Selected)
                {
                    lb_drop.Text = e.Drop.ToString();
                    tbar_drop.Value = e.Drop;
                }
            }
        }

        private void Cs_SettedSpeed(object sender, SetSpeedEventArgs e)
        {
            if (this.InvokeRequired)
            {
                SetSpeedEventHandler dele = Cs_SettedSpeed;
                this.Invoke(dele, new object[] { sender, e });
            }
            else
            {
                ListViewItem lvi = lvi_dic[e.No];
                WaferLine wl = lvi.Tag as WaferLine;
                wl.Spin = e.Speed;
                if (lvi.Selected)
                {
                    lb_spin.Text = e.Speed.ToString();
                    tbar_spin.Value = e.Speed;
                }
            }
        }

        private void Cs_AddedPR(object sender, AddPREventArgs e)
        {
            if (this.InvokeRequired)
            {
                AddPREventHandler dele = Cs_AddedPR;
                this.Invoke(dele, new object[] { sender, e });
            }
            else
            {
                ListViewItem lvi = lvi_dic[e.No];
                WaferLine wl = lvi.Tag as WaferLine;
                int gap = e.PCnt-wl.PCnt;
                wl.InPr(gap);
                if (lv_line.SelectedItems.Count == 0) { return; }
                if (lvi==lv_line.SelectedItems[0])
                {
                    lb_npr.Text = wl.PCnt.ToString();
                }
            }
        }

        private void Cs_AddedWafer(object sender, AddWaferEventArgs e)
        {
            if (this.InvokeRequired)
            {
                AddWaferEventHandler dele = Cs_AddedWafer;
                this.Invoke(dele, new object[] { sender, e });
            }
            else
            {
                ListViewItem lvi = lvi_dic[e.No];
                lvi.SubItems[1].Text = e.BWCnt.ToString();
                WaferLine wl = lvi.Tag as WaferLine;
                int gap = e.BWCnt - wl.BWCnt;
                wl.InWafer(gap);
            }
        }


        Dictionary<int, ListViewItem> lvi_dic = new Dictionary<int, ListViewItem>();
        private void Cs_AddedLine(object sender, AddLineEventArgs e)
        {
            if (this.InvokeRequired)
            {
                AddLineEventHandler dele = Cs_AddedLine;
                this.Invoke(dele, new object[] { sender, e });
            }
            else
            {
                string[] sitems = new string[] { e.No.ToString(), "0" };
                ListViewItem lvi = new ListViewItem(sitems);
                lv_line.Items.Add(lvi);
                lvi_dic[e.No] = lvi;
                WaferLine wl = new WaferLine(e.No);
                lvi.Tag = wl;
            }
        }

        private void lv_line_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_line.SelectedItems.Count == 0)
            {
                SetLineControl(false);
                return;
            }
            SetLineControl(true);
            ListViewItem lvi = lv_line.SelectedItems[0];
            WaferLine wl = lvi.Tag as WaferLine;
            lb_npr.Text = wl.PCnt.ToString();
            tbar_spin.Value = wl.Spin;
            tbar_drop.Value = wl.Drop;
            lb_spin.Text = wl.Spin.ToString();
            lb_drop.Text = wl.Drop.ToString();
        }

        private void SetLineControl(bool flag)
        {
            tbar_wafer.Enabled = flag;
            tbar_pr.Enabled = flag;
            tbar_spin.Enabled = flag;
            tbar_drop.Enabled = flag;
            btn_wafer.Enabled = flag;
            btn_pr.Enabled = flag;
        }
    }
}
