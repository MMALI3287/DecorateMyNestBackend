using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class CatalogCategory
    {
        [Key]
        public int CatalogCategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; }
    }
}
