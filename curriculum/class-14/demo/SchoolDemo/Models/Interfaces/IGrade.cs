using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDemo.Models.Interfaces
{
  public interface IGrade
  {
    // Create
    Task<Grade> Create(Grade grade);

    // Read

    // Get all
    Task<List<Grade>> GetAll();

    // Get one by id
    Task<Grade> GetOne(int id);

    // Update
    Task<Grade> Update(int id, Grade grade);

    // Delete
    Task Delete(int id);

  }
}
