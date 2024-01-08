using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class ArchivedProject
    {
        [Key, ForeignKey("InProgressProject")]
        public int ProjectId { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        public DateTime CompletionDate { get; set; }

        public string Review { get; set; }

        public int Rating { get; set; }

        public int Revenue { get; set; }

        public byte[] Picture { get; set; }

        public virtual InProgressProject InProgressProject { get; set; }
    }
}
