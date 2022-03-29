using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ItemDB.Models
{
    public class recipient
    {
        public int RecipientId { get; set; }

        [Display(Name = "Tracking number")]
        public int OrderId { get; set; }
        [Required]
        public string Address { get; set; }
        [Display(Name = "Item ordered")]
        [Required]
        public string ItemOrdered { get; set; }
        
        public order Order { get; set; }
    }
}
