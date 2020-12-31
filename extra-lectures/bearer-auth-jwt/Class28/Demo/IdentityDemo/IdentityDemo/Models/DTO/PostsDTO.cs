using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityDemo.Models.DTO
{
    public class PostsDTO
    {
        public string Title { get; set; }
        public string Contents { get; set; }
    }
}
