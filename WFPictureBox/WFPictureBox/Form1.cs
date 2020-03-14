using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFPictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadImageName();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Resources\\a.jpg");
        }

        void LoadImageName()
        {
            List<string> list = new List<string>() { "a.jpg", "b.jpg", "c.jpg", "d.jpg" };
            comboBox1.DataSource = list;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if(cb.SelectedValue != null)
            {
                Bitmap bm = new Bitmap(Application.StartupPath +
                                "\\Resources\\" + cb.SelectedValue.ToString());
                pictureBox1.Image = bm;
            }
        }
    }
}
