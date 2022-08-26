using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepeteYolla.Entities
{
    /// <summary>
    /// Satılan Ürünlerin Tablosu
    /// </summary>
    public class Purchased
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int Total_Price { get; set; }
        public int Quantity { get; set; }
        public DateTime Time { get; set; }

        [ForeignKey("Company")]
        public int Company_Id { get; set; }
        [ForeignKey("Product")]
        public int Product_Id { get; set; }
        [ForeignKey("Customer")]
        public int Customer_Id { get; set; }
    }
}
