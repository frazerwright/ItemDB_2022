using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ItemDB.Models
{
    public class order
    {
        [Display(Name = "Tracking number")]
        public int OrderId { get; set; } 
        [Display(Name = "Estimated delivery")]
        [DataType(DataType.Date)]
        public DateTime EstimatedDelivery { get; set; }
        [Display(Name = "Shipping method")]
        [Required]
        public string ShippingMethod { get; set; }
        [Display(Name = "Shipping notes")]
        public string? ShippingNotes { get; set; }
        [Display(Name = "Shipping notes")]
        public ICollection<item> Item { get; set; }
        public recipient Recipient { get; set; }
    }
}
