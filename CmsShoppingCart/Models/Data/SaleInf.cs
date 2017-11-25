using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CmsShoppingCart.Models.Data
{
    [Table("tblSaleInf")]
    public class SaleInf
    {

        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen ad giriniz")]
        public String Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen bir adres giriniz")]
        public String Address { get; set; }
        public String Country { get; set; }
        public String PostCode { get; set; }
        [Required(ErrorMessage = "Lütfen bir telefon giriniz")]
        public String Telephone { get; set; }
    }
}