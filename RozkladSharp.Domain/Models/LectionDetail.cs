namespace RozkladSharp.Domain.Models
{
    public class LectionDetail
    {
        public int Id { get; set; }
        public int LectionId { get; set; }
        public Lection Lection { get; set; }
        
        public string OrderInShedule { get; set; }
        public string WeekdayInShedule { get; set; }
        
        public string Cabinet { get; set; }
        public string StudentsGroup { get; set; }
        
        public bool IsLaboratory { get; set; }
        public bool IsPractice { get; set; }
        public bool IsOnline { get; set; }
    }
}