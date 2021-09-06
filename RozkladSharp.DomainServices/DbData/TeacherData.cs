using RozkladSharp.Domain.Models;

namespace RozkladSharp.DomainServices
{
    public static class TeacherData
    {
        public static void Initialize(RozkladSharpDbContext context)
        {
            context.Teachers.AddRange(
                new Teacher { Id = 0, Name = "Ігнатенко Підор Іванович", RankId = 3, TeacherSheduleId = 0 },
                new Teacher { Id = 1, Name = "Масабанда Тібан Дмитро ВамБан", RankId = 0, TeacherSheduleId = 1 },
                new Teacher { Id = 2, Name = "Бля мені лєнь", RankId = 4, TeacherSheduleId = 2}
            );
            context.SaveChanges();
        }
    }
}