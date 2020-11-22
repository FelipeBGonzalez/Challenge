using Microsoft.Extensions.DependencyInjection;

namespace Challenge.Domain.Interfaces
{
    public interface IInitializeDomain
    {
        void Initialize(ServiceProvider _provider);
    }
}
