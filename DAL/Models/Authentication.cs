using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Authentication
    {
        [Key]
        public int AuthId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public byte[] ProfilePicture { get; set; }

        public string MimeType { get; set; }

        public bool Verified { get; set; }

        public bool Banned { get; set; }

        public string Role { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<Admin> Admins { get; set; }
        public virtual ICollection<EmployeeRoster> EmployeeRosters { get; set; }
        public virtual ICollection<Vendor> Vendors { get; set; }

        public Authentication()
        {
            Messages = new List<Message>();
            Notifications = new List<Notification>();
            Admins = new List<Admin>();
            EmployeeRosters = new List<EmployeeRoster>();
            Vendors = new List<Vendor>();
        }
    }
}
