using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }

        [ForeignKey("UserId")]
        public virtual Authentication UserId { get; set; }
    }
}