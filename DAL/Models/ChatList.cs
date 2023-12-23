using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class ChatList
    {
        [Key]
        public int ChatId { get; set; }

        [Required]
        public int ClientId { get; set; }

        [Required]
        public int AdminId { get; set; }
    }
}
