using Family_tree.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Family_tree.Views
{
    public partial class LearnTreeView : Form
    {
        MyAppContext context = new MyAppContext();
        private TreeNode selectedNode;
        public LearnTreeView()
        {
            InitializeComponent();
        }

        private void LearnTreeView_Load(object sender, EventArgs e)
        {
            BindFamilyTree();
        }
        private void BindFamilyTree()
        {
            //var rNode = treeView1.Nodes.Add("All Docs");
            //var families = context.TreeViews.Where(x => x.ParentId == null);
            //foreach (var family in families)
            //{
            //    TreeNode subNode = new TreeNode(family.FamilyDescription);

            //    GetNodes(subNode, family);
            //    rNode.Nodes.Add(subNode);
            //}
            // treeViewFamilyTree.Nodes.Add(ro);
        }

        private void GetNodes(TreeNode rNode, FamilyTree family)
        {
            //var childNodes = context.TreeViews.Where(x => x.ParentId == family.Id);
            //foreach (var child in childNodes)
            //{
            //    TreeNode subnode = new TreeNode(child.FamilyDescription);
            //    GetNodes(subnode, child);
            //    rNode.Nodes.Add(subnode);
            //}
        }
            private void buttonAddNode_Click(object sender, EventArgs e)
        {
            //    var dbCount = context.TreeViews.Count();
            //if(selectedNode != null)
            //{
            //    var selNode = context.TreeViews.Where(x => x.FamilyDescription == selectedNode.Text).FirstOrDefault();
            //    var newNode = new FamilyTree
            //    {
            //        FamilyDescription = textBoxNodeName.Text,
            //        ParentId = selNode.Id,
            //    };
            //    context.TreeViews.Add(newNode);
            //    context.SaveChanges();
            //}
            //else
            //{

            //    var newNode = new FamilyTree
            //    {
            //        FamilyDescription = textBoxNodeName.Text,
            //        ParentId = null,
            //    };
            //    context.TreeViews.Add(newNode);
            //    context.SaveChanges();
            //}

            //if(context.TreeViews.Count() > dbCount)
            //    MessageBox.Show("Save successfull", "Message");
            //treeView1.Nodes.Clear();
            //BindFamilyTree();
        }

        private void buttonDeleteNode_Click(object sender, EventArgs e)
        {
            //var selNode = context.TreeViews.Where(x => x.FamilyDescription == selectedNode.Text).FirstOrDefault();
            //var dbCount = context.TreeViews.Count();
            //if (selNode != null)
            //{
            //    context.TreeViews.Remove(selNode);
            //    context.SaveChanges();
            //    if (context.TreeViews.Count() < dbCount)
            //        MessageBox.Show("Deleted successfully", "Message");
            //}
            //treeView1.Nodes.Clear();
            //BindFamilyTree();
        }
        private bool isUpdate = false;
        private void buttonEditNode_Click(object sender, EventArgs e)
        {
            //var selNode = context.TreeViews.Where(x => x.FamilyDescription == selectedNode.Text).FirstOrDefault();
            //var dbCount = context.TreeViews.Count();
            //if (!isUpdate)
            //{
            //    isUpdate = true;
            //    buttonEditNode.Text = "Update";
            //    if (selectedNode != null)
            //    {
            //        textBoxNodeName.Text = selNode.FamilyDescription;
            //    }
            //}
            //else
            //{
            //    isUpdate = false;
            //    selNode.FamilyDescription = textBoxNodeName.Text;
            //    context.SaveChanges();
            //    buttonEditNode.Text = "Edit Node";
            //        if(context.TreeViews.Count()==dbCount)
            //    MessageBox.Show("Update successfull", "Message");
            //    treeView1.Nodes.Clear();
            //    BindFamilyTree();
            //}
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            selectedNode = e.Node;
        }
    }
}
