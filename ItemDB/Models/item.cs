using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ItemDB.Models
{
    public class item
    {
        [Display(Name = "ID")]
        public int ItemId { get; set; }
        public int OrderId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Rarity { get; set; }
        [Required]
        public string Description { get; set; }
        [Display(Name = "Personal notes")]
        public string? Personal_Notes { get; set; }
        [Required]
        public string Archetype { get; set; }
        [Display(Name = "Tracking number")]
        public order Order { get; set; } 
       
    }
}
