using System.Collections.Generic;

namespace RozkladSharp.Domain.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelephoneNumber { get; set; }
        
        public int StudentSheduleId { get; set; }
        public StudentShedule StudentShedule { get; set; }
    }
}