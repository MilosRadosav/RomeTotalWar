using Factions.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Factions.Persistence.DataBaseContext
{
    public class FactionDbContext : DbContext
    {
        public FactionDbContext(DbContextOptions<FactionDbContext> options) : base(options)
        {
            
        }

        public DbSet<Faction> Factions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
