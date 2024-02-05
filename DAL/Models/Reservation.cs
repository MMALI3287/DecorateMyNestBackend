using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        public int ClientId { get; set; }

        public DateTime ReservationDate { get; set; }

        public string Status { get; set; }

        public int CatalogCategoryId { get; set; }

        public int CatalogId { get; set; }

        public virtual ICollection<InProgressProject> InProgressProjects { get; set; }
        public virtual ICollection<ReservationTransaction> ReservationTransactions { get; set; }

        public Reservation()
        {
            ReservationTransactions = new List<ReservationTransaction>();
            InProgressProjects = new List<InProgressProject>();
        }
    }

}