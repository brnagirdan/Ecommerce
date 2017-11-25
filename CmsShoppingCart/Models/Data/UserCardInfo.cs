using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CmsShoppingCart.Models.Data
{
    public class UserCardInfo
    {
        public String CardNumber { get; set; }
        public String SecurityNumber { get; set; }
        public String CardHasName { get; set; }
        public String ExpYear { get; set; }
        public String ExpMonth { get; set; }
        public String Id { get; set; }

    }
}