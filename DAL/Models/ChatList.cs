using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class ChatList
    {
        [Key]
        public int ChatId { get; set; }

        [ForeignKey("ClientId")]
        public virtual Client ClientId { get; set; }

        [ForeignKey("AdminId")]
        public virtual Admin AdminId { get; set; }

        [ForeignKey("ProjectId")]
        public virtual InProgressProject ProjectId { get; set; }
    }
}
