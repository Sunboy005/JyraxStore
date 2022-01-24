using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace JyraxStore.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Must be between 3 and 15")]
        public string LastName { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Must be between 3 and 15")]
        public string FirstName { get; set; }

        public bool IsActive { get; set; }
        public Address Address { get; set; }

        public AppUser()
        {
            Address = new Address();
        }

    }
}
