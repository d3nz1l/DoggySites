using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    using Doggy.Persistence.Entities.Flyball;

    using Bfa = Doggy.Persistence.Entities.Bfa;

    using GenericRepository;

    internal class TeamTimesService
    {
        private readonly IEntityRepository<Team, string> teamEntityRepository;

        private readonly IRepository<Bfa.Team, string> bfaTeamRepository;

        public TeamTimesService(IEntityRepository<Team, string> teamEntityRepository, IRepository<Bfa.Team, string> bfaTeamRepository)
        {
            this.teamEntityRepository = teamEntityRepository;
            this.bfaTeamRepository = bfaTeamRepository;
        }

        public 
    }
}
