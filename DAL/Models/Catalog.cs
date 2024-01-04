using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public int EstimatedPrice { get; set; }

        [ForeignKey("CatalogCategoryId")]
        public virtual CatalogCategory CatalogCategoryId { get; set; }

        public byte[] Picture { get; set; }
    }
}
