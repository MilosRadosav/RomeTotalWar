using Factions.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factions.Persistence.Configurations
{
    public class FactionsConfiguration : IEntityTypeConfiguration<Faction>
    {
        public void Configure(EntityTypeBuilder<Faction> builder)
        {
            builder.HasData
                (
                new Faction { Id=1,Name="CPQR"},
                new Faction { Id=2,Name="Julii"},
                new Faction { Id=3,Name="Brutii"},
                new Faction { Id=4,Name="Scipii"}
                );

            builder.Property(q=>q.Name)
                .HasMaxLength(50)
                .IsRequired();
           
        }
    }
}
