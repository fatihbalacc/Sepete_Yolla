using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace SepeteYolla.Entities
{
    public class Product_Kind
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(50)]
        public string Dimension { get; set; }
        [StringLength(50)]
        public string Color { get; set; }
        [DisallowNull]
        public int Price { get; set; }

        [ForeignKey("Product")]
        public int Product_Id { get; set; }
        [ForeignKey("Category")]
        public int Category_Id { get; set; }
        [ForeignKey("Company")]
        public int Company_Id { get; set; }
    }
}
