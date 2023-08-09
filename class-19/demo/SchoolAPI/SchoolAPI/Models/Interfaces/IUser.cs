using Microsoft.AspNetCore.Mvc.ModelBinding;
using SchoolAPI.Models.DTO;
using System.Security.Claims;

namespace SchoolAPI.Models.Interfaces
{
    public interface IUser
    {
        public Task<UserDto> Register(RegisterUserDto registerUser, ModelStateDictionary modelState);

        public Task<UserDto> Authenticate(string username, string password);

        public Task<UserDto> GetUser(ClaimsPrincipal principal);
    }
}
