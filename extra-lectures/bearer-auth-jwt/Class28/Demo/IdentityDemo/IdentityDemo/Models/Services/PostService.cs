using IdentityDemo.Data;
using IdentityDemo.Models.DTO;
using IdentityDemo.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityDemo.Models.Services
{
    public class PostService : IPostManager
    {
        private BlogDbContext _context;

        public PostService(BlogDbContext context)
        {
            _context = context;
        }

        public async Task CreatePost(PostsDTO post, string userId)
        {
            Post entry = new Post()
            {
                Title = post.Title,
                Contents = post.Contents,
                UserId = userId
            };
            _context.Entry(entry).State = EntityState.Added;
            await _context.SaveChangesAsync();
        }

        public async Task DeletePost(int id)
        {
            var post = await _context.Posts.FindAsync(id);
            _context.Entry(post).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task<List<Post>> GetAllPosts(string userId)
        {
            return await _context.Posts.Where(x=> x.UserId == userId).ToListAsync();
        }

        public async Task<Post> GetPost(int id, string userId)
        {
            var post = await _context.Posts.FindAsync(id);
            if(post.UserId == userId)
            {
                return post;
            }
            return null;
        }

        public async Task<Post> UpdatePost(Post post, int id)
        {
            if (post.Id == id)
            {
                _context.Entry(post).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }

            return post;
        }
    }
}
