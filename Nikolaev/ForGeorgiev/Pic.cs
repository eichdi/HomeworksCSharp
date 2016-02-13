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
    public partial class Pic : Form
    {
        //string path;
        public void OpenPic(string path) {
            pictureBox1.Image = Image.FromFile(path);
            this.Visible = true;
        }
        public Pic()
        {
            InitializeComponent();
        }

        private void Pic_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            e.Cancel = true;
        }
    }
}
