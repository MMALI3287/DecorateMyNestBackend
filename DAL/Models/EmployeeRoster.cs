using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class EmployeeRoster
    {
        [Key]
        public int EmployeeId { get; set; }

        [ForeignKey("Authentication")]
        public int AuthId { get; set; }
        public virtual Authentication Authentication { get; set; }

        public string Department { get; set; }

        public string Designation { get; set; }

        public int Salary { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<ChatList> ChatLists { get; set; }
        public virtual ICollection<SalaryTransaction> SalaryTransactions { get; set; }


        public EmployeeRoster()
        {
            Appointments = new List<Appointment>();
            ChatLists = new List<ChatList>();
            SalaryTransactions = new List<SalaryTransaction>();
        }
    }
}
