namespace BLL.DTOs
{
    internal class MaterialInventoryDTO
    {
        public int MaterialId { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public string Remarks { get; set; }

        public int CriticalLimit { get; set; }
    }
}
