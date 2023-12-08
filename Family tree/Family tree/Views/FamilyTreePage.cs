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
    public partial class FamilyTreePage : Form
    {
        #region Properties
        private FamilyTreeViewPageSetup _targetFamily;
        MyAppContext _appContext = new MyAppContext();
        

        string Familytitle;
        int Familyid;
        string Addnode;
        private int targetFamilyId;
        private TreeNode SelectedNode;
        #endregion Properties

        #region Constructor
        public FamilyTreePage()
        {
            InitializeComponent();
        }
       
        #endregion Constructor

        #region Page Events

        private void FamilyTreeView_Load(object sender, EventArgs e)
        {
            BindFamilyTree();
        }
      
    private void BindFamilyTree()
        {
            var rootFamily = _appContext.FamilyTitles.Where(n => n.FamilyId == _targetFamily.TargetFamily.FamilyId).FirstOrDefault();
             var rNode = treeViewFamilyTree.Nodes.Add(rootFamily.Family_Title);
                 var families = _appContext.FamilyMembers.Where(x => x.ParentId == rootFamily.FamilyId);
        
                    foreach (var family in families)
                    { 
                        TreeNode subNode = new TreeNode(family.Title);
                        GetNodes(subNode, family);
                        rNode.Nodes.Add(subNode);
                    }
                }

        public void PageSetup(FamilyTreeViewPageSetup targetFamily)
        {
            _targetFamily = targetFamily;
        }

        private void GetNodes(TreeNode rNode, FamilyMember family)
        {
            var childNodes = _appContext.FamilyMembers.Where(x => x.ParentId == family.ID);
            foreach(var child in childNodes)
            {
                TreeNode subnode = new TreeNode(child.Title);
                GetNodes(subnode, child);
                rNode.Nodes.Add(subnode);
            }
        }
        #endregion Page Events
        
        #region User Events

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            AddEditFamilyMemberDialog addNodes = new AddEditFamilyMemberDialog();
            var pageSetup = new FamilyTreeViewPageSetup(targetFamily, selectedFamilyMember);
            addNodes.PageSetup(pageSetup);
            addNodes.Show();
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            AddEditFamilyMemberDialog addNodes = new AddEditFamilyMemberDialog();
            var pageSetup = new FamilyTreeViewPageSetup(targetFamily, selectedFamilyMember);
            addNodes.PageSetup(pageSetup);
            addNodes.Show();
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
           // try
           // {

                var pageSetup = new FamilyTreeViewPageSetup(targetFamily, selectedFamilyMember);

                var selectedNode = _appContext.FamilyMembers.Find(pageSetup.SelectedMember.ID);


                var childNode = _appContext.FamilyMembers.Where(Title => Title.ParentId == selectedNode.ID).FirstOrDefault();
                if (childNode == null)
                {
                    DialogResult res;
                    res = MessageBox.Show("Do you want to delete node", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        _appContext.FamilyMembers.Remove(selectedNode);
                        _appContext.SaveChanges();
                    }
                    else
                    {
                        this.Show();
                    }
                }
                else
                {
                    if (selectedNode.ID == childNode.ParentId && childNode != null)
                    {
                        DialogResult res;
                        res = MessageBox.Show("Do you want to delete childnodes also", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (res == DialogResult.Yes)
                        {

                            _appContext.FamilyMembers.Remove(selectedNode);
                            _appContext.FamilyMembers.Remove(childNode);
                            _appContext.SaveChanges();
                        }
                        else
                        {
                            _appContext.FamilyMembers.Remove(selectedNode);
                            _appContext.SaveChanges();
                        }
                        this.Close();
                    }
                    else
                    {

                        DialogResult res;
                        res = MessageBox.Show("Do you want to delete node", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (res == DialogResult.Yes)
                        {
                            _appContext.FamilyMembers.Remove(selectedNode);
                            _appContext.SaveChanges();
                        }
                        else
                        {
                            this.Show();
                        }
                    }
                }
           // }
          //  catch
          //  {
          //      MessageBox.Show("RootNode cannot be deleted");
          //  }
        }

        private void treeViewFamilyTree_AfterSelect(object sender, TreeViewEventArgs e)
        { 
            switch (e.Action)
            {
                case TreeViewAction.ByKeyboard:
                   break;
                case TreeViewAction.ByMouse:

                    break;
            }
        }
        private FamilyMember selectedFamilyMember;
        private FamilyTitle targetFamily;
        private void treeViewFamilyTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            try
            {
                var rootFamily = _appContext.FamilyTitles.Where(x => x.Family_Title == e.Node.Text).FirstOrDefault();
                if (rootFamily != null)
                    targetFamily = _appContext.FamilyTitles.Where(x => x.Family_Title == e.Node.Text).FirstOrDefault();
                else
                {
                    selectedFamilyMember = _appContext.FamilyMembers.Where(x => x.Title == e.Node.Text).FirstOrDefault();
                    targetFamily = null;
                }
                     
            }
            catch
            { }
            
            
        }
        #endregion User Events

        private void buttonSaveDescription_Click(object sender, EventArgs e)
        {

        }
    }
}   

