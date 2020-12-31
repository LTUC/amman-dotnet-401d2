using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using IdentityDemo.Models;
using IdentityDemo.Models.DTO;
using IdentityDemo.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IdentityDemo.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private IPostManager _posts;

        public PostsController(IPostManager posts)
        {
            _posts = posts;
        }
        // GET: api/<PostsController>
        [HttpGet]
        public async Task<List<Post>> Get()
        {
            var handler = new JwtSecurityTokenHandler();
            string authHeader = Request.Headers["Authorization"];
            authHeader = authHeader.Replace("Bearer ", "");
            var jsonToken = handler.ReadToken(authHeader);
            var tokenS = handler.ReadToken(authHeader) as JwtSecurityToken;

            var id = tokenS.Claims.First(claim => claim.Type == "UserId").Value;

            return await _posts.GetAllPosts(id);
        }

        // GET api/<PostsController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            string userId = GetUserId();
            var post = await _posts.GetPost(id, userId);

            if (post != null)
            {
                return Ok(post);
            }
            else
            {
                return BadRequest("Invalid Request");
            }
        }

        // POST api/<PostsController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PostsDTO post)
        {
            // Pull the userid from the token

            var handler = new JwtSecurityTokenHandler();
            string authHeader = Request.Headers["Authorization"];
            authHeader = authHeader.Replace("Bearer ", "");
            var jsonToken = handler.ReadToken(authHeader);
            var tokenS = handler.ReadToken(authHeader) as JwtSecurityToken;

            var id = tokenS.Claims.First(claim => claim.Type == "UserId").Value;


            await _posts.CreatePost(post, id);

            return Ok("Complete");
        }

        // PUT api/<PostsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Post post)
        {
            await _posts.UpdatePost(post, id);
            return Ok("Complete");
        }

        // DELETE api/<PostsController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _posts.DeletePost(id);

        }

        /// <summary>
        /// Validate JWT token and get userId
        /// </summary>
        /// <returns>Userid of user</returns>
        private string GetUserId()
        {
            var handler = new JwtSecurityTokenHandler();
            string authHeader = Request.Headers["Authorization"];
            authHeader = authHeader.Replace("Bearer ", "");
            var jsonToken = handler.ReadToken(authHeader);
            var tokenS = handler.ReadToken(authHeader) as JwtSecurityToken;

            var id = tokenS.Claims.First(claim => claim.Type == "UserId").Value;
            return id;
        }
    }
}
