using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace InformationFIle.Models
{
    public class InformationFIleContext : DbContext
    {
        public InformationFIleContext (DbContextOptions<InformationFIleContext> options)
            : base(options)
        {
        }

        public DbSet<InformationFIle.Models.Information> Information { get; set; }
    }
}
