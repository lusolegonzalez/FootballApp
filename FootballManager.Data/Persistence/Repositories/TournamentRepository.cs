using Football.Data.Abstract.Repositories;
using Football.Model.Entities;

namespace Football.Data.Persistence.Repositories
{

    public class TournamentRepository : Repository<Tournament>, ITournamentRepository
    {
        public TournamentRepository(ApplicationContext context) : base(context)
        {
        }

        public ApplicationContext ApplicationContext => Context as ApplicationContext;
    }
}
