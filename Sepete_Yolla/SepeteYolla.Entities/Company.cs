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
    public class Company
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(50), DisallowNull]
        public string Brand { get; set; }                               // Eklenecek
        [StringLength(60), DisallowNull]
        public string Name { get; set; }                                // Eklenecek
        [StringLength(80), DisallowNull]
        public string E_mail { get; set; }
        [StringLength(80), PasswordPropertyText(true), DisallowNull]
        public string Password { get; set; }
        [StringLength(30), DisallowNull]
        public string City { get; set; }                                // Eklenecek
        [StringLength(250), DisallowNull]
        public string Contact_Info { get; set; }                        // Eklenecek
    }
}
