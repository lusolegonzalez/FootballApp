using Football.Data.Abstract.Repositories;
using Football.Model.Entities;

namespace Football.Data.Persistence.Repositories
{

    public class TeamRepository : Repository<Team>, ITeamRepository
    {
        public TeamRepository(ApplicationContext context) : base(context)
        {
        }

        public ApplicationContext ApplicationContext => Context as ApplicationContext;
    }
}
