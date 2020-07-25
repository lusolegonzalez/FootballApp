using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Football.Model.Entities
{
    //Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GenderId { get; set; }
        public bool IsEnabled { get; set; }

        public IEnumerable<ApplicationUserRole> Roles { get; set; }
    }
}
