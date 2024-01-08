using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Catalog
    {
        [Key]
        public int CatalogId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int EstimatedPrice { get; set; }

        [ForeignKey("CatalogCategory")]
        public int CatalogCategoryId { get; set; }
        public virtual CatalogCategory CatalogCategory { get; set; }

        public byte[] Picture { get; set; }
    }
}
