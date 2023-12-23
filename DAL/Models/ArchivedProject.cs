using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class ArchivedProject
    {
        [Key]
        public int ProjectId { get; set; }

        [Required]
        public int ClientId { get; set; }

        [Required]
        public DateTime CompletionDate { get; set; }

        [Required]
        [MaxLength(100)]
        public string Review { get; set; }

        [Required]
        public int Rating { get; set; }

        [Required]
        public int Revenue { get; set; }

        public byte[] Picture { get; set; }
    }
}
