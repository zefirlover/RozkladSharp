namespace RozkladSharp.Domain.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public int TeacherSheduleId { get; set; }
        public TeacherShedule TeacherShedule { get; set; }
        
        public int RankId { get; set; }
        public Rank Rank { get; set; }
    }
}