using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarathonSkills.Models
{
    public class MarathonContext: DbContext
    {
        public MarathonContext(DbContextOptions<MarathonContext> options):
            base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<User> Users { get; set; }
    }
}
