namespace BLL.DTOs
{
    public class OrderDTO
    {
        public int OrderId { get; set; }

        public int VendorId { get; set; }

        public int MaterialTransactionId { get; set; }

        public bool IsComplete { get; set; }
    }
}
