using RozkladSharp.Domain.Models;

namespace RozkladSharp.DomainServices
{
    public static class LectionData
    {
        public static void Initialize(RozkladSharpDbContext context)
        {
            context.Lections.AddRange(
                // all Math lections
                new Lection
                {
                    Id = 0,
                    LectionDetailId = 0,
                    
                    StudentSheduleId = 0,
                    TeacherSheduleId = 0,
                    SubjectId = 0
                },
                new Lection
                {
                    Id = 1,
                    LectionDetailId = 1,
                    
                    StudentSheduleId = 0,
                    TeacherSheduleId = 0,
                    SubjectId = 0
                },
                new Lection
                {
                    Id = 2,
                    LectionDetailId = 2,
                    
                    StudentSheduleId = 1,
                    TeacherSheduleId = 0,
                    SubjectId = 0
                },
                new Lection
                {
                    Id = 3,
                    LectionDetailId = 3,
                    
                    StudentSheduleId = 2,
                    TeacherSheduleId = 0,
                    SubjectId = 0
                },
                // all Meth lections
                new Lection
                {
                    Id = 4,
                    LectionDetailId = 4,
                    
                    StudentSheduleId = 0,
                    TeacherSheduleId = 1,
                    SubjectId = 1
                },
                new Lection
                {
                    Id = 5,
                    LectionDetailId = 5,
                    
                    StudentSheduleId = 1,
                    TeacherSheduleId = 1,
                    SubjectId = 1
                },
                new Lection
                {
                    Id = 6,
                    LectionDetailId = 6,
                    
                    StudentSheduleId = 2,
                    TeacherSheduleId = 1,
                    SubjectId = 1
                },
                // all Кєкос lections
                new Lection
                {
                    Id = 7,
                    LectionDetailId = 7,
                    
                    StudentSheduleId = 0,
                    TeacherSheduleId = 2,
                    SubjectId = 2
                },
                new Lection
                {
                    Id = 8,
                    LectionDetailId = 8,
                    
                    StudentSheduleId = 1,
                    TeacherSheduleId = 2,
                    SubjectId = 2
                },
                new Lection
                {
                    Id = 9,
                    LectionDetailId = 9,
                    
                    StudentSheduleId = 2,
                    TeacherSheduleId = 2,
                    SubjectId = 2
                }
            );
            context.SaveChanges();
        }
    }
}