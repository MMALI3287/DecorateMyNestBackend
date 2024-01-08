namespace BLL.DTOs
{
    public class MaterialTransactionDTO
    {
        public int MaterialTransactionId { get; set; }

        public int TransactionId { get; set; }

        public int MaterialId { get; set; }

        public int Quantity { get; set; }

        public int VendorId { get; set; }
    }
}
