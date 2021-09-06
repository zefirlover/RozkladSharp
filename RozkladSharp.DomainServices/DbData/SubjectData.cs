using RozkladSharp.Domain.Models;

namespace RozkladSharp.DomainServices
{
    public static class SubjectData
    {
        public static void Initialize(RozkladSharpDbContext context)
        {
            context.Subjects.AddRange(
                new Subject { Id = 0, Name = "Math" },
                new Subject { Id = 1, Name = "Meth" },
                new Subject { Id = 2, Name = "Кєкос" }
            );
            context.SaveChanges();
        }
    }
}