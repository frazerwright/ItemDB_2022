using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ItemDB.Models
{
    public class recipient
    {
        [Display(Name = "Tracking number")]
        public int RecipientId { get; set; }
        public int OrderId { get; set; }
        public string Address { get; set; }
        [Display(Name = "Item ordered")]
        public string ItemOrdered { get; set; }
        
        public order Order { get; set; }
    }
}
