using Microsoft.EntityFrameworkCore;
using LearningWebAPI.Models;
namespace LearningWebAPI.Database
{
    public class StudentContext :DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) :base(options)
        {
            
        }

        public DbSet<student> Stu { get; set; }
        public DbSet<Actor> actors { get; set; }
    }
}
