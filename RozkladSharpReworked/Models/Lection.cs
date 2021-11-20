namespace RozkladSharp.Domain.Models
{
    public class Lection
    {
        public int Id { get; set; }
        
        public int StudentSheduleId { get; set; }
        public StudentShedule StudentShedule { get; set; }
        public int TeacherSheduleId { get; set; }
        public TeacherShedule TeacherShedule { get; set; }
        
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        
        public int LectionDetailId { get; set; }
        public LectionDetail LectionDetail { get; set; }
    }
}