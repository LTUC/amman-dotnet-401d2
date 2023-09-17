using RazorPagesDemo.Models.Entities;

namespace RazorPagesDemo.Services.Interfaces
{
    public interface IPersonService
    {
        Task<Person> Create(Person person);

        Task<List<Person>> GetAll();
    }
}
