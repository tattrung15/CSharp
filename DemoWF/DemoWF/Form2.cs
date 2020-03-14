using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWF
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddButton();
        }

        int i = 0;
        private void AddButton()
        {
            Random random = new Random();
            Button btn = new Button();
            btn.Text = i.ToString();
            btn.Location = new Point(random.Next(0, this.Size.Width),
                random.Next(0, this.Size.Height));
            btn.Click += Btn_Click;
            this.Controls.Add(btn);
            i++;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show(btn.Text);
        }
    }
}
