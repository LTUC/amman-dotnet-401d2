using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMSDemo.Models
{
    /// <summary>
    /// Basic Model class for our demo. We will want to create posts for our CMS site
    /// </summary>
    public class Post
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public string Content { get; set; }
    }
}
