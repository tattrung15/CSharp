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

namespace WFTreeView
{
    public partial class Form1 : Form
    {
        string path = @"D:\VSC";
        public Form1()
        {
            InitializeComponent();

            treeView.CheckBoxes = true;
            treeView.NodeMouseClick += TreeView_NodeMouseClick;

            if (Directory.Exists(path))
            {
                TreeNode root = new TreeNode() { Text = path };
                treeView.Nodes.Add(root);
                LoadExplorer(root);
            }
        }

        void LoadExplorer(TreeNode root)
        {
            if(root == null) return;

            var folderList = new DirectoryInfo(root.Text).GetDirectories();

            if (folderList.Count() == 0) return;

            foreach(DirectoryInfo item in folderList)
            {
                if (Directory.Exists(item.FullName))
                {
                    TreeNode node = new TreeNode() { Text = item.FullName };
                    root.Nodes.Add(node);
                    LoadExplorer(node);
                }
            }
        }

        private void TreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            e.Node.Checked = !e.Node.Checked;
        }
    }
}
