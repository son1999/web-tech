using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] drivers = DriveInfo.GetDrives();
            for (int i = 0; i < drivers.Length; i++) {
                TreeNode myNode = new TreeNode();
                myNode.Text = drivers[i].Name;
                myNode.ImageIndex = 0;
                myNode.SelectedImageIndex = 0;
                treeView1.Nodes.Add(myNode);
                LoadTreeView(myNode.Text, myNode);
            }
        }
        public void LoadTreeView(string dirValue, TreeNodeparentNode)
        {
            string[] dirArray = Directory.GetDirectories(dirValue);
        }
    }
}
