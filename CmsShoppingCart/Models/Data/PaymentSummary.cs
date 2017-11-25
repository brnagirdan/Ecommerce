using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CmsShoppingCart.Models.Data
{
    [Table("tblPayment")]
    public class PaymentSummary
    {
        [Key]
        public int Id { get; set; }
    /*    public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int SaleState { get; set; } */
        public int CargoPrice { get; set; }
        public DateTime RecordDate { get; set; }
      //  public DateTime LastUpdateDate { get; set; }
    }
}