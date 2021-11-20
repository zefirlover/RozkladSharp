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

                    OrderInShedule = 3,
                    WeekdayInShedule = WeekdaysInShedule.Saturday,
                    StudentsGroup = "IS-3"
                }
            );
            context.SaveChanges();
        }
    }
}