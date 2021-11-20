using RozkladSharp.Domain.Models;

namespace RozkladSharp.DomainServices
{
    public class TeacherSheduleData
    {
        public static void Initialize(RozkladSharpDbContext context)
        {
            context.TeacherShedules.AddRange(
                new TeacherShedule
                {
                    Id = 0
                },
                new TeacherShedule
                {
                    Id = 1
                },
                new TeacherShedule
                {
                    Id = 2
                }
            );
            context.SaveChanges();
        }
    }
}