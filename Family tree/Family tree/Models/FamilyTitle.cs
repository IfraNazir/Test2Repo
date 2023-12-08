using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_tree.Models
{
    public class FamilyTitle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FamilyId { get; set; }
        [StringLength(50)]
        public string Family_Title { get; set; }
        [StringLength(50)]
        public string Address { get; set; }
        public ICollection<FamilyMember> FamilyMembers { get; set; }
    }
}
