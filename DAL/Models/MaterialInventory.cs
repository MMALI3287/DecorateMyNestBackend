using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class MaterialInventory
    {
        [Key]
        public int MaterialId { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public string Remarks { get; set; }

        public int CriticalLimit { get; set; }

        public virtual ICollection<MaterialTransaction> MaterialTransactions { get; set; }

        public MaterialInventory()
        {
            MaterialTransactions = new List<MaterialTransaction>();
        }
    }
}
