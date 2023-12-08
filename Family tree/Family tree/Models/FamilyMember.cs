using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_tree.Models
{
    public class FamilyMember
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(50)]
        public string Title { get; set; }

        [ForeignKey("FamilyNames")]
        public int ParentId { get; set; }
        public FamilyTitle FamilyNames { get; set; }
    }
}
