using Football.Model.Entities;

namespace Football.Data.Abstract.Repositories
{
    public interface IApplicationUserRepository : IRepository<ApplicationUser>
    {
        //ApplicationUser GetFullUser(int id);
        //bool IsHasPassword(ApplicationUser user);
        //bool IsEmailConfirmed(ApplicationUser user);
        //ApplicationUser GetByName(string userName);
    }
}
