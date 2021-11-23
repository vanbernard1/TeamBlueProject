using Microsoft.EntityFrameworkCore;

namespace TeamBlueProject.Models
{
    public class CLODbContext : DbContext
    {
        public CLODbContext (DbContextOptions<CLODbContext> options)
                : base (options)
        {
        }

        public DbSet<CLO> CLOs {get; set;}
}
}
