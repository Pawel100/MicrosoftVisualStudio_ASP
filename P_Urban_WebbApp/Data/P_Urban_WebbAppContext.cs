using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace P_Urban_WebbApp.Models
{
    public class P_Urban_WebbAppContext : DbContext
    {
        public P_Urban_WebbAppContext (DbContextOptions<P_Urban_WebbAppContext> options)
            : base(options)
        {
        }

        public DbSet<P_Urban_WebbApp.Models.Animals> Animals { get; set; }
    }
}
