﻿namespace BLL.DTOs
{
    public class ClientDTO
    {
        public int ClientId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public byte[] ProfilePicture { get; set; }
    }
}