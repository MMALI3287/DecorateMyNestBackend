using System;

namespace BLL.DTOs
{
    internal class AppoitmentDTO
    {
        public int AppointmentId { get; set; }

        public int ClientId { get; set; }

        public int EmployeeId { get; set; }

        public DateTime AppointmentDate { get; set; }

        public int AppointmentRoom { get; set; }
    }
}
