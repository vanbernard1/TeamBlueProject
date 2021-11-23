using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace TeamBlueProject.Models
{
    public static class CLOSeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CLODbContext(
            serviceProvider.GetRequiredService<DbContextOptions<CLODbContext>>()))

        {
            //Look for any CLOs
            if (context.CLOs.Any())
            {
                return; //DB has been seeded
            }

            context.CLOs.AddRange(
                new CLO
                {
                    Objective = "Techniques, skills, and tools necessary for computing practice."
                },

                new CLO
                {
                    Objective = "Principles and practices for secure computing."
                },

                new CLO
                {
                    Objective = "Local and global impacts of computing solutions on individuals, organizations, and society."
                }
            );

            context.SaveChanges();
            }
        }  
    }
}