using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_tree.Models
{
    public class FamilyTreeViewPageSetup
    {
        public FamilyTreeViewPageSetup(FamilyTitle targetFamily, FamilyMember selectedMember)
        {
            TargetFamily = targetFamily;
            SelectedMember = selectedMember;       
        }
        public FamilyTitle TargetFamily { get; set; }
        public FamilyMember SelectedMember { get; set; }
    }
}
