using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace SepeteYolla.MVC.Models
{
    public class User:IdentityUser
    {
        [Display(Name = "İkinci Telefon")]
        public int Second_Phone{ get; set; }

        [Display(Name = "Adres")]
        public string Address { get; set; }

        [Display(Name = "Firma Adı")]
        public string Brand{ get; set; }

        [Display(Name = "Adı Soyadı")]
        public string Name{ get; set; }

        [Display(Name = "Şehir")]
        public string City { get; set; }

        [Display(Name = "İletişim Bilgileri")]
        public string Contact_Info { get; set; }

        [Display(Name = "Kullanıcı Türü")]
        public string Role { get; set; }
    }
}
