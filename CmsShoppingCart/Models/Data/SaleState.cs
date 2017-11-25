using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CmsShoppingCart.Models.Data
{
    public enum SaleState
    {
        PendingCheck,
        PendingDelivery,
        Completed,
        Cancel
    }
}