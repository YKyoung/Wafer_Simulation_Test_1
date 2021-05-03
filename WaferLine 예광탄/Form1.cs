using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using WaferLlineLib;

namespace WaferLine_예광탄
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            waferLineControl1.Line = new WaferLine(1);
        }
    }
}
