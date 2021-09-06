using System.Runtime.InteropServices;

namespace RozkladSharp.Domain.Models
{
    public class LectionDetail
    {
        public int Id { get; set; }
        public int LectionId { get; set; }
        public Lection Lection { get; set; }
        
        // todo забацать перевірку на значення, якшо <1 і >6, то давай по новой Міша
        public int OrderInShedule { get; set; }
        public WeekdaysInShedule WeekdayInShedule { get; set; }
        
        public string Cabinet { get; set; }
        public string StudentsGroup { get; set; }
        
        public bool IsLaboratory { get; set; }
        public bool IsPractice { get; set; }
        public bool IsOnline { get; set; }
    }
    // https://stackoverflow.com/questions/2646498/best-method-to-store-enum-in-database
    public enum WeekdaysInShedule
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    }
}