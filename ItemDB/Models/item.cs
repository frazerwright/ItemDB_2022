using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ItemDB.Models
{
    public class item
    {
        [Display(Name = "ID")]
        public int itemId { get; set; }
        [Display(Name = "Order number")]
        public int orderId { get; set; }
        public string Name { get; set; }
        public string Rarity { get; set; }
        public string Description { get; set; }
        [Display(Name = "Personal notes")]
        public string Personal_Notes { get; set; }
        public string Archetype { get; set; }
        [Display(Name = "Tracking number")]
        public order order { get; set; } 
       
    }
}
