﻿
namespace WaferLine_공장_시뮬레이젼
{
    partial class WaferLineForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wlc = new WaferLineControlLib.WaferLineControl();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_no = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wlc
            // 
            this.wlc.Line = null;
            this.wlc.Location = new System.Drawing.Point(-2, 54);
            this.wlc.Name = "wlc";
            this.wlc.Size = new System.Drawing.Size(687, 462);
            this.wlc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "WaferLine 번호";
            // 
            // lb_no
            // 
            this.lb_no.AutoSize = true;
            this.lb_no.Location = new System.Drawing.Point(118, 21);
            this.lb_no.Name = "lb_no";
            this.lb_no.Size = new System.Drawing.Size(21, 12);
            this.lb_no.TabIndex = 2;
            this.lb_no.Text = "No";
            // 
            // WaferLineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 516);
            this.Controls.Add(this.lb_no);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wlc);
            this.Name = "WaferLineForm";
            this.Text = "WaferLineForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WaferLineControlLib.WaferLineControl wlc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_no;
    }
}