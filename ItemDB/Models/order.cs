using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ItemDB.Models
{
    public class order
    {
        [Display(Name = "Tracking number")]
        public int orderId { get; set; } 
        [Display(Name = "Estimated delivery")]
        public DateTime EstimatedDelivery { get; set; }
        [Display(Name = "Shipping method")]
        public string ShippingMethod { get; set; }
        [Display(Name = "Shipping notes")]
        public string ShippingNotes { get; set; }

        public ICollection<item> item { get; set; }
        public recipient recipient { get; set; }
    }
}
