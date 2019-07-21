using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMSDemo.Models.Handlers
{
    public class RequiredEmailRequirement : IAuthorizationRequirement
    {

        public RequiredEmailRequirement()
        {

        }

    }
}
