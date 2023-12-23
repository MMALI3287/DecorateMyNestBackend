using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class MaterialInventory
    {
        [Key]
        public int MaterialId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public int Quantity { get; set; }

        [StringLength(50)]
        public string Remarks { get; set; }

        [Required]
        public int CriticalLimit { get; set; }
    }
}
