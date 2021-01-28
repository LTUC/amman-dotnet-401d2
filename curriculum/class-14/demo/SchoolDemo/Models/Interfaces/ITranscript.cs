using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDemo.Models.Interfaces
{
  public interface ITranscript
  {
    // Create
    Task<Transcript> Create(Transcript transcript);

    // Read

    // Get all
    Task<List<Transcript>> GetAll();

    // Get one by id
    Task<Transcript> GetOne(int id);

    // Update
    Task<Transcript> Update(int id, Transcript transcript);

    // Delete
    Task Delete(int id);

  }
}
