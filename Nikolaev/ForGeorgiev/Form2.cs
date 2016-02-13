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
    public partial class Form2 : Form
    {
        Pic pic;
        public Form2()
        {
            InitializeComponent();
            pic = new Pic();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pic.OpenPic(@"img\1.1.jpg");
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            e.Cancel = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pic.OpenPic(@"img\1.2.jpg");
        }
    }
}
