using System;

namespace BLL.DTOs
{
    internal class ReservationDTO
    {
        public int ReservationId { get; set; }

        public int ClientId { get; set; }

        public int ProjectId { get; set; }

        public DateTime ReservationDate { get; set; }

        public string Status { get; set; }
    }
}
