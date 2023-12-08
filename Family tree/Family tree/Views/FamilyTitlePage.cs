using Family_tree.Models;
using Family_tree.Views;

namespace Family_tree
{
    public partial class FamilyTitlePage : Form
    {
        string familyTitle;
        MyAppContext appContext = new MyAppContext();

        public FamilyTitlePage()
        {
            InitializeComponent();
        }

        private void FamilyName_Load(object sender, EventArgs e)
        {
            //dataGridViewFamilyName.DataSource = appContext.FamilyTitles.ToList();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var familyTree = new FamilyTitle()
            {
                Family_Title = textBoxFamilyTitle.Text,
                Address = textBoxAddress.Text,
            };
            appContext.FamilyTitles.Add(familyTree);
            appContext.SaveChanges();
            dataGridViewFamilyName.DataSource = appContext.FamilyTitles.ToList();

        }

        private void dataGridViewFamilyName_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var familyTreePage = new FamilyTreePage();
                var familyID = (int)dataGridViewFamilyName.Rows[e.RowIndex].Cells[0].Value;
                var selectedFamily = appContext.FamilyTitles.Where(m => m.FamilyId == familyID).FirstOrDefault();
                var targetFamily = new FamilyTreeViewPageSetup(selectedFamily, null);
                familyTreePage.PageSetup(targetFamily);
                familyTreePage.ShowDialog();
            }
        }

    }
}