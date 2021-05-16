
namespace 중앙_관제
{
    partial class CentralForm
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
            this.tbox_fa_ip = new System.Windows.Forms.TextBox();
            this.tbox_fa_port = new System.Windows.Forms.TextBox();
            this.btn_set_fa = new System.Windows.Forms.Button();
            this.btn_set_me = new System.Windows.Forms.Button();
            this.tbox_me_port = new System.Windows.Forms.TextBox();
            this.tbox_me_ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbar_wafer = new System.Windows.Forms.TrackBar();
            this.lb_wafer = new System.Windows.Forms.Label();
            this.btn_wafer = new System.Windows.Forms.Button();
            this.btn_pr = new System.Windows.Forms.Button();
            this.lb_pr = new System.Windows.Forms.Label();
            this.tbar_pr = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_npr = new System.Windows.Forms.Label();
            this.lb_spin = new System.Windows.Forms.Label();
            this.tbar_spin = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_drop = new System.Windows.Forms.Label();
            this.tbar_drop = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.lb_awafer = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lv_line = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.tbar_wafer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_pr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_spin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_drop)).BeginInit();
            this.SuspendLayout();
            // 
            // tbox_fa_ip
            // 
            this.tbox_fa_ip.Location = new System.Drawing.Point(22, 28);
            this.tbox_fa_ip.Name = "tbox_fa_ip";
            this.tbox_fa_ip.Size = new System.Drawing.Size(244, 21);
            this.tbox_fa_ip.TabIndex = 0;
            // 
            // tbox_fa_port
            // 
            this.tbox_fa_port.Location = new System.Drawing.Point(275, 28);
            this.tbox_fa_port.Name = "tbox_fa_port";
            this.tbox_fa_port.Size = new System.Drawing.Size(85, 21);
            this.tbox_fa_port.TabIndex = 1;
            // 
            // btn_set_fa
            // 
            this.btn_set_fa.Location = new System.Drawing.Point(375, 28);
            this.btn_set_fa.Name = "btn_set_fa";
            this.btn_set_fa.Size = new System.Drawing.Size(98, 20);
            this.btn_set_fa.TabIndex = 2;
            this.btn_set_fa.Text = "공장설정";
            this.btn_set_fa.UseVisualStyleBackColor = true;
            this.btn_set_fa.Click += new System.EventHandler(this.btn_set_fa_Click);
            // 
            // btn_set_me
            // 
            this.btn_set_me.Location = new System.Drawing.Point(375, 57);
            this.btn_set_me.Name = "btn_set_me";
            this.btn_set_me.Size = new System.Drawing.Size(98, 20);
            this.btn_set_me.TabIndex = 5;
            this.btn_set_me.Text = "중앙관제설정";
            this.btn_set_me.UseVisualStyleBackColor = true;
            this.btn_set_me.Click += new System.EventHandler(this.btn_set_me_Click);
            // 
            // tbox_me_port
            // 
            this.tbox_me_port.Location = new System.Drawing.Point(275, 55);
            this.tbox_me_port.Name = "tbox_me_port";
            this.tbox_me_port.Size = new System.Drawing.Size(85, 21);
            this.tbox_me_port.TabIndex = 4;
            // 
            // tbox_me_ip
            // 
            this.tbox_me_ip.Location = new System.Drawing.Point(22, 55);
            this.tbox_me_ip.Name = "tbox_me_ip";
            this.tbox_me_ip.ReadOnly = true;
            this.tbox_me_ip.Size = new System.Drawing.Size(244, 21);
            this.tbox_me_ip.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Wafer";
            // 
            // tbar_wafer
            // 
            this.tbar_wafer.Location = new System.Drawing.Point(324, 107);
            this.tbar_wafer.Maximum = 200;
            this.tbar_wafer.Name = "tbar_wafer";
            this.tbar_wafer.Size = new System.Drawing.Size(84, 45);
            this.tbar_wafer.TabIndex = 8;
            // 
            // lb_wafer
            // 
            this.lb_wafer.AutoSize = true;
            this.lb_wafer.Location = new System.Drawing.Point(423, 107);
            this.lb_wafer.Name = "lb_wafer";
            this.lb_wafer.Size = new System.Drawing.Size(11, 12);
            this.lb_wafer.TabIndex = 9;
            this.lb_wafer.Text = "0";
            // 
            // btn_wafer
            // 
            this.btn_wafer.Location = new System.Drawing.Point(467, 107);
            this.btn_wafer.Name = "btn_wafer";
            this.btn_wafer.Size = new System.Drawing.Size(82, 25);
            this.btn_wafer.TabIndex = 10;
            this.btn_wafer.Text = "투입";
            this.btn_wafer.UseVisualStyleBackColor = true;
            // 
            // btn_pr
            // 
            this.btn_pr.Location = new System.Drawing.Point(467, 151);
            this.btn_pr.Name = "btn_pr";
            this.btn_pr.Size = new System.Drawing.Size(82, 25);
            this.btn_pr.TabIndex = 14;
            this.btn_pr.Text = "투입";
            this.btn_pr.UseVisualStyleBackColor = true;
            // 
            // lb_pr
            // 
            this.lb_pr.AutoSize = true;
            this.lb_pr.Location = new System.Drawing.Point(423, 151);
            this.lb_pr.Name = "lb_pr";
            this.lb_pr.Size = new System.Drawing.Size(11, 12);
            this.lb_pr.TabIndex = 13;
            this.lb_pr.Text = "0";
            // 
            // tbar_pr
            // 
            this.tbar_pr.Location = new System.Drawing.Point(324, 151);
            this.tbar_pr.Maximum = 20;
            this.tbar_pr.Name = "tbar_pr";
            this.tbar_pr.Size = new System.Drawing.Size(84, 45);
            this.tbar_pr.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "코팅액";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "현재 코팅액:";
            // 
            // lb_npr
            // 
            this.lb_npr.AutoSize = true;
            this.lb_npr.Location = new System.Drawing.Point(360, 206);
            this.lb_npr.Name = "lb_npr";
            this.lb_npr.Size = new System.Drawing.Size(11, 12);
            this.lb_npr.TabIndex = 16;
            this.lb_npr.Text = "0";
            // 
            // lb_spin
            // 
            this.lb_spin.AutoSize = true;
            this.lb_spin.Location = new System.Drawing.Point(423, 250);
            this.lb_spin.Name = "lb_spin";
            this.lb_spin.Size = new System.Drawing.Size(29, 12);
            this.lb_spin.TabIndex = 19;
            this.lb_spin.Text = "1000";
            // 
            // tbar_spin
            // 
            this.tbar_spin.Location = new System.Drawing.Point(327, 250);
            this.tbar_spin.Maximum = 8000;
            this.tbar_spin.Minimum = 1000;
            this.tbar_spin.Name = "tbar_spin";
            this.tbar_spin.Size = new System.Drawing.Size(84, 45);
            this.tbar_spin.TabIndex = 18;
            this.tbar_spin.Value = 1000;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "회전 속도";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(485, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "rpm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(485, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 12);
            this.label10.TabIndex = 24;
            this.label10.Text = "ps";
            // 
            // lb_drop
            // 
            this.lb_drop.AutoSize = true;
            this.lb_drop.Location = new System.Drawing.Point(423, 301);
            this.lb_drop.Name = "lb_drop";
            this.lb_drop.Size = new System.Drawing.Size(17, 12);
            this.lb_drop.TabIndex = 23;
            this.lb_drop.Text = "20";
            // 
            // tbar_drop
            // 
            this.tbar_drop.Location = new System.Drawing.Point(327, 301);
            this.tbar_drop.Maximum = 100;
            this.tbar_drop.Minimum = 20;
            this.tbar_drop.Name = "tbar_drop";
            this.tbar_drop.Size = new System.Drawing.Size(84, 45);
            this.tbar_drop.TabIndex = 22;
            this.tbar_drop.Value = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(270, 303);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 12);
            this.label12.TabIndex = 21;
            this.label12.Text = "낙하 속도";
            // 
            // lb_awafer
            // 
            this.lb_awafer.AutoSize = true;
            this.lb_awafer.Location = new System.Drawing.Point(360, 359);
            this.lb_awafer.Name = "lb_awafer";
            this.lb_awafer.Size = new System.Drawing.Size(11, 12);
            this.lb_awafer.TabIndex = 26;
            this.lb_awafer.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(270, 359);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 12);
            this.label14.TabIndex = 25;
            this.label14.Text = "코팅할 Wafer";
            // 
            // lv_line
            // 
            this.lv_line.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lv_line.HideSelection = false;
            this.lv_line.Location = new System.Drawing.Point(25, 107);
            this.lv_line.Name = "lv_line";
            this.lv_line.Size = new System.Drawing.Size(222, 263);
            this.lv_line.TabIndex = 27;
            this.lv_line.UseCompatibleStateImageBehavior = false;
            this.lv_line.View = System.Windows.Forms.View.Details;
            this.lv_line.SelectedIndexChanged += new System.EventHandler(this.lv_line_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 83;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "코팅할 Wafer";
            this.columnHeader2.Width = 104;
            // 
            // CentralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 429);
            this.Controls.Add(this.lv_line);
            this.Controls.Add(this.lb_awafer);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lb_drop);
            this.Controls.Add(this.tbar_drop);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lb_spin);
            this.Controls.Add(this.tbar_spin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lb_npr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_pr);
            this.Controls.Add(this.lb_pr);
            this.Controls.Add(this.tbar_pr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_wafer);
            this.Controls.Add(this.lb_wafer);
            this.Controls.Add(this.tbar_wafer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_set_me);
            this.Controls.Add(this.tbox_me_port);
            this.Controls.Add(this.tbox_me_ip);
            this.Controls.Add(this.btn_set_fa);
            this.Controls.Add(this.tbox_fa_port);
            this.Controls.Add(this.tbox_fa_ip);
            this.Name = "CentralForm";
            this.Text = "중앙관제";
            this.Load += new System.EventHandler(this.CentralForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbar_wafer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_pr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_spin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_drop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_fa_ip;
        private System.Windows.Forms.TextBox tbox_fa_port;
        private System.Windows.Forms.Button btn_set_fa;
        private System.Windows.Forms.Button btn_set_me;
        private System.Windows.Forms.TextBox tbox_me_port;
        private System.Windows.Forms.TextBox tbox_me_ip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbar_wafer;
        private System.Windows.Forms.Label lb_wafer;
        private System.Windows.Forms.Button btn_wafer;
        private System.Windows.Forms.Button btn_pr;
        private System.Windows.Forms.Label lb_pr;
        private System.Windows.Forms.TrackBar tbar_pr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_npr;
        private System.Windows.Forms.Label lb_spin;
        private System.Windows.Forms.TrackBar tbar_spin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_drop;
        private System.Windows.Forms.TrackBar tbar_drop;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lb_awafer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListView lv_line;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

