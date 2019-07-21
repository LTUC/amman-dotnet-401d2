using CMSDemo.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMSDemo.Components
{
    public class TopPosts : ViewComponent
    {
        private IPostManagement _postManagement;

        public TopPosts(IPostManagement postManagement)
        {
            _postManagement = postManagement;
        }

        public async Task<IViewComponentResult> InvokeAsync(int number)
        {
            var posts = await _postManagement.GetAllPostsAsync();
            var results = posts.OrderByDescending(x => x.ID)
                                .Take(number);
            return View(results);

        }


    }
}
