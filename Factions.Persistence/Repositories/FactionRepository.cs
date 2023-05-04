using Factions.Application.Contracts.Persistence;
using Factions.Domain.Entities;
using Factions.Persistence.DataBaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factions.Persistence.Repositories
{
    public class FactionRepository : GenericRepository<Faction>, IFactionsRepository
    {
        public FactionRepository(FactionDbContext context) : base(context)
        {
        }
    }
}
