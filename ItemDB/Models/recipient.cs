using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ItemDB.Models
{
    public class recipient
    {
        public int recipientId { get; set; }
        public int orderId { get; set; }
        public string Address { get; set; }
        [Display(Name = "Item ordered")]
        public string ItemOrdered { get; set; }
        [Display(Name = "Tracking number")]
        public order order { get; set; }
    }
}
