using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WFProcess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.ScrollBars = ScrollBars.Vertical;
        }

        private void btnGetProc_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses();
            foreach(Process item in processes)
            {
                textBox1.Text = item.ProcessName + "\n" + textBox1.Text;
            }
        }
    }
}
