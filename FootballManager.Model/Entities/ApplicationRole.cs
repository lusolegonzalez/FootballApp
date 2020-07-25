using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Football.Model.Entities
{
    public class ApplicationRole : IdentityRole<int>
    {
        public IEnumerable<ApplicationUserRole> Users { get; set; }
    }
}
