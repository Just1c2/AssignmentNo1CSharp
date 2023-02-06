using Microsoft.EntityFrameworkCore;

namespace AssignmentNo1.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options) {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Exam> Exams { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Student>().HasData(new Student()
            {
                Id = 1,
                Name = "John 321421",
                DateOfBirth = new DateTime(2003, 12, 02),
                Email = "johndoe@gmail.com",
                Address = "Hanoi"
            },
            new Student()
            {
                Id = 2,
                Name = "Quan sad aw",
                DateOfBirth = new DateTime(2008, 10, 02),
                Email = "cuan@gmail.com",
                Address = "Hanoi"
            },
            new Student()
            {
                Id = 3,
                Name = "Hieu huhuh",
                DateOfBirth = new DateTime(2002, 12, 02),
                Email = "hiu@gmail.com",
                Address = "Hanoi"
            });

            builder.Entity<Subject>().HasData(new Subject()
            {
                SubjectId = 1,
                SubjectName = "Math Algebra",
                SubjectCode = "273604",
                StartDate= new DateTime(2021, 12, 02),
                EndDate= new DateTime(2022, 02, 12),
                Description = "Ooi khoongggggggggggg"
            },
            new Subject()
            {
                SubjectId = 2,
                SubjectName = "Math2 Algebra",
                SubjectCode = "273605",
                StartDate = new DateTime(2021, 12, 02),
                EndDate = new DateTime(2022, 02, 12),
                Description = "Ooi khoongggggggggggg"
            },
            new Subject()
            {
                SubjectId = 3,
                SubjectName = "Math Algebra",
                SubjectCode = "273606",
                StartDate = new DateTime(2021, 12, 02),
                EndDate = new DateTime(2022, 02, 12),
                Description = "Ooi khoongggggggggggg"
            });
        }
    }
}
