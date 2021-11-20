using System.Collections.Generic;

namespace RozkladSharp.Domain.Models
{
    public class Rank
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}