using System.Text.RegularExpressions;
using Football.Data.Abstract.Repositories;

namespace Football.Data.Persistence.Repositories
{

    public class MatchRepository : Repository<Match>, IMatchRepository
    {
        public MatchRepository(ApplicationContext context) : base(context)
        {
        }

        public ApplicationContext ApplicationContext => Context as ApplicationContext;

    }
}
