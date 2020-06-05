using IdentityDemo.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityDemo.Models.Interfaces
{
   public interface IPostManager
    {
        Task CreatePost(PostsDTO post, string userId);
        Task<Post> GetPost(int id, string userId);
        Task<List<Post>> GetAllPosts(string userId);
        Task<Post> UpdatePost(Post post, int id);
        Task DeletePost(int id);

    }
}
