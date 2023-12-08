using Family_tree.Models;
using System.Data;

namespace Family_tree.Views
{
    public partial class AddEditFamilyMemberDialog : Form
    {
        private FamilyTreeViewPageSetup _familyTreeViewPageSetup;
        string Addnode;
        String SelectedNode;
         MyAppContext appContext = new MyAppContext();
         FamilyTreePage familyTreeView = new FamilyTreePage();
        //  private TreeView TreeView;

        public AddEditFamilyMemberDialog()
        {
            InitializeComponent();
        }

        public void PageSetup(FamilyTreeViewPageSetup familyTreeViewPageSetup)
        {
            _familyTreeViewPageSetup = familyTreeViewPageSetup;
        }

        #region edit family member
        private bool isUpdate = true;
        private void buttonEditNodeName_Click(object sender, EventArgs e)
        {

          
                var selectedNode = appContext.FamilyMembers.Find(_familyTreeViewPageSetup.SelectedMember.ID);
                if (!isUpdate)
                {
                    isUpdate = true;
                    buttonEditNodeName.Text = "Update";
                    if (selectedNode != null)
                    {
                        textBoxNodeName.Text = selectedNode.Title;
                    }
                }
                else
                {
                    isUpdate = false;
                    selectedNode.Title = textBoxNodeName.Text;
                    appContext.SaveChanges();
                    buttonEditNodeName.Text = "Edit";
                }

            


            this.Close();
        }
        #endregion edit family member
        //Adding new node
        private void buttonAddNodeName_Click(object sender, EventArgs e)
        {
            if (_familyTreeViewPageSetup.TargetFamily != null)
            {
                var selectedNode = appContext.FamilyTitles.Find(_familyTreeViewPageSetup.TargetFamily.FamilyId);
                var newNode = new FamilyMember
                {
                    Title = textBoxNodeName.Text,
                    ParentId = selectedNode.FamilyId,
                };
                appContext.FamilyMembers.Add(newNode);
                appContext.SaveChanges();
            }
            else
            {
                var selectedNode = appContext.FamilyMembers.Find(_familyTreeViewPageSetup.SelectedMember.ID);
                var newNode = new FamilyMember
                {
                    Title = textBoxNodeName.Text,
                    ParentId = selectedNode.ID,
                };
                appContext.FamilyMembers.Add(newNode);
                appContext.SaveChanges();
            }
    

            this.Close();
        }

        private void buttonDeleteNodeName_Click(object sender, EventArgs e)
        {

            
                var selectedNode = appContext.FamilyMembers.Find(_familyTreeViewPageSetup.SelectedMember.ID);
          var childNode = appContext.FamilyMembers.Where(Title => Title.ParentId == selectedNode.ID).FirstOrDefault();
            textBoxNodeName.Text = selectedNode.Title; 
            if (selectedNode.ID==childNode.ParentId)
            {
                DialogResult res;
                res = MessageBox.Show("Do you want to delete childnodes also", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    appContext.FamilyMembers.Remove(selectedNode);
                    appContext.FamilyMembers.Remove(childNode);

                    appContext.SaveChanges();
                }
                else
                {
                    appContext.FamilyMembers.Remove(selectedNode);
                    appContext.SaveChanges();
                }
                this.Close();
            }
            else
            {
                DialogResult res;
                res = MessageBox.Show("Do you want to delete node", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    appContext.FamilyMembers.Remove(selectedNode);
                    appContext.SaveChanges();
                }
                else
                {
                    this.Show();
                }

                this.Close();

            }
        }
    }
}
