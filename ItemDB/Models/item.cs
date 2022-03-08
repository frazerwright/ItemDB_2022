using System;
using System.Collections.Generic;

namespace ItemDB.Models
{
    public class item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Rarity { get; set; }
        public string Description { get; set; }
        public string Personal_Notes { get; set; }
        public string Archetype { get; set; }
 
        public order order { get; set; } 
       
    }
}
