using Microsoft.EntityFrameworkCore;

namespace TeamBlueProject.Models
{
    public class AssessmentDbContext: DbContext
    {
        public AssessmentDbContext (DbContextOptions<AssessmentDbContext> options)
                : base (options)
        {
        }

        public DbSet<CLO> CLOs {get; set;}
        public DbSet<Dean> Deans {get; set;}
        public DbSet<Professor> Professors {get; set;}
        public DbSet<Administrator> Administrators {get; set;}
        

        }
}
