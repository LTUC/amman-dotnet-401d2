﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace IdentityDemo.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public string UserId { get; set; }
    }
}
