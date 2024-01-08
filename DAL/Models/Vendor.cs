using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Vendor
    {
        [Key]
        public int VendorId { get; set; }

        [ForeignKey("Authentication")]
        public int AuthId { get; set; }
        public virtual Authentication Authentication { get; set; }

        public string CompanyName { get; set; }

        public virtual ICollection<MaterialTransaction> MaterialTransactions { get; set; }

        public Vendor()
        {
            MaterialTransactions = new List<MaterialTransaction>();
        }
    }
}