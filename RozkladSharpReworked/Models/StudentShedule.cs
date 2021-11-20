using System.Collections.Generic;

namespace RozkladSharp.Domain.Models
{
    public class StudentShedule
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public List<Lection> Lections { get; set; }
    }
}