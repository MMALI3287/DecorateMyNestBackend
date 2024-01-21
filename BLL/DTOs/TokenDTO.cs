using System;

namespace BLL.DTOs
{
    public class TokenDTO
    {

        public int Id { get; set; }

        public string TokenKey { get; set; }

        public DateTime? CreatedAt { get; set; }

        public string UserId { get; set; }

        public DateTime? ExpiresAt { get; set; }

        public DateTime? DeletedAt { get; set; }
    }
}
