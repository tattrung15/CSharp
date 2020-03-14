using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadListView();
        }

        ImageList imgListSmall;
        ImageList imgListLarge;

        void LoadListImage()
        {
            imgListSmall = new ImageList() { ImageSize = new Size(16, 16) };
            imgListSmall.Images.Add(new Bitmap(Application.StartupPath + 
                "\\Resources\\1.jpg"));
            imgListSmall.Images.Add(new Bitmap(Application.StartupPath +
                "\\Resources\\2.jpg"));
            imgListSmall.Images.Add(new Bitmap(Application.StartupPath +
                "\\Resources\\3.jpg"));

            imgListLarge = new ImageList() { ImageSize = new Size(68, 68) };
            imgListLarge.Images.Add(new Bitmap(Application.StartupPath +
                "\\Resources\\1.jpg"));
            imgListLarge.Images.Add(new Bitmap(Application.StartupPath +
                "\\Resources\\2.jpg"));
            imgListLarge.Images.Add(new Bitmap(Application.StartupPath +
                "\\Resources\\3.jpg"));
        }

        void LoadListView()
        {
            LoadListImage();
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.LargeImageList = imgListLarge;
            listView.SmallImageList = imgListSmall;

            listView.Columns.Add("Column 1");
            listView.Columns.Add("Column 2");
            listView.Columns.Add("Column 3");

            ListViewItem item1 = new ListViewItem();
            item1.Text = "Item 1";
            item1.ImageIndex = 0;
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "SubItem 1" });
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "SubItem 2" });

            ListViewItem item2 = new ListViewItem();
            item2.Text = "Item 2";
            item2.ImageIndex = 1;
            item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "SubItem 1" });
            item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "SubItem 2" });

            ListViewItem item3 = new ListViewItem();
            item3.Text = "Item 3";
            item3.ImageIndex = 2;
            item3.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "SubItem 1" });
            item3.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "SubItem 2" });

            listView.Items.Add(item1);
            listView.Items.Add(item2);
            listView.Items.Add(item3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView.View = View.LargeIcon;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView.View = View.Details;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView.View = View.SmallIcon;
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = sender as ListView;
            if(lv.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lv.SelectedItems[0];
                MessageBox.Show(lvi.Text);
            }
        }
    }
}
