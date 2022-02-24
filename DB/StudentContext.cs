using Microsoft.EntityFrameworkCore;
using EF_Core_1.Entities;

namespace EF_Core_1.DB
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }
        public DbSet<Student> Students { get; set; }
    }
}