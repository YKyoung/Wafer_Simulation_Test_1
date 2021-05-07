
namespace WaferLine_공장_시뮬레이젼
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbox_ip = new System.Windows.Forms.ComboBox();
            this.tbox_port = new System.Windows.Forms.TextBox();
            this.btn_set = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_line = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.lb_next_no = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_selno = new System.Windows.Forms.Label();
            this.cb_awafer = new System.Windows.Forms.ComboBox();
            this.lb_spin = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_drop = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_pr = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_line = new System.Windows.Forms.ComboBox();
            this.btn_manage = new System.Windows.Forms.Button();
            this.ts_lb2 = new System.Windows.Forms.StatusStrip();
            this.ts_lb = new System.Windows.Forms.ToolStripStatusLabel();
            this.pn_awafer = new WaferLineControlLib.WaferPanel();
            this.ts_lb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbox_ip
            // 
            this.cbox_ip.FormattingEnabled = true;
            this.cbox_ip.Location = new System.Drawing.Point(33, 25);
            this.cbox_ip.Name = "cbox_ip";
            this.cbox_ip.Size = new System.Drawing.Size(274, 20);
            this.cbox_ip.TabIndex = 0;
            // 
            // tbox_port
            // 
            this.tbox_port.Location = new System.Drawing.Point(326, 25);
            this.tbox_port.Name = "tbox_port";
            this.tbox_port.Size = new System.Drawing.Size(95, 21);
            this.tbox_port.TabIndex = 1;
            // 
            // btn_set
            // 
            this.btn_set.Location = new System.Drawing.Point(451, 22);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(84, 25);
            this.btn_set.TabIndex = 2;
            this.btn_set.Text = "설정";
            this.btn_set.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "라인";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(33, 130);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(274, 188);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 38;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "코팅 전";
            this.columnHeader2.Width = 59;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "코팅 후";
            this.columnHeader3.Width = 58;
            // 
            // lv_line
            // 
            this.lv_line.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lv_line.FullRowSelect = true;
            this.lv_line.HideSelection = false;
            this.lv_line.Location = new System.Drawing.Point(33, 130);
            this.lv_line.MultiSelect = false;
            this.lv_line.Name = "lv_line";
            this.lv_line.Size = new System.Drawing.Size(274, 229);
            this.lv_line.TabIndex = 4;
            this.lv_line.UseCompatibleStateImageBehavior = false;
            this.lv_line.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "No";
            this.columnHeader4.Width = 66;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "코팅 전";
            this.columnHeader5.Width = 96;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "코팅 후";
            this.columnHeader6.Width = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "다음 라인";
            // 
            // lb_next_no
            // 
            this.lb_next_no.AutoSize = true;
            this.lb_next_no.Location = new System.Drawing.Point(122, 390);
            this.lb_next_no.Name = "lb_next_no";
            this.lb_next_no.Size = new System.Drawing.Size(11, 12);
            this.lb_next_no.TabIndex = 6;
            this.lb_next_no.Text = "1";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(189, 382);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(72, 29);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "추가";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "선택한 라인";
            // 
            // lb_selno
            // 
            this.lb_selno.AutoSize = true;
            this.lb_selno.Location = new System.Drawing.Point(399, 91);
            this.lb_selno.Name = "lb_selno";
            this.lb_selno.Size = new System.Drawing.Size(11, 12);
            this.lb_selno.TabIndex = 9;
            this.lb_selno.Text = "0";
            // 
            // cb_awafer
            // 
            this.cb_awafer.FormattingEnabled = true;
            this.cb_awafer.Location = new System.Drawing.Point(331, 131);
            this.cb_awafer.Name = "cb_awafer";
            this.cb_awafer.Size = new System.Drawing.Size(144, 20);
            this.cb_awafer.TabIndex = 10;
            this.cb_awafer.SelectedIndexChanged += new System.EventHandler(this.cb_awafer_SelectedIndexChanged);
            // 
            // lb_spin
            // 
            this.lb_spin.AutoSize = true;
            this.lb_spin.Location = new System.Drawing.Point(575, 184);
            this.lb_spin.Name = "lb_spin";
            this.lb_spin.Size = new System.Drawing.Size(29, 12);
            this.lb_spin.TabIndex = 13;
            this.lb_spin.Text = "2000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(516, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "Spin";
            // 
            // lb_drop
            // 
            this.lb_drop.AutoSize = true;
            this.lb_drop.Location = new System.Drawing.Point(575, 223);
            this.lb_drop.Name = "lb_drop";
            this.lb_drop.Size = new System.Drawing.Size(23, 12);
            this.lb_drop.TabIndex = 15;
            this.lb_drop.Text = "100";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(516, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "Drop";
            // 
            // lb_pr
            // 
            this.lb_pr.AutoSize = true;
            this.lb_pr.Location = new System.Drawing.Point(575, 268);
            this.lb_pr.Name = "lb_pr";
            this.lb_pr.Size = new System.Drawing.Size(11, 12);
            this.lb_pr.TabIndex = 17;
            this.lb_pr.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(516, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 16;
            this.label11.Text = "코팅액";
            // 
            // cb_line
            // 
            this.cb_line.FormattingEnabled = true;
            this.cb_line.Location = new System.Drawing.Point(326, 387);
            this.cb_line.Name = "cb_line";
            this.cb_line.Size = new System.Drawing.Size(191, 20);
            this.cb_line.TabIndex = 18;
            // 
            // btn_manage
            // 
            this.btn_manage.Location = new System.Drawing.Point(553, 385);
            this.btn_manage.Name = "btn_manage";
            this.btn_manage.Size = new System.Drawing.Size(86, 25);
            this.btn_manage.TabIndex = 19;
            this.btn_manage.Text = "관리";
            this.btn_manage.UseVisualStyleBackColor = true;
            this.btn_manage.Click += new System.EventHandler(this.btn_manage_Click);
            // 
            // ts_lb2
            // 
            this.ts_lb2.Enabled = false;
            this.ts_lb2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_lb});
            this.ts_lb2.Location = new System.Drawing.Point(0, 428);
            this.ts_lb2.Name = "ts_lb2";
            this.ts_lb2.Size = new System.Drawing.Size(671, 22);
            this.ts_lb2.TabIndex = 20;
            // 
            // ts_lb
            // 
            this.ts_lb.Name = "ts_lb";
            this.ts_lb.Size = new System.Drawing.Size(218, 17);
            this.ts_lb.Text = "가장 최근에 발생한 사건을 보여줍니다.";
            // 
            // pn_awafer
            // 
            this.pn_awafer.Location = new System.Drawing.Point(331, 184);
            this.pn_awafer.Name = "pn_awafer";
            this.pn_awafer.Size = new System.Drawing.Size(144, 144);
            this.pn_awafer.TabIndex = 11;
            this.pn_awafer.Wafer = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.ts_lb2);
            this.Controls.Add(this.btn_manage);
            this.Controls.Add(this.cb_line);
            this.Controls.Add(this.lb_pr);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lb_drop);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lb_spin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pn_awafer);
            this.Controls.Add(this.cb_awafer);
            this.Controls.Add(this.lb_selno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lb_next_no);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lv_line);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_set);
            this.Controls.Add(this.tbox_port);
            this.Controls.Add(this.cbox_ip);
            this.Name = "MainForm";
            this.Text = "WaferLine 공장 Main Form";
            this.ts_lb2.ResumeLayout(false);
            this.ts_lb2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbox_ip;
        private System.Windows.Forms.TextBox tbox_port;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lv_line;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_next_no;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_selno;
        private System.Windows.Forms.ComboBox cb_awafer;
        private WaferLineControlLib.WaferPanel pn_awafer;
        private System.Windows.Forms.Label lb_spin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_drop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_pr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_line;
        private System.Windows.Forms.Button btn_manage;
        private System.Windows.Forms.StatusStrip ts_lb2;
        private System.Windows.Forms.ToolStripStatusLabel ts_lb;
    }
}

