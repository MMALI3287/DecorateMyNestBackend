using System;

namespace BLL.DTOs
{
    public class ReservationDTO
    {
        public int ReservationId { get; set; }

        public int ClientId { get; set; }

        public DateTime ReservationDate { get; set; }

        public string Status { get; set; }

        public int CatalogId { get; set; }

        public int CatalogCategoryId { get; set; }

    }
}
