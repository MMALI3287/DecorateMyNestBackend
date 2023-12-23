using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Catalog
    {
        [Key]
        public int ItemId { get; set; }

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
        public int CategoryId { get; set; }

        public byte[] Picture { get; set; }
    }
}
