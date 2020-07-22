
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace FootballManager.Web.Services.Profile
{
    public class ProfileManager
    {
        ////private readonly UserManager<ApplicationUser> _userManager;
        ////private readonly SignInManager<ApplicationUser> _signInManager;
        ////private readonly IHttpContextAccessor _httpContextAccessor;
        ////private readonly IUnitOfWork _unitOfWork;

        ////private ApplicationUser _currentUser;

        ////public ProfileManager(
        ////    UserManager<ApplicationUser> userManager,
        ////    SignInManager<ApplicationUser> signInManager,
        ////    IHttpContextAccessor httpContextAccessor,
        ////    IUnitOfWork unitOfWork)
        ////{
        ////    _userManager = userManager;
        ////    _signInManager = signInManager;
        ////    _httpContextAccessor = httpContextAccessor;
        ////    _unitOfWork = unitOfWork;
        ////}

        ////public ApplicationUser CurrentUser => _currentUser ?? (_currentUser = _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User).Result);

        ////public bool IsHasPassword(ApplicationUser user)
        ////{
        ////    return _userManager.HasPasswordAsync(user).Result;
        ////}

        //public bool IsEmailConfirmed(ApplicationUser user)
        //{
        //    return _userManager.IsEmailConfirmedAsync(user).Result;
        //}

    }
}
