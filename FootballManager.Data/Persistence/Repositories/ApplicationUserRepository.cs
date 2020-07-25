using Football.Data.Abstract.Repositories;
using Football.Model.Entities;
using Microsoft.AspNetCore.Identity;

namespace Football.Data.Persistence.Repositories
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public ApplicationUserRepository(ApplicationContext context) : base(context)
        {
        }

        public ApplicationUserRepository(UserManager<ApplicationUser> userManager, ApplicationContext context) : base(context)
        {
            _userManager = userManager;
        }

        //public ApplicationUser GetFullUser(int id)
        //{
        //    return ApplicationContext.Users
        //        .Include(x => x.Offices).ThenInclude(y => y.Office)
        //        .Include(x => x.Roles).ThenInclude(y => y.Role)
        //        .FirstOrDefault(m => m.Id == id);
        //}

        //public IEnumerable<ApplicationUser> GetAllWithOffices()
        //{
        //    return ApplicationContext.Users
        //        .Include(x => x.Offices).ThenInclude(y => y.Office)
        //        .Include(x => x.Roles).ThenInclude(y => y.Role);

        //}

        //public ApplicationUser GetByName(string userName)
        //{
        //    return ApplicationContext.Users
        //        .Include(x => x.Offices).ThenInclude(y => y.Office)
        //        .Include(x => x.Roles).ThenInclude(y => y.Role)
        //        .FirstOrDefault(m => m.UserName == userName);
        //}

        //#region ProfileManager
        //public bool IsHasPassword(ApplicationUser user)
        //{
        //    return _userManager.HasPasswordAsync(user).Result;
        //}

        //public bool IsEmailConfirmed(ApplicationUser user)
        //{
        //    return _userManager.IsEmailConfirmedAsync(user).Result;
        //}
        //#endregion

        public ApplicationContext ApplicationContext => Context as ApplicationContext;
    }
}
