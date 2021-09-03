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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Task6;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lection>().ToTable("Lections");
            modelBuilder.Entity<LectionDetail>().ToTable("LectionDetails");
            modelBuilder.Entity<Rank>().ToTable("Ranks");
            modelBuilder.Entity<Student>().ToTable("Students");
            modelBuilder.Entity<StudentShedule>().ToTable("StudentShedules");
            modelBuilder.Entity<Subject>().ToTable("Subjects");
            modelBuilder.Entity<Teacher>().ToTable("Teachers");
            modelBuilder.Entity<TeacherShedule>().ToTable("TeacherShedules");

            modelBuilder.Entity<Lection>().HasOne(_ => _.LectionDetail).WithOne(_ => _.Lection);
            modelBuilder.Entity<Teacher>().HasOne(_ => _.Rank).WithMany(_ => _.Teachers);
            modelBuilder.Entity<Student>().HasOne(_ => _.StudentShedule).WithOne(_ => _.Student);
            modelBuilder.Entity<Teacher>().HasOne(_ => _.TeacherShedule).WithOne(_ => _.Teacher);
            modelBuilder.Entity<Lection>().HasOne(_ => _.Subject).WithMany(_ => _.Lections);
            modelBuilder.Entity<TeacherShedule>().HasMany(_ => _.Lections).WithOne(_ => _.TeacherShedule);
            modelBuilder.Entity<StudentShedule>().HasMany(_ => _.Lections).WithOne(_ => _.StudentShedule);
        }
    }
}