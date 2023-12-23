using System;

namespace BLL.DTOs
{
    public class InProgressProjectDTO
    {
        public int ProjectId { get; set; }

        public int ClientId { get; set; }

        public int ReservationId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int ProjectManagerId { get; set; }

        public int EstimatedCost { get; set; }

        public int Balance { get; set; }
    }
}
