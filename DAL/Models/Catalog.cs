using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Catalog
    {
        [Key]
        public int CatalogId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        [Required]
        [StringLength(50)]
        public int EstimatedPrice { get; set; }

        [Required]
        [StringLength(50)]
        public int CatalogCategoryId { get; set; }

        public byte[] Picture { get; set; }
    }
}
