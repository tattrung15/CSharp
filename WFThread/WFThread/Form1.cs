using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WFThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(ShowInfo);
            thread.IsBackground = true;
            thread.Start();
        }

        void ShowInfo()
        {
            for(int i = 0; i < 50000; i++)
            {
                label1.Text = i.ToString();
                Thread.Sleep(50);
            }
        }

        int speed;

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Nhập tốc độ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
            }
            else
            {
                new Thread(() =>
                {
                    while (true)
                    {
                        if (checkBox1.Checked)
                        {
                            pictureBox1.Location = new Point(pictureBox1.Location.X - 1,
                                pictureBox1.Location.Y);
                        }
                        else
                        {
                            pictureBox1.Location = new Point(pictureBox1.Location.X + 1,
                                pictureBox1.Location.Y);
                        }
                        Thread.Sleep(speed);
                    }
                }) { IsBackground = true }.Start();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                speed = int.Parse(textBox1.Text);
            }
        }
    }
}
