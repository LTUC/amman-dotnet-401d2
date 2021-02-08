using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDemo.Models.Api
{
  public class UserDto
  {
    public string Id { get; set; }
    public string Username { get; set; }
    public string Token { get; set; }
    public IList<string> Roles { get; internal set; }
  }
}
