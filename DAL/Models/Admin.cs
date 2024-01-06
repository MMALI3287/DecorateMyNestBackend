using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public virtual Authentication User { get; set; }
    }
}