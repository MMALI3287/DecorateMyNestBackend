using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }

        public int AuthId { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<ArchivedProject> ArchivedProjects { get; set; }
        public virtual ICollection<ChatList> ChatLists { get; set; }


        public Client()
        {
            Appointments = new List<Appointment>();
            ArchivedProjects = new List<ArchivedProject>();
            ChatLists = new List<ChatList>();
        }
    }
}