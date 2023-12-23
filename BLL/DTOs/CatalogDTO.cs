namespace BLL.DTOs
{
    public class CatalogDTO
    {
        public int CatalogId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int EstimatedPrice { get; set; }

        public int CatalogCategoryId { get; set; }

        public byte[] Picture { get; set; }
    }
}
