using System.Collections.Generic;

namespace RozkladSharp.Domain.Models
{
    public class TeacherShedule
    {
        public int Id { get; set; }
        public Teacher Teacher { get; set; }
        public List<Lection> Lections { get; set; }
    }
}