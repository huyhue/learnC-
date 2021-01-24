using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsGUI
{
    public partial class TreeViewGUI : Form
    {
        string path = @"D:\";
        public TreeViewGUI()
        {
            InitializeComponent();
            LoadTreeView();

            /*
              if (Directory.Exists(path))
            {
                TreeNode root = new TreeNode() { Text = path };
                tvShow.Nodes.Add(root);
                LoadExplorer(root);
            }
            */
        }

        void LoadExplorer(TreeNode root)
        {
            if (root == null)
                return;
            try
            {
                var folderList = new DirectoryInfo(root.Text).GetDirectories();

                if (folderList.Count() == 0)
                    return;

                foreach (DirectoryInfo item in folderList)
                {
                    if (Directory.Exists(item.FullName))
                    {
                        TreeNode node = new TreeNode() { Text = item.FullName };
                        root.Nodes.Add(node);
                        LoadExplorer(node);
                    }
                }
            }
            catch
            {
                return;
            }
        }

        void LoadTreeView()
        {
            tvShow.CheckBoxes = true;
            tvShow.NodeMouseClick += tvShow_NodeMouseClick;

            TreeNode root1 = new TreeNode();
            root1.Text = "Root nè";
            root1.ImageIndex = 0;

            TreeNode node1 = new TreeNode() { Text = "Node 1 nè" };
            root1.Nodes.Add(node1);
            node1.ImageIndex = 1;
            node1.Checked = true;

            TreeNode root2 = new TreeNode();
            root2.Text = "Ứ phải root đâu. à hi hí";
            root2.ImageIndex = 2;

            tvShow.Nodes.Add(root1);
            tvShow.Nodes.Add(root2);
        }

        void tvShow_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            e.Node.Checked = !e.Node.Checked;
        }
    }
}
