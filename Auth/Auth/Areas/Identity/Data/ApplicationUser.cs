using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Auth.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string FirstName{ get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string City{ get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public int Age{ get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(1)")]
        public char Gender { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(250)")]
        public string AboutMyself { get; set; }
    }
}
