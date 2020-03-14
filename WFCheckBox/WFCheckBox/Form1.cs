using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            string nam = ckbSex.CheckState == CheckState.Checked ? "là nam" :
                ckbSex.CheckState == CheckState.Unchecked ?
                "là nữ" : "không phải nam không phải nữ";
            MessageBox.Show("Chào bạn " + name + ", bạn " + nam, "Caption", MessageBoxButtons.YesNoCancel,
                                MessageBoxIcon.Information);
        }
    }
}
