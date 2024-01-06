using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class ArchivedProject
    {
        [Key]
        public int ProjectId { get; set; }

        [ForeignKey("ClientId")]
        public virtual Client ClientId { get; set; }

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
