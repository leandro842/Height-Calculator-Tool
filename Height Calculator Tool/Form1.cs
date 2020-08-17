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
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        public static int txtBox_value = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txtBox_value = Convert.ToInt16(this.textBox1.Text);
                Form2 form2 = new Form2(this);
                form2.Show();
                this.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Input a valid height!");
            }

        }
    }
}
