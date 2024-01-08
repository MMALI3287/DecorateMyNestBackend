using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class ChatList
    {
        [Key]
        public int ChatId { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        [ForeignKey("EmployeeRoster")]
        public int EmployeeId { get; set; }
        public virtual EmployeeRoster EmployeeRoster { get; set; }

        [ForeignKey("InProgressProject")]
        public int ProjectId { get; set; }
        public virtual InProgressProject InProgressProject { get; set; }
    }
}
