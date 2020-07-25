using Microsoft.AspNetCore.Identity;

namespace Football.Model.Entities
{
    public class ApplicationUserRole : IdentityUserRole<int>
    {
        public virtual ApplicationUser User { get; set; }
        public virtual ApplicationRole Role { get; set; }
    }
}
