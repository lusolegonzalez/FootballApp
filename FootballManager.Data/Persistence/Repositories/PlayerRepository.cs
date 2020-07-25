using Football.Data.Abstract.Repositories;
using Football.Model.Entities;

namespace Football.Data.Persistence.Repositories
{

    public class PlayerRepository : Repository<Player>, IPlayerRepository
    {
        public PlayerRepository(ApplicationContext context) : base(context)
        {
        }

        public ApplicationContext ApplicationContext => Context as ApplicationContext;
    }
}
