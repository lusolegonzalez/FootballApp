using Football.Data.Abstract;
using Football.Data.Abstract.Repositories;
using Football.Data.Persistence.Repositories;

namespace Football.Data.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;
        public IApplicationUserRepository ApplicationUsers { get; private set; }
        public ITournamentRepository Tournaments { get; }
        public IMatchRepository Matches { get; private set; }
        public ITeamRepository Teams { get; private set; }
        public IPlayerRepository Players { get; private set; }

        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            ApplicationUsers = new ApplicationUserRepository(_context);
            Tournaments = new TournamentRepository(_context);
            Matches = new MatchRepository(_context);
            Teams = new TeamRepository(_context);
            Players = new PlayerRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}