using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FootballManager.Web.Models
{
    public class PlayerViewModel
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        [EmailAddress]
        [MaxLength(50, ErrorMessage = "Maximum length for this field is {1}.")]
        public string Email { get; set; }

        [Display(Name = "FirstName")]
        [Required(ErrorMessage = "The {0} field is required.")]
        [MaxLength(50, ErrorMessage = "Maximum length for this field is {1}.")]
        public string FirstName { get; set; }

        [Display(Name = "LastName")]
        [Required(ErrorMessage = "The {0} field is required.")]
        [MaxLength(50, ErrorMessage = "Maximum length for this field is {1}.")]
        public string LastName { get; set; }

        public int TeamId { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "The {0} field is required.")]
        public int GenderId { get; set; }

    public bool EmailConfirmed { get; set; }
        public bool IsEnabled { get; set; }
        public DateTime LockoutEnd { get; set; }

        public IEnumerable<SelectListItem> GenderOptions { get; set; }

        public IEnumerable<SelectListItem> TeamOptions { get; set; }

        public PlayerViewModel()
        {
            GenderOptions = new List<SelectListItem>();
            TeamOptions = new List<SelectListItem>();
        }
    }
}