using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMSDemo.Models
{
    /// <summary>
    /// Creating a new Application User that derives from Identity User. 
    /// </summary>
    public class ApplicationUser : IdentityUser
    {
        // Adding additional props to associate with our identity user. 
        // Identity User does not contain this information already. 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }

    }
}
