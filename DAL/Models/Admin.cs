using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [ForeignKey("Authentication")]
        public int AuthId { get; set; }
        public virtual Authentication Authentication { get; set; }
    }
}