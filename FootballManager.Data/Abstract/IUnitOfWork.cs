using System;
using Football.Data.Abstract.Repositories;

namespace Football.Data.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        ITournamentRepository Tournaments { get; }
        IMatchRepository Matches { get; }
        ITeamRepository Teams { get; }
        IPlayerRepository Players { get; }
        int Complete();
    }
}