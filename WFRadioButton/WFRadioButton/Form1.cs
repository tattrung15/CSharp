using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFRadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ShowResult(Label label, Panel panel)
        {
            RadioButton radioButton = null;

            foreach(RadioButton item in panel.Controls)
            {
                if(item != null)
                {
                    if (item.Checked)
                    {
                        radioButton = item;
                        break;
                    }
                }
            }

            if (radioButton != null)
            {
                label.Text = radioButton.Text;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ShowResult(label1, pnl1);
            ShowResult(label2, pnl2);
            ShowResult(label3, pnl3);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}
