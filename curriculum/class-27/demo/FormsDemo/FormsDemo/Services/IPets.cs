using FormsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormsDemo.Services
{
  public interface IPets
  {

    Task<Pet> Create(Pet pet);
    Task<List<Pet>> GetAll();
    Task<Pet> GetOne(int id);
    Task<Pet> Update(Pet pet);
    Task Delete(int id);

  }
}
