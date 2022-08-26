using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace SepeteYolla.Entities
{
    public class Customer
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(80), DisallowNull]
        public string E_mail { get; set; }
        [StringLength(80),PasswordPropertyText(true), DisallowNull]
        public string Password { get; set; }

        [StringLength(30), DisallowNull]
        public string Mobile_Phone { get; set; }        
        [StringLength(30)]
        public string Second_Phone { get; set; }        // Eklenecek
        [StringLength(150), DisallowNull]
        public string Address { get; set; }             // Eklenecek
    }
}
