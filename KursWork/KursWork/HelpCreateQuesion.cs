using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KursWork
{
    public partial class HelpCreateQuesion : Form
    {
        public HelpCreateQuesion()
        {
            InitializeComponent();
            StreamReader LableReader = new StreamReader("HelpCreateQuesion.txt");
            label1.Text = LableReader.ReadToEnd();
            LableReader.Close();
        }

    }
}
