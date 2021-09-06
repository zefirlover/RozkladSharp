using RozkladSharp.Domain.Models;

namespace RozkladSharp.DomainServices
{
    public static class LectionData
    {
        public static void Initialize(RozkladSharpDbContext context)
        {
            context.Lections.AddRange(
                new Lection
                {
                    Id = 0,
                    LectionDetailId = 0,
                    StudentSheduleId = 0,
                    SubjectId = 0,
                    TeacherSheduleId = 0
                }
                
            );
        }
    }
}