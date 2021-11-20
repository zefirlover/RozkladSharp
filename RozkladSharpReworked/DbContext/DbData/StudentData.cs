using RozkladSharp.Domain.Models;

namespace RozkladSharp.DomainServices
{
    public static class StudentData
    {
        public static void Initialize(RozkladSharpDbContext context)
        {
            context.Students.AddRange(
                new Student
                {
                    Id = 0, FirstName = "Kola", LastName = "Kation", TelephoneNumber = "388005553535", StudentSheduleId = 0
                },
                new Student
                {
                    Id = 1, FirstName = "Debil", LastName = "Ivanovich", TelephoneNumber = "380664206969", StudentSheduleId = 1
                },
                new Student
                {
                    Id = 2, FirstName = "Кек", LastName = "Дебілович", TelephoneNumber = "380690694242", StudentSheduleId = 2
                }
            );
            context.SaveChanges();
        }
    }
}