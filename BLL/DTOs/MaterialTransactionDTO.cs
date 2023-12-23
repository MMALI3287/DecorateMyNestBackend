namespace BLL.DTOs
{
    internal class MaterialTransactionDTO
    {
        public int TransactionId { get; set; }

        public int MaterialId { get; set; }

        public int Quantity { get; set; }

        public int VendorId { get; set; }
    }
}
