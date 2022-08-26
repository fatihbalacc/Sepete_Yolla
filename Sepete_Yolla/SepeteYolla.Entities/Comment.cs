using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata.Ecma335;
using System.Diagnostics.CodeAnalysis;

namespace SepeteYolla.Entities
{
    public class Comment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(300), DisallowNull]
        public string Commentary { get; set; }
        public bool Evolation { get; set; }
        public DateTime Time { get; set; }

        [ForeignKey("Product")]
        public int Product_Id { get; set; }
        [ForeignKey("Customer")]
        public int Customer_Id { get; set; }
        [ForeignKey("Company")]
        public int Company_Id { get; set; }
    }
}
