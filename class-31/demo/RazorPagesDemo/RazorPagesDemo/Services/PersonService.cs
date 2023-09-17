using Microsoft.EntityFrameworkCore;
using RazorPagesDemo.Data;
using RazorPagesDemo.Models.Entities;
using RazorPagesDemo.Services.Interfaces;

namespace RazorPagesDemo.Services
{
    public class PersonService : IPersonService
    {

        private readonly DemoDbContext _demoDbContext;

        public PersonService(DemoDbContext demoDbContext)
        {
            _demoDbContext = demoDbContext;
        }

        public async Task<Person> Create(Person person)
        {
            //_demoDbContext.People.Add(person);
            _demoDbContext.Entry(person).State = Microsoft.EntityFrameworkCore.EntityState.Added;

            await _demoDbContext.SaveChangesAsync();

            return person;
        }

        public async Task<List<Person>> GetAll()
        {
           return await _demoDbContext.People.ToListAsync();
        }
    }
}
