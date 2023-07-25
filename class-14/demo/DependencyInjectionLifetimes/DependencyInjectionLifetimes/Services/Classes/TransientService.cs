using DependencyInjectionLifetimes.Services.Interfaces;

namespace DependencyInjectionLifetimes.Services.Classes
{
    public class TransientService : ITransientService
    {
        private readonly Guid Id;

        public TransientService()
        {
            Id = Guid.NewGuid();
        }
        public string GetGuid()
        {
            return Id.ToString();
        }
    }
}
