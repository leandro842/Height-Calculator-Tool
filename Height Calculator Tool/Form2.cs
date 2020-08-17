using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Height_Calculator_Tool
{
    public partial class Form2 : Form
    {
        private Form1 _frm1 = null;
        public Form2(Form frm)
        {
            _frm1 = frm as Form1;
            InitializeComponent();
            this.label1.Text = ("Your height is " + Form1.txtBox_value.ToString() + " cm!");
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            _frm1.Enabled = true;
        }
    }
}
