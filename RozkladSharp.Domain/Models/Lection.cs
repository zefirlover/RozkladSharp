namespace RozkladSharp.Domain.Models
{
    public class Lection
    {
        public int Id { get; set; }
        public int StudentSheduleId { get; set; }
        public StudentShedule StudentShedule { get; set; }
        
        
        
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        
        public string OrderInShedule { get; set; }
        public string WeekdayInShedule { get; set; }
        
        public string Cabinet { get; set; }
        public string StudentsGroup { get; set; }
        
        public bool IsLaboratory { get; set; }
        public bool IsPractice { get; set; }
        public bool IsOnline { get; set; }
        
    }
}