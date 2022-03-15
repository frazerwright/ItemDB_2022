namespace ItemDB.Models
{
    public class recipient
    {
        public int recipientId { get; set; }
        public int orderId { get; set; }
        public string Address { get; set; }
        public string ItemOrdered { get; set; }

        public order order { get; set; }
    }
}
