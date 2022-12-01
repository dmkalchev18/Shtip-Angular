using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;

namespace Shtip_API.Data.Models
{
    public class User : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
