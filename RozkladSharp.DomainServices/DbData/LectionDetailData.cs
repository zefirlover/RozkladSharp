using RozkladSharp.Domain.Models;

namespace RozkladSharp.DomainServices
{
    public static class LectionDetailData
    {
        public static void Initialize(RozkladSharpDbContext context)
        {
            context.LectionDetails.AddRange(
                // all Math lections
                new LectionDetail
                {
                    Id = 0,
                    Cabinet = "228-18",
                    IsLaboratory = false,
                    IsOnline = false,
                    IsPractice = true,
                    LectionId = 0,
                    OrderInShedule = 1,
                    WeekdayInShedule = WeekdaysInShedule.Tuesday,
                    StudentsGroup = "IA-69"
                },
                new LectionDetail
                {
                    Id = 1,
                    Cabinet = "1488-18",
                    IsLaboratory = false,
                    IsOnline = true,
                    IsPractice = true,
                    LectionId = 1,
                    OrderInShedule = 1,
                    WeekdayInShedule = WeekdaysInShedule.Thursday,
                    StudentsGroup = "IA-69"
                },
                new LectionDetail
                {
                    Id = 2,
                    Cabinet = "69-18",
                    IsLaboratory = false,
                    IsOnline = false,
                    IsPractice = false,
                    LectionId = 2,
                    OrderInShedule = 4,
                    WeekdayInShedule = WeekdaysInShedule.Tuesday,
                    StudentsGroup = "IA-228"
                },
                new LectionDetail
                {
                    Id = 3,
                    Cabinet = "1488-18",
                    IsLaboratory = false,
                    IsOnline = false,
                    IsPractice = true,
                    LectionId = 3,
                    OrderInShedule = 3,
                    WeekdayInShedule = WeekdaysInShedule.Monday,
                    StudentsGroup = "IS-3"
                },
                // all Meth lections
                new LectionDetail
                {
                    Id = 4,
                    Cabinet = "1488-18",
                    IsLaboratory = false,
                    IsOnline = true,
                    IsPractice = false,
                    LectionId = 4,
                    OrderInShedule = 3,
                    WeekdayInShedule = WeekdaysInShedule.Tuesday,
                    StudentsGroup = "IA-69"
                },
                new LectionDetail
                {
                    Id = 5,
                    Cabinet = "228-18",
                    IsLaboratory = false,
                    IsOnline = true,
                    IsPractice = false,
                    LectionId = 5,
                    OrderInShedule = 1,
                    WeekdayInShedule = WeekdaysInShedule.Thursday,
                    StudentsGroup = "IA-228"
                },
                new LectionDetail
                {
                    Id = 6,
                    Cabinet = "1488-18",
                    IsLaboratory = false,
                    IsOnline = true,
                    IsPractice = false,
                    LectionId = 6,
                    OrderInShedule = 2,
                    WeekdayInShedule = WeekdaysInShedule.Tuesday,
                    StudentsGroup = "IS-3"
                },
                // all Кєкос lections
                new LectionDetail
                {
                    Id = 7,
                    Cabinet = "30-18",
                    IsLaboratory = false,
                    IsOnline = false,
                    IsPractice = false,
                    LectionId = 7,
                    OrderInShedule = 3,
                    WeekdayInShedule = WeekdaysInShedule.Saturday,
                    StudentsGroup = "IA-69"
                },
                new LectionDetail
                {
                    Id = 8,
                    Cabinet = "30-18",
                    IsLaboratory = false,
                    IsOnline = false,
                    IsPractice = false,
                    LectionId = 8,
                    OrderInShedule = 3,
                    WeekdayInShedule = WeekdaysInShedule.Saturday,
                    StudentsGroup = "IA-228"
                },
                new LectionDetail
                {
                    Id = 9,
                    Cabinet = "30-18",
                    IsLaboratory = false,
                    IsOnline = false,
                    IsPractice = false,
                    LectionId = 9,
                    OrderInShedule = 3,
                    WeekdayInShedule = WeekdaysInShedule.Saturday,
                    StudentsGroup = "IS-3"
                }
            );
            context.SaveChanges();
        }
    }
}