using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;

namespace SepeteYolla.Entities
{
    public class Product
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [StringLength(70), DisallowNull]
        public string Name { get; set; }
        [StringLength(750)]
        public string Statement { get; set; }

        [DefaultValue(0)]
        public int Comment_Number { get; set; }

        [ForeignKey("Company")]
        public int Company_Id { get; set; }
        [ForeignKey("Category")]
        public int Category_Id { get; set; }
    }
}