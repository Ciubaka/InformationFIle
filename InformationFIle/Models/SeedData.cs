using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
namespace InformationFIle.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new InformationFIleContext(
                serviceProvider.GetRequiredService<DbContextOptions<InformationFIleContext>>()))
            {
                // Look for any movies.
                if (context.Information.Any())
                {
                    return;   // DB has been seeded
                }


                //context.SaveChanges();
            }
        }
    }
}
