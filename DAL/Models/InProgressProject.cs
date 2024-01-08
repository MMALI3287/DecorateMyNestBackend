using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class InProgressProject
    {
        [Key]
        public int ProjectId { get; set; }

        public int ClientId { get; set; }

        [ForeignKey("Reservation")]
        public int ReservationId { get; set; }
        public virtual Reservation Reservation { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int ProjectManagerId { get; set; }

        public int EstimatedCost { get; set; }

        public int Balance { get; set; }

        public virtual ICollection<ChatList> ChatLists { get; set; }
        public virtual ICollection<InstallmentTransaction> InstallmentTransactions { get; set; }

        public InProgressProject()
        {
            ChatLists = new List<ChatList>();
            InstallmentTransactions = new List<InstallmentTransaction>();
        }
    }
}
