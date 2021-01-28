using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDemo.Models.Interfaces
{
  public interface ICourse
  {
    // Contains methods and properties our classes are required to implement

    // Create
    Task<Course> Create(Course course);

    // Read

    // Get all
    Task<List<Course>> GetAll();

    // Get one by id
    Task<Course> GetOne(int id);

    // Update
    Task<Course> Update(int id, Course course);

    // Delete
    Task Delete(int id);

  }
}
