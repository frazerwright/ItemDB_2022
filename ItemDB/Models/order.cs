using System;
using System.Collections.Generic;


namespace ItemDB.Models
{
    public class order
    {
        public int orderId { get; set; } 
        public DateTime EstimatedDelivery { get; set; }
        public string ShippingMethod { get; set; }
        public string ShippingNotes { get; set; }

        public ICollection<item> item { get; set; }
        public recipient recipient { get; set; }
    }
}
