using System.Collections.Generic;

namespace RozkladSharp.Domain.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public List<Lection> Lections { get; set; }
        public string Name { get; set; }
    }
}