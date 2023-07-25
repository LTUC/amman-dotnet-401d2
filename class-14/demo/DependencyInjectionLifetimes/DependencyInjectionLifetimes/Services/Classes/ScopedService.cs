using DependencyInjectionLifetimes.Services.Interfaces;

namespace DependencyInjectionLifetimes.Services.Classes
{
    public class ScopedService : IScopedService
    {
        private readonly Guid Id;

        public ScopedService()
        {
            Id = Guid.NewGuid();
        }
        public string GetGuid()
        {
            return Id.ToString();
        }
    }
}
