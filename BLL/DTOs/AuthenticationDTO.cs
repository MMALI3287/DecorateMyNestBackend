namespace BLL.DTOs
{
    public class AuthenticationDTO
    {
        public int AuthId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public byte[] ProfilePicture { get; set; }

        public bool Verified { get; set; }

        public bool Banned { get; set; }

        public string Role { get; set; }
    }
}
