using Microsoft.EntityFrameworkCore;
using RozkladSharp.Domain.Models;

namespace RozkladSharp.DomainServices
{
    public class RozkladSharpDbContext : DbContext
    {
        public DbSet<Lection> Lections { get; set; }
        public DbSet<LectionDetail> LectionDetails { get; set; }
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentShedule> StudentShedules { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherShedule> TeacherShedules { get; set; }
    }
}