using RozkladSharp.Domain.Models;

namespace RozkladSharp.DomainServices
{
    public static class LectionDetailData
    {
        public static void Initialize(RozkladSharpDbContext context)
        {
            context.LectionDetails.AddRange(
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
                }
            );
            context.SaveChanges();
        }
    }
}