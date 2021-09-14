using RozkladSharp.Domain.Models;

namespace RozkladSharp.DomainServices
{
    public class StudentSheduleData
    {
        public static void Initialize(RozkladSharpDbContext context)
        {
            context.StudentShedules.AddRange(
                new StudentShedule
                {
                    Id = 0,
                    StudentId = 0
                },
                new StudentShedule
                {
                    Id = 1,
                    StudentId = 1
                },
                new StudentShedule
                {
                    Id = 2,
                    StudentId = 2
                }
            );
            context.SaveChanges();
        }
    }
}