using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForGeorgiev
{
    public partial class Form3 : Form
    {
        Pic pic;
        public Form3()
        {
            InitializeComponent();
            pic = new Pic();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pic.OpenPic(@"img\2.1.jpg");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pic.OpenPic(@"img\2.2.jpg");
        }
    }
}
